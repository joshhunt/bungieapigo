/**
 * This is a custom, hand-rolled generator for Dart typings for the Bungie.net API based on DIM's bungie-api-ts.
 * It's meant for use in Little Light, but is free for anyone to use.
 */

import { OpenAPIObject } from "openapi3-ts";

import * as fs from "fs-extra";
import * as path from "path";

export async function copyCustom(doc: OpenAPIObject) {
  fs.writeFileSync("../bungie-api-version", doc.info.version);

  // fs.mkdirpSync("../BungieNetApi/Api");
  // fs.copyFileSync(
  //   path.join(".", "cs-custom", "DestinyServerResponse.cs"),
  //   path.join("..", "BungieNetApi", "Api", "DestinyServerResponse.cs")
  // );
}
