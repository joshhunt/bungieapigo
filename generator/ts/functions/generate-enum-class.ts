/**
 * This is a custom, hand-rolled generator for Dart typings for the Bungie.net API based on DIM's bungie-api-ts.
 * It's meant for use in Little Light, but is free for anyone to use.
 */

import * as shell from "shelljs";
import * as mustache from "mustache";
import { readFileSync, writeFileSync } from "fs";
import { EnumClass } from "../models/EnumClass";

export function generateEnumClass(enumClass: EnumClass) {
  if (!shell.test("-d", "../pkg/models")) {
    shell.mkdir("-p", "../pkg/models");
  }

  let template = readFileSync("templates/enum.mustache").toString();
  let rendered = mustache.render(template, enumClass);

  writeFileSync(`../pkg/models/${enumClass.filename}.go`, rendered);
}
