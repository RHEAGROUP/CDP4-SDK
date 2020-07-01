// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRuleVerificationResolver.cs" company="RHEA System S.A.">
//   Copyright (c) 2017 RHEA System S.A.
// </copyright>
// <summary>
//   This is an auto-generated Resolver class. Any manual changes on this file will be overwritten!
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    #pragma warning disable S1128
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;
    using Newtonsoft.Json.Linq;
    #pragma warning restore S1128

    /// <summary>
    /// The purpose of the <see cref="UserRuleVerificationResolver"/> is to deserialize a JSON object to a <see cref="UserRuleVerification"/>
    /// </summary>
    public static class UserRuleVerificationResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <paramref name="UserRuleVerification"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JObject"/> containing the data</param>
        /// <returns>The <see cref="UserRuleVerification"/> to instantiate</returns>
        public static CDP4Common.DTO.UserRuleVerification FromJsonObject(JObject jObject)
        {
            var iid = jObject["iid"].ToObject<Guid>();
            var revisionNumber = jObject["revisionNumber"].IsNullOrEmpty() ? 0 : jObject["revisionNumber"].ToObject<int>();
            var userRuleVerification = new CDP4Common.DTO.UserRuleVerification(iid, revisionNumber);

            if (!jObject["excludedDomain"].IsNullOrEmpty())
            {
                userRuleVerification.ExcludedDomain.AddRange(jObject["excludedDomain"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedPerson"].IsNullOrEmpty())
            {
                userRuleVerification.ExcludedPerson.AddRange(jObject["excludedPerson"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["executedOn"].IsNullOrEmpty())
            {
                userRuleVerification.ExecutedOn = jObject["executedOn"].ToObject<DateTime?>();
            }

            if (!jObject["isActive"].IsNullOrEmpty())
            {
                userRuleVerification.IsActive = jObject["isActive"].ToObject<bool>();
            }

            if (!jObject["modifiedOn"].IsNullOrEmpty())
            {
                userRuleVerification.ModifiedOn = jObject["modifiedOn"].ToObject<DateTime>();
            }

            if (!jObject["rule"].IsNullOrEmpty())
            {
                userRuleVerification.Rule = jObject["rule"].ToObject<Guid>();
            }

            if (!jObject["status"].IsNullOrEmpty())
            {
                userRuleVerification.Status = jObject["status"].ToObject<RuleVerificationStatusKind>();
            }

            return userRuleVerification;
        }
    }
}
