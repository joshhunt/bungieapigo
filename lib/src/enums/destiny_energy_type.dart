import 'package:json_annotation/json_annotation.dart';

enum DestinyEnergyType {
  ///Any = 0
  @JsonValue(0)
  Any,
  ///Arc = 1
  @JsonValue(1)
  Arc,
  ///Thermal = 2
  @JsonValue(2)
  Thermal,
  ///Void = 3
  @JsonValue(3)
  Void,
}

extension DestinyEnergyTypeExtension on DestinyEnergyType{
  int get value {
    switch(this){
      case DestinyEnergyType.Any:
        return 0;
      case DestinyEnergyType.Arc:
        return 1;
      case DestinyEnergyType.Thermal:
        return 2;
      case DestinyEnergyType.Void:
        return 3;
      default:
        return null;
    }
  }
}