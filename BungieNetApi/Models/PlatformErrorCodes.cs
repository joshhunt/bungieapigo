using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum PlatformErrorCodes
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Success = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Success = 1,

        /// <summary>
        /// TransportException = 2
        /// </summary>
        [EnumMember(Value = "2")]
        TransportException = 2,

        /// <summary>
        /// UnhandledException = 3
        /// </summary>
        [EnumMember(Value = "3")]
        UnhandledException = 3,

        /// <summary>
        /// NotImplemented = 4
        /// </summary>
        [EnumMember(Value = "4")]
        NotImplemented = 4,

        /// <summary>
        /// SystemDisabled = 5
        /// </summary>
        [EnumMember(Value = "5")]
        SystemDisabled = 5,

        /// <summary>
        /// FailedToLoadAvailableLocalesConfiguration = 6
        /// </summary>
        [EnumMember(Value = "6")]
        FailedToLoadAvailableLocalesConfiguration = 6,

        /// <summary>
        /// ParameterParseFailure = 7
        /// </summary>
        [EnumMember(Value = "7")]
        ParameterParseFailure = 7,

        /// <summary>
        /// ParameterInvalidRange = 8
        /// </summary>
        [EnumMember(Value = "8")]
        ParameterInvalidRange = 8,

        /// <summary>
        /// BadRequest = 9
        /// </summary>
        [EnumMember(Value = "9")]
        BadRequest = 9,

        /// <summary>
        /// AuthenticationInvalid = 10
        /// </summary>
        [EnumMember(Value = "10")]
        AuthenticationInvalid = 10,

        /// <summary>
        /// DataNotFound = 11
        /// </summary>
        [EnumMember(Value = "11")]
        DataNotFound = 11,

        /// <summary>
        /// InsufficientPrivileges = 12
        /// </summary>
        [EnumMember(Value = "12")]
        InsufficientPrivileges = 12,

        /// <summary>
        /// Duplicate = 13
        /// </summary>
        [EnumMember(Value = "13")]
        Duplicate = 13,

        /// <summary>
        /// UnknownSqlResult = 14
        /// Deprecated, please do not check for this value anywhere.
        /// </summary>
        [EnumMember(Value = "14")]
        UnknownSqlResult = 14,

        /// <summary>
        /// ValidationError = 15
        /// </summary>
        [EnumMember(Value = "15")]
        ValidationError = 15,

        /// <summary>
        /// ValidationMissingFieldError = 16
        /// </summary>
        [EnumMember(Value = "16")]
        ValidationMissingFieldError = 16,

        /// <summary>
        /// ValidationInvalidInputError = 17
        /// </summary>
        [EnumMember(Value = "17")]
        ValidationInvalidInputError = 17,

        /// <summary>
        /// InvalidParameters = 18
        /// </summary>
        [EnumMember(Value = "18")]
        InvalidParameters = 18,

        /// <summary>
        /// ParameterNotFound = 19
        /// </summary>
        [EnumMember(Value = "19")]
        ParameterNotFound = 19,

        /// <summary>
        /// UnhandledHttpException = 20
        /// </summary>
        [EnumMember(Value = "20")]
        UnhandledHttpException = 20,

        /// <summary>
        /// NotFound = 21
        /// </summary>
        [EnumMember(Value = "21")]
        NotFound = 21,

        /// <summary>
        /// WebAuthModuleAsyncFailed = 22
        /// </summary>
        [EnumMember(Value = "22")]
        WebAuthModuleAsyncFailed = 22,

        /// <summary>
        /// InvalidReturnValue = 23
        /// </summary>
        [EnumMember(Value = "23")]
        InvalidReturnValue = 23,

        /// <summary>
        /// UserBanned = 24
        /// </summary>
        [EnumMember(Value = "24")]
        UserBanned = 24,

        /// <summary>
        /// InvalidPostBody = 25
        /// </summary>
        [EnumMember(Value = "25")]
        InvalidPostBody = 25,

        /// <summary>
        /// MissingPostBody = 26
        /// </summary>
        [EnumMember(Value = "26")]
        MissingPostBody = 26,

        /// <summary>
        /// ExternalServiceTimeout = 27
        /// </summary>
        [EnumMember(Value = "27")]
        ExternalServiceTimeout = 27,

        /// <summary>
        /// ValidationLengthError = 28
        /// </summary>
        [EnumMember(Value = "28")]
        ValidationLengthError = 28,

        /// <summary>
        /// ValidationRangeError = 29
        /// </summary>
        [EnumMember(Value = "29")]
        ValidationRangeError = 29,

        /// <summary>
        /// JsonDeserializationError = 30
        /// </summary>
        [EnumMember(Value = "30")]
        JsonDeserializationError = 30,

        /// <summary>
        /// ThrottleLimitExceeded = 31
        /// </summary>
        [EnumMember(Value = "31")]
        ThrottleLimitExceeded = 31,

        /// <summary>
        /// ValidationTagError = 32
        /// </summary>
        [EnumMember(Value = "32")]
        ValidationTagError = 32,

        /// <summary>
        /// ValidationProfanityError = 33
        /// </summary>
        [EnumMember(Value = "33")]
        ValidationProfanityError = 33,

        /// <summary>
        /// ValidationUrlFormatError = 34
        /// </summary>
        [EnumMember(Value = "34")]
        ValidationUrlFormatError = 34,

        /// <summary>
        /// ThrottleLimitExceededMinutes = 35
        /// </summary>
        [EnumMember(Value = "35")]
        ThrottleLimitExceededMinutes = 35,

        /// <summary>
        /// ThrottleLimitExceededMomentarily = 36
        /// </summary>
        [EnumMember(Value = "36")]
        ThrottleLimitExceededMomentarily = 36,

        /// <summary>
        /// ThrottleLimitExceededSeconds = 37
        /// </summary>
        [EnumMember(Value = "37")]
        ThrottleLimitExceededSeconds = 37,

        /// <summary>
        /// ExternalServiceUnknown = 38
        /// </summary>
        [EnumMember(Value = "38")]
        ExternalServiceUnknown = 38,

        /// <summary>
        /// ValidationWordLengthError = 39
        /// </summary>
        [EnumMember(Value = "39")]
        ValidationWordLengthError = 39,

        /// <summary>
        /// ValidationInvisibleUnicode = 40
        /// </summary>
        [EnumMember(Value = "40")]
        ValidationInvisibleUnicode = 40,

        /// <summary>
        /// ValidationBadNames = 41
        /// </summary>
        [EnumMember(Value = "41")]
        ValidationBadNames = 41,

        /// <summary>
        /// ExternalServiceFailed = 42
        /// </summary>
        [EnumMember(Value = "42")]
        ExternalServiceFailed = 42,

        /// <summary>
        /// ServiceRetired = 43
        /// </summary>
        [EnumMember(Value = "43")]
        ServiceRetired = 43,

        /// <summary>
        /// UnknownSqlException = 44
        /// </summary>
        [EnumMember(Value = "44")]
        UnknownSqlException = 44,

        /// <summary>
        /// UnsupportedLocale = 45
        /// </summary>
        [EnumMember(Value = "45")]
        UnsupportedLocale = 45,

        /// <summary>
        /// InvalidPageNumber = 46
        /// </summary>
        [EnumMember(Value = "46")]
        InvalidPageNumber = 46,

        /// <summary>
        /// MaximumPageSizeExceeded = 47
        /// </summary>
        [EnumMember(Value = "47")]
        MaximumPageSizeExceeded = 47,

        /// <summary>
        /// ServiceUnsupported = 48
        /// </summary>
        [EnumMember(Value = "48")]
        ServiceUnsupported = 48,

        /// <summary>
        /// ValidationMaximumUnicodeCombiningCharacters = 49
        /// </summary>
        [EnumMember(Value = "49")]
        ValidationMaximumUnicodeCombiningCharacters = 49,

        /// <summary>
        /// ValidationMaximumSequentialCarriageReturns = 50
        /// </summary>
        [EnumMember(Value = "50")]
        ValidationMaximumSequentialCarriageReturns = 50,

        /// <summary>
        /// PerEndpointRequestThrottleExceeded = 51
        /// </summary>
        [EnumMember(Value = "51")]
        PerEndpointRequestThrottleExceeded = 51,

        /// <summary>
        /// AuthContextCacheAssertion = 52
        /// </summary>
        [EnumMember(Value = "52")]
        AuthContextCacheAssertion = 52,

        /// <summary>
        /// ExPlatformStringValidationError = 53
        /// </summary>
        [EnumMember(Value = "53")]
        ExPlatformStringValidationError = 53,

        /// <summary>
        /// PerApplicationThrottleExceeded = 54
        /// </summary>
        [EnumMember(Value = "54")]
        PerApplicationThrottleExceeded = 54,

        /// <summary>
        /// PerApplicationAnonymousThrottleExceeded = 55
        /// </summary>
        [EnumMember(Value = "55")]
        PerApplicationAnonymousThrottleExceeded = 55,

        /// <summary>
        /// PerApplicationAuthenticatedThrottleExceeded = 56
        /// </summary>
        [EnumMember(Value = "56")]
        PerApplicationAuthenticatedThrottleExceeded = 56,

        /// <summary>
        /// PerUserThrottleExceeded = 57
        /// </summary>
        [EnumMember(Value = "57")]
        PerUserThrottleExceeded = 57,

        /// <summary>
        /// PayloadSignatureVerificationFailure = 58
        /// </summary>
        [EnumMember(Value = "58")]
        PayloadSignatureVerificationFailure = 58,

        /// <summary>
        /// InvalidServiceAuthContext = 59
        /// </summary>
        [EnumMember(Value = "59")]
        InvalidServiceAuthContext = 59,

        /// <summary>
        /// ObsoleteCredentialType = 89
        /// </summary>
        [EnumMember(Value = "89")]
        ObsoleteCredentialType = 89,

        /// <summary>
        /// UnableToUnPairMobileApp = 90
        /// </summary>
        [EnumMember(Value = "90")]
        UnableToUnPairMobileApp = 90,

        /// <summary>
        /// UnableToPairMobileApp = 91
        /// </summary>
        [EnumMember(Value = "91")]
        UnableToPairMobileApp = 91,

        /// <summary>
        /// CannotUseMobileAuthWithNonMobileProvider = 92
        /// </summary>
        [EnumMember(Value = "92")]
        CannotUseMobileAuthWithNonMobileProvider = 92,

        /// <summary>
        /// MissingDeviceCookie = 93
        /// </summary>
        [EnumMember(Value = "93")]
        MissingDeviceCookie = 93,

        /// <summary>
        /// FacebookTokenExpired = 94
        /// </summary>
        [EnumMember(Value = "94")]
        FacebookTokenExpired = 94,

        /// <summary>
        /// AuthTicketRequired = 95
        /// </summary>
        [EnumMember(Value = "95")]
        AuthTicketRequired = 95,

        /// <summary>
        /// CookieContextRequired = 96
        /// </summary>
        [EnumMember(Value = "96")]
        CookieContextRequired = 96,

        /// <summary>
        /// UnknownAuthenticationError = 97
        /// </summary>
        [EnumMember(Value = "97")]
        UnknownAuthenticationError = 97,

        /// <summary>
        /// BungieNetAccountCreationRequired = 98
        /// </summary>
        [EnumMember(Value = "98")]
        BungieNetAccountCreationRequired = 98,

        /// <summary>
        /// WebAuthRequired = 99
        /// </summary>
        [EnumMember(Value = "99")]
        WebAuthRequired = 99,

        /// <summary>
        /// ContentUnknownSqlResult = 100
        /// </summary>
        [EnumMember(Value = "100")]
        ContentUnknownSqlResult = 100,

        /// <summary>
        /// ContentNeedUniquePath = 101
        /// </summary>
        [EnumMember(Value = "101")]
        ContentNeedUniquePath = 101,

        /// <summary>
        /// ContentSqlException = 102
        /// </summary>
        [EnumMember(Value = "102")]
        ContentSqlException = 102,

        /// <summary>
        /// ContentNotFound = 103
        /// </summary>
        [EnumMember(Value = "103")]
        ContentNotFound = 103,

        /// <summary>
        /// ContentSuccessWithTagAddFail = 104
        /// </summary>
        [EnumMember(Value = "104")]
        ContentSuccessWithTagAddFail = 104,

        /// <summary>
        /// ContentSearchMissingParameters = 105
        /// </summary>
        [EnumMember(Value = "105")]
        ContentSearchMissingParameters = 105,

        /// <summary>
        /// ContentInvalidId = 106
        /// </summary>
        [EnumMember(Value = "106")]
        ContentInvalidId = 106,

        /// <summary>
        /// ContentPhysicalFileDeletionError = 107
        /// </summary>
        [EnumMember(Value = "107")]
        ContentPhysicalFileDeletionError = 107,

        /// <summary>
        /// ContentPhysicalFileCreationError = 108
        /// </summary>
        [EnumMember(Value = "108")]
        ContentPhysicalFileCreationError = 108,

        /// <summary>
        /// ContentPerforceSubmissionError = 109
        /// </summary>
        [EnumMember(Value = "109")]
        ContentPerforceSubmissionError = 109,

        /// <summary>
        /// ContentPerforceInitializationError = 110
        /// </summary>
        [EnumMember(Value = "110")]
        ContentPerforceInitializationError = 110,

        /// <summary>
        /// ContentDeploymentPackageNotReadyError = 111
        /// </summary>
        [EnumMember(Value = "111")]
        ContentDeploymentPackageNotReadyError = 111,

        /// <summary>
        /// ContentUploadFailed = 112
        /// </summary>
        [EnumMember(Value = "112")]
        ContentUploadFailed = 112,

        /// <summary>
        /// ContentTooManyResults = 113
        /// </summary>
        [EnumMember(Value = "113")]
        ContentTooManyResults = 113,

        /// <summary>
        /// ContentInvalidState = 115
        /// </summary>
        [EnumMember(Value = "115")]
        ContentInvalidState = 115,

        /// <summary>
        /// ContentNavigationParentNotFound = 116
        /// </summary>
        [EnumMember(Value = "116")]
        ContentNavigationParentNotFound = 116,

        /// <summary>
        /// ContentNavigationParentUpdateError = 117
        /// </summary>
        [EnumMember(Value = "117")]
        ContentNavigationParentUpdateError = 117,

        /// <summary>
        /// DeploymentPackageNotEditable = 118
        /// </summary>
        [EnumMember(Value = "118")]
        DeploymentPackageNotEditable = 118,

        /// <summary>
        /// ContentValidationError = 119
        /// </summary>
        [EnumMember(Value = "119")]
        ContentValidationError = 119,

        /// <summary>
        /// ContentPropertiesValidationError = 120
        /// </summary>
        [EnumMember(Value = "120")]
        ContentPropertiesValidationError = 120,

        /// <summary>
        /// ContentTypeNotFound = 121
        /// </summary>
        [EnumMember(Value = "121")]
        ContentTypeNotFound = 121,

        /// <summary>
        /// DeploymentPackageNotFound = 122
        /// </summary>
        [EnumMember(Value = "122")]
        DeploymentPackageNotFound = 122,

        /// <summary>
        /// ContentSearchInvalidParameters = 123
        /// </summary>
        [EnumMember(Value = "123")]
        ContentSearchInvalidParameters = 123,

        /// <summary>
        /// ContentItemPropertyAggregationError = 124
        /// </summary>
        [EnumMember(Value = "124")]
        ContentItemPropertyAggregationError = 124,

        /// <summary>
        /// DeploymentPackageFileNotFound = 125
        /// </summary>
        [EnumMember(Value = "125")]
        DeploymentPackageFileNotFound = 125,

        /// <summary>
        /// ContentPerforceFileHistoryNotFound = 126
        /// </summary>
        [EnumMember(Value = "126")]
        ContentPerforceFileHistoryNotFound = 126,

        /// <summary>
        /// ContentAssetZipCreationFailure = 127
        /// </summary>
        [EnumMember(Value = "127")]
        ContentAssetZipCreationFailure = 127,

        /// <summary>
        /// ContentAssetZipCreationBusy = 128
        /// </summary>
        [EnumMember(Value = "128")]
        ContentAssetZipCreationBusy = 128,

        /// <summary>
        /// ContentProjectNotFound = 129
        /// </summary>
        [EnumMember(Value = "129")]
        ContentProjectNotFound = 129,

        /// <summary>
        /// ContentFolderNotFound = 130
        /// </summary>
        [EnumMember(Value = "130")]
        ContentFolderNotFound = 130,

        /// <summary>
        /// ContentPackagesInconsistent = 131
        /// </summary>
        [EnumMember(Value = "131")]
        ContentPackagesInconsistent = 131,

        /// <summary>
        /// ContentPackagesInvalidState = 132
        /// </summary>
        [EnumMember(Value = "132")]
        ContentPackagesInvalidState = 132,

        /// <summary>
        /// ContentPackagesInconsistentType = 133
        /// </summary>
        [EnumMember(Value = "133")]
        ContentPackagesInconsistentType = 133,

        /// <summary>
        /// ContentCannotDeletePackage = 134
        /// </summary>
        [EnumMember(Value = "134")]
        ContentCannotDeletePackage = 134,

        /// <summary>
        /// ContentLockedForChanges = 135
        /// </summary>
        [EnumMember(Value = "135")]
        ContentLockedForChanges = 135,

        /// <summary>
        /// ContentFileUploadFailed = 136
        /// </summary>
        [EnumMember(Value = "136")]
        ContentFileUploadFailed = 136,

        /// <summary>
        /// ContentNotReviewed = 137
        /// </summary>
        [EnumMember(Value = "137")]
        ContentNotReviewed = 137,

        /// <summary>
        /// ContentPermissionDenied = 138
        /// </summary>
        [EnumMember(Value = "138")]
        ContentPermissionDenied = 138,

        /// <summary>
        /// ContentInvalidExternalUrl = 139
        /// </summary>
        [EnumMember(Value = "139")]
        ContentInvalidExternalUrl = 139,

        /// <summary>
        /// ContentExternalFileCannotBeImportedLocally = 140
        /// </summary>
        [EnumMember(Value = "140")]
        ContentExternalFileCannotBeImportedLocally = 140,

        /// <summary>
        /// ContentTagSaveFailure = 141
        /// </summary>
        [EnumMember(Value = "141")]
        ContentTagSaveFailure = 141,

        /// <summary>
        /// ContentPerforceUnmatchedFileError = 142
        /// </summary>
        [EnumMember(Value = "142")]
        ContentPerforceUnmatchedFileError = 142,

        /// <summary>
        /// ContentPerforceChangelistResultNotFound = 143
        /// </summary>
        [EnumMember(Value = "143")]
        ContentPerforceChangelistResultNotFound = 143,

        /// <summary>
        /// ContentPerforceChangelistFileItemsNotFound = 144
        /// </summary>
        [EnumMember(Value = "144")]
        ContentPerforceChangelistFileItemsNotFound = 144,

        /// <summary>
        /// ContentPerforceInvalidRevisionError = 145
        /// </summary>
        [EnumMember(Value = "145")]
        ContentPerforceInvalidRevisionError = 145,

        /// <summary>
        /// ContentUnloadedSaveResult = 146
        /// </summary>
        [EnumMember(Value = "146")]
        ContentUnloadedSaveResult = 146,

        /// <summary>
        /// ContentPropertyInvalidNumber = 147
        /// </summary>
        [EnumMember(Value = "147")]
        ContentPropertyInvalidNumber = 147,

        /// <summary>
        /// ContentPropertyInvalidUrl = 148
        /// </summary>
        [EnumMember(Value = "148")]
        ContentPropertyInvalidUrl = 148,

        /// <summary>
        /// ContentPropertyInvalidDate = 149
        /// </summary>
        [EnumMember(Value = "149")]
        ContentPropertyInvalidDate = 149,

        /// <summary>
        /// ContentPropertyInvalidSet = 150
        /// </summary>
        [EnumMember(Value = "150")]
        ContentPropertyInvalidSet = 150,

        /// <summary>
        /// ContentPropertyCannotDeserialize = 151
        /// </summary>
        [EnumMember(Value = "151")]
        ContentPropertyCannotDeserialize = 151,

        /// <summary>
        /// ContentRegexValidationFailOnProperty = 152
        /// </summary>
        [EnumMember(Value = "152")]
        ContentRegexValidationFailOnProperty = 152,

        /// <summary>
        /// ContentMaxLengthFailOnProperty = 153
        /// </summary>
        [EnumMember(Value = "153")]
        ContentMaxLengthFailOnProperty = 153,

        /// <summary>
        /// ContentPropertyUnexpectedDeserializationError = 154
        /// </summary>
        [EnumMember(Value = "154")]
        ContentPropertyUnexpectedDeserializationError = 154,

        /// <summary>
        /// ContentPropertyRequired = 155
        /// </summary>
        [EnumMember(Value = "155")]
        ContentPropertyRequired = 155,

        /// <summary>
        /// ContentCannotCreateFile = 156
        /// </summary>
        [EnumMember(Value = "156")]
        ContentCannotCreateFile = 156,

        /// <summary>
        /// ContentInvalidMigrationFile = 157
        /// </summary>
        [EnumMember(Value = "157")]
        ContentInvalidMigrationFile = 157,

        /// <summary>
        /// ContentMigrationAlteringProcessedItem = 158
        /// </summary>
        [EnumMember(Value = "158")]
        ContentMigrationAlteringProcessedItem = 158,

        /// <summary>
        /// ContentPropertyDefinitionNotFound = 159
        /// </summary>
        [EnumMember(Value = "159")]
        ContentPropertyDefinitionNotFound = 159,

        /// <summary>
        /// ContentReviewDataChanged = 160
        /// </summary>
        [EnumMember(Value = "160")]
        ContentReviewDataChanged = 160,

        /// <summary>
        /// ContentRollbackRevisionNotInPackage = 161
        /// </summary>
        [EnumMember(Value = "161")]
        ContentRollbackRevisionNotInPackage = 161,

        /// <summary>
        /// ContentItemNotBasedOnLatestRevision = 162
        /// </summary>
        [EnumMember(Value = "162")]
        ContentItemNotBasedOnLatestRevision = 162,

        /// <summary>
        /// ContentUnauthorized = 163
        /// </summary>
        [EnumMember(Value = "163")]
        ContentUnauthorized = 163,

        /// <summary>
        /// ContentCannotCreateDeploymentPackage = 164
        /// </summary>
        [EnumMember(Value = "164")]
        ContentCannotCreateDeploymentPackage = 164,

        /// <summary>
        /// ContentUserNotFound = 165
        /// </summary>
        [EnumMember(Value = "165")]
        ContentUserNotFound = 165,

        /// <summary>
        /// ContentLocalePermissionDenied = 166
        /// </summary>
        [EnumMember(Value = "166")]
        ContentLocalePermissionDenied = 166,

        /// <summary>
        /// ContentInvalidLinkToInternalEnvironment = 167
        /// </summary>
        [EnumMember(Value = "167")]
        ContentInvalidLinkToInternalEnvironment = 167,

        /// <summary>
        /// ContentInvalidBlacklistedContent = 168
        /// </summary>
        [EnumMember(Value = "168")]
        ContentInvalidBlacklistedContent = 168,

        /// <summary>
        /// ContentMacroMalformedNoContentId = 169
        /// </summary>
        [EnumMember(Value = "169")]
        ContentMacroMalformedNoContentId = 169,

        /// <summary>
        /// ContentMacroMalformedNoTemplateType = 170
        /// </summary>
        [EnumMember(Value = "170")]
        ContentMacroMalformedNoTemplateType = 170,

        /// <summary>
        /// ContentIllegalBNetMembershipId = 171
        /// </summary>
        [EnumMember(Value = "171")]
        ContentIllegalBNetMembershipId = 171,

        /// <summary>
        /// ContentLocaleDidNotMatchExpected = 172
        /// </summary>
        [EnumMember(Value = "172")]
        ContentLocaleDidNotMatchExpected = 172,

        /// <summary>
        /// ContentBabelCallFailed = 173
        /// </summary>
        [EnumMember(Value = "173")]
        ContentBabelCallFailed = 173,

        /// <summary>
        /// ContentEnglishPostLiveForbidden = 174
        /// </summary>
        [EnumMember(Value = "174")]
        ContentEnglishPostLiveForbidden = 174,

        /// <summary>
        /// ContentLocaleEditPermissionDenied = 175
        /// </summary>
        [EnumMember(Value = "175")]
        ContentLocaleEditPermissionDenied = 175,

        /// <summary>
        /// UserNonUniqueName = 200
        /// </summary>
        [EnumMember(Value = "200")]
        UserNonUniqueName = 200,

        /// <summary>
        /// UserManualLinkingStepRequired = 201
        /// </summary>
        [EnumMember(Value = "201")]
        UserManualLinkingStepRequired = 201,

        /// <summary>
        /// UserCreateUnknownSqlResult = 202
        /// </summary>
        [EnumMember(Value = "202")]
        UserCreateUnknownSqlResult = 202,

        /// <summary>
        /// UserCreateUnknownSqlException = 203
        /// </summary>
        [EnumMember(Value = "203")]
        UserCreateUnknownSqlException = 203,

        /// <summary>
        /// UserMalformedMembershipId = 204
        /// </summary>
        [EnumMember(Value = "204")]
        UserMalformedMembershipId = 204,

        /// <summary>
        /// UserCannotFindRequestedUser = 205
        /// </summary>
        [EnumMember(Value = "205")]
        UserCannotFindRequestedUser = 205,

        /// <summary>
        /// UserCannotLoadAccountCredentialLinkInfo = 206
        /// </summary>
        [EnumMember(Value = "206")]
        UserCannotLoadAccountCredentialLinkInfo = 206,

        /// <summary>
        /// UserInvalidMobileAppType = 207
        /// </summary>
        [EnumMember(Value = "207")]
        UserInvalidMobileAppType = 207,

        /// <summary>
        /// UserMissingMobilePairingInfo = 208
        /// </summary>
        [EnumMember(Value = "208")]
        UserMissingMobilePairingInfo = 208,

        /// <summary>
        /// UserCannotGenerateMobileKeyWhileUsingMobileCredential = 209
        /// </summary>
        [EnumMember(Value = "209")]
        UserCannotGenerateMobileKeyWhileUsingMobileCredential = 209,

        /// <summary>
        /// UserGenerateMobileKeyExistingSlotCollision = 210
        /// </summary>
        [EnumMember(Value = "210")]
        UserGenerateMobileKeyExistingSlotCollision = 210,

        /// <summary>
        /// UserDisplayNameMissingOrInvalid = 211
        /// </summary>
        [EnumMember(Value = "211")]
        UserDisplayNameMissingOrInvalid = 211,

        /// <summary>
        /// UserCannotLoadAccountProfileData = 212
        /// </summary>
        [EnumMember(Value = "212")]
        UserCannotLoadAccountProfileData = 212,

        /// <summary>
        /// UserCannotSaveUserProfileData = 213
        /// </summary>
        [EnumMember(Value = "213")]
        UserCannotSaveUserProfileData = 213,

        /// <summary>
        /// UserEmailMissingOrInvalid = 214
        /// </summary>
        [EnumMember(Value = "214")]
        UserEmailMissingOrInvalid = 214,

        /// <summary>
        /// UserTermsOfUseRequired = 215
        /// </summary>
        [EnumMember(Value = "215")]
        UserTermsOfUseRequired = 215,

        /// <summary>
        /// UserCannotCreateNewAccountWhileLoggedIn = 216
        /// </summary>
        [EnumMember(Value = "216")]
        UserCannotCreateNewAccountWhileLoggedIn = 216,

        /// <summary>
        /// UserCannotResolveCentralAccount = 217
        /// </summary>
        [EnumMember(Value = "217")]
        UserCannotResolveCentralAccount = 217,

        /// <summary>
        /// UserInvalidAvatar = 218
        /// </summary>
        [EnumMember(Value = "218")]
        UserInvalidAvatar = 218,

        /// <summary>
        /// UserMissingCreatedUserResult = 219
        /// </summary>
        [EnumMember(Value = "219")]
        UserMissingCreatedUserResult = 219,

        /// <summary>
        /// UserCannotChangeUniqueNameYet = 220
        /// </summary>
        [EnumMember(Value = "220")]
        UserCannotChangeUniqueNameYet = 220,

        /// <summary>
        /// UserCannotChangeDisplayNameYet = 221
        /// </summary>
        [EnumMember(Value = "221")]
        UserCannotChangeDisplayNameYet = 221,

        /// <summary>
        /// UserCannotChangeEmail = 222
        /// </summary>
        [EnumMember(Value = "222")]
        UserCannotChangeEmail = 222,

        /// <summary>
        /// UserUniqueNameMustStartWithLetter = 223
        /// </summary>
        [EnumMember(Value = "223")]
        UserUniqueNameMustStartWithLetter = 223,

        /// <summary>
        /// UserNoLinkedAccountsSupportFriendListings = 224
        /// </summary>
        [EnumMember(Value = "224")]
        UserNoLinkedAccountsSupportFriendListings = 224,

        /// <summary>
        /// UserAcknowledgmentTableFull = 225
        /// </summary>
        [EnumMember(Value = "225")]
        UserAcknowledgmentTableFull = 225,

        /// <summary>
        /// UserCreationDestinyMembershipRequired = 226
        /// </summary>
        [EnumMember(Value = "226")]
        UserCreationDestinyMembershipRequired = 226,

        /// <summary>
        /// UserFriendsTokenNeedsRefresh = 227
        /// </summary>
        [EnumMember(Value = "227")]
        UserFriendsTokenNeedsRefresh = 227,

        /// <summary>
        /// UserEmailValidationUnknown = 228
        /// </summary>
        [EnumMember(Value = "228")]
        UserEmailValidationUnknown = 228,

        /// <summary>
        /// UserEmailValidationLimit = 229
        /// </summary>
        [EnumMember(Value = "229")]
        UserEmailValidationLimit = 229,

        /// <summary>
        /// TransactionEmailSendFailure = 230
        /// </summary>
        [EnumMember(Value = "230")]
        TransactionEmailSendFailure = 230,

        /// <summary>
        /// MailHookPermissionFailure = 231
        /// </summary>
        [EnumMember(Value = "231")]
        MailHookPermissionFailure = 231,

        /// <summary>
        /// MailServiceRateLimit = 232
        /// </summary>
        [EnumMember(Value = "232")]
        MailServiceRateLimit = 232,

        /// <summary>
        /// UserEmailMustBeVerified = 233
        /// </summary>
        [EnumMember(Value = "233")]
        UserEmailMustBeVerified = 233,

        /// <summary>
        /// UserMustAllowCustomerServiceEmails = 234
        /// </summary>
        [EnumMember(Value = "234")]
        UserMustAllowCustomerServiceEmails = 234,

        /// <summary>
        /// NonTransactionalEmailSendFailure = 235
        /// </summary>
        [EnumMember(Value = "235")]
        NonTransactionalEmailSendFailure = 235,

        /// <summary>
        /// MessagingUnknownError = 300
        /// </summary>
        [EnumMember(Value = "300")]
        MessagingUnknownError = 300,

        /// <summary>
        /// MessagingSelfError = 301
        /// </summary>
        [EnumMember(Value = "301")]
        MessagingSelfError = 301,

        /// <summary>
        /// MessagingSendThrottle = 302
        /// </summary>
        [EnumMember(Value = "302")]
        MessagingSendThrottle = 302,

        /// <summary>
        /// MessagingNoBody = 303
        /// </summary>
        [EnumMember(Value = "303")]
        MessagingNoBody = 303,

        /// <summary>
        /// MessagingTooManyUsers = 304
        /// </summary>
        [EnumMember(Value = "304")]
        MessagingTooManyUsers = 304,

        /// <summary>
        /// MessagingCanNotLeaveConversation = 305
        /// </summary>
        [EnumMember(Value = "305")]
        MessagingCanNotLeaveConversation = 305,

        /// <summary>
        /// MessagingUnableToSend = 306
        /// </summary>
        [EnumMember(Value = "306")]
        MessagingUnableToSend = 306,

        /// <summary>
        /// MessagingDeletedUserForbidden = 307
        /// </summary>
        [EnumMember(Value = "307")]
        MessagingDeletedUserForbidden = 307,

        /// <summary>
        /// MessagingCannotDeleteExternalConversation = 308
        /// </summary>
        [EnumMember(Value = "308")]
        MessagingCannotDeleteExternalConversation = 308,

        /// <summary>
        /// MessagingGroupChatDisabled = 309
        /// </summary>
        [EnumMember(Value = "309")]
        MessagingGroupChatDisabled = 309,

        /// <summary>
        /// MessagingMustIncludeSelfInPrivateMessage = 310
        /// </summary>
        [EnumMember(Value = "310")]
        MessagingMustIncludeSelfInPrivateMessage = 310,

        /// <summary>
        /// MessagingSenderIsBanned = 311
        /// </summary>
        [EnumMember(Value = "311")]
        MessagingSenderIsBanned = 311,

        /// <summary>
        /// MessagingGroupOptionalChatExceededMaximum = 312
        /// </summary>
        [EnumMember(Value = "312")]
        MessagingGroupOptionalChatExceededMaximum = 312,

        /// <summary>
        /// PrivateMessagingRequiresDestinyMembership = 313
        /// </summary>
        [EnumMember(Value = "313")]
        PrivateMessagingRequiresDestinyMembership = 313,

        /// <summary>
        /// AddSurveyAnswersUnknownSqlException = 400
        /// </summary>
        [EnumMember(Value = "400")]
        AddSurveyAnswersUnknownSqlException = 400,

        /// <summary>
        /// ForumBodyCannotBeEmpty = 500
        /// </summary>
        [EnumMember(Value = "500")]
        ForumBodyCannotBeEmpty = 500,

        /// <summary>
        /// ForumSubjectCannotBeEmptyOnTopicPost = 501
        /// </summary>
        [EnumMember(Value = "501")]
        ForumSubjectCannotBeEmptyOnTopicPost = 501,

        /// <summary>
        /// ForumCannotLocateParentPost = 502
        /// </summary>
        [EnumMember(Value = "502")]
        ForumCannotLocateParentPost = 502,

        /// <summary>
        /// ForumThreadLockedForReplies = 503
        /// </summary>
        [EnumMember(Value = "503")]
        ForumThreadLockedForReplies = 503,

        /// <summary>
        /// ForumUnknownSqlResultDuringCreatePost = 504
        /// </summary>
        [EnumMember(Value = "504")]
        ForumUnknownSqlResultDuringCreatePost = 504,

        /// <summary>
        /// ForumUnknownTagCreationError = 505
        /// </summary>
        [EnumMember(Value = "505")]
        ForumUnknownTagCreationError = 505,

        /// <summary>
        /// ForumUnknownSqlResultDuringTagItem = 506
        /// </summary>
        [EnumMember(Value = "506")]
        ForumUnknownSqlResultDuringTagItem = 506,

        /// <summary>
        /// ForumUnknownExceptionCreatePost = 507
        /// </summary>
        [EnumMember(Value = "507")]
        ForumUnknownExceptionCreatePost = 507,

        /// <summary>
        /// ForumQuestionMustBeTopicPost = 508
        /// </summary>
        [EnumMember(Value = "508")]
        ForumQuestionMustBeTopicPost = 508,

        /// <summary>
        /// ForumExceptionDuringTagSearch = 509
        /// </summary>
        [EnumMember(Value = "509")]
        ForumExceptionDuringTagSearch = 509,

        /// <summary>
        /// ForumExceptionDuringTopicRetrieval = 510
        /// </summary>
        [EnumMember(Value = "510")]
        ForumExceptionDuringTopicRetrieval = 510,

        /// <summary>
        /// ForumAliasedTagError = 511
        /// </summary>
        [EnumMember(Value = "511")]
        ForumAliasedTagError = 511,

        /// <summary>
        /// ForumCannotLocateThread = 512
        /// </summary>
        [EnumMember(Value = "512")]
        ForumCannotLocateThread = 512,

        /// <summary>
        /// ForumUnknownExceptionEditPost = 513
        /// </summary>
        [EnumMember(Value = "513")]
        ForumUnknownExceptionEditPost = 513,

        /// <summary>
        /// ForumCannotLocatePost = 514
        /// </summary>
        [EnumMember(Value = "514")]
        ForumCannotLocatePost = 514,

        /// <summary>
        /// ForumUnknownExceptionGetOrCreateTags = 515
        /// </summary>
        [EnumMember(Value = "515")]
        ForumUnknownExceptionGetOrCreateTags = 515,

        /// <summary>
        /// ForumEditPermissionDenied = 516
        /// </summary>
        [EnumMember(Value = "516")]
        ForumEditPermissionDenied = 516,

        /// <summary>
        /// ForumUnknownSqlResultDuringTagIdRetrieval = 517
        /// </summary>
        [EnumMember(Value = "517")]
        ForumUnknownSqlResultDuringTagIdRetrieval = 517,

        /// <summary>
        /// ForumCannotGetRating = 518
        /// </summary>
        [EnumMember(Value = "518")]
        ForumCannotGetRating = 518,

        /// <summary>
        /// ForumUnknownExceptionGetRating = 519
        /// </summary>
        [EnumMember(Value = "519")]
        ForumUnknownExceptionGetRating = 519,

        /// <summary>
        /// ForumRatingsAccessError = 520
        /// </summary>
        [EnumMember(Value = "520")]
        ForumRatingsAccessError = 520,

        /// <summary>
        /// ForumRelatedPostAccessError = 521
        /// </summary>
        [EnumMember(Value = "521")]
        ForumRelatedPostAccessError = 521,

        /// <summary>
        /// ForumLatestReplyAccessError = 522
        /// </summary>
        [EnumMember(Value = "522")]
        ForumLatestReplyAccessError = 522,

        /// <summary>
        /// ForumUserStatusAccessError = 523
        /// </summary>
        [EnumMember(Value = "523")]
        ForumUserStatusAccessError = 523,

        /// <summary>
        /// ForumAuthorAccessError = 524
        /// </summary>
        [EnumMember(Value = "524")]
        ForumAuthorAccessError = 524,

        /// <summary>
        /// ForumGroupAccessError = 525
        /// </summary>
        [EnumMember(Value = "525")]
        ForumGroupAccessError = 525,

        /// <summary>
        /// ForumUrlExpectedButMissing = 526
        /// </summary>
        [EnumMember(Value = "526")]
        ForumUrlExpectedButMissing = 526,

        /// <summary>
        /// ForumRepliesCannotBeEmpty = 527
        /// </summary>
        [EnumMember(Value = "527")]
        ForumRepliesCannotBeEmpty = 527,

        /// <summary>
        /// ForumRepliesCannotBeInDifferentGroups = 528
        /// </summary>
        [EnumMember(Value = "528")]
        ForumRepliesCannotBeInDifferentGroups = 528,

        /// <summary>
        /// ForumSubTopicCannotBeCreatedAtThisThreadLevel = 529
        /// </summary>
        [EnumMember(Value = "529")]
        ForumSubTopicCannotBeCreatedAtThisThreadLevel = 529,

        /// <summary>
        /// ForumCannotCreateContentTopic = 530
        /// </summary>
        [EnumMember(Value = "530")]
        ForumCannotCreateContentTopic = 530,

        /// <summary>
        /// ForumTopicDoesNotExist = 531
        /// </summary>
        [EnumMember(Value = "531")]
        ForumTopicDoesNotExist = 531,

        /// <summary>
        /// ForumContentCommentsNotAllowed = 532
        /// </summary>
        [EnumMember(Value = "532")]
        ForumContentCommentsNotAllowed = 532,

        /// <summary>
        /// ForumUnknownSqlResultDuringEditPost = 533
        /// </summary>
        [EnumMember(Value = "533")]
        ForumUnknownSqlResultDuringEditPost = 533,

        /// <summary>
        /// ForumUnknownSqlResultDuringGetPost = 534
        /// </summary>
        [EnumMember(Value = "534")]
        ForumUnknownSqlResultDuringGetPost = 534,

        /// <summary>
        /// ForumPostValidationBadUrl = 535
        /// </summary>
        [EnumMember(Value = "535")]
        ForumPostValidationBadUrl = 535,

        /// <summary>
        /// ForumBodyTooLong = 536
        /// </summary>
        [EnumMember(Value = "536")]
        ForumBodyTooLong = 536,

        /// <summary>
        /// ForumSubjectTooLong = 537
        /// </summary>
        [EnumMember(Value = "537")]
        ForumSubjectTooLong = 537,

        /// <summary>
        /// ForumAnnouncementNotAllowed = 538
        /// </summary>
        [EnumMember(Value = "538")]
        ForumAnnouncementNotAllowed = 538,

        /// <summary>
        /// ForumCannotShareOwnPost = 539
        /// </summary>
        [EnumMember(Value = "539")]
        ForumCannotShareOwnPost = 539,

        /// <summary>
        /// ForumEditNoOp = 540
        /// </summary>
        [EnumMember(Value = "540")]
        ForumEditNoOp = 540,

        /// <summary>
        /// ForumUnknownDatabaseErrorDuringGetPost = 541
        /// </summary>
        [EnumMember(Value = "541")]
        ForumUnknownDatabaseErrorDuringGetPost = 541,

        /// <summary>
        /// ForumExceeedMaximumRowLimit = 542
        /// </summary>
        [EnumMember(Value = "542")]
        ForumExceeedMaximumRowLimit = 542,

        /// <summary>
        /// ForumCannotSharePrivatePost = 543
        /// </summary>
        [EnumMember(Value = "543")]
        ForumCannotSharePrivatePost = 543,

        /// <summary>
        /// ForumCannotCrossPostBetweenGroups = 544
        /// </summary>
        [EnumMember(Value = "544")]
        ForumCannotCrossPostBetweenGroups = 544,

        /// <summary>
        /// ForumIncompatibleCategories = 555
        /// </summary>
        [EnumMember(Value = "555")]
        ForumIncompatibleCategories = 555,

        /// <summary>
        /// ForumCannotUseTheseCategoriesOnNonTopicPost = 556
        /// </summary>
        [EnumMember(Value = "556")]
        ForumCannotUseTheseCategoriesOnNonTopicPost = 556,

        /// <summary>
        /// ForumCanOnlyDeleteTopics = 557
        /// </summary>
        [EnumMember(Value = "557")]
        ForumCanOnlyDeleteTopics = 557,

        /// <summary>
        /// ForumDeleteSqlException = 558
        /// </summary>
        [EnumMember(Value = "558")]
        ForumDeleteSqlException = 558,

        /// <summary>
        /// ForumDeleteSqlUnknownResult = 559
        /// </summary>
        [EnumMember(Value = "559")]
        ForumDeleteSqlUnknownResult = 559,

        /// <summary>
        /// ForumTooManyTags = 560
        /// </summary>
        [EnumMember(Value = "560")]
        ForumTooManyTags = 560,

        /// <summary>
        /// ForumCanOnlyRateTopics = 561
        /// </summary>
        [EnumMember(Value = "561")]
        ForumCanOnlyRateTopics = 561,

        /// <summary>
        /// ForumBannedPostsCannotBeEdited = 562
        /// </summary>
        [EnumMember(Value = "562")]
        ForumBannedPostsCannotBeEdited = 562,

        /// <summary>
        /// ForumThreadRootIsBanned = 563
        /// </summary>
        [EnumMember(Value = "563")]
        ForumThreadRootIsBanned = 563,

        /// <summary>
        /// ForumCannotUseOfficialTagCategoryAsTag = 564
        /// </summary>
        [EnumMember(Value = "564")]
        ForumCannotUseOfficialTagCategoryAsTag = 564,

        /// <summary>
        /// ForumAnswerCannotBeMadeOnCreatePost = 565
        /// </summary>
        [EnumMember(Value = "565")]
        ForumAnswerCannotBeMadeOnCreatePost = 565,

        /// <summary>
        /// ForumAnswerCannotBeMadeOnEditPost = 566
        /// </summary>
        [EnumMember(Value = "566")]
        ForumAnswerCannotBeMadeOnEditPost = 566,

        /// <summary>
        /// ForumAnswerPostIdIsNotADirectReplyOfQuestion = 567
        /// </summary>
        [EnumMember(Value = "567")]
        ForumAnswerPostIdIsNotADirectReplyOfQuestion = 567,

        /// <summary>
        /// ForumAnswerTopicIdIsNotAQuestion = 568
        /// </summary>
        [EnumMember(Value = "568")]
        ForumAnswerTopicIdIsNotAQuestion = 568,

        /// <summary>
        /// ForumUnknownExceptionDuringMarkAnswer = 569
        /// </summary>
        [EnumMember(Value = "569")]
        ForumUnknownExceptionDuringMarkAnswer = 569,

        /// <summary>
        /// ForumUnknownSqlResultDuringMarkAnswer = 570
        /// </summary>
        [EnumMember(Value = "570")]
        ForumUnknownSqlResultDuringMarkAnswer = 570,

        /// <summary>
        /// ForumCannotRateYourOwnPosts = 571
        /// </summary>
        [EnumMember(Value = "571")]
        ForumCannotRateYourOwnPosts = 571,

        /// <summary>
        /// ForumPollsMustBeTheFirstPostInTopic = 572
        /// </summary>
        [EnumMember(Value = "572")]
        ForumPollsMustBeTheFirstPostInTopic = 572,

        /// <summary>
        /// ForumInvalidPollInput = 573
        /// </summary>
        [EnumMember(Value = "573")]
        ForumInvalidPollInput = 573,

        /// <summary>
        /// ForumGroupAdminEditNonMember = 574
        /// </summary>
        [EnumMember(Value = "574")]
        ForumGroupAdminEditNonMember = 574,

        /// <summary>
        /// ForumCannotEditModeratorEditedPost = 575
        /// </summary>
        [EnumMember(Value = "575")]
        ForumCannotEditModeratorEditedPost = 575,

        /// <summary>
        /// ForumRequiresDestinyMembership = 576
        /// </summary>
        [EnumMember(Value = "576")]
        ForumRequiresDestinyMembership = 576,

        /// <summary>
        /// ForumUnexpectedError = 577
        /// </summary>
        [EnumMember(Value = "577")]
        ForumUnexpectedError = 577,

        /// <summary>
        /// ForumAgeLock = 578
        /// </summary>
        [EnumMember(Value = "578")]
        ForumAgeLock = 578,

        /// <summary>
        /// ForumMaxPages = 579
        /// </summary>
        [EnumMember(Value = "579")]
        ForumMaxPages = 579,

        /// <summary>
        /// ForumMaxPagesOldestFirst = 580
        /// </summary>
        [EnumMember(Value = "580")]
        ForumMaxPagesOldestFirst = 580,

        /// <summary>
        /// ForumCannotApplyForumIdWithoutTags = 581
        /// </summary>
        [EnumMember(Value = "581")]
        ForumCannotApplyForumIdWithoutTags = 581,

        /// <summary>
        /// ForumCannotApplyForumIdToNonTopics = 582
        /// </summary>
        [EnumMember(Value = "582")]
        ForumCannotApplyForumIdToNonTopics = 582,

        /// <summary>
        /// ForumCannotDownvoteCommunityCreations = 583
        /// </summary>
        [EnumMember(Value = "583")]
        ForumCannotDownvoteCommunityCreations = 583,

        /// <summary>
        /// ForumTopicsMustHaveOfficialCategory = 584
        /// </summary>
        [EnumMember(Value = "584")]
        ForumTopicsMustHaveOfficialCategory = 584,

        /// <summary>
        /// ForumRecruitmentTopicMalformed = 585
        /// </summary>
        [EnumMember(Value = "585")]
        ForumRecruitmentTopicMalformed = 585,

        /// <summary>
        /// ForumRecruitmentTopicNotFound = 586
        /// </summary>
        [EnumMember(Value = "586")]
        ForumRecruitmentTopicNotFound = 586,

        /// <summary>
        /// ForumRecruitmentTopicNoSlotsRemaining = 587
        /// </summary>
        [EnumMember(Value = "587")]
        ForumRecruitmentTopicNoSlotsRemaining = 587,

        /// <summary>
        /// ForumRecruitmentTopicKickBan = 588
        /// </summary>
        [EnumMember(Value = "588")]
        ForumRecruitmentTopicKickBan = 588,

        /// <summary>
        /// ForumRecruitmentTopicRequirementsNotMet = 589
        /// </summary>
        [EnumMember(Value = "589")]
        ForumRecruitmentTopicRequirementsNotMet = 589,

        /// <summary>
        /// ForumRecruitmentTopicNoPlayers = 590
        /// </summary>
        [EnumMember(Value = "590")]
        ForumRecruitmentTopicNoPlayers = 590,

        /// <summary>
        /// ForumRecruitmentApproveFailMessageBan = 591
        /// </summary>
        [EnumMember(Value = "591")]
        ForumRecruitmentApproveFailMessageBan = 591,

        /// <summary>
        /// ForumRecruitmentGlobalBan = 592
        /// </summary>
        [EnumMember(Value = "592")]
        ForumRecruitmentGlobalBan = 592,

        /// <summary>
        /// ForumUserBannedFromThisTopic = 593
        /// </summary>
        [EnumMember(Value = "593")]
        ForumUserBannedFromThisTopic = 593,

        /// <summary>
        /// ForumRecruitmentFireteamMembersOnly = 594
        /// </summary>
        [EnumMember(Value = "594")]
        ForumRecruitmentFireteamMembersOnly = 594,

        /// <summary>
        /// ForumRequiresDestiny2Progress = 595
        /// </summary>
        [EnumMember(Value = "595")]
        ForumRequiresDestiny2Progress = 595,

        /// <summary>
        /// GroupMembershipApplicationAlreadyResolved = 601
        /// </summary>
        [EnumMember(Value = "601")]
        GroupMembershipApplicationAlreadyResolved = 601,

        /// <summary>
        /// GroupMembershipAlreadyApplied = 602
        /// </summary>
        [EnumMember(Value = "602")]
        GroupMembershipAlreadyApplied = 602,

        /// <summary>
        /// GroupMembershipInsufficientPrivileges = 603
        /// </summary>
        [EnumMember(Value = "603")]
        GroupMembershipInsufficientPrivileges = 603,

        /// <summary>
        /// GroupIdNotReturnedFromCreation = 604
        /// </summary>
        [EnumMember(Value = "604")]
        GroupIdNotReturnedFromCreation = 604,

        /// <summary>
        /// GroupSearchInvalidParameters = 605
        /// </summary>
        [EnumMember(Value = "605")]
        GroupSearchInvalidParameters = 605,

        /// <summary>
        /// GroupMembershipPendingApplicationNotFound = 606
        /// </summary>
        [EnumMember(Value = "606")]
        GroupMembershipPendingApplicationNotFound = 606,

        /// <summary>
        /// GroupInvalidId = 607
        /// </summary>
        [EnumMember(Value = "607")]
        GroupInvalidId = 607,

        /// <summary>
        /// GroupInvalidMembershipId = 608
        /// </summary>
        [EnumMember(Value = "608")]
        GroupInvalidMembershipId = 608,

        /// <summary>
        /// GroupInvalidMembershipType = 609
        /// </summary>
        [EnumMember(Value = "609")]
        GroupInvalidMembershipType = 609,

        /// <summary>
        /// GroupMissingTags = 610
        /// </summary>
        [EnumMember(Value = "610")]
        GroupMissingTags = 610,

        /// <summary>
        /// GroupMembershipNotFound = 611
        /// </summary>
        [EnumMember(Value = "611")]
        GroupMembershipNotFound = 611,

        /// <summary>
        /// GroupInvalidRating = 612
        /// </summary>
        [EnumMember(Value = "612")]
        GroupInvalidRating = 612,

        /// <summary>
        /// GroupUserFollowingAccessError = 613
        /// </summary>
        [EnumMember(Value = "613")]
        GroupUserFollowingAccessError = 613,

        /// <summary>
        /// GroupUserMembershipAccessError = 614
        /// </summary>
        [EnumMember(Value = "614")]
        GroupUserMembershipAccessError = 614,

        /// <summary>
        /// GroupCreatorAccessError = 615
        /// </summary>
        [EnumMember(Value = "615")]
        GroupCreatorAccessError = 615,

        /// <summary>
        /// GroupAdminAccessError = 616
        /// </summary>
        [EnumMember(Value = "616")]
        GroupAdminAccessError = 616,

        /// <summary>
        /// GroupPrivatePostNotViewable = 617
        /// </summary>
        [EnumMember(Value = "617")]
        GroupPrivatePostNotViewable = 617,

        /// <summary>
        /// GroupMembershipNotLoggedIn = 618
        /// </summary>
        [EnumMember(Value = "618")]
        GroupMembershipNotLoggedIn = 618,

        /// <summary>
        /// GroupNotDeleted = 619
        /// </summary>
        [EnumMember(Value = "619")]
        GroupNotDeleted = 619,

        /// <summary>
        /// GroupUnknownErrorUndeletingGroup = 620
        /// </summary>
        [EnumMember(Value = "620")]
        GroupUnknownErrorUndeletingGroup = 620,

        /// <summary>
        /// GroupDeleted = 621
        /// </summary>
        [EnumMember(Value = "621")]
        GroupDeleted = 621,

        /// <summary>
        /// GroupNotFound = 622
        /// </summary>
        [EnumMember(Value = "622")]
        GroupNotFound = 622,

        /// <summary>
        /// GroupMemberBanned = 623
        /// </summary>
        [EnumMember(Value = "623")]
        GroupMemberBanned = 623,

        /// <summary>
        /// GroupMembershipClosed = 624
        /// </summary>
        [EnumMember(Value = "624")]
        GroupMembershipClosed = 624,

        /// <summary>
        /// GroupPrivatePostOverrideError = 625
        /// </summary>
        [EnumMember(Value = "625")]
        GroupPrivatePostOverrideError = 625,

        /// <summary>
        /// GroupNameTaken = 626
        /// </summary>
        [EnumMember(Value = "626")]
        GroupNameTaken = 626,

        /// <summary>
        /// GroupDeletionGracePeriodExpired = 627
        /// </summary>
        [EnumMember(Value = "627")]
        GroupDeletionGracePeriodExpired = 627,

        /// <summary>
        /// GroupCannotCheckBanStatus = 628
        /// </summary>
        [EnumMember(Value = "628")]
        GroupCannotCheckBanStatus = 628,

        /// <summary>
        /// GroupMaximumMembershipCountReached = 629
        /// </summary>
        [EnumMember(Value = "629")]
        GroupMaximumMembershipCountReached = 629,

        /// <summary>
        /// NoDestinyAccountForClanPlatform = 630
        /// </summary>
        [EnumMember(Value = "630")]
        NoDestinyAccountForClanPlatform = 630,

        /// <summary>
        /// AlreadyRequestingMembershipForClanPlatform = 631
        /// </summary>
        [EnumMember(Value = "631")]
        AlreadyRequestingMembershipForClanPlatform = 631,

        /// <summary>
        /// AlreadyClanMemberOnPlatform = 632
        /// </summary>
        [EnumMember(Value = "632")]
        AlreadyClanMemberOnPlatform = 632,

        /// <summary>
        /// GroupJoinedCannotSetClanName = 633
        /// </summary>
        [EnumMember(Value = "633")]
        GroupJoinedCannotSetClanName = 633,

        /// <summary>
        /// GroupLeftCannotClearClanName = 634
        /// </summary>
        [EnumMember(Value = "634")]
        GroupLeftCannotClearClanName = 634,

        /// <summary>
        /// GroupRelationshipRequestPending = 635
        /// </summary>
        [EnumMember(Value = "635")]
        GroupRelationshipRequestPending = 635,

        /// <summary>
        /// GroupRelationshipRequestBlocked = 636
        /// </summary>
        [EnumMember(Value = "636")]
        GroupRelationshipRequestBlocked = 636,

        /// <summary>
        /// GroupRelationshipRequestNotFound = 637
        /// </summary>
        [EnumMember(Value = "637")]
        GroupRelationshipRequestNotFound = 637,

        /// <summary>
        /// GroupRelationshipBlockNotFound = 638
        /// </summary>
        [EnumMember(Value = "638")]
        GroupRelationshipBlockNotFound = 638,

        /// <summary>
        /// GroupRelationshipNotFound = 639
        /// </summary>
        [EnumMember(Value = "639")]
        GroupRelationshipNotFound = 639,

        /// <summary>
        /// GroupAlreadyAllied = 641
        /// </summary>
        [EnumMember(Value = "641")]
        GroupAlreadyAllied = 641,

        /// <summary>
        /// GroupAlreadyMember = 642
        /// </summary>
        [EnumMember(Value = "642")]
        GroupAlreadyMember = 642,

        /// <summary>
        /// GroupRelationshipAlreadyExists = 643
        /// </summary>
        [EnumMember(Value = "643")]
        GroupRelationshipAlreadyExists = 643,

        /// <summary>
        /// InvalidGroupTypesForRelationshipRequest = 644
        /// </summary>
        [EnumMember(Value = "644")]
        InvalidGroupTypesForRelationshipRequest = 644,

        /// <summary>
        /// GroupAtMaximumAlliances = 646
        /// </summary>
        [EnumMember(Value = "646")]
        GroupAtMaximumAlliances = 646,

        /// <summary>
        /// GroupCannotSetClanOnlySettings = 647
        /// </summary>
        [EnumMember(Value = "647")]
        GroupCannotSetClanOnlySettings = 647,

        /// <summary>
        /// ClanCannotSetTwoDefaultPostTypes = 648
        /// </summary>
        [EnumMember(Value = "648")]
        ClanCannotSetTwoDefaultPostTypes = 648,

        /// <summary>
        /// GroupMemberInvalidMemberType = 649
        /// </summary>
        [EnumMember(Value = "649")]
        GroupMemberInvalidMemberType = 649,

        /// <summary>
        /// GroupInvalidPlatformType = 650
        /// </summary>
        [EnumMember(Value = "650")]
        GroupInvalidPlatformType = 650,

        /// <summary>
        /// GroupMemberInvalidSort = 651
        /// </summary>
        [EnumMember(Value = "651")]
        GroupMemberInvalidSort = 651,

        /// <summary>
        /// GroupInvalidResolveState = 652
        /// </summary>
        [EnumMember(Value = "652")]
        GroupInvalidResolveState = 652,

        /// <summary>
        /// ClanAlreadyEnabledForPlatform = 653
        /// </summary>
        [EnumMember(Value = "653")]
        ClanAlreadyEnabledForPlatform = 653,

        /// <summary>
        /// ClanNotEnabledForPlatform = 654
        /// </summary>
        [EnumMember(Value = "654")]
        ClanNotEnabledForPlatform = 654,

        /// <summary>
        /// ClanEnabledButCouldNotJoinNoAccount = 655
        /// </summary>
        [EnumMember(Value = "655")]
        ClanEnabledButCouldNotJoinNoAccount = 655,

        /// <summary>
        /// ClanEnabledButCouldNotJoinAlreadyMember = 656
        /// </summary>
        [EnumMember(Value = "656")]
        ClanEnabledButCouldNotJoinAlreadyMember = 656,

        /// <summary>
        /// ClanCannotJoinNoCredential = 657
        /// </summary>
        [EnumMember(Value = "657")]
        ClanCannotJoinNoCredential = 657,

        /// <summary>
        /// NoClanMembershipForPlatform = 658
        /// </summary>
        [EnumMember(Value = "658")]
        NoClanMembershipForPlatform = 658,

        /// <summary>
        /// GroupToGroupFollowLimitReached = 659
        /// </summary>
        [EnumMember(Value = "659")]
        GroupToGroupFollowLimitReached = 659,

        /// <summary>
        /// ChildGroupAlreadyInAlliance = 660
        /// </summary>
        [EnumMember(Value = "660")]
        ChildGroupAlreadyInAlliance = 660,

        /// <summary>
        /// OwnerGroupAlreadyInAlliance = 661
        /// </summary>
        [EnumMember(Value = "661")]
        OwnerGroupAlreadyInAlliance = 661,

        /// <summary>
        /// AllianceOwnerCannotJoinAlliance = 662
        /// </summary>
        [EnumMember(Value = "662")]
        AllianceOwnerCannotJoinAlliance = 662,

        /// <summary>
        /// GroupNotInAlliance = 663
        /// </summary>
        [EnumMember(Value = "663")]
        GroupNotInAlliance = 663,

        /// <summary>
        /// ChildGroupCannotInviteToAlliance = 664
        /// </summary>
        [EnumMember(Value = "664")]
        ChildGroupCannotInviteToAlliance = 664,

        /// <summary>
        /// GroupToGroupAlreadyFollowed = 665
        /// </summary>
        [EnumMember(Value = "665")]
        GroupToGroupAlreadyFollowed = 665,

        /// <summary>
        /// GroupToGroupNotFollowing = 666
        /// </summary>
        [EnumMember(Value = "666")]
        GroupToGroupNotFollowing = 666,

        /// <summary>
        /// ClanMaximumMembershipReached = 667
        /// </summary>
        [EnumMember(Value = "667")]
        ClanMaximumMembershipReached = 667,

        /// <summary>
        /// ClanNameNotValid = 668
        /// </summary>
        [EnumMember(Value = "668")]
        ClanNameNotValid = 668,

        /// <summary>
        /// ClanNameNotValidError = 669
        /// </summary>
        [EnumMember(Value = "669")]
        ClanNameNotValidError = 669,

        /// <summary>
        /// AllianceOwnerNotDefined = 670
        /// </summary>
        [EnumMember(Value = "670")]
        AllianceOwnerNotDefined = 670,

        /// <summary>
        /// AllianceChildNotDefined = 671
        /// </summary>
        [EnumMember(Value = "671")]
        AllianceChildNotDefined = 671,

        /// <summary>
        /// ClanCultureIllegalCharacters = 672
        /// </summary>
        [EnumMember(Value = "672")]
        ClanCultureIllegalCharacters = 672,

        /// <summary>
        /// ClanTagIllegalCharacters = 673
        /// </summary>
        [EnumMember(Value = "673")]
        ClanTagIllegalCharacters = 673,

        /// <summary>
        /// ClanRequiresInvitation = 674
        /// </summary>
        [EnumMember(Value = "674")]
        ClanRequiresInvitation = 674,

        /// <summary>
        /// ClanMembershipClosed = 675
        /// </summary>
        [EnumMember(Value = "675")]
        ClanMembershipClosed = 675,

        /// <summary>
        /// ClanInviteAlreadyMember = 676
        /// </summary>
        [EnumMember(Value = "676")]
        ClanInviteAlreadyMember = 676,

        /// <summary>
        /// GroupInviteAlreadyMember = 677
        /// </summary>
        [EnumMember(Value = "677")]
        GroupInviteAlreadyMember = 677,

        /// <summary>
        /// GroupJoinApprovalRequired = 678
        /// </summary>
        [EnumMember(Value = "678")]
        GroupJoinApprovalRequired = 678,

        /// <summary>
        /// ClanTagRequired = 679
        /// </summary>
        [EnumMember(Value = "679")]
        ClanTagRequired = 679,

        /// <summary>
        /// GroupNameCannotStartOrEndWithWhiteSpace = 680
        /// </summary>
        [EnumMember(Value = "680")]
        GroupNameCannotStartOrEndWithWhiteSpace = 680,

        /// <summary>
        /// ClanCallsignCannotStartOrEndWithWhiteSpace = 681
        /// </summary>
        [EnumMember(Value = "681")]
        ClanCallsignCannotStartOrEndWithWhiteSpace = 681,

        /// <summary>
        /// ClanMigrationFailed = 682
        /// </summary>
        [EnumMember(Value = "682")]
        ClanMigrationFailed = 682,

        /// <summary>
        /// ClanNotEnabledAlreadyMemberOfAnotherClan = 683
        /// </summary>
        [EnumMember(Value = "683")]
        ClanNotEnabledAlreadyMemberOfAnotherClan = 683,

        /// <summary>
        /// GroupModerationNotPermittedOnNonMembers = 684
        /// </summary>
        [EnumMember(Value = "684")]
        GroupModerationNotPermittedOnNonMembers = 684,

        /// <summary>
        /// ClanCreationInWorldServerFailed = 685
        /// </summary>
        [EnumMember(Value = "685")]
        ClanCreationInWorldServerFailed = 685,

        /// <summary>
        /// ClanNotFound = 686
        /// </summary>
        [EnumMember(Value = "686")]
        ClanNotFound = 686,

        /// <summary>
        /// ClanMembershipLevelDoesNotPermitThatAction = 687
        /// </summary>
        [EnumMember(Value = "687")]
        ClanMembershipLevelDoesNotPermitThatAction = 687,

        /// <summary>
        /// ClanMemberNotFound = 688
        /// </summary>
        [EnumMember(Value = "688")]
        ClanMemberNotFound = 688,

        /// <summary>
        /// ClanMissingMembershipApprovers = 689
        /// </summary>
        [EnumMember(Value = "689")]
        ClanMissingMembershipApprovers = 689,

        /// <summary>
        /// ClanInWrongStateForRequestedAction = 690
        /// </summary>
        [EnumMember(Value = "690")]
        ClanInWrongStateForRequestedAction = 690,

        /// <summary>
        /// ClanNameAlreadyUsed = 691
        /// </summary>
        [EnumMember(Value = "691")]
        ClanNameAlreadyUsed = 691,

        /// <summary>
        /// ClanTooFewMembers = 692
        /// </summary>
        [EnumMember(Value = "692")]
        ClanTooFewMembers = 692,

        /// <summary>
        /// ClanInfoCannotBeWhitespace = 693
        /// </summary>
        [EnumMember(Value = "693")]
        ClanInfoCannotBeWhitespace = 693,

        /// <summary>
        /// GroupCultureThrottle = 694
        /// </summary>
        [EnumMember(Value = "694")]
        GroupCultureThrottle = 694,

        /// <summary>
        /// ClanTargetDisallowsInvites = 695
        /// </summary>
        [EnumMember(Value = "695")]
        ClanTargetDisallowsInvites = 695,

        /// <summary>
        /// ClanInvalidOperation = 696
        /// </summary>
        [EnumMember(Value = "696")]
        ClanInvalidOperation = 696,

        /// <summary>
        /// ClanFounderCannotLeaveWithoutAbdication = 697
        /// </summary>
        [EnumMember(Value = "697")]
        ClanFounderCannotLeaveWithoutAbdication = 697,

        /// <summary>
        /// ClanNameReserved = 698
        /// </summary>
        [EnumMember(Value = "698")]
        ClanNameReserved = 698,

        /// <summary>
        /// ClanApplicantInClanSoNowInvited = 699
        /// </summary>
        [EnumMember(Value = "699")]
        ClanApplicantInClanSoNowInvited = 699,

        /// <summary>
        /// ActivitiesUnknownException = 701
        /// </summary>
        [EnumMember(Value = "701")]
        ActivitiesUnknownException = 701,

        /// <summary>
        /// ActivitiesParameterNull = 702
        /// </summary>
        [EnumMember(Value = "702")]
        ActivitiesParameterNull = 702,

        /// <summary>
        /// ActivityCountsDiabled = 703
        /// </summary>
        [EnumMember(Value = "703")]
        ActivityCountsDiabled = 703,

        /// <summary>
        /// ActivitySearchInvalidParameters = 704
        /// </summary>
        [EnumMember(Value = "704")]
        ActivitySearchInvalidParameters = 704,

        /// <summary>
        /// ActivityPermissionDenied = 705
        /// </summary>
        [EnumMember(Value = "705")]
        ActivityPermissionDenied = 705,

        /// <summary>
        /// ShareAlreadyShared = 706
        /// </summary>
        [EnumMember(Value = "706")]
        ShareAlreadyShared = 706,

        /// <summary>
        /// ActivityLoggingDisabled = 707
        /// </summary>
        [EnumMember(Value = "707")]
        ActivityLoggingDisabled = 707,

        /// <summary>
        /// ClanRequiresExistingDestinyAccount = 750
        /// </summary>
        [EnumMember(Value = "750")]
        ClanRequiresExistingDestinyAccount = 750,

        /// <summary>
        /// ClanNameRestricted = 751
        /// </summary>
        [EnumMember(Value = "751")]
        ClanNameRestricted = 751,

        /// <summary>
        /// ItemAlreadyFollowed = 801
        /// </summary>
        [EnumMember(Value = "801")]
        ItemAlreadyFollowed = 801,

        /// <summary>
        /// ItemNotFollowed = 802
        /// </summary>
        [EnumMember(Value = "802")]
        ItemNotFollowed = 802,

        /// <summary>
        /// CannotFollowSelf = 803
        /// </summary>
        [EnumMember(Value = "803")]
        CannotFollowSelf = 803,

        /// <summary>
        /// GroupFollowLimitExceeded = 804
        /// </summary>
        [EnumMember(Value = "804")]
        GroupFollowLimitExceeded = 804,

        /// <summary>
        /// TagFollowLimitExceeded = 805
        /// </summary>
        [EnumMember(Value = "805")]
        TagFollowLimitExceeded = 805,

        /// <summary>
        /// UserFollowLimitExceeded = 806
        /// </summary>
        [EnumMember(Value = "806")]
        UserFollowLimitExceeded = 806,

        /// <summary>
        /// FollowUnsupportedEntityType = 807
        /// </summary>
        [EnumMember(Value = "807")]
        FollowUnsupportedEntityType = 807,

        /// <summary>
        /// NoValidTagsInList = 900
        /// </summary>
        [EnumMember(Value = "900")]
        NoValidTagsInList = 900,

        /// <summary>
        /// BelowMinimumSuggestionLength = 901
        /// </summary>
        [EnumMember(Value = "901")]
        BelowMinimumSuggestionLength = 901,

        /// <summary>
        /// CannotGetSuggestionsOnMultipleTagsSimultaneously = 902
        /// </summary>
        [EnumMember(Value = "902")]
        CannotGetSuggestionsOnMultipleTagsSimultaneously = 902,

        /// <summary>
        /// NotAValidPartialTag = 903
        /// </summary>
        [EnumMember(Value = "903")]
        NotAValidPartialTag = 903,

        /// <summary>
        /// TagSuggestionsUnknownSqlResult = 904
        /// </summary>
        [EnumMember(Value = "904")]
        TagSuggestionsUnknownSqlResult = 904,

        /// <summary>
        /// TagsUnableToLoadPopularTagsFromDatabase = 905
        /// </summary>
        [EnumMember(Value = "905")]
        TagsUnableToLoadPopularTagsFromDatabase = 905,

        /// <summary>
        /// TagInvalid = 906
        /// </summary>
        [EnumMember(Value = "906")]
        TagInvalid = 906,

        /// <summary>
        /// TagNotFound = 907
        /// </summary>
        [EnumMember(Value = "907")]
        TagNotFound = 907,

        /// <summary>
        /// SingleTagExpected = 908
        /// </summary>
        [EnumMember(Value = "908")]
        SingleTagExpected = 908,

        /// <summary>
        /// TagsExceededMaximumPerItem = 909
        /// </summary>
        [EnumMember(Value = "909")]
        TagsExceededMaximumPerItem = 909,

        /// <summary>
        /// IgnoreInvalidParameters = 1000
        /// </summary>
        [EnumMember(Value = "1000")]
        IgnoreInvalidParameters = 1000,

        /// <summary>
        /// IgnoreSqlException = 1001
        /// </summary>
        [EnumMember(Value = "1001")]
        IgnoreSqlException = 1001,

        /// <summary>
        /// IgnoreErrorRetrievingGroupPermissions = 1002
        /// </summary>
        [EnumMember(Value = "1002")]
        IgnoreErrorRetrievingGroupPermissions = 1002,

        /// <summary>
        /// IgnoreErrorInsufficientPermission = 1003
        /// </summary>
        [EnumMember(Value = "1003")]
        IgnoreErrorInsufficientPermission = 1003,

        /// <summary>
        /// IgnoreErrorRetrievingItem = 1004
        /// </summary>
        [EnumMember(Value = "1004")]
        IgnoreErrorRetrievingItem = 1004,

        /// <summary>
        /// IgnoreCannotIgnoreSelf = 1005
        /// </summary>
        [EnumMember(Value = "1005")]
        IgnoreCannotIgnoreSelf = 1005,

        /// <summary>
        /// IgnoreIllegalType = 1006
        /// </summary>
        [EnumMember(Value = "1006")]
        IgnoreIllegalType = 1006,

        /// <summary>
        /// IgnoreNotFound = 1007
        /// </summary>
        [EnumMember(Value = "1007")]
        IgnoreNotFound = 1007,

        /// <summary>
        /// IgnoreUserGloballyIgnored = 1008
        /// </summary>
        [EnumMember(Value = "1008")]
        IgnoreUserGloballyIgnored = 1008,

        /// <summary>
        /// IgnoreUserIgnored = 1009
        /// </summary>
        [EnumMember(Value = "1009")]
        IgnoreUserIgnored = 1009,

        /// <summary>
        /// NotificationSettingInvalid = 1100
        /// </summary>
        [EnumMember(Value = "1100")]
        NotificationSettingInvalid = 1100,

        /// <summary>
        /// PsnApiExpiredAccessToken = 1204
        /// </summary>
        [EnumMember(Value = "1204")]
        PsnApiExpiredAccessToken = 1204,

        /// <summary>
        /// PSNExForbidden = 1205
        /// </summary>
        [EnumMember(Value = "1205")]
        PSNExForbidden = 1205,

        /// <summary>
        /// PSNExSystemDisabled = 1218
        /// </summary>
        [EnumMember(Value = "1218")]
        PSNExSystemDisabled = 1218,

        /// <summary>
        /// PsnApiErrorCodeUnknown = 1223
        /// </summary>
        [EnumMember(Value = "1223")]
        PsnApiErrorCodeUnknown = 1223,

        /// <summary>
        /// PsnApiErrorWebException = 1224
        /// </summary>
        [EnumMember(Value = "1224")]
        PsnApiErrorWebException = 1224,

        /// <summary>
        /// PsnApiBadRequest = 1225
        /// </summary>
        [EnumMember(Value = "1225")]
        PsnApiBadRequest = 1225,

        /// <summary>
        /// PsnApiAccessTokenRequired = 1226
        /// </summary>
        [EnumMember(Value = "1226")]
        PsnApiAccessTokenRequired = 1226,

        /// <summary>
        /// PsnApiInvalidAccessToken = 1227
        /// </summary>
        [EnumMember(Value = "1227")]
        PsnApiInvalidAccessToken = 1227,

        /// <summary>
        /// PsnApiBannedUser = 1229
        /// </summary>
        [EnumMember(Value = "1229")]
        PsnApiBannedUser = 1229,

        /// <summary>
        /// PsnApiAccountUpgradeRequired = 1230
        /// </summary>
        [EnumMember(Value = "1230")]
        PsnApiAccountUpgradeRequired = 1230,

        /// <summary>
        /// PsnApiServiceTemporarilyUnavailable = 1231
        /// </summary>
        [EnumMember(Value = "1231")]
        PsnApiServiceTemporarilyUnavailable = 1231,

        /// <summary>
        /// PsnApiServerBusy = 1232
        /// </summary>
        [EnumMember(Value = "1232")]
        PsnApiServerBusy = 1232,

        /// <summary>
        /// PsnApiUnderMaintenance = 1233
        /// </summary>
        [EnumMember(Value = "1233")]
        PsnApiUnderMaintenance = 1233,

        /// <summary>
        /// PsnApiProfileUserNotFound = 1234
        /// </summary>
        [EnumMember(Value = "1234")]
        PsnApiProfileUserNotFound = 1234,

        /// <summary>
        /// PsnApiProfilePrivacyRestriction = 1235
        /// </summary>
        [EnumMember(Value = "1235")]
        PsnApiProfilePrivacyRestriction = 1235,

        /// <summary>
        /// PsnApiProfileUnderMaintenance = 1236
        /// </summary>
        [EnumMember(Value = "1236")]
        PsnApiProfileUnderMaintenance = 1236,

        /// <summary>
        /// PsnApiAccountAttributeMissing = 1237
        /// </summary>
        [EnumMember(Value = "1237")]
        PsnApiAccountAttributeMissing = 1237,

        /// <summary>
        /// PsnApiNoPermission = 1238
        /// </summary>
        [EnumMember(Value = "1238")]
        PsnApiNoPermission = 1238,

        /// <summary>
        /// PsnApiTargetUserBlocked = 1239
        /// </summary>
        [EnumMember(Value = "1239")]
        PsnApiTargetUserBlocked = 1239,

        /// <summary>
        /// XblExSystemDisabled = 1300
        /// </summary>
        [EnumMember(Value = "1300")]
        XblExSystemDisabled = 1300,

        /// <summary>
        /// XblExUnknownError = 1301
        /// </summary>
        [EnumMember(Value = "1301")]
        XblExUnknownError = 1301,

        /// <summary>
        /// XblApiErrorWebException = 1302
        /// </summary>
        [EnumMember(Value = "1302")]
        XblApiErrorWebException = 1302,

        /// <summary>
        /// XblStsTokenInvalid = 1303
        /// </summary>
        [EnumMember(Value = "1303")]
        XblStsTokenInvalid = 1303,

        /// <summary>
        /// XblStsMissingToken = 1304
        /// </summary>
        [EnumMember(Value = "1304")]
        XblStsMissingToken = 1304,

        /// <summary>
        /// XblStsExpiredToken = 1305
        /// </summary>
        [EnumMember(Value = "1305")]
        XblStsExpiredToken = 1305,

        /// <summary>
        /// XblAccessToTheSandboxDenied = 1306
        /// </summary>
        [EnumMember(Value = "1306")]
        XblAccessToTheSandboxDenied = 1306,

        /// <summary>
        /// XblMsaResponseMissing = 1307
        /// </summary>
        [EnumMember(Value = "1307")]
        XblMsaResponseMissing = 1307,

        /// <summary>
        /// XblMsaAccessTokenExpired = 1308
        /// </summary>
        [EnumMember(Value = "1308")]
        XblMsaAccessTokenExpired = 1308,

        /// <summary>
        /// XblMsaInvalidRequest = 1309
        /// </summary>
        [EnumMember(Value = "1309")]
        XblMsaInvalidRequest = 1309,

        /// <summary>
        /// XblMsaFriendsRequireSignIn = 1310
        /// </summary>
        [EnumMember(Value = "1310")]
        XblMsaFriendsRequireSignIn = 1310,

        /// <summary>
        /// XblUserActionRequired = 1311
        /// </summary>
        [EnumMember(Value = "1311")]
        XblUserActionRequired = 1311,

        /// <summary>
        /// XblParentalControls = 1312
        /// </summary>
        [EnumMember(Value = "1312")]
        XblParentalControls = 1312,

        /// <summary>
        /// XblDeveloperAccount = 1313
        /// </summary>
        [EnumMember(Value = "1313")]
        XblDeveloperAccount = 1313,

        /// <summary>
        /// XblUserTokenExpired = 1314
        /// </summary>
        [EnumMember(Value = "1314")]
        XblUserTokenExpired = 1314,

        /// <summary>
        /// XblUserTokenInvalid = 1315
        /// </summary>
        [EnumMember(Value = "1315")]
        XblUserTokenInvalid = 1315,

        /// <summary>
        /// XblOffline = 1316
        /// </summary>
        [EnumMember(Value = "1316")]
        XblOffline = 1316,

        /// <summary>
        /// XblUnknownErrorCode = 1317
        /// </summary>
        [EnumMember(Value = "1317")]
        XblUnknownErrorCode = 1317,

        /// <summary>
        /// XblMsaInvalidGrant = 1318
        /// </summary>
        [EnumMember(Value = "1318")]
        XblMsaInvalidGrant = 1318,

        /// <summary>
        /// ReportNotYetResolved = 1400
        /// </summary>
        [EnumMember(Value = "1400")]
        ReportNotYetResolved = 1400,

        /// <summary>
        /// ReportOverturnDoesNotChangeDecision = 1401
        /// </summary>
        [EnumMember(Value = "1401")]
        ReportOverturnDoesNotChangeDecision = 1401,

        /// <summary>
        /// ReportNotFound = 1402
        /// </summary>
        [EnumMember(Value = "1402")]
        ReportNotFound = 1402,

        /// <summary>
        /// ReportAlreadyReported = 1403
        /// </summary>
        [EnumMember(Value = "1403")]
        ReportAlreadyReported = 1403,

        /// <summary>
        /// ReportInvalidResolution = 1404
        /// </summary>
        [EnumMember(Value = "1404")]
        ReportInvalidResolution = 1404,

        /// <summary>
        /// ReportNotAssignedToYou = 1405
        /// </summary>
        [EnumMember(Value = "1405")]
        ReportNotAssignedToYou = 1405,

        /// <summary>
        /// LegacyGameStatsSystemDisabled = 1500
        /// </summary>
        [EnumMember(Value = "1500")]
        LegacyGameStatsSystemDisabled = 1500,

        /// <summary>
        /// LegacyGameStatsUnknownError = 1501
        /// </summary>
        [EnumMember(Value = "1501")]
        LegacyGameStatsUnknownError = 1501,

        /// <summary>
        /// LegacyGameStatsMalformedSneakerNetCode = 1502
        /// </summary>
        [EnumMember(Value = "1502")]
        LegacyGameStatsMalformedSneakerNetCode = 1502,

        /// <summary>
        /// DestinyAccountAcquisitionFailure = 1600
        /// </summary>
        [EnumMember(Value = "1600")]
        DestinyAccountAcquisitionFailure = 1600,

        /// <summary>
        /// DestinyAccountNotFound = 1601
        /// </summary>
        [EnumMember(Value = "1601")]
        DestinyAccountNotFound = 1601,

        /// <summary>
        /// DestinyBuildStatsDatabaseError = 1602
        /// </summary>
        [EnumMember(Value = "1602")]
        DestinyBuildStatsDatabaseError = 1602,

        /// <summary>
        /// DestinyCharacterStatsDatabaseError = 1603
        /// </summary>
        [EnumMember(Value = "1603")]
        DestinyCharacterStatsDatabaseError = 1603,

        /// <summary>
        /// DestinyPvPStatsDatabaseError = 1604
        /// </summary>
        [EnumMember(Value = "1604")]
        DestinyPvPStatsDatabaseError = 1604,

        /// <summary>
        /// DestinyPvEStatsDatabaseError = 1605
        /// </summary>
        [EnumMember(Value = "1605")]
        DestinyPvEStatsDatabaseError = 1605,

        /// <summary>
        /// DestinyGrimoireStatsDatabaseError = 1606
        /// </summary>
        [EnumMember(Value = "1606")]
        DestinyGrimoireStatsDatabaseError = 1606,

        /// <summary>
        /// DestinyStatsParameterMembershipTypeParseError = 1607
        /// </summary>
        [EnumMember(Value = "1607")]
        DestinyStatsParameterMembershipTypeParseError = 1607,

        /// <summary>
        /// DestinyStatsParameterMembershipIdParseError = 1608
        /// </summary>
        [EnumMember(Value = "1608")]
        DestinyStatsParameterMembershipIdParseError = 1608,

        /// <summary>
        /// DestinyStatsParameterRangeParseError = 1609
        /// </summary>
        [EnumMember(Value = "1609")]
        DestinyStatsParameterRangeParseError = 1609,

        /// <summary>
        /// DestinyStringItemHashNotFound = 1610
        /// </summary>
        [EnumMember(Value = "1610")]
        DestinyStringItemHashNotFound = 1610,

        /// <summary>
        /// DestinyStringSetNotFound = 1611
        /// </summary>
        [EnumMember(Value = "1611")]
        DestinyStringSetNotFound = 1611,

        /// <summary>
        /// DestinyContentLookupNotFoundForKey = 1612
        /// </summary>
        [EnumMember(Value = "1612")]
        DestinyContentLookupNotFoundForKey = 1612,

        /// <summary>
        /// DestinyContentItemNotFound = 1613
        /// </summary>
        [EnumMember(Value = "1613")]
        DestinyContentItemNotFound = 1613,

        /// <summary>
        /// DestinyContentSectionNotFound = 1614
        /// </summary>
        [EnumMember(Value = "1614")]
        DestinyContentSectionNotFound = 1614,

        /// <summary>
        /// DestinyContentPropertyNotFound = 1615
        /// </summary>
        [EnumMember(Value = "1615")]
        DestinyContentPropertyNotFound = 1615,

        /// <summary>
        /// DestinyContentConfigNotFound = 1616
        /// </summary>
        [EnumMember(Value = "1616")]
        DestinyContentConfigNotFound = 1616,

        /// <summary>
        /// DestinyContentPropertyBucketValueNotFound = 1617
        /// </summary>
        [EnumMember(Value = "1617")]
        DestinyContentPropertyBucketValueNotFound = 1617,

        /// <summary>
        /// DestinyUnexpectedError = 1618
        /// </summary>
        [EnumMember(Value = "1618")]
        DestinyUnexpectedError = 1618,

        /// <summary>
        /// DestinyInvalidAction = 1619
        /// </summary>
        [EnumMember(Value = "1619")]
        DestinyInvalidAction = 1619,

        /// <summary>
        /// DestinyCharacterNotFound = 1620
        /// </summary>
        [EnumMember(Value = "1620")]
        DestinyCharacterNotFound = 1620,

        /// <summary>
        /// DestinyInvalidFlag = 1621
        /// </summary>
        [EnumMember(Value = "1621")]
        DestinyInvalidFlag = 1621,

        /// <summary>
        /// DestinyInvalidRequest = 1622
        /// </summary>
        [EnumMember(Value = "1622")]
        DestinyInvalidRequest = 1622,

        /// <summary>
        /// DestinyItemNotFound = 1623
        /// </summary>
        [EnumMember(Value = "1623")]
        DestinyItemNotFound = 1623,

        /// <summary>
        /// DestinyInvalidCustomizationChoices = 1624
        /// </summary>
        [EnumMember(Value = "1624")]
        DestinyInvalidCustomizationChoices = 1624,

        /// <summary>
        /// DestinyVendorItemNotFound = 1625
        /// </summary>
        [EnumMember(Value = "1625")]
        DestinyVendorItemNotFound = 1625,

        /// <summary>
        /// DestinyInternalError = 1626
        /// </summary>
        [EnumMember(Value = "1626")]
        DestinyInternalError = 1626,

        /// <summary>
        /// DestinyVendorNotFound = 1627
        /// </summary>
        [EnumMember(Value = "1627")]
        DestinyVendorNotFound = 1627,

        /// <summary>
        /// DestinyRecentActivitiesDatabaseError = 1628
        /// </summary>
        [EnumMember(Value = "1628")]
        DestinyRecentActivitiesDatabaseError = 1628,

        /// <summary>
        /// DestinyItemBucketNotFound = 1629
        /// </summary>
        [EnumMember(Value = "1629")]
        DestinyItemBucketNotFound = 1629,

        /// <summary>
        /// DestinyInvalidMembershipType = 1630
        /// </summary>
        [EnumMember(Value = "1630")]
        DestinyInvalidMembershipType = 1630,

        /// <summary>
        /// DestinyVersionIncompatibility = 1631
        /// </summary>
        [EnumMember(Value = "1631")]
        DestinyVersionIncompatibility = 1631,

        /// <summary>
        /// DestinyItemAlreadyInInventory = 1632
        /// </summary>
        [EnumMember(Value = "1632")]
        DestinyItemAlreadyInInventory = 1632,

        /// <summary>
        /// DestinyBucketNotFound = 1633
        /// </summary>
        [EnumMember(Value = "1633")]
        DestinyBucketNotFound = 1633,

        /// <summary>
        /// DestinyCharacterNotInTower = 1634
        /// Note: This is one of those holdovers from Destiny 1. We didn&#39;t change the enum because I am lazy, but in Destiny 2 this would read &quot;DestinyCharacterNotInSocialSpace&quot;
        /// </summary>
        [EnumMember(Value = "1634")]
        DestinyCharacterNotInTower = 1634,

        /// <summary>
        /// DestinyCharacterNotLoggedIn = 1635
        /// </summary>
        [EnumMember(Value = "1635")]
        DestinyCharacterNotLoggedIn = 1635,

        /// <summary>
        /// DestinyDefinitionsNotLoaded = 1636
        /// </summary>
        [EnumMember(Value = "1636")]
        DestinyDefinitionsNotLoaded = 1636,

        /// <summary>
        /// DestinyInventoryFull = 1637
        /// </summary>
        [EnumMember(Value = "1637")]
        DestinyInventoryFull = 1637,

        /// <summary>
        /// DestinyItemFailedLevelCheck = 1638
        /// </summary>
        [EnumMember(Value = "1638")]
        DestinyItemFailedLevelCheck = 1638,

        /// <summary>
        /// DestinyItemFailedUnlockCheck = 1639
        /// </summary>
        [EnumMember(Value = "1639")]
        DestinyItemFailedUnlockCheck = 1639,

        /// <summary>
        /// DestinyItemUnequippable = 1640
        /// </summary>
        [EnumMember(Value = "1640")]
        DestinyItemUnequippable = 1640,

        /// <summary>
        /// DestinyItemUniqueEquipRestricted = 1641
        /// </summary>
        [EnumMember(Value = "1641")]
        DestinyItemUniqueEquipRestricted = 1641,

        /// <summary>
        /// DestinyNoRoomInDestination = 1642
        /// </summary>
        [EnumMember(Value = "1642")]
        DestinyNoRoomInDestination = 1642,

        /// <summary>
        /// DestinyServiceFailure = 1643
        /// </summary>
        [EnumMember(Value = "1643")]
        DestinyServiceFailure = 1643,

        /// <summary>
        /// DestinyServiceRetired = 1644
        /// </summary>
        [EnumMember(Value = "1644")]
        DestinyServiceRetired = 1644,

        /// <summary>
        /// DestinyTransferFailed = 1645
        /// </summary>
        [EnumMember(Value = "1645")]
        DestinyTransferFailed = 1645,

        /// <summary>
        /// DestinyTransferNotFoundForSourceBucket = 1646
        /// </summary>
        [EnumMember(Value = "1646")]
        DestinyTransferNotFoundForSourceBucket = 1646,

        /// <summary>
        /// DestinyUnexpectedResultInVendorTransferCheck = 1647
        /// </summary>
        [EnumMember(Value = "1647")]
        DestinyUnexpectedResultInVendorTransferCheck = 1647,

        /// <summary>
        /// DestinyUniquenessViolation = 1648
        /// </summary>
        [EnumMember(Value = "1648")]
        DestinyUniquenessViolation = 1648,

        /// <summary>
        /// DestinyErrorDeserializationFailure = 1649
        /// </summary>
        [EnumMember(Value = "1649")]
        DestinyErrorDeserializationFailure = 1649,

        /// <summary>
        /// DestinyValidAccountTicketRequired = 1650
        /// </summary>
        [EnumMember(Value = "1650")]
        DestinyValidAccountTicketRequired = 1650,

        /// <summary>
        /// DestinyShardRelayClientTimeout = 1651
        /// </summary>
        [EnumMember(Value = "1651")]
        DestinyShardRelayClientTimeout = 1651,

        /// <summary>
        /// DestinyShardRelayProxyTimeout = 1652
        /// </summary>
        [EnumMember(Value = "1652")]
        DestinyShardRelayProxyTimeout = 1652,

        /// <summary>
        /// DestinyPGCRNotFound = 1653
        /// </summary>
        [EnumMember(Value = "1653")]
        DestinyPGCRNotFound = 1653,

        /// <summary>
        /// DestinyAccountMustBeOffline = 1654
        /// </summary>
        [EnumMember(Value = "1654")]
        DestinyAccountMustBeOffline = 1654,

        /// <summary>
        /// DestinyCanOnlyEquipInGame = 1655
        /// </summary>
        [EnumMember(Value = "1655")]
        DestinyCanOnlyEquipInGame = 1655,

        /// <summary>
        /// DestinyCannotPerformActionOnEquippedItem = 1656
        /// </summary>
        [EnumMember(Value = "1656")]
        DestinyCannotPerformActionOnEquippedItem = 1656,

        /// <summary>
        /// DestinyQuestAlreadyCompleted = 1657
        /// </summary>
        [EnumMember(Value = "1657")]
        DestinyQuestAlreadyCompleted = 1657,

        /// <summary>
        /// DestinyQuestAlreadyTracked = 1658
        /// </summary>
        [EnumMember(Value = "1658")]
        DestinyQuestAlreadyTracked = 1658,

        /// <summary>
        /// DestinyTrackableQuestsFull = 1659
        /// </summary>
        [EnumMember(Value = "1659")]
        DestinyTrackableQuestsFull = 1659,

        /// <summary>
        /// DestinyItemNotTransferrable = 1660
        /// </summary>
        [EnumMember(Value = "1660")]
        DestinyItemNotTransferrable = 1660,

        /// <summary>
        /// DestinyVendorPurchaseNotAllowed = 1661
        /// </summary>
        [EnumMember(Value = "1661")]
        DestinyVendorPurchaseNotAllowed = 1661,

        /// <summary>
        /// DestinyContentVersionMismatch = 1662
        /// </summary>
        [EnumMember(Value = "1662")]
        DestinyContentVersionMismatch = 1662,

        /// <summary>
        /// DestinyItemActionForbidden = 1663
        /// </summary>
        [EnumMember(Value = "1663")]
        DestinyItemActionForbidden = 1663,

        /// <summary>
        /// DestinyRefundInvalid = 1664
        /// </summary>
        [EnumMember(Value = "1664")]
        DestinyRefundInvalid = 1664,

        /// <summary>
        /// DestinyPrivacyRestriction = 1665
        /// </summary>
        [EnumMember(Value = "1665")]
        DestinyPrivacyRestriction = 1665,

        /// <summary>
        /// DestinyActionInsufficientPrivileges = 1666
        /// </summary>
        [EnumMember(Value = "1666")]
        DestinyActionInsufficientPrivileges = 1666,

        /// <summary>
        /// DestinyInvalidClaimException = 1667
        /// </summary>
        [EnumMember(Value = "1667")]
        DestinyInvalidClaimException = 1667,

        /// <summary>
        /// DestinyLegacyPlatformRestricted = 1668
        /// </summary>
        [EnumMember(Value = "1668")]
        DestinyLegacyPlatformRestricted = 1668,

        /// <summary>
        /// DestinyLegacyPlatformInUse = 1669
        /// </summary>
        [EnumMember(Value = "1669")]
        DestinyLegacyPlatformInUse = 1669,

        /// <summary>
        /// DestinyLegacyPlatformInaccessible = 1670
        /// </summary>
        [EnumMember(Value = "1670")]
        DestinyLegacyPlatformInaccessible = 1670,

        /// <summary>
        /// DestinyCannotPerformActionAtThisLocation = 1671
        /// </summary>
        [EnumMember(Value = "1671")]
        DestinyCannotPerformActionAtThisLocation = 1671,

        /// <summary>
        /// DestinyThrottledByGameServer = 1672
        /// </summary>
        [EnumMember(Value = "1672")]
        DestinyThrottledByGameServer = 1672,

        /// <summary>
        /// DestinyItemNotTransferrableHasSideEffects = 1673
        /// </summary>
        [EnumMember(Value = "1673")]
        DestinyItemNotTransferrableHasSideEffects = 1673,

        /// <summary>
        /// DestinyItemLocked = 1674
        /// </summary>
        [EnumMember(Value = "1674")]
        DestinyItemLocked = 1674,

        /// <summary>
        /// DestinyCannotAffordMaterialRequirements = 1675
        /// </summary>
        [EnumMember(Value = "1675")]
        DestinyCannotAffordMaterialRequirements = 1675,

        /// <summary>
        /// DestinyFailedPlugInsertionRules = 1676
        /// </summary>
        [EnumMember(Value = "1676")]
        DestinyFailedPlugInsertionRules = 1676,

        /// <summary>
        /// DestinySocketNotFound = 1677
        /// </summary>
        [EnumMember(Value = "1677")]
        DestinySocketNotFound = 1677,

        /// <summary>
        /// DestinySocketActionNotAllowed = 1678
        /// </summary>
        [EnumMember(Value = "1678")]
        DestinySocketActionNotAllowed = 1678,

        /// <summary>
        /// DestinySocketAlreadyHasPlug = 1679
        /// </summary>
        [EnumMember(Value = "1679")]
        DestinySocketAlreadyHasPlug = 1679,

        /// <summary>
        /// DestinyPlugItemNotAvailable = 1680
        /// </summary>
        [EnumMember(Value = "1680")]
        DestinyPlugItemNotAvailable = 1680,

        /// <summary>
        /// DestinyCharacterLoggedInNotAllowed = 1681
        /// </summary>
        [EnumMember(Value = "1681")]
        DestinyCharacterLoggedInNotAllowed = 1681,

        /// <summary>
        /// DestinyPublicAccountNotAccessible = 1682
        /// </summary>
        [EnumMember(Value = "1682")]
        DestinyPublicAccountNotAccessible = 1682,

        /// <summary>
        /// DestinyClaimsItemAlreadyClaimed = 1683
        /// </summary>
        [EnumMember(Value = "1683")]
        DestinyClaimsItemAlreadyClaimed = 1683,

        /// <summary>
        /// DestinyClaimsNoInventorySpace = 1684
        /// </summary>
        [EnumMember(Value = "1684")]
        DestinyClaimsNoInventorySpace = 1684,

        /// <summary>
        /// DestinyClaimsRequiredLevelNotMet = 1685
        /// </summary>
        [EnumMember(Value = "1685")]
        DestinyClaimsRequiredLevelNotMet = 1685,

        /// <summary>
        /// DestinyClaimsInvalidState = 1686
        /// </summary>
        [EnumMember(Value = "1686")]
        DestinyClaimsInvalidState = 1686,

        /// <summary>
        /// DestinyNotEnoughRoomForMultipleRewards = 1687
        /// </summary>
        [EnumMember(Value = "1687")]
        DestinyNotEnoughRoomForMultipleRewards = 1687,

        /// <summary>
        /// DestinyDirectBabelClientTimeout = 1688
        /// </summary>
        [EnumMember(Value = "1688")]
        DestinyDirectBabelClientTimeout = 1688,

        /// <summary>
        /// FbInvalidRequest = 1800
        /// </summary>
        [EnumMember(Value = "1800")]
        FbInvalidRequest = 1800,

        /// <summary>
        /// FbRedirectMismatch = 1801
        /// </summary>
        [EnumMember(Value = "1801")]
        FbRedirectMismatch = 1801,

        /// <summary>
        /// FbAccessDenied = 1802
        /// </summary>
        [EnumMember(Value = "1802")]
        FbAccessDenied = 1802,

        /// <summary>
        /// FbUnsupportedResponseType = 1803
        /// </summary>
        [EnumMember(Value = "1803")]
        FbUnsupportedResponseType = 1803,

        /// <summary>
        /// FbInvalidScope = 1804
        /// </summary>
        [EnumMember(Value = "1804")]
        FbInvalidScope = 1804,

        /// <summary>
        /// FbUnsupportedGrantType = 1805
        /// </summary>
        [EnumMember(Value = "1805")]
        FbUnsupportedGrantType = 1805,

        /// <summary>
        /// FbInvalidGrant = 1806
        /// </summary>
        [EnumMember(Value = "1806")]
        FbInvalidGrant = 1806,

        /// <summary>
        /// InvitationExpired = 1900
        /// </summary>
        [EnumMember(Value = "1900")]
        InvitationExpired = 1900,

        /// <summary>
        /// InvitationUnknownType = 1901
        /// </summary>
        [EnumMember(Value = "1901")]
        InvitationUnknownType = 1901,

        /// <summary>
        /// InvitationInvalidResponseStatus = 1902
        /// </summary>
        [EnumMember(Value = "1902")]
        InvitationInvalidResponseStatus = 1902,

        /// <summary>
        /// InvitationInvalidType = 1903
        /// </summary>
        [EnumMember(Value = "1903")]
        InvitationInvalidType = 1903,

        /// <summary>
        /// InvitationAlreadyPending = 1904
        /// </summary>
        [EnumMember(Value = "1904")]
        InvitationAlreadyPending = 1904,

        /// <summary>
        /// InvitationInsufficientPermission = 1905
        /// </summary>
        [EnumMember(Value = "1905")]
        InvitationInsufficientPermission = 1905,

        /// <summary>
        /// InvitationInvalidCode = 1906
        /// </summary>
        [EnumMember(Value = "1906")]
        InvitationInvalidCode = 1906,

        /// <summary>
        /// InvitationInvalidTargetState = 1907
        /// </summary>
        [EnumMember(Value = "1907")]
        InvitationInvalidTargetState = 1907,

        /// <summary>
        /// InvitationCannotBeReactivated = 1908
        /// </summary>
        [EnumMember(Value = "1908")]
        InvitationCannotBeReactivated = 1908,

        /// <summary>
        /// InvitationNoRecipients = 1910
        /// </summary>
        [EnumMember(Value = "1910")]
        InvitationNoRecipients = 1910,

        /// <summary>
        /// InvitationGroupCannotSendToSelf = 1911
        /// </summary>
        [EnumMember(Value = "1911")]
        InvitationGroupCannotSendToSelf = 1911,

        /// <summary>
        /// InvitationTooManyRecipients = 1912
        /// </summary>
        [EnumMember(Value = "1912")]
        InvitationTooManyRecipients = 1912,

        /// <summary>
        /// InvitationInvalid = 1913
        /// </summary>
        [EnumMember(Value = "1913")]
        InvitationInvalid = 1913,

        /// <summary>
        /// InvitationNotFound = 1914
        /// </summary>
        [EnumMember(Value = "1914")]
        InvitationNotFound = 1914,

        /// <summary>
        /// TokenInvalid = 2000
        /// </summary>
        [EnumMember(Value = "2000")]
        TokenInvalid = 2000,

        /// <summary>
        /// TokenBadFormat = 2001
        /// </summary>
        [EnumMember(Value = "2001")]
        TokenBadFormat = 2001,

        /// <summary>
        /// TokenAlreadyClaimed = 2002
        /// </summary>
        [EnumMember(Value = "2002")]
        TokenAlreadyClaimed = 2002,

        /// <summary>
        /// TokenAlreadyClaimedSelf = 2003
        /// </summary>
        [EnumMember(Value = "2003")]
        TokenAlreadyClaimedSelf = 2003,

        /// <summary>
        /// TokenThrottling = 2004
        /// </summary>
        [EnumMember(Value = "2004")]
        TokenThrottling = 2004,

        /// <summary>
        /// TokenUnknownRedemptionFailure = 2005
        /// </summary>
        [EnumMember(Value = "2005")]
        TokenUnknownRedemptionFailure = 2005,

        /// <summary>
        /// TokenPurchaseClaimFailedAfterTokenClaimed = 2006
        /// </summary>
        [EnumMember(Value = "2006")]
        TokenPurchaseClaimFailedAfterTokenClaimed = 2006,

        /// <summary>
        /// TokenUserAlreadyOwnsOffer = 2007
        /// </summary>
        [EnumMember(Value = "2007")]
        TokenUserAlreadyOwnsOffer = 2007,

        /// <summary>
        /// TokenInvalidOfferKey = 2008
        /// </summary>
        [EnumMember(Value = "2008")]
        TokenInvalidOfferKey = 2008,

        /// <summary>
        /// TokenEmailNotValidated = 2009
        /// </summary>
        [EnumMember(Value = "2009")]
        TokenEmailNotValidated = 2009,

        /// <summary>
        /// TokenProvisioningBadVendorOrOffer = 2010
        /// </summary>
        [EnumMember(Value = "2010")]
        TokenProvisioningBadVendorOrOffer = 2010,

        /// <summary>
        /// TokenPurchaseHistoryUnknownError = 2011
        /// </summary>
        [EnumMember(Value = "2011")]
        TokenPurchaseHistoryUnknownError = 2011,

        /// <summary>
        /// TokenThrottleStateUnknownError = 2012
        /// </summary>
        [EnumMember(Value = "2012")]
        TokenThrottleStateUnknownError = 2012,

        /// <summary>
        /// TokenUserAgeNotVerified = 2013
        /// </summary>
        [EnumMember(Value = "2013")]
        TokenUserAgeNotVerified = 2013,

        /// <summary>
        /// TokenExceededOfferMaximum = 2014
        /// </summary>
        [EnumMember(Value = "2014")]
        TokenExceededOfferMaximum = 2014,

        /// <summary>
        /// TokenNoAvailableUnlocks = 2015
        /// </summary>
        [EnumMember(Value = "2015")]
        TokenNoAvailableUnlocks = 2015,

        /// <summary>
        /// TokenMarketplaceInvalidPlatform = 2016
        /// </summary>
        [EnumMember(Value = "2016")]
        TokenMarketplaceInvalidPlatform = 2016,

        /// <summary>
        /// TokenNoMarketplaceCodesFound = 2017
        /// </summary>
        [EnumMember(Value = "2017")]
        TokenNoMarketplaceCodesFound = 2017,

        /// <summary>
        /// TokenOfferNotAvailableForRedemption = 2018
        /// </summary>
        [EnumMember(Value = "2018")]
        TokenOfferNotAvailableForRedemption = 2018,

        /// <summary>
        /// TokenUnlockPartialFailure = 2019
        /// </summary>
        [EnumMember(Value = "2019")]
        TokenUnlockPartialFailure = 2019,

        /// <summary>
        /// TokenMarketplaceInvalidRegion = 2020
        /// </summary>
        [EnumMember(Value = "2020")]
        TokenMarketplaceInvalidRegion = 2020,

        /// <summary>
        /// TokenOfferExpired = 2021
        /// </summary>
        [EnumMember(Value = "2021")]
        TokenOfferExpired = 2021,

        /// <summary>
        /// RAFExceededMaximumReferrals = 2022
        /// </summary>
        [EnumMember(Value = "2022")]
        RAFExceededMaximumReferrals = 2022,

        /// <summary>
        /// RAFDuplicateBond = 2023
        /// </summary>
        [EnumMember(Value = "2023")]
        RAFDuplicateBond = 2023,

        /// <summary>
        /// RAFNoValidVeteranDestinyMembershipsFound = 2024
        /// </summary>
        [EnumMember(Value = "2024")]
        RAFNoValidVeteranDestinyMembershipsFound = 2024,

        /// <summary>
        /// RAFNotAValidVeteranUser = 2025
        /// </summary>
        [EnumMember(Value = "2025")]
        RAFNotAValidVeteranUser = 2025,

        /// <summary>
        /// RAFCodeAlreadyClaimedOrNotFound = 2026
        /// </summary>
        [EnumMember(Value = "2026")]
        RAFCodeAlreadyClaimedOrNotFound = 2026,

        /// <summary>
        /// RAFMismatchedDestinyMembershipType = 2027
        /// </summary>
        [EnumMember(Value = "2027")]
        RAFMismatchedDestinyMembershipType = 2027,

        /// <summary>
        /// RAFUnableToAccessPurchaseHistory = 2028
        /// </summary>
        [EnumMember(Value = "2028")]
        RAFUnableToAccessPurchaseHistory = 2028,

        /// <summary>
        /// RAFUnableToCreateBond = 2029
        /// </summary>
        [EnumMember(Value = "2029")]
        RAFUnableToCreateBond = 2029,

        /// <summary>
        /// RAFUnableToFindBond = 2030
        /// </summary>
        [EnumMember(Value = "2030")]
        RAFUnableToFindBond = 2030,

        /// <summary>
        /// RAFUnableToRemoveBond = 2031
        /// </summary>
        [EnumMember(Value = "2031")]
        RAFUnableToRemoveBond = 2031,

        /// <summary>
        /// RAFCannotBondToSelf = 2032
        /// </summary>
        [EnumMember(Value = "2032")]
        RAFCannotBondToSelf = 2032,

        /// <summary>
        /// RAFInvalidPlatform = 2033
        /// </summary>
        [EnumMember(Value = "2033")]
        RAFInvalidPlatform = 2033,

        /// <summary>
        /// RAFGenerateThrottled = 2034
        /// </summary>
        [EnumMember(Value = "2034")]
        RAFGenerateThrottled = 2034,

        /// <summary>
        /// RAFUnableToCreateBondVersionMismatch = 2035
        /// </summary>
        [EnumMember(Value = "2035")]
        RAFUnableToCreateBondVersionMismatch = 2035,

        /// <summary>
        /// RAFUnableToRemoveBondVersionMismatch = 2036
        /// </summary>
        [EnumMember(Value = "2036")]
        RAFUnableToRemoveBondVersionMismatch = 2036,

        /// <summary>
        /// RAFRedeemThrottled = 2037
        /// </summary>
        [EnumMember(Value = "2037")]
        RAFRedeemThrottled = 2037,

        /// <summary>
        /// NoAvailableDiscountCode = 2038
        /// </summary>
        [EnumMember(Value = "2038")]
        NoAvailableDiscountCode = 2038,

        /// <summary>
        /// DiscountAlreadyClaimed = 2039
        /// </summary>
        [EnumMember(Value = "2039")]
        DiscountAlreadyClaimed = 2039,

        /// <summary>
        /// DiscountClaimFailure = 2040
        /// </summary>
        [EnumMember(Value = "2040")]
        DiscountClaimFailure = 2040,

        /// <summary>
        /// DiscountConfigurationFailure = 2041
        /// </summary>
        [EnumMember(Value = "2041")]
        DiscountConfigurationFailure = 2041,

        /// <summary>
        /// DiscountGenerationFailure = 2042
        /// </summary>
        [EnumMember(Value = "2042")]
        DiscountGenerationFailure = 2042,

        /// <summary>
        /// DiscountAlreadyExists = 2043
        /// </summary>
        [EnumMember(Value = "2043")]
        DiscountAlreadyExists = 2043,

        /// <summary>
        /// TokenRequiresCredentialXuid = 2044
        /// </summary>
        [EnumMember(Value = "2044")]
        TokenRequiresCredentialXuid = 2044,

        /// <summary>
        /// TokenRequiresCredentialPsnid = 2045
        /// </summary>
        [EnumMember(Value = "2045")]
        TokenRequiresCredentialPsnid = 2045,

        /// <summary>
        /// OfferRequired = 2046
        /// </summary>
        [EnumMember(Value = "2046")]
        OfferRequired = 2046,

        /// <summary>
        /// UnknownEververseHistoryError = 2047
        /// </summary>
        [EnumMember(Value = "2047")]
        UnknownEververseHistoryError = 2047,

        /// <summary>
        /// MissingEververseHistoryError = 2048
        /// </summary>
        [EnumMember(Value = "2048")]
        MissingEververseHistoryError = 2048,

        /// <summary>
        /// BungieRewardEmailStateInvalid = 2049
        /// </summary>
        [EnumMember(Value = "2049")]
        BungieRewardEmailStateInvalid = 2049,

        /// <summary>
        /// BungieRewardNotYetClaimable = 2050
        /// </summary>
        [EnumMember(Value = "2050")]
        BungieRewardNotYetClaimable = 2050,

        /// <summary>
        /// MissingOfferConfig = 2051
        /// </summary>
        [EnumMember(Value = "2051")]
        MissingOfferConfig = 2051,

        /// <summary>
        /// RAFQuestEntitlementRequiresBnet = 2052
        /// </summary>
        [EnumMember(Value = "2052")]
        RAFQuestEntitlementRequiresBnet = 2052,

        /// <summary>
        /// RAFQuestEntitlementTransportFailure = 2053
        /// </summary>
        [EnumMember(Value = "2053")]
        RAFQuestEntitlementTransportFailure = 2053,

        /// <summary>
        /// RAFQuestEntitlementUnknownFailure = 2054
        /// </summary>
        [EnumMember(Value = "2054")]
        RAFQuestEntitlementUnknownFailure = 2054,

        /// <summary>
        /// RAFVeteranRewardUnknownFailure = 2055
        /// </summary>
        [EnumMember(Value = "2055")]
        RAFVeteranRewardUnknownFailure = 2055,

        /// <summary>
        /// RAFTooEarlyToCancelBond = 2056
        /// </summary>
        [EnumMember(Value = "2056")]
        RAFTooEarlyToCancelBond = 2056,

        /// <summary>
        /// LoyaltyRewardAlreadyRedeemed = 2057
        /// </summary>
        [EnumMember(Value = "2057")]
        LoyaltyRewardAlreadyRedeemed = 2057,

        /// <summary>
        /// UnclaimedLoyaltyRewardEntryNotFound = 2058
        /// </summary>
        [EnumMember(Value = "2058")]
        UnclaimedLoyaltyRewardEntryNotFound = 2058,

        /// <summary>
        /// PartnerOfferPartialFailure = 2059
        /// </summary>
        [EnumMember(Value = "2059")]
        PartnerOfferPartialFailure = 2059,

        /// <summary>
        /// PartnerOfferAlreadyClaimed = 2060
        /// </summary>
        [EnumMember(Value = "2060")]
        PartnerOfferAlreadyClaimed = 2060,

        /// <summary>
        /// PartnerOfferSkuNotFound = 2061
        /// </summary>
        [EnumMember(Value = "2061")]
        PartnerOfferSkuNotFound = 2061,

        /// <summary>
        /// PartnerOfferSkuExpired = 2062
        /// </summary>
        [EnumMember(Value = "2062")]
        PartnerOfferSkuExpired = 2062,

        /// <summary>
        /// PartnerOfferPermissionFailure = 2063
        /// </summary>
        [EnumMember(Value = "2063")]
        PartnerOfferPermissionFailure = 2063,

        /// <summary>
        /// PartnerOfferNoDestinyAccount = 2064
        /// </summary>
        [EnumMember(Value = "2064")]
        PartnerOfferNoDestinyAccount = 2064,

        /// <summary>
        /// PartnerOfferApplyDataNotFound = 2065
        /// </summary>
        [EnumMember(Value = "2065")]
        PartnerOfferApplyDataNotFound = 2065,

        /// <summary>
        /// ApiExceededMaxKeys = 2100
        /// </summary>
        [EnumMember(Value = "2100")]
        ApiExceededMaxKeys = 2100,

        /// <summary>
        /// ApiInvalidOrExpiredKey = 2101
        /// </summary>
        [EnumMember(Value = "2101")]
        ApiInvalidOrExpiredKey = 2101,

        /// <summary>
        /// ApiKeyMissingFromRequest = 2102
        /// </summary>
        [EnumMember(Value = "2102")]
        ApiKeyMissingFromRequest = 2102,

        /// <summary>
        /// ApplicationDisabled = 2103
        /// </summary>
        [EnumMember(Value = "2103")]
        ApplicationDisabled = 2103,

        /// <summary>
        /// ApplicationExceededMax = 2104
        /// </summary>
        [EnumMember(Value = "2104")]
        ApplicationExceededMax = 2104,

        /// <summary>
        /// ApplicationDisallowedByScope = 2105
        /// </summary>
        [EnumMember(Value = "2105")]
        ApplicationDisallowedByScope = 2105,

        /// <summary>
        /// AuthorizationCodeInvalid = 2106
        /// </summary>
        [EnumMember(Value = "2106")]
        AuthorizationCodeInvalid = 2106,

        /// <summary>
        /// OriginHeaderDoesNotMatchKey = 2107
        /// </summary>
        [EnumMember(Value = "2107")]
        OriginHeaderDoesNotMatchKey = 2107,

        /// <summary>
        /// AccessNotPermittedByApplicationScope = 2108
        /// </summary>
        [EnumMember(Value = "2108")]
        AccessNotPermittedByApplicationScope = 2108,

        /// <summary>
        /// ApplicationNameIsTaken = 2109
        /// </summary>
        [EnumMember(Value = "2109")]
        ApplicationNameIsTaken = 2109,

        /// <summary>
        /// RefreshTokenNotYetValid = 2110
        /// </summary>
        [EnumMember(Value = "2110")]
        RefreshTokenNotYetValid = 2110,

        /// <summary>
        /// AccessTokenHasExpired = 2111
        /// </summary>
        [EnumMember(Value = "2111")]
        AccessTokenHasExpired = 2111,

        /// <summary>
        /// ApplicationTokenFormatNotValid = 2112
        /// </summary>
        [EnumMember(Value = "2112")]
        ApplicationTokenFormatNotValid = 2112,

        /// <summary>
        /// ApplicationNotConfiguredForBungieAuth = 2113
        /// </summary>
        [EnumMember(Value = "2113")]
        ApplicationNotConfiguredForBungieAuth = 2113,

        /// <summary>
        /// ApplicationNotConfiguredForOAuth = 2114
        /// </summary>
        [EnumMember(Value = "2114")]
        ApplicationNotConfiguredForOAuth = 2114,

        /// <summary>
        /// OAuthAccessTokenExpired = 2115
        /// </summary>
        [EnumMember(Value = "2115")]
        OAuthAccessTokenExpired = 2115,

        /// <summary>
        /// ApplicationTokenKeyIdDoesNotExist = 2116
        /// </summary>
        [EnumMember(Value = "2116")]
        ApplicationTokenKeyIdDoesNotExist = 2116,

        /// <summary>
        /// ProvidedTokenNotValidRefreshToken = 2117
        /// </summary>
        [EnumMember(Value = "2117")]
        ProvidedTokenNotValidRefreshToken = 2117,

        /// <summary>
        /// RefreshTokenExpired = 2118
        /// </summary>
        [EnumMember(Value = "2118")]
        RefreshTokenExpired = 2118,

        /// <summary>
        /// AuthorizationRecordInvalid = 2119
        /// </summary>
        [EnumMember(Value = "2119")]
        AuthorizationRecordInvalid = 2119,

        /// <summary>
        /// TokenPreviouslyRevoked = 2120
        /// </summary>
        [EnumMember(Value = "2120")]
        TokenPreviouslyRevoked = 2120,

        /// <summary>
        /// TokenInvalidMembership = 2121
        /// </summary>
        [EnumMember(Value = "2121")]
        TokenInvalidMembership = 2121,

        /// <summary>
        /// AuthorizationCodeStale = 2122
        /// </summary>
        [EnumMember(Value = "2122")]
        AuthorizationCodeStale = 2122,

        /// <summary>
        /// AuthorizationRecordExpired = 2123
        /// </summary>
        [EnumMember(Value = "2123")]
        AuthorizationRecordExpired = 2123,

        /// <summary>
        /// AuthorizationRecordRevoked = 2124
        /// </summary>
        [EnumMember(Value = "2124")]
        AuthorizationRecordRevoked = 2124,

        /// <summary>
        /// AuthorizationRecordInactiveApiKey = 2125
        /// </summary>
        [EnumMember(Value = "2125")]
        AuthorizationRecordInactiveApiKey = 2125,

        /// <summary>
        /// AuthorizationRecordApiKeyMatching = 2126
        /// </summary>
        [EnumMember(Value = "2126")]
        AuthorizationRecordApiKeyMatching = 2126,

        /// <summary>
        /// PartnershipInvalidType = 2200
        /// </summary>
        [EnumMember(Value = "2200")]
        PartnershipInvalidType = 2200,

        /// <summary>
        /// PartnershipValidationError = 2201
        /// </summary>
        [EnumMember(Value = "2201")]
        PartnershipValidationError = 2201,

        /// <summary>
        /// PartnershipValidationTimeout = 2202
        /// </summary>
        [EnumMember(Value = "2202")]
        PartnershipValidationTimeout = 2202,

        /// <summary>
        /// PartnershipAccessFailure = 2203
        /// </summary>
        [EnumMember(Value = "2203")]
        PartnershipAccessFailure = 2203,

        /// <summary>
        /// PartnershipAccountInvalid = 2204
        /// </summary>
        [EnumMember(Value = "2204")]
        PartnershipAccountInvalid = 2204,

        /// <summary>
        /// PartnershipGetAccountInfoFailure = 2205
        /// </summary>
        [EnumMember(Value = "2205")]
        PartnershipGetAccountInfoFailure = 2205,

        /// <summary>
        /// PartnershipDisabled = 2206
        /// </summary>
        [EnumMember(Value = "2206")]
        PartnershipDisabled = 2206,

        /// <summary>
        /// PartnershipAlreadyExists = 2207
        /// </summary>
        [EnumMember(Value = "2207")]
        PartnershipAlreadyExists = 2207,

        /// <summary>
        /// CommunityStreamingUnavailable = 2300
        /// </summary>
        [EnumMember(Value = "2300")]
        CommunityStreamingUnavailable = 2300,

        /// <summary>
        /// TwitchNotLinked = 2500
        /// </summary>
        [EnumMember(Value = "2500")]
        TwitchNotLinked = 2500,

        /// <summary>
        /// TwitchAccountNotFound = 2501
        /// </summary>
        [EnumMember(Value = "2501")]
        TwitchAccountNotFound = 2501,

        /// <summary>
        /// TwitchCouldNotLoadDestinyInfo = 2502
        /// </summary>
        [EnumMember(Value = "2502")]
        TwitchCouldNotLoadDestinyInfo = 2502,

        /// <summary>
        /// TwitchCouldNotRegisterUser = 2503
        /// </summary>
        [EnumMember(Value = "2503")]
        TwitchCouldNotRegisterUser = 2503,

        /// <summary>
        /// TwitchCouldNotUnregisterUser = 2504
        /// </summary>
        [EnumMember(Value = "2504")]
        TwitchCouldNotUnregisterUser = 2504,

        /// <summary>
        /// TwitchRequiresRelinking = 2505
        /// </summary>
        [EnumMember(Value = "2505")]
        TwitchRequiresRelinking = 2505,

        /// <summary>
        /// TwitchNoPlatformChosen = 2506
        /// </summary>
        [EnumMember(Value = "2506")]
        TwitchNoPlatformChosen = 2506,

        /// <summary>
        /// TrendingCategoryNotFound = 2600
        /// </summary>
        [EnumMember(Value = "2600")]
        TrendingCategoryNotFound = 2600,

        /// <summary>
        /// TrendingEntryTypeNotSupported = 2601
        /// </summary>
        [EnumMember(Value = "2601")]
        TrendingEntryTypeNotSupported = 2601,

        /// <summary>
        /// ReportOffenderNotInPgcr = 2700
        /// </summary>
        [EnumMember(Value = "2700")]
        ReportOffenderNotInPgcr = 2700,

        /// <summary>
        /// ReportRequestorNotInPgcr = 2701
        /// </summary>
        [EnumMember(Value = "2701")]
        ReportRequestorNotInPgcr = 2701,

        /// <summary>
        /// ReportSubmissionFailed = 2702
        /// </summary>
        [EnumMember(Value = "2702")]
        ReportSubmissionFailed = 2702,

        /// <summary>
        /// ReportCannotReportSelf = 2703
        /// </summary>
        [EnumMember(Value = "2703")]
        ReportCannotReportSelf = 2703,

        /// <summary>
        /// AwaTypeDisabled = 2800
        /// </summary>
        [EnumMember(Value = "2800")]
        AwaTypeDisabled = 2800,

        /// <summary>
        /// AwaTooManyPendingRequests = 2801
        /// </summary>
        [EnumMember(Value = "2801")]
        AwaTooManyPendingRequests = 2801,

        /// <summary>
        /// AwaTheFeatureRequiresARegisteredDevice = 2802
        /// </summary>
        [EnumMember(Value = "2802")]
        AwaTheFeatureRequiresARegisteredDevice = 2802,

        /// <summary>
        /// AwaRequestWasUnansweredForTooLong = 2803
        /// </summary>
        [EnumMember(Value = "2803")]
        AwaRequestWasUnansweredForTooLong = 2803,

        /// <summary>
        /// AwaWriteRequestMissingOrInvalidToken = 2804
        /// </summary>
        [EnumMember(Value = "2804")]
        AwaWriteRequestMissingOrInvalidToken = 2804,

        /// <summary>
        /// AwaWriteRequestTokenExpired = 2805
        /// </summary>
        [EnumMember(Value = "2805")]
        AwaWriteRequestTokenExpired = 2805,

        /// <summary>
        /// AwaWriteRequestTokenUsageLimitReached = 2806
        /// </summary>
        [EnumMember(Value = "2806")]
        AwaWriteRequestTokenUsageLimitReached = 2806,

        /// <summary>
        /// SteamWebApiError = 2900
        /// </summary>
        [EnumMember(Value = "2900")]
        SteamWebApiError = 2900,

        /// <summary>
        /// SteamWebNullResponseError = 2901
        /// </summary>
        [EnumMember(Value = "2901")]
        SteamWebNullResponseError = 2901,

        /// <summary>
        /// ClanFireteamNotFound = 3000
        /// </summary>
        [EnumMember(Value = "3000")]
        ClanFireteamNotFound = 3000,

        /// <summary>
        /// ClanFireteamAddNoAlternatesForImmediate = 3001
        /// </summary>
        [EnumMember(Value = "3001")]
        ClanFireteamAddNoAlternatesForImmediate = 3001,

        /// <summary>
        /// ClanFireteamFull = 3002
        /// </summary>
        [EnumMember(Value = "3002")]
        ClanFireteamFull = 3002,

        /// <summary>
        /// ClanFireteamAltFull = 3003
        /// </summary>
        [EnumMember(Value = "3003")]
        ClanFireteamAltFull = 3003,

        /// <summary>
        /// ClanFireteamBlocked = 3004
        /// </summary>
        [EnumMember(Value = "3004")]
        ClanFireteamBlocked = 3004,

        /// <summary>
        /// ClanFireteamPlayerEntryNotFound = 3005
        /// </summary>
        [EnumMember(Value = "3005")]
        ClanFireteamPlayerEntryNotFound = 3005,

        /// <summary>
        /// ClanFireteamPermissions = 3006
        /// </summary>
        [EnumMember(Value = "3006")]
        ClanFireteamPermissions = 3006,

        /// <summary>
        /// ClanFireteamInvalidPlatform = 3007
        /// </summary>
        [EnumMember(Value = "3007")]
        ClanFireteamInvalidPlatform = 3007,

        /// <summary>
        /// ClanFireteamCannotAdjustSlotCount = 3008
        /// </summary>
        [EnumMember(Value = "3008")]
        ClanFireteamCannotAdjustSlotCount = 3008,

        /// <summary>
        /// ClanFireteamInvalidPlayerPlatform = 3009
        /// </summary>
        [EnumMember(Value = "3009")]
        ClanFireteamInvalidPlayerPlatform = 3009,

        /// <summary>
        /// ClanFireteamNotReadyForInvitesNotEnoughPlayers = 3010
        /// </summary>
        [EnumMember(Value = "3010")]
        ClanFireteamNotReadyForInvitesNotEnoughPlayers = 3010,

        /// <summary>
        /// ClanFireteamGameInvitesNotSupportForPlatform = 3011
        /// </summary>
        [EnumMember(Value = "3011")]
        ClanFireteamGameInvitesNotSupportForPlatform = 3011,

        /// <summary>
        /// ClanFireteamPlatformInvitePreqFailure = 3012
        /// </summary>
        [EnumMember(Value = "3012")]
        ClanFireteamPlatformInvitePreqFailure = 3012,

        /// <summary>
        /// ClanFireteamInvalidAuthContext = 3013
        /// </summary>
        [EnumMember(Value = "3013")]
        ClanFireteamInvalidAuthContext = 3013,

        /// <summary>
        /// ClanFireteamInvalidAuthProviderPsn = 3014
        /// </summary>
        [EnumMember(Value = "3014")]
        ClanFireteamInvalidAuthProviderPsn = 3014,

        /// <summary>
        /// ClanFireteamPs4SessionFull = 3015
        /// </summary>
        [EnumMember(Value = "3015")]
        ClanFireteamPs4SessionFull = 3015,

        /// <summary>
        /// ClanFireteamInvalidAuthToken = 3016
        /// </summary>
        [EnumMember(Value = "3016")]
        ClanFireteamInvalidAuthToken = 3016,

        /// <summary>
        /// ClanFireteamScheduledFireteamsDisabled = 3017
        /// </summary>
        [EnumMember(Value = "3017")]
        ClanFireteamScheduledFireteamsDisabled = 3017,

        /// <summary>
        /// ClanFireteamNotReadyForInvitesNotScheduledYet = 3018
        /// </summary>
        [EnumMember(Value = "3018")]
        ClanFireteamNotReadyForInvitesNotScheduledYet = 3018,

        /// <summary>
        /// ClanFireteamNotReadyForInvitesClosed = 3019
        /// </summary>
        [EnumMember(Value = "3019")]
        ClanFireteamNotReadyForInvitesClosed = 3019,

        /// <summary>
        /// ClanFireteamScheduledFireteamsRequireAdminPermissions = 3020
        /// </summary>
        [EnumMember(Value = "3020")]
        ClanFireteamScheduledFireteamsRequireAdminPermissions = 3020,

        /// <summary>
        /// ClanFireteamNonPublicMustHaveClan = 3021
        /// </summary>
        [EnumMember(Value = "3021")]
        ClanFireteamNonPublicMustHaveClan = 3021,

        /// <summary>
        /// ClanFireteamPublicCreationRestriction = 3022
        /// </summary>
        [EnumMember(Value = "3022")]
        ClanFireteamPublicCreationRestriction = 3022,

        /// <summary>
        /// ClanFireteamAlreadyJoined = 3023
        /// </summary>
        [EnumMember(Value = "3023")]
        ClanFireteamAlreadyJoined = 3023,

        /// <summary>
        /// ClanFireteamScheduledFireteamsRange = 3024
        /// </summary>
        [EnumMember(Value = "3024")]
        ClanFireteamScheduledFireteamsRange = 3024,

        /// <summary>
        /// ClanFireteamPublicCreationRestrictionExtended = 3025
        /// </summary>
        [EnumMember(Value = "3025")]
        ClanFireteamPublicCreationRestrictionExtended = 3025,

        /// <summary>
        /// ClanFireteamExpired = 3026
        /// </summary>
        [EnumMember(Value = "3026")]
        ClanFireteamExpired = 3026,

        /// <summary>
        /// ClanFireteamInvalidAuthProvider = 3027
        /// </summary>
        [EnumMember(Value = "3027")]
        ClanFireteamInvalidAuthProvider = 3027,

        /// <summary>
        /// ClanFireteamInvalidAuthProviderXuid = 3028
        /// </summary>
        [EnumMember(Value = "3028")]
        ClanFireteamInvalidAuthProviderXuid = 3028,

        /// <summary>
        /// CrossSaveOverriddenAccountNotFound = 3200
        /// </summary>
        [EnumMember(Value = "3200")]
        CrossSaveOverriddenAccountNotFound = 3200,

        /// <summary>
        /// CrossSaveTooManyOverriddenPlatforms = 3201
        /// </summary>
        [EnumMember(Value = "3201")]
        CrossSaveTooManyOverriddenPlatforms = 3201,

        /// <summary>
        /// CrossSaveNoOverriddenPlatforms = 3202
        /// </summary>
        [EnumMember(Value = "3202")]
        CrossSaveNoOverriddenPlatforms = 3202,

        /// <summary>
        /// CrossSavePrimaryAccountNotFound = 3203
        /// </summary>
        [EnumMember(Value = "3203")]
        CrossSavePrimaryAccountNotFound = 3203,

        /// <summary>
        /// CrossSaveRequestInvalid = 3204
        /// </summary>
        [EnumMember(Value = "3204")]
        CrossSaveRequestInvalid = 3204,

        /// <summary>
        /// CrossSaveBungieAccountValidationFailure = 3206
        /// </summary>
        [EnumMember(Value = "3206")]
        CrossSaveBungieAccountValidationFailure = 3206,

        /// <summary>
        /// CrossSaveOverriddenPlatformNotAllowed = 3207
        /// </summary>
        [EnumMember(Value = "3207")]
        CrossSaveOverriddenPlatformNotAllowed = 3207,

        /// <summary>
        /// CrossSaveThresholdExceeded = 3208
        /// </summary>
        [EnumMember(Value = "3208")]
        CrossSaveThresholdExceeded = 3208,

        /// <summary>
        /// CrossSaveIncompatibleMembershipType = 3209
        /// </summary>
        [EnumMember(Value = "3209")]
        CrossSaveIncompatibleMembershipType = 3209,

        /// <summary>
        /// CrossSaveCouldNotFindLinkedAccountForMembershipType = 3210
        /// </summary>
        [EnumMember(Value = "3210")]
        CrossSaveCouldNotFindLinkedAccountForMembershipType = 3210,

        /// <summary>
        /// CrossSaveCouldNotCreateDestinyProfileForMembershipType = 3211
        /// </summary>
        [EnumMember(Value = "3211")]
        CrossSaveCouldNotCreateDestinyProfileForMembershipType = 3211,

        /// <summary>
        /// CrossSaveErrorCreatingDestinyProfileForMembershipType = 3212
        /// </summary>
        [EnumMember(Value = "3212")]
        CrossSaveErrorCreatingDestinyProfileForMembershipType = 3212,

        /// <summary>
        /// CrossSaveCannotOverrideSelf = 3213
        /// </summary>
        [EnumMember(Value = "3213")]
        CrossSaveCannotOverrideSelf = 3213,

        /// <summary>
        /// CrossSaveRecentSilverPurchase = 3214
        /// </summary>
        [EnumMember(Value = "3214")]
        CrossSaveRecentSilverPurchase = 3214,

        /// <summary>
        /// CrossSaveSilverBalanceNegative = 3215
        /// </summary>
        [EnumMember(Value = "3215")]
        CrossSaveSilverBalanceNegative = 3215,

        /// <summary>
        /// CrossSaveAccountNotAuthenticated = 3216
        /// </summary>
        [EnumMember(Value = "3216")]
        CrossSaveAccountNotAuthenticated = 3216,

        /// <summary>
        /// ErrorOneAccountAlreadyActive = 3217
        /// </summary>
        [EnumMember(Value = "3217")]
        ErrorOneAccountAlreadyActive = 3217,

        /// <summary>
        /// ErrorOneAccountDestinyRestriction = 3218
        /// </summary>
        [EnumMember(Value = "3218")]
        ErrorOneAccountDestinyRestriction = 3218,

        /// <summary>
        /// CrossSaveMustMigrateToSteam = 3219
        /// </summary>
        [EnumMember(Value = "3219")]
        CrossSaveMustMigrateToSteam = 3219,

        /// <summary>
        /// CrossSaveSteamAlreadyPaired = 3220
        /// </summary>
        [EnumMember(Value = "3220")]
        CrossSaveSteamAlreadyPaired = 3220,

        /// <summary>
        /// CrossSaveCannotPairJustSteamAndBlizzard = 3221
        /// </summary>
        [EnumMember(Value = "3221")]
        CrossSaveCannotPairJustSteamAndBlizzard = 3221,

        /// <summary>
        /// CrossSaveCannotPairSteamAloneBeforeShadowkeep = 3222
        /// </summary>
        [EnumMember(Value = "3222")]
        CrossSaveCannotPairSteamAloneBeforeShadowkeep = 3222,

        /// <summary>
        /// AuthVerificationNotLinkedToAccount = 3300
        /// </summary>
        [EnumMember(Value = "3300")]
        AuthVerificationNotLinkedToAccount = 3300,

        /// <summary>
        /// PCMigrationMissingBlizzard = 3400
        /// </summary>
        [EnumMember(Value = "3400")]
        PCMigrationMissingBlizzard = 3400,

        /// <summary>
        /// PCMigrationMissingSteam = 3401
        /// </summary>
        [EnumMember(Value = "3401")]
        PCMigrationMissingSteam = 3401,

        /// <summary>
        /// PCMigrationInvalidBlizzard = 3402
        /// </summary>
        [EnumMember(Value = "3402")]
        PCMigrationInvalidBlizzard = 3402,

        /// <summary>
        /// PCMigrationInvalidSteam = 3403
        /// </summary>
        [EnumMember(Value = "3403")]
        PCMigrationInvalidSteam = 3403,

        /// <summary>
        /// PCMigrationUnknownFailure = 3404
        /// </summary>
        [EnumMember(Value = "3404")]
        PCMigrationUnknownFailure = 3404,

        /// <summary>
        /// PCMigrationUnknownException = 3405
        /// </summary>
        [EnumMember(Value = "3405")]
        PCMigrationUnknownException = 3405,

        /// <summary>
        /// PCMigrationNotLinked = 3406
        /// </summary>
        [EnumMember(Value = "3406")]
        PCMigrationNotLinked = 3406,

        /// <summary>
        /// PCMigrationAccountsAlreadyUsed = 3407
        /// </summary>
        [EnumMember(Value = "3407")]
        PCMigrationAccountsAlreadyUsed = 3407,

        /// <summary>
        /// PCMigrationStepFailed = 3408
        /// </summary>
        [EnumMember(Value = "3408")]
        PCMigrationStepFailed = 3408,

        /// <summary>
        /// PCMigrationInvalidBlizzardCrossSaveState = 3409
        /// </summary>
        [EnumMember(Value = "3409")]
        PCMigrationInvalidBlizzardCrossSaveState = 3409,

        /// <summary>
        /// PCMigrationDestinationBanned = 3410
        /// </summary>
        [EnumMember(Value = "3410")]
        PCMigrationDestinationBanned = 3410,

        /// <summary>
        /// PCMigrationDestinyFailure = 3411
        /// </summary>
        [EnumMember(Value = "3411")]
        PCMigrationDestinyFailure = 3411,

        /// <summary>
        /// PCMigrationSilverTransferFailed = 3412
        /// </summary>
        [EnumMember(Value = "3412")]
        PCMigrationSilverTransferFailed = 3412,

        /// <summary>
        /// PCMigrationEntitlementTransferFailed = 3413
        /// </summary>
        [EnumMember(Value = "3413")]
        PCMigrationEntitlementTransferFailed = 3413,

        /// <summary>
        /// PCMigrationCannotStompClanFounder = 3414
        /// </summary>
        [EnumMember(Value = "3414")]
        PCMigrationCannotStompClanFounder = 3414,

        /// <summary>
        /// UnsupportedBrowser = 3500
        /// </summary>
        [EnumMember(Value = "3500")]
        UnsupportedBrowser = 3500,

        /// <summary>
        /// StadiaAccountRequired = 3600
        /// </summary>
        [EnumMember(Value = "3600")]
        StadiaAccountRequired = 3600,

        /// <summary>
        /// ErrorPhoneValidationTooManyUses = 3702
        /// </summary>
        [EnumMember(Value = "3702")]
        ErrorPhoneValidationTooManyUses = 3702,

        /// <summary>
        /// ErrorPhoneValidationNoAssociatedPhone = 3703
        /// </summary>
        [EnumMember(Value = "3703")]
        ErrorPhoneValidationNoAssociatedPhone = 3703,

        /// <summary>
        /// ErrorPhoneValidationCodeInvalid = 3705
        /// </summary>
        [EnumMember(Value = "3705")]
        ErrorPhoneValidationCodeInvalid = 3705,

        /// <summary>
        /// ErrorPhoneValidationBanned = 3706
        /// </summary>
        [EnumMember(Value = "3706")]
        ErrorPhoneValidationBanned = 3706,

    }
}