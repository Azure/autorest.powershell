import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import * as aio from "@microsoft.azure/async-io"
import { Project } from '../project'
import { values } from '@microsoft.azure/codegen';

@suite class TestServiceName {

  @test async "output service names"() {
    const titlesFile = await aio.readFile(`${__dirname}/../../test/resources/titles.txt`);
    const serviceNamesFile = await aio.readFile(`${__dirname}/../../test/resources/service-names.txt`);

    assert(titlesFile != null);
    assert(serviceNamesFile != null);

    const serviceNames = TestServiceName.normalizeEndlines(titlesFile, tl => `${tl} => ${Project.titleToServiceName(tl)}`);
    //console.log(serviceNames);
    const normalizedServiceNamesFile = TestServiceName.normalizeEndlines(serviceNamesFile, tl => tl);
    assert.strictEqual(serviceNames, normalizedServiceNamesFile);
  }

  private static normalizeEndlines(text: string, selector: (each: string) => string) {
    return values(text.split(/\r\n|\r|\n/))
      .linq.select(tl => `${selector(tl)}\r\n`)
      .linq.toArray().join('');
  }
}