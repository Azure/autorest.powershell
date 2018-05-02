import { suite, test, slow, timeout, skip, only } from 'mocha-typescript';
import * as assert from 'assert';

import { clone, setExcept, setIntersect, setIsEmpty, setIsEqual, setIsSubset, tsc, objReplace, deepEquals } from '../src/helpers';

@suite class HelpersClone {
  @test "primitive"() {
    assert.equal(clone(3.141), 3.141);
    assert.equal(clone("asd"), "asd");
    assert.equal(clone(true), true);
  }

  @test "complex"() {
    const a1 = { x: 1, y: { z: 4 } };
    const b1 = [1, a1, "asd", a1];
    const c1 = { x: b1, y: { z: b1 }, a: a1, b: a1 };
    const a2 = clone(a1);
    const b2 = clone(b1);
    const c2 = clone(c1);
    assert.deepEqual(a2, a1);
    assert.deepEqual(b2, b1);
    assert.deepEqual(c2, c1);
    assert.notEqual(a2, a1);
    assert.notEqual(b2, b1);
    assert.notEqual(c2, c1);
  }

  @test "identity"() {
    const a1 = { x: 1, y: { z: 4 } };
    const b1 = [1, a1, "asd", a1];
    const c1 = { x: b1, y: { z: b1 }, a: a1, b: a1 };
    const a2 = clone(a1);
    const b2 = clone(b1);
    const c2 = clone(c1);
    assert.strictEqual(b1[1], b1[3]);
    assert.strictEqual(b2[1], b2[3]);
    assert.strictEqual(c1.x, c1.y.z);
    assert.strictEqual(c2.x, c2.y.z);
    assert.strictEqual(c1.a, c1.b);
    assert.strictEqual(c2.a, c2.b);
  }
}

@suite class HelpersReplace {
  @test "untouched"() {
    const a = { x: 1, y: { z: 4 } };
    const b = [1, a, "asd", a];
    const c = { x: b, y: { z: b }, a: a, b: a };

    assert.equal(objReplace(1, 2, 3), 1);
    assert.equal(objReplace(a, 2, 3), a);
    assert.equal(objReplace(a, b, null), a);
    assert.equal(objReplace(b, 2, 3), b);
    assert.equal(objReplace(c, 2, 3), c);
  }

  @test "full"() {
    const a = { x: 1, y: { z: 4 } };
    const b = [1, a, "asd", a];
    const c: any = { x: b, y: { z: b }, a: a, b: a };

    assert.strictEqual(objReplace(1, 1, 3), 3);
    assert.strictEqual(objReplace(a, a, null), null);
    assert.strictEqual(objReplace(b, b, b), b);
    assert.strictEqual(objReplace(c, c, a), a);
  }

  @test "partial"() {
    const a = { x: 1, y: { z: 4 } };
    const b = [1, a, "asd", a];
    const c = { x: b, y: { z: b }, a: a, b: a };

    assert.notEqual(objReplace(a, 1, 3), a);
    assert.deepEqual(objReplace(a, 1, 3), { x: 3, y: { z: 4 } });
    assert.notEqual(objReplace(b, "asd", "foo"), b);
    assert.deepEqual(objReplace(b, "asd", "foo"), [1, a, "foo", a]);
    {
      const tmp = objReplace(objReplace(b, 1, 3), "asd", "foo");
      assert.notEqual(tmp, b);
      assert.deepEqual(tmp, [3, { x: 3, y: { z: 4 } }, "foo", { x: 3, y: { z: 4 } }]);
      assert.deepEqual(tmp[1], tmp[3]);
    }
    assert.deepEqual(objReplace(c, a as any, c), { x: [1, c, "asd", c], y: { z: [1, c, "asd", c] }, a: c, b: c });
    {
      const tmp = objReplace(c, "asd", "foo");
      assert.notEqual(tmp, c);
      assert.deepEqual(tmp, { x: [1, a, "foo", a], y: { z: [1, a, "foo", a] }, a: a, b: a });
      assert.deepEqual(tmp.x, tmp.y.z);
    }
  }

  @test "circular"() {
    {
      const a: any = { x: 1, y: { z: 4, w: [1] } };
      a.y.w.push(a);

      // expected
      const b: any = { x: 3, y: { z: 4, w: [3] } };
      b.y.w.push(b);

      // actual
      const c = objReplace(a, 1, 3);

      assert.notEqual(c, a);
      assert.deepEqual(c, b);
      assert.strictEqual(c.y.w[1], c);
    }
    {
      const x: any = { a: { z: 1 }, b: { z: 2 } };
      x.a.b = x.b;
      x.b.a = x.a;

      {
        const y = objReplace(x, 1, 4);
        assert.strictEqual(y.b.a, y.a);
        assert.strictEqual(y.a.b, y.b);
        assert.strictEqual(y.a.z, 4);
        assert.strictEqual(y.b.z, 2);
      }

      {
        const y = objReplace(x, 2, 4);
        assert.strictEqual(y.b.a, y.a);
        assert.strictEqual(y.a.b, y.b);
        assert.strictEqual(y.a.z, 1);
        assert.strictEqual(y.b.z, 4);
      }
    }
  }
}

@suite class HelpersSet {
  @test "equality"() {
    assert.ok(setIsEqual([1, 2, 3], [3, 2, 1]));
    assert.ok(setIsEqual([1, 2, 3], [3, 2, 1, 1]));
    assert.ok(setIsEqual([1, "foo", 3], [3, "foo", 1]));

    assert.ok(!setIsEqual([1, 2, 3], [3, 2]));
    assert.ok(!setIsEqual([1, 2], [3, 2, 1]));
    assert.ok(!setIsEqual([1, "foo", 3], [3, "fo", 1]));
  }

  @test "subset"() {
    assert.ok(setIsSubset([1, 2, 3], [3, 2, 1]));
    assert.ok(setIsSubset([1, 2], [3, 2, 1]));
    assert.ok(setIsSubset([1, 3], [3, 2, 1]));
    assert.ok(setIsSubset([2, 3], [3, 2, 1]));
    assert.ok(setIsSubset([], [3, 2, 1]));
    assert.ok(setIsSubset([], []));

    assert.ok(!setIsSubset([1, 2, 3], [1, 2]));
    assert.ok(!setIsSubset([1, "foo", 3], [1, "fo", 3]));
    assert.ok(!setIsSubset([1], []));
  }

  @test "empty"() {
    assert.ok(setIsEmpty([]));
    assert.ok(!setIsEmpty([1]));
    assert.ok(!setIsEmpty([undefined]));
    assert.ok(!setIsEmpty([null]));
    assert.ok(!setIsEmpty([1, 2]));
    assert.ok(!setIsEmpty([1, "foo"]));
  }

  @test "except"() {
    assert.ok(setIsEqual([1, 2, 3], setExcept([0, 1, 2, 3, 4, 5], [0, 4, 5])));
    assert.ok(setIsEqual([1, 2, 3], setExcept([0, 1, 2, 3, 4, 5], [0, 4, 5, 5])));
    assert.ok(setIsEqual([1, 2, 3], setExcept([0, 1, 2, 3, 4, 5], [0, 4, 5, 6])));
    assert.ok(setIsEqual([1, 2, 3], setExcept([1, 2, 3], [])));
    assert.ok(setIsEqual([1, 2, 3], setExcept([1, 2, 3], [1.1])));
    assert.ok(setIsEqual([], setExcept([1, 2, 3], [0, 1, 2, 3, 4])));
  }

  @test "intersect"() {
    assert.ok(setIsEqual([1, 2, 3], setIntersect([0, 1, 2, 3, 4, 5], [-1, 1, 2, 3, "foo", 42])));
    assert.ok(setIsEqual([0], setIntersect([0, 1, 2, 3, 4, 5], [0, 0, 0, 0])));
    assert.ok(setIsEqual([0, 4, 5], setIntersect([0, 1, 2, 3, 4, 5], [0, 4, 5, 6])));
    assert.ok(setIsEqual([], setIntersect([1, 2, 3], [])));
    assert.ok(setIsEqual([], setIntersect([1, 2, 3], [1.1])));
  }
}

@suite class HelpersTsc {
  @test "succeed"() {
    assert.strictEqual(eval(tsc("3")), 3);
    assert.strictEqual(eval(tsc("1 + 3")), 4);
    assert.strictEqual(eval(tsc("((a: string, b: string) => a + b)('foo', 'bar')")), "foobar");
  }

  @test "fail"() {
    assert.throws(() => tsc("asd"));
    assert.throws(() => tsc("const x: string = 3"));
    assert.throws(() => tsc("const x:: number = 3"));
  }
}

@suite class HelpersDeepEquals {
  @test "success"() {
    assert.ok(deepEquals(3, 3));
    assert.ok(deepEquals(true, true));
    assert.ok(deepEquals(false, false));
    assert.ok(deepEquals("asd", "asd"));
    assert.ok(deepEquals(["asd"], ["asd"]));
    assert.ok(deepEquals(["asd", 3.141], ["asd", 3.141]));
    assert.ok(deepEquals({ x: "asd" }, { x: "asd" }));
    assert.ok(deepEquals({ x: "asd", y: 3.141 }, { y: 3.141, x: "asd" }));
    assert.ok(deepEquals({ x: "asd", y: 3.141, z: ["asd", 3.141] }, { y: 3.141, x: "asd", z: ["asd", 3.141] }));
  }

  @test "failure"() {
    assert.ok(!deepEquals(2, 3));
    assert.ok(!deepEquals(false, true));
    assert.ok(!deepEquals("asd" as any, false));
    assert.ok(!deepEquals("asd", "asdx"));
    assert.ok(!deepEquals(["asdx"], ["asd"]));
    assert.ok(!deepEquals(["asd", 3.141], [3.141, "asd"]));
    assert.ok(!deepEquals(["asd", 3.141], [3.141]));
    assert.ok(!deepEquals({ x: "asd" }, { y: "asd" }));
    assert.ok(!deepEquals({ x: "asd", y: 3.141 }, { y: 3.142, x: "asd" }));
    assert.ok(!deepEquals({ x: "asd", y: 3.141 }, { y: 3.142 }));
    assert.ok(!deepEquals({ x: "asd", y: 3.141, z: ["asd", 3.142] }, { y: 3.141, x: "asd", z: ["asd", 3.141] }));
  }
}