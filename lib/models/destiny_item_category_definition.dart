import 'destiny_display_properties_definition.dart';
class DestinyItemCategoryDefinition{
	DestinyDisplayPropertiesDefinition displayProperties;
	bool visible;
	bool deprecated;
	String shortTitle;
	String itemTypeRegex;
	String plugCategoryIdentifier;
	String itemTypeRegexNot;
	String originBucketIdentifier;
	int grantDestinyItemType;
	int grantDestinySubType;
	int grantDestinyClass;
	List<int> groupedCategoryHashes;
	List<int> parentCategoryHashes;
	bool groupCategoryOnly;
	int hash;
	int index;
	bool redacted;
	DestinyItemCategoryDefinition(
		this.displayProperties,
		this.visible,
		this.deprecated,
		this.shortTitle,
		this.itemTypeRegex,
		this.plugCategoryIdentifier,
		this.itemTypeRegexNot,
		this.originBucketIdentifier,
		this.grantDestinyItemType,
		this.grantDestinySubType,
		this.grantDestinyClass,
		this.groupedCategoryHashes,
		this.parentCategoryHashes,
		this.groupCategoryOnly,
		this.hash,
		this.index,
		this.redacted,
	);

	static DestinyItemCategoryDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyItemCategoryDefinition(
				data['displayProperties'] != null ? DestinyDisplayPropertiesDefinition.fromMap(data['displayProperties']) : null,
				data['visible'],
				data['deprecated'],
				data['shortTitle'],
				data['itemTypeRegex'],
				data['plugCategoryIdentifier'],
				data['itemTypeRegexNot'],
				data['originBucketIdentifier'],
				data['grantDestinyItemType'],
				data['grantDestinySubType'],
				data['grantDestinyClass'],
				data['groupedCategoryHashes'] != null ? data['groupedCategoryHashes']?.cast<int>() ?? null : null,
				data['parentCategoryHashes'] != null ? data['parentCategoryHashes']?.cast<int>() ?? null : null,
				data['groupCategoryOnly'],
				data['hash'],
				data['index'],
				data['redacted'],
		);
	}

	static List<DestinyItemCategoryDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyItemCategoryDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinyItemCategoryDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['displayProperties'] = this.displayProperties.toMap();
			data['visible'] = this.visible;
			data['deprecated'] = this.deprecated;
			data['shortTitle'] = this.shortTitle;
			data['itemTypeRegex'] = this.itemTypeRegex;
			data['plugCategoryIdentifier'] = this.plugCategoryIdentifier;
			data['itemTypeRegexNot'] = this.itemTypeRegexNot;
			data['originBucketIdentifier'] = this.originBucketIdentifier;
			data['grantDestinyItemType'] = this.grantDestinyItemType;
			data['grantDestinySubType'] = this.grantDestinySubType;
			data['grantDestinyClass'] = this.grantDestinyClass;
			data['groupedCategoryHashes'] = this.groupedCategoryHashes;
			data['parentCategoryHashes'] = this.parentCategoryHashes;
			data['groupCategoryOnly'] = this.groupCategoryOnly;
			data['hash'] = this.hash;
			data['index'] = this.index;
			data['redacted'] = this.redacted;
		return data;
	}
}