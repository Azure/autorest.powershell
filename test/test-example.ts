import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as tasks from '@microsoft.azure/tasks'
import * as assert from "assert";
import * as os from 'os'

@suite class Testing {

  @test async "Do tests work"() {
    assert.equal(true, true, "Sure do!");
  }

}