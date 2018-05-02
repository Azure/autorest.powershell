import { suite, test, slow, timeout, skip, only } from 'mocha-typescript';
import * as assert from 'assert';

import { EnglishPluralizationService } from '../english-pluralization-service';

const service = new EnglishPluralizationService();
service.AddWord("Database", "Databases");
service.AddWord("database", "databases");

const words: [string, string][] = [
  ["time", "times"],
  ["year", "years"],
  ["way", "ways"],
  ["day", "days"],
  ["man", "men"],
  ["thing", "things"],
  ["woman", "women"],
  ["life", "lives"],
  ["child", "children"],
  ["world", "worlds"],
  ["school", "schools"],
  ["state", "states"],
  ["family", "families"],
  ["student", "students"],
  ["group", "groups"],
  ["country", "countries"],
  ["problem", "problems"],
  ["hand", "hands"],
  ["part", "parts"],
  ["place", "places"],
  ["case", "cases"],
  ["week", "weeks"],
  ["company", "companies"],
  ["system", "systems"],
  ["program", "programs"],
  ["question", "questions"],
  ["work", "works"],
  ["government", "governments"],
  ["number", "numbers"],
  ["night", "nights"],
  ["point", "points"],
  ["home", "homes"],
  ["water", "waters"],
  ["room", "rooms"],
  ["mother", "mothers"],
  ["area", "areas"],
  ["story", "stories"],
  ["fact", "facts"],
  ["month", "months"],
  ["lot", "lots"],
  ["right", "rights"],
  ["study", "studies"],
  ["book", "books"],
  ["eye", "eyes"],
  ["job", "jobs"],
  ["word", "words"],
  ["business", "businesses"],
  ["issue", "issues"],
  ["side", "sides"],
  ["kind", "kinds"],
  ["head", "heads"],
  ["house", "houses"],
  ["service", "services"],
  ["friend", "friends"],
  ["father", "fathers"],
  ["power", "powers"],
  ["hour", "hours"],
  ["game", "games"],
  ["line", "lines"],
  ["end", "ends"],
  ["member", "members"],
  ["law", "laws"],
  ["car", "cars"],
  ["city", "cities"],
  ["community", "communities"],
  ["name", "names"],
  ["president", "presidents"],
  ["team", "teams"],
  ["minute", "minutes"],
  ["idea", "ideas"],
  ["kid", "kids"],
  ["body", "bodies"],
  ["parent", "parents"],
  ["face", "faces"],
  ["level", "levels"],
  ["office", "offices"],
  ["door", "doors"],
  ["war", "wars"],
  ["history", "histories"],
  ["party", "parties"],
  ["result", "results"],
  ["change", "changes"],
  ["morning", "mornings"],
  ["reason", "reasons"],
  ["girl", "girls"],
  ["guy", "guys"],
  ["moment", "moments"],
  ["teacher", "teachers"],
  ["force", "forces"],
  ["database", "databases"],
  ["cat", "cats"],
  ["bus", "buses"],
  ["wolf", "wolves"],
  ["wife", "wives"],
  ["belief", "beliefs"],
  ["potato", "potatoes"],
  ["photo", "photos"],
  ["focus", "foci"],
  ["analysis", "analyses"],
  ["phenomenon", "phenomena"],
  ["goose", "geese"],
  ["mouse", "mice"],
  ["tooth", "teeth"]
];

@suite class English {
  @test "singularize"() {
    for (const [s, p] of words) assert.strictEqual(service.Singularize(p), s);
  }

  @test "pluralize"() {
    for (const [s, p] of words) assert.strictEqual(service.Pluralize(s), p);
  }

  @test "is singular"() {
    for (const [s, p] of words) {
      assert.ok(service.IsSingular(s));
      assert.ok(!service.IsSingular(p));
    }
  }

  @test "is plural"() {
    for (const [s, p] of words) {
      assert.ok(!service.IsPlural(s));
      assert.ok(service.IsPlural(p));
    }
  }
}
