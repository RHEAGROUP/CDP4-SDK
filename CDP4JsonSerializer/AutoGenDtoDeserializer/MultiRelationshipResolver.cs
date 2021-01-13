// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MultiRelationshipResolver.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2018 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou
//
//    This file is part of CDP4-SDK Community Edition
//
//    The CDP4-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The CDP4-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
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

    /// <summary>
    /// The purpose of the <see cref="MultiRelationshipResolver"/> is to deserialize a JSON object to a <see cref="MultiRelationship"/>
    /// </summary>
    public static class MultiRelationshipResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <paramref name="MultiRelationship"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JObject"/> containing the data</param>
        /// <returns>The <see cref="MultiRelationship"/> to instantiate</returns>
        public static CDP4Common.DTO.MultiRelationship FromJsonObject(JObject jObject)
        {
            var iid = jObject["iid"].ToObject<Guid>();
            var revisionNumber = jObject["revisionNumber"].IsNullOrEmpty() ? 0 : jObject["revisionNumber"].ToObject<int>();
            var multiRelationship = new CDP4Common.DTO.MultiRelationship(iid, revisionNumber);

            if (!jObject["category"].IsNullOrEmpty())
            {
                multiRelationship.Category.AddRange(jObject["category"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedDomain"].IsNullOrEmpty())
            {
                multiRelationship.ExcludedDomain.AddRange(jObject["excludedDomain"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedPerson"].IsNullOrEmpty())
            {
                multiRelationship.ExcludedPerson.AddRange(jObject["excludedPerson"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["modifiedOn"].IsNullOrEmpty())
            {
                multiRelationship.ModifiedOn = jObject["modifiedOn"].ToObject<DateTime>();
            }

            if (!jObject["name"].IsNullOrEmpty())
            {
                multiRelationship.Name = jObject["name"].ToObject<string>();
            }

            if (!jObject["owner"].IsNullOrEmpty())
            {
                multiRelationship.Owner = jObject["owner"].ToObject<Guid>();
            }

            if (!jObject["parameterValue"].IsNullOrEmpty())
            {
                multiRelationship.ParameterValue.AddRange(jObject["parameterValue"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["relatedThing"].IsNullOrEmpty())
            {
                multiRelationship.RelatedThing.AddRange(jObject["relatedThing"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["thingPreference"].IsNullOrEmpty())
            {
                multiRelationship.ThingPreference = jObject["thingPreference"].ToObject<string>();
            }

            return multiRelationship;
        }
    }
}
