var fs = require('fs');

function read(filename) {
  const txt  =fs.readFileSync(filename, 'utf8')
  .replace(/\r/gm, '')
  .replace(/\n/gm, '«')
  .replace(/\/\*.*?\*\//gm,'')
  .replace(/«/gm, '\n')
  .replace(/\s+\/\/.*/g, '');
  return JSON.parse( txt);
}

const rush =read(`${__dirname}/../../rush.json`);
const pjs = {};
for( const each of rush.projects ) {
  const packageName = each.packageName;
  const projectFolder = each.projectFolder;
  pjs[packageName] = require(`${__dirname}/../../${projectFolder}/package.json`);
}

for( const pj of Object.getOwnPropertyNames(pjs) ){
  const each = pjs[pj];
  for( const dep in each.dependencies ) {
    const ref = pjs[dep];
    if( ref ) {
      each.dependencies[dep] = `^${ref.version}`;
    }
  }
}

for( const each of rush.projects ) {
  const packageName = each.packageName;
  const projectFolder = each.projectFolder;
  fs.writeFileSync(`${__dirname}/../../${projectFolder}/package.json`, JSON.stringify(pjs[packageName], null, 2 ));
}

console.log("project.json files updated");