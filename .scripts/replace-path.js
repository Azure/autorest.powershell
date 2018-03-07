const fs = require('fs');

const path = require('path');

const tsconfig = require("../tsconfig.json");
const importOptions = tsconfig.compilerOptions;

function process(dir){
    const items =  fs.readdirSync(dir,);
    for( const i of items ) 
    {
        const p = `${dir}/${i}`;
        if( fs.statSync(p).isDirectory()) {
            process(p);
            continue;
        }
        if( p.endsWith('.js')) {
            // console.log(p);
            const code = fs.readFileSync(p,'utf8');
            const fixed = replace(code,p);
            fs.writeFileSync(p,fixed);
        }
    }
}

async function main() {
    process(`${__dirname}/../dist`);
}
main();

function replace(code, filePath) {
    var tscpaths = Object.keys(importOptions.paths)
    var lines = code.split('\n')
  
    return lines.map((line) => {
      var matches = []
      var requireMatches = line.match(/require\("#[^.](.*)"\)/g)
  
      Array.prototype.push.apply(matches, requireMatches)
  
      if (!matches || matches.length === 0) {
        return line
      }
  
      // Go through each require statement
      for (var match of matches) {
          // console.log(match);
        // Find each paths
        for (var tscpath of tscpaths) {
          // Find required module & check if its path matching what is described in the paths config.
          var requiredModules = match.match(new RegExp(tscpath, 'g'))
  
          if (requiredModules && requiredModules.length > 0) {
            for (var requiredModule of requiredModules) {
              // Skip if it resolves to the node_modules folder
              var modulePath = path.resolve('./node_modules/' + tscpath)
              if (fs.existsSync(modulePath)) {
                continue
              }
              // Get relative path and replace
              var sourcePath = path.dirname(filePath)
              var targetPath = path.dirname(path.resolve(importOptions.outDir + '/' + importOptions.baseUrl + '/' + importOptions.paths[tscpath]))
              var relativePath = path.relative(sourcePath, targetPath).replace(/\\/g,"/")
              line = line.replace(new RegExp(tscpath, 'g'), './' + relativePath + '/').replace(/^.\/\.\./g,'..')
            }
          }
        }
      }
      return line
}).join('\n');
}