// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'post_response.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

PostResponse _$PostResponseFromJson(Map<String, dynamic> json) {
  return PostResponse()
    ..lastReplyTimestamp = json['lastReplyTimestamp'] as String
    ..isPinned = json['IsPinned'] as bool
    ..urlMediaType = _$enumDecodeNullable(
        _$ForumMediaTypeEnumMap, json['urlMediaType'],
        unknownValue: ForumMediaType.None)
    ..thumbnail = json['thumbnail'] as String
    ..popularity = _$enumDecodeNullable(
        _$ForumPostPopularityEnumMap, json['popularity'],
        unknownValue: ForumPostPopularity.Empty)
    ..isActive = json['isActive'] as bool
    ..isAnnouncement = json['isAnnouncement'] as bool
    ..userRating = json['userRating'] as int
    ..userHasRated = json['userHasRated'] as bool
    ..userHasMutedPost = json['userHasMutedPost'] as bool
    ..latestReplyPostId = json['latestReplyPostId'] as String
    ..latestReplyAuthorId = json['latestReplyAuthorId'] as String
    ..ignoreStatus = json['ignoreStatus'] == null
        ? null
        : IgnoreResponse.fromJson(json['ignoreStatus'] as Map<String, dynamic>)
    ..locale = json['locale'] as String;
}

Map<String, dynamic> _$PostResponseToJson(PostResponse instance) =>
    <String, dynamic>{
      'lastReplyTimestamp': instance.lastReplyTimestamp,
      'IsPinned': instance.isPinned,
      'urlMediaType': _$ForumMediaTypeEnumMap[instance.urlMediaType],
      'thumbnail': instance.thumbnail,
      'popularity': _$ForumPostPopularityEnumMap[instance.popularity],
      'isActive': instance.isActive,
      'isAnnouncement': instance.isAnnouncement,
      'userRating': instance.userRating,
      'userHasRated': instance.userHasRated,
      'userHasMutedPost': instance.userHasMutedPost,
      'latestReplyPostId': instance.latestReplyPostId,
      'latestReplyAuthorId': instance.latestReplyAuthorId,
      'ignoreStatus': instance.ignoreStatus,
      'locale': instance.locale,
    };

T _$enumDecode<T>(
  Map<T, dynamic> enumValues,
  dynamic source, {
  T unknownValue,
}) {
  if (source == null) {
    throw ArgumentError('A value must be provided. Supported values: '
        '${enumValues.values.join(', ')}');
  }

  final value = enumValues.entries
      .singleWhere((e) => e.value == source, orElse: () => null)
      ?.key;

  if (value == null && unknownValue == null) {
    throw ArgumentError('`$source` is not one of the supported values: '
        '${enumValues.values.join(', ')}');
  }
  return value ?? unknownValue;
}

T _$enumDecodeNullable<T>(
  Map<T, dynamic> enumValues,
  dynamic source, {
  T unknownValue,
}) {
  if (source == null) {
    return null;
  }
  return _$enumDecode<T>(enumValues, source, unknownValue: unknownValue);
}

const _$ForumMediaTypeEnumMap = {
  ForumMediaType.None: 0,
  ForumMediaType.Image: 1,
  ForumMediaType.Video: 2,
  ForumMediaType.Youtube: 3,
};

const _$ForumPostPopularityEnumMap = {
  ForumPostPopularity.Empty: 0,
  ForumPostPopularity.Default: 1,
  ForumPostPopularity.Discussed: 2,
  ForumPostPopularity.CoolStory: 3,
  ForumPostPopularity.HeatingUp: 4,
  ForumPostPopularity.Hot: 5,
};
