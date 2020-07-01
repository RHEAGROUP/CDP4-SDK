// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerationValueDefinitionResolver.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="EnumerationValueDefinitionResolver"/> is to deserialize a JSON object to a <see cref="EnumerationValueDefinition"/>
    /// </summary>
    public static class EnumerationValueDefinitionResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <paramref name="EnumerationValueDefinition"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JObject"/> containing the data</param>
        /// <returns>The <see cref="EnumerationValueDefinition"/> to instantiate</returns>
        public static CDP4Common.DTO.EnumerationValueDefinition FromJsonObject(JObject jObject)
        {
            var iid = jObject["iid"].ToObject<Guid>();
            var revisionNumber = jObject["revisionNumber"].IsNullOrEmpty() ? 0 : jObject["revisionNumber"].ToObject<int>();
            var enumerationValueDefinition = new CDP4Common.DTO.EnumerationValueDefinition(iid, revisionNumber);

            if (!jObject["alias"].IsNullOrEmpty())
            {
                enumerationValueDefinition.Alias.AddRange(jObject["alias"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["definition"].IsNullOrEmpty())
            {
                enumerationValueDefinition.Definition.AddRange(jObject["definition"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedDomain"].IsNullOrEmpty())
            {
                enumerationValueDefinition.ExcludedDomain.AddRange(jObject["excludedDomain"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedPerson"].IsNullOrEmpty())
            {
                enumerationValueDefinition.ExcludedPerson.AddRange(jObject["excludedPerson"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["hyperLink"].IsNullOrEmpty())
            {
                enumerationValueDefinition.HyperLink.AddRange(jObject["hyperLink"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["modifiedOn"].IsNullOrEmpty())
            {
                enumerationValueDefinition.ModifiedOn = jObject["modifiedOn"].ToObject<DateTime>();
            }

            if (!jObject["name"].IsNullOrEmpty())
            {
                enumerationValueDefinition.Name = jObject["name"].ToObject<string>();
            }

            if (!jObject["shortName"].IsNullOrEmpty())
            {
                enumerationValueDefinition.ShortName = jObject["shortName"].ToObject<string>();
            }

            return enumerationValueDefinition;
        }
    }
}
