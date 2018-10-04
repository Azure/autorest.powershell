const semver = require("semver");
const util = require("util");
const cp = require("child_process");
const exec = util.promisify(cp.exec);

async function getTag(packageJson) {
  for ( const each of process.argv ) {
    if ( each.startsWith("--tag=")) {
      const tag = each.substr(6);
      if ( tag ) {
        return tag;
      }
    }
  }

  const suffix = semver.parse((packageJson.version).trim()).prerelease.join(".");
  if ( suffix ) {
    return suffix;
  }

  if ( process.env.BUILD_SOURCEBRANCHNAME ) {
    return process.env.BUILD_SOURCEBRANCHNAME === "master" || process.env.BUILD_SOURCEBRANCHNAME === "HEAD" ?
      "preview" :
      process.env.BUILD_SOURCEBRANCHNAME;
  }

  const branch = (await exec("git rev-parse --abbrev-ref HEAD")).stdout.trim();
  return !branch || branch === "master" ? "preview" : branch;
}

async function main() {
  const packageJson = require("../package.json");
  const baseVersion = (packageJson.version).trim();

  tag = await getTag(packageJson);

  const v = (await exec("git rev-list --parents HEAD --count --full-history")).stdout.trim();

  const version = `${semver.major(baseVersion)}.${semver.minor(baseVersion)}.${v}`;

  console.log(`Using version ${version}, tag ${tag}`);
  process.argv.push(`publish`, `--access`,
    `public`, `--tag`, tag, `--new-version`, `${version}`, `--no-git-tag-version`);
  // now, on with the publish...
  require( "yarn/lib/cli.js" );
}
main();
