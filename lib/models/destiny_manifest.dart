import 'gear_asset_data_base_definition.dart';
class DestinyManifest{
	String version;
	String mobileAssetContentPath;
	List<GearAssetDataBaseDefinition> mobileGearAssetDataBases;
	Map<String, String> mobileWorldContentPaths;
	Map<String, String> jsonWorldContentPaths;
	String mobileClanBannerDatabasePath;
	Map<String, String> mobileGearCdn;
	DestinyManifest(
		this.version,
		this.mobileAssetContentPath,
		this.mobileGearAssetDataBases,
		this.mobileWorldContentPaths,
		this.jsonWorldContentPaths,
		this.mobileClanBannerDatabasePath,
		this.mobileGearCdn,
	);

	static DestinyManifest fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyManifest(
				data['version'],
				data['mobileAssetContentPath'],
				data['mobileGearAssetDataBases'] != null ? GearAssetDataBaseDefinition.fromList(data['mobileGearAssetDataBases']) : null,
				data['mobileWorldContentPaths'] != null ? Map<String, String>.from(data['mobileWorldContentPaths'].map((k, v)=>MapEntry(k, v))) : null,
				data['jsonWorldContentPaths'] != null ? Map<String, String>.from(data['jsonWorldContentPaths'].map((k, v)=>MapEntry(k, v))) : null,
				data['mobileClanBannerDatabasePath'],
				data['mobileGearCDN'] != null ? Map<String, String>.from(data['mobileGearCDN'].map((k, v)=>MapEntry(k, v))) : null,
		);
	}

	static List<DestinyManifest> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyManifest> list = new List();
    data.forEach((item) {
      list.add(DestinyManifest.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['version'] = this.version;
			data['mobileAssetContentPath'] = this.mobileAssetContentPath;
			data['mobileGearAssetDataBases'] = this.mobileGearAssetDataBases.map((item)=>item.toMap()).toList();
			data['mobileWorldContentPaths'] = this.mobileWorldContentPaths;
			data['jsonWorldContentPaths'] = this.jsonWorldContentPaths;
			data['mobileClanBannerDatabasePath'] = this.mobileClanBannerDatabasePath;
			data['mobileGearCDN'] = this.mobileGearCdn;
		return data;
	}
}