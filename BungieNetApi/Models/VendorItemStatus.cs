using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum VendorItemStatus
    {
        /// <summary>
        /// Success = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Success = 0,

        /// <summary>
        /// NoInventorySpace = 1
        /// </summary>
        [EnumMember(Value = "1")]
        NoInventorySpace = 1,

        /// <summary>
        /// NoFunds = 2
        /// </summary>
        [EnumMember(Value = "2")]
        NoFunds = 2,

        /// <summary>
        /// NoProgression = 4
        /// </summary>
        [EnumMember(Value = "4")]
        NoProgression = 4,

        /// <summary>
        /// NoUnlock = 8
        /// </summary>
        [EnumMember(Value = "8")]
        NoUnlock = 8,

        /// <summary>
        /// NoQuantity = 16
        /// </summary>
        [EnumMember(Value = "16")]
        NoQuantity = 16,

        /// <summary>
        /// OutsidePurchaseWindow = 32
        /// </summary>
        [EnumMember(Value = "32")]
        OutsidePurchaseWindow = 32,

        /// <summary>
        /// NotAvailable = 64
        /// </summary>
        [EnumMember(Value = "64")]
        NotAvailable = 64,

        /// <summary>
        /// UniquenessViolation = 128
        /// </summary>
        [EnumMember(Value = "128")]
        UniquenessViolation = 128,

        /// <summary>
        /// UnknownError = 256
        /// </summary>
        [EnumMember(Value = "256")]
        UnknownError = 256,

        /// <summary>
        /// AlreadySelling = 512
        /// </summary>
        [EnumMember(Value = "512")]
        AlreadySelling = 512,

        /// <summary>
        /// Unsellable = 1024
        /// </summary>
        [EnumMember(Value = "1024")]
        Unsellable = 1024,

        /// <summary>
        /// SellingInhibited = 2048
        /// </summary>
        [EnumMember(Value = "2048")]
        SellingInhibited = 2048,

        /// <summary>
        /// AlreadyOwned = 4096
        /// </summary>
        [EnumMember(Value = "4096")]
        AlreadyOwned = 4096,

        /// <summary>
        /// DisplayOnly = 8192
        /// </summary>
        [EnumMember(Value = "8192")]
        DisplayOnly = 8192,

    }
}