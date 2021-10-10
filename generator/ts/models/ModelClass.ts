import { SchemaObject, ReferenceObject, ParameterObject } from "openapi3-ts";
import { ModelProperty } from "./ModelProperty";
import { chain, map } from "lodash";
import { ApiDocHelper } from "../utils/api-doc-helper";
import { camelcaseToUnderscore } from "../utils/camelcase-to-underscore";
import { ImportInfo } from "./ImportInfo";
import { basename } from "path";

export class ModelClass {
  static all: { [id: string]: ModelClass } = {};
  public className: string;

  constructor(public pathName: string, public data: SchemaObject) {
    this.className = pathName.split(".").pop()!;
    if (Object.keys(this.data.properties || {}).length === 0) {
      console.warn(`Omitting ${this.className} due to no properties`);
    } else {
      ModelClass.all[this.className] = this;
    }
  }

  get hasProperties(): boolean {
    return this.properties.length > 0;
  }

  properties(): ModelProperty[] {
    let props = map(
      this.data.properties,
      (property: ParameterObject | ReferenceObject, index: string) => {
        return new ModelProperty(index, property);
      }
    );

    const fixedProperties = props as any as ModelProperty[];
    fixedProperties.forEach((prop, index) => {
      prop.notLast = index !== fixedProperties.length - 1;
    });

    return fixedProperties;
  }

  description() {
    if (!this.data.description) return null;
    return this.data.description.split("\r\n");
  }

  get filename(): String {
    return ApiDocHelper.propertyName(this.className);
  }

  imports() {
    const baseImports = [];

    const propertyImports = this.properties()
      .flatMap((prop) => {
        const type = prop.typeName();

        if (type.includes("time.")) {
          return ["time"];
        }

        return null;
      })
      .filter(Boolean)
      .reduce((acc, v) => {
        return acc.includes(v || "") ? acc : [...acc, v];
      }, [] as string[]);

    return [...baseImports, ...propertyImports];
  }
}
