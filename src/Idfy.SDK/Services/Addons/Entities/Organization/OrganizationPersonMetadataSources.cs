﻿using System.Runtime.Serialization;

namespace Idfy.Addons.Entities.Organization
{
    public enum OrganizationPersonMetadataSources
    {
        [EnumMember(Value = "BISNODE")] BISNODE,

        [EnumMember(Value = "BRREG")] BRREG,

        [EnumMember(Value = "UN_CONSOLIDATED")]
        UNCONSOLIDATED,

        [EnumMember(Value = "EU_GLOBAL")] EUGLOBAL,

        [EnumMember(Value = "HMTREASURY")] HMTREASURY,

        [EnumMember(Value = "OFAC")] OFAC,

        [EnumMember(Value = "PEP_AC")] PEPAC,

        [EnumMember(Value = "PEP_EDGE")] PEPEDGE,

        [EnumMember(Value = "GLEIF")] GLEIF,

        [EnumMember(Value = "NO_NATIONAL_REGISTRY")]
        NONATIONALREGISTRY,

        [EnumMember(Value = "NO_BANK_ID")] NOBANKID
    }
}