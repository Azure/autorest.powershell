import { suite, test, slow, timeout, skip, only } from "mocha-typescript";
import * as assert from "assert";
import { getSchemaFunctions } from "../model-function-inferrer";
import { Schema, PropertyReference } from "#remodeler/code-model";
import { JsonType } from "#remodeler/oai3";

function fail(message: string): never {
  throw message;
}

function makePrimitiveProperty(name: string, required: boolean, type: JsonType, deprecated: boolean): PropertyReference<Schema> {
  return new PropertyReference(name, { schema: new Schema(name, { type }), details: { required, name, deprecationMessage: deprecated ? "deprecated" : undefined } });
}

@suite class GetSchemaFunctions {
  @test "as expected baseline"() {
    const schema: Schema = new Schema("cowbell", {
      deprecated: false,
      type: JsonType.Object,
      properties: {
        size: makePrimitiveProperty("size", true, JsonType.Number, false),
        shape: makePrimitiveProperty("shape", false, JsonType.String, false)
      }
    });

    const hlOps = [...getSchemaFunctions(schema)];

    const hlOpCtor = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpCtor.parameters).length, 2); // = #properties
    assert.strictEqual(Object.values(hlOpCtor.responses).length, 1);
    assert.strictEqual(hlOpCtor.deprecated, false);
    assert.strictEqual(hlOpCtor.parameters.size.required, true);
    assert.strictEqual(hlOpCtor.parameters.shape.required, false);

    const hlOpGetSize = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpGetSize.parameters).length, 1);
    assert.strictEqual(Object.values(hlOpGetSize.responses).length, 2); // success/failure
    assert.strictEqual(hlOpGetSize.deprecated, false);

    const hlOpGetShape = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpGetShape.parameters).length, 1);
    assert.strictEqual(Object.values(hlOpGetShape.responses).length, 2); // success/failure
    assert.strictEqual(hlOpGetShape.deprecated, false);

    assert.strictEqual(hlOps.length, 0);
  }

  @test "as expected deprecated type"() {
    const schema: Schema = new Schema("cowbell", {
      deprecated: true,
      type: JsonType.Object,
      properties: {
        size: makePrimitiveProperty("size", true, JsonType.Number, false),
        shape: makePrimitiveProperty("shape", false, JsonType.String, false)
      }
    });

    const hlOps = [...getSchemaFunctions(schema)];

    const hlOpCtor = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpCtor.parameters).length, 2); // = #properties
    assert.strictEqual(Object.values(hlOpCtor.responses).length, 1);
    assert.strictEqual(hlOpCtor.deprecated, true);
    assert.strictEqual(hlOpCtor.parameters.size.required, true);
    assert.strictEqual(hlOpCtor.parameters.shape.required, false);

    const hlOpGetSize = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpGetSize.parameters).length, 1);
    assert.strictEqual(Object.values(hlOpGetSize.responses).length, 2); // success/failure
    assert.strictEqual(hlOpGetSize.deprecated, true);

    const hlOpGetShape = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpGetShape.parameters).length, 1);
    assert.strictEqual(Object.values(hlOpGetShape.responses).length, 2); // success/failure
    assert.strictEqual(hlOpGetShape.deprecated, true);

    assert.strictEqual(hlOps.length, 0);
  }

  @test "as expected deprecated property"() {
    const schema: Schema = new Schema("cowbell", {
      deprecated: false,
      type: JsonType.Object,
      properties: {
        size: makePrimitiveProperty("size", true, JsonType.Number, false),
        shape: makePrimitiveProperty("shape", false, JsonType.String, true)
      }
    });

    const hlOps = [...getSchemaFunctions(schema)];

    const hlOpCtor = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpCtor.parameters).length, 2); // = #properties
    assert.strictEqual(Object.values(hlOpCtor.responses).length, 1);
    assert.strictEqual(hlOpCtor.deprecated, false);
    assert.strictEqual(hlOpCtor.parameters.size.required, true);
    assert.strictEqual(hlOpCtor.parameters.shape.required, false);

    const hlOpGetSize = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpGetSize.parameters).length, 1);
    assert.strictEqual(Object.values(hlOpGetSize.responses).length, 2); // success/failure
    assert.strictEqual(hlOpGetSize.deprecated, false);

    const hlOpGetShape = hlOps.shift() || fail("more HL ops expected");
    assert.strictEqual(Object.values(hlOpGetShape.parameters).length, 1);
    assert.strictEqual(Object.values(hlOpGetShape.responses).length, 2); // success/failure
    assert.strictEqual(hlOpGetShape.deprecated, true);

    assert.strictEqual(hlOps.length, 0);
  }
}
