const fsa = require('fs');
const util = require('util');

const path = require('path');

const readFile = util.promisify(fsa.readFile);
const writeFile = util.promisify(fsa.writeFile);
const readdir = util.promisify(fsa.readdir);
const stat = util.promisify(fsa.stat);

const tsconfig = require("../tsconfig.json");
const importOptions = tsconfig.compilerOptions;
const tscpaths = Object.keys(importOptions.paths)
let count =0;

async function fixImports(filePath) {
  let code = await readFile(filePath, 'utf8');
  if (!code) {
    return;
  }
  const orig = code;
  let write = false;
  for (var tscpath of tscpaths) {
    code = code.replace(new RegExp(`require\\("${tscpath}`, 'g'), (match, p1) => {
      write = true;
      // Get relative path and replace
      const sourcePath = path.dirname(filePath);
      const targetPath = path.dirname(path.resolve(importOptions.outDir + '/' + importOptions.baseUrl + '/' + importOptions.paths[tscpath]))
      const relativePath = path.relative(sourcePath, targetPath).replace(/\\/g, "/");
      return `require("./${relativePath}/`.replace(`"./..`, `"..`).replace("../src/", "../"); // fix messy parent referential path. 
    });
  }
  if (write && orig.trim() !== code.trim()) {
    // console.log(`Fixing '${filePath}'`);
    count ++ ;
    tasks.push(writeFile(filePath, code));
  }
}
let busy = false;
let tasks = [];

async function processDirectory(dir) {
  const items = await readdir(dir);
  for (const i of items) {
    const filePath = path.normalize(`${dir}/${i}`);
    if ((await stat(filePath)).isDirectory()) {
      await processDirectory(filePath);
      continue;
    }
    if (filePath.endsWith('.js')) {
      tasks.push(fixImports(filePath));
    }
  }
}

async function delay(delayMS) {
  return new Promise(res => setTimeout(res, delayMS));
}

async function start() {
  if (!busy) {
    busy = true;
    tasks = [];
    count = 0;
    const timer = Date.now();
    // console.log('debouncing...');
    while (Date.now() < tm + 200) {
      await delay(15);
    }
    console.log("Fixing files...");
    await processDirectory(`${__dirname}/../dist`);
    await Promise.all(tasks);

    try {
      // fix weird issue with namespace class and importing stuff
      let namespc = await readFile(`${__dirname}/../dist/csharp/code-dom/namespace.js`, "utf8");
      const orig = namespc;
      const c = namespc.indexOf('const interface_1 = require("./interface");');
      if (c > 0) {
        namespc = namespc.replace('const interface_1 = require("./interface");', '');
        namespc = namespc.replace(/interface_1\./gi, 'require("./interface").');
        if (orig !== namespc) {
          await writeFile(`${__dirname}/../dist/csharp/code-dom/namespace.js`, namespc);
        }
      }
    } catch (e) {

    }
    console.log(`Fixed ${count} files in ${Date.now() - timer} msec`);
    busy = false;
  }
}
let tm = Date.now();

async function main() {
  await start();

  fsa.watch(`${__dirname}/../dist`, { recursive: true }, (e, filePath) => {
    tm = Date.now();
    if (filePath && filePath.endsWith('.js')) {
      start();
      // fixImports(`${__dirname}/../dist/${filePath`);
    }
  });
}
process.chdir(path.resolve(`${__dirname}/..`));

if (process.argv.indexOf('--watch') > -1) {
  main();
} else {
  processDirectory(`${__dirname}/../dist`)
}