import { suite, test, slow, timeout, skip, only } from 'mocha-typescript';
import * as assert from 'assert';
import { getSchemaFunctions } from '../model-function-inferrer';
import { Property } from '#common/code-model/schema';
import { JsonType } from 'remodeler/oai3';
import { Schema } from '#common/code-model/schema';

function fail(message: string): never {
  throw message;
}

function makePrimitiveProperty(name: string, required: boolean, type: JsonType, deprecated: boolean): Property {
  //return new Property(name, { schema: new Schema(name, { type }), details: { default: { required, name, deprecationMessage: deprecated ? "deprecated" : undefined } }});
  throw new Error("FIXME");
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

    const intrinsicOps = [...getSchemaFunctions(schema)];

    const intrinsicOpCtor = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpCtor.parameters).length, 2); // = #properties
    assert.strictEqual(Object.values(intrinsicOpCtor.responses).length, 1);
    assert.strictEqual(intrinsicOpCtor.deprecated, false);
    // assert.strictEqual(intrinsicOpCtor.parameters.size.required, true); // todo: fix
    // assert.strictEqual(intrinsicOpCtor.parameters.shape.required, false); // todo: fix

    const intrinsicOpGetSize = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpGetSize.parameters).length, 1);
    assert.strictEqual(Object.values(intrinsicOpGetSize.responses).length, 2); // success/failure
    assert.strictEqual(intrinsicOpGetSize.deprecated, false);

    const intrinsicOpGetShape = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpGetShape.parameters).length, 1);
    assert.strictEqual(Object.values(intrinsicOpGetShape.responses).length, 2); // success/failure
    assert.strictEqual(intrinsicOpGetShape.deprecated, false);

    const intrinsicOpSetSize = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpSetSize.parameters).length, 2);
    assert.strictEqual(Object.values(intrinsicOpSetSize.responses).length, 1);
    assert.strictEqual(intrinsicOpSetSize.deprecated, false);

    const intrinsicOpSetShape = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpSetShape.parameters).length, 2);
    assert.strictEqual(Object.values(intrinsicOpSetShape.responses).length, 1);
    assert.strictEqual(intrinsicOpSetShape.deprecated, false);

    assert.strictEqual(intrinsicOps.length, 0);
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

    const intrinsicOps = [...getSchemaFunctions(schema)];

    const intrinsicOpCtor = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpCtor.parameters).length, 2); // = #properties
    assert.strictEqual(Object.values(intrinsicOpCtor.responses).length, 1);
    assert.strictEqual(intrinsicOpCtor.deprecated, true);
    // assert.strictEqual(intrinsicOpCtor.parameters.size.required, true); // todo: fix
    // assert.strictEqual(intrinsicOpCtor.parameters.shape.required, false); // todo: fix

    const intrinsicOpGetSize = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpGetSize.parameters).length, 1);
    assert.strictEqual(Object.values(intrinsicOpGetSize.responses).length, 2); // success/failure
    assert.strictEqual(intrinsicOpGetSize.deprecated, true);

    const intrinsicOpGetShape = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpGetShape.parameters).length, 1);
    assert.strictEqual(Object.values(intrinsicOpGetShape.responses).length, 2); // success/failure
    assert.strictEqual(intrinsicOpGetShape.deprecated, true);

    const intrinsicOpSetSize = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpSetSize.parameters).length, 2);
    assert.strictEqual(Object.values(intrinsicOpSetSize.responses).length, 1);
    assert.strictEqual(intrinsicOpSetSize.deprecated, true);

    const intrinsicOpSetShape = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpSetShape.parameters).length, 2);
    assert.strictEqual(Object.values(intrinsicOpSetShape.responses).length, 1);
    assert.strictEqual(intrinsicOpSetShape.deprecated, true);

    assert.strictEqual(intrinsicOps.length, 0);
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

    const intrinsicOps = [...getSchemaFunctions(schema)];

    const intrinsicOpCtor = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpCtor.parameters).length, 2); // = #properties
    assert.strictEqual(Object.values(intrinsicOpCtor.responses).length, 1);
    assert.strictEqual(intrinsicOpCtor.deprecated, false);
    // assert.strictEqual(intrinsicOpCtor.parameters.size.required, true); // todo: fix
    //  assert.strictEqual(intrinsicOpCtor.parameters.shape.required, false); // todo: fix

    const intrinsicOpGetSize = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpGetSize.parameters).length, 1);
    assert.strictEqual(Object.values(intrinsicOpGetSize.responses).length, 2); // success/failure
    assert.strictEqual(intrinsicOpGetSize.deprecated, false);

    const intrinsicOpGetShape = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpGetShape.parameters).length, 1);
    assert.strictEqual(Object.values(intrinsicOpGetShape.responses).length, 2); // success/failure
    assert.strictEqual(intrinsicOpGetShape.deprecated, true);

    const intrinsicOpSetSize = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpSetSize.parameters).length, 2);
    assert.strictEqual(Object.values(intrinsicOpSetSize.responses).length, 1);
    assert.strictEqual(intrinsicOpSetSize.deprecated, false);

    const intrinsicOpSetShape = intrinsicOps.shift() || fail("more intrinsic ops expected");
    assert.strictEqual(Object.values(intrinsicOpSetShape.parameters).length, 2);
    assert.strictEqual(Object.values(intrinsicOpSetShape.responses).length, 1);
    assert.strictEqual(intrinsicOpSetShape.deprecated, true);

    assert.strictEqual(intrinsicOps.length, 0);
  }
}
