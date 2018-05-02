import { suite, test, slow, timeout, skip, only } from 'mocha-typescript';
import * as assert from 'assert';
import { getCommandName } from '../name-inferrer';

const samples: [string, { noun?: string, verb: string }[]][] = [
  ["ApplicationGateways_Delete",
    [{ noun: "ApplicationGateway", verb: "Remove" }]],
  ["ApplicationGateways_Get",
    [{ noun: "ApplicationGateway", verb: "Get" }]],
  ["ApplicationGateways_CreateOrUpdate",
    [{ noun: "ApplicationGateway", verb: "New" }, { noun: "ApplicationGateway", verb: "Set" }]],
  ["ApplicationGateways_UpdateTags",
    [{ noun: "ApplicationGatewayTag", verb: "Update" }]],
  ["ApplicationGateways_List",
    [{ noun: "ApplicationGateway", verb: "Get" }]],
  ["ApplicationGateways_Start",
    [{ noun: "ApplicationGateway", verb: "Start" }]],
  ["ApplicationGateways_Stop",
    [{ noun: "ApplicationGateway", verb: "Stop" }]]
];

@suite class GetCommandName {
  @test "as expected"() {
    for (const [opId, res] of samples) assert.deepStrictEqual(getCommandName(opId, _ => { }), res);
  }
}
