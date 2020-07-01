// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DerivedUnitResolver.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="DerivedUnitResolver"/> is to deserialize a JSON object to a <see cref="DerivedUnit"/>
    /// </summary>
    public static class DerivedUnitResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <paramref name="DerivedUnit"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JObject"/> containing the data</param>
        /// <returns>The <see cref="DerivedUnit"/> to instantiate</returns>
        public static CDP4Common.DTO.DerivedUnit FromJsonObject(JObject jObject)
        {
            var iid = jObject["iid"].ToObject<Guid>();
            var revisionNumber = jObject["revisionNumber"].IsNullOrEmpty() ? 0 : jObject["revisionNumber"].ToObject<int>();
            var derivedUnit = new CDP4Common.DTO.DerivedUnit(iid, revisionNumber);

            if (!jObject["alias"].IsNullOrEmpty())
            {
                derivedUnit.Alias.AddRange(jObject["alias"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["definition"].IsNullOrEmpty())
            {
                derivedUnit.Definition.AddRange(jObject["definition"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedDomain"].IsNullOrEmpty())
            {
                derivedUnit.ExcludedDomain.AddRange(jObject["excludedDomain"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedPerson"].IsNullOrEmpty())
            {
                derivedUnit.ExcludedPerson.AddRange(jObject["excludedPerson"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["hyperLink"].IsNullOrEmpty())
            {
                derivedUnit.HyperLink.AddRange(jObject["hyperLink"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["isDeprecated"].IsNullOrEmpty())
            {
                derivedUnit.IsDeprecated = jObject["isDeprecated"].ToObject<bool>();
            }

            if (!jObject["modifiedOn"].IsNullOrEmpty())
            {
                derivedUnit.ModifiedOn = jObject["modifiedOn"].ToObject<DateTime>();
            }

            if (!jObject["name"].IsNullOrEmpty())
            {
                derivedUnit.Name = jObject["name"].ToObject<string>();
            }

            if (!jObject["shortName"].IsNullOrEmpty())
            {
                derivedUnit.ShortName = jObject["shortName"].ToObject<string>();
            }

            if (!jObject["unitFactor"].IsNullOrEmpty())
            {
                derivedUnit.UnitFactor.AddRange(jObject["unitFactor"].ToOrderedItemCollection());
            }

            return derivedUnit;
        }
    }
}
