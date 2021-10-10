import { SchemaObject } from "openapi3-ts";
import { camelcaseToUnderscore } from "../utils/camelcase-to-underscore";
import { ApiDocHelper } from "../utils/api-doc-helper";

export class EnumClass {
  static all: { [id: string]: EnumClass } = {};
  public className: string;
  constructor(public pathName: string, public data: SchemaObject) {
    this.className = pathName.split(".").pop()!;
    EnumClass.all[this.className] = this;
  }

  get isBitMask(): boolean {
    return this.data["x-enum-is-bitmask"] || false;
  }

  get filename(): string {
    return ApiDocHelper.propertyName(this.className);
  }

  get description(): string[] | null {
    if (this.data.description) {
      return ApiDocHelper.formatDescription(this.data.description);
    }

    return null;
  }

  get baseEnumTypeName(): string {
    return `${this.className}`;
  }

  get baseEnumType(): string {
    return ApiDocHelper.getObjectType(this.data);
  }

  values() {
    let enumValues = this.data["x-enum-values"];
    return enumValues.map((enumValue) => {
      return {
        type: "int",
        name: `${this.baseEnumTypeName}${enumValue.identifier}`,

        value: enumValue.numericValue,

        description: ApiDocHelper.formatDescription(enumValue.description),
      };
    });
  }
}
