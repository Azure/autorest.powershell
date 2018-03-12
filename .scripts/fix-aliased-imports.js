const fs = require('fs');
const path = require('path');

const tsconfig = require("../tsconfig.json");
const importOptions = tsconfig.compilerOptions;
const tscpaths = Object.keys(importOptions.paths)

 
function fixImports(filePath) {
  fs.readFile(filePath,'utf8',(e,code)=> {
    let write = false;
    for (var tscpath of tscpaths) {
      code = code.replace( new RegExp(`require\\("${tscpath}`,'g') ,(match, p1)=> {    
        write = true;
        // Get relative path and replace
        const sourcePath = path.dirname(filePath);
        const targetPath = path.dirname(path.resolve(importOptions.outDir + '/' + importOptions.baseUrl + '/' + importOptions.paths[tscpath]))
        const relativePath = path.relative(sourcePath, targetPath).replace(/\\/g,"/");
        return `require("./${relativePath}/`.replace(`"./..`,`"..`); // fix messy parent referential path. 
        });
      }
    if( write ) {
      fs.writeFile(filePath,code,(err) => {
        if( err )  {
          console.error(`ERROR: writing ${filePath}"`);
        }
      });
    }
  });
 
}

function processDirectory(dir){
  const items =  fs.readdirSync(dir);
  for( const i of items ) {
      const filePath = path.normalize(`${dir}/${i}`);
      if( fs.statSync(filePath).isDirectory()) {
          processDirectory(filePath);
          continue;
      }
      if( filePath.endsWith('.js')) {
          fixImports(filePath);
      }
  }
}

processDirectory(`${__dirname}/../dist`);