// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonRoleSerializer.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, 
//            Antoine Théate, Omar Elebiary, Jaime Bernar
//
//    This file is part of CDP4-COMET SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
//
//    The CDP4-COMET SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The CDP4-COMET SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// --------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using CDP4Common.DTO;
    using CDP4Common.Types;

    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The purpose of the <see cref="PersonRoleSerializer"/> class is to provide a <see cref="PersonRole"/> specific serializer
    /// </summary>
    public class PersonRoleSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JToken>> propertySerializerMap = new Dictionary<string, Func<object, JToken>>
        {
            { "actor", actor => new JValue(actor) },
            { "alias", alias => new JArray(alias) },
            { "attachment", attachment => new JArray(attachment) },
            { "classKind", classKind => new JValue(classKind.ToString()) },
            { "definition", definition => new JArray(definition) },
            { "excludedDomain", excludedDomain => new JArray(excludedDomain) },
            { "excludedPerson", excludedPerson => new JArray(excludedPerson) },
            { "hyperLink", hyperLink => new JArray(hyperLink) },
            { "iid", iid => new JValue(iid) },
            { "isDeprecated", isDeprecated => new JValue(isDeprecated) },
            { "modifiedOn", modifiedOn => new JValue(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => new JValue(name) },
            { "personPermission", personPermission => new JArray(personPermission) },
            { "revisionNumber", revisionNumber => new JValue(revisionNumber) },
            { "shortName", shortName => new JValue(shortName) },
            { "thingPreference", thingPreference => new JValue(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="PersonRole"/>
        /// </summary>
        /// <param name="personRole">The <see cref="PersonRole"/> to serialize</param>
        /// <returns>The <see cref="JObject"/></returns>
        private JObject Serialize(PersonRole personRole)
        {
            var jsonObject = new JObject();
            jsonObject.Add("alias", this.PropertySerializerMap["alias"](personRole.Alias.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("attachment", this.PropertySerializerMap["attachment"](personRole.Attachment.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), personRole.ClassKind)));
            jsonObject.Add("definition", this.PropertySerializerMap["definition"](personRole.Definition.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("excludedDomain", this.PropertySerializerMap["excludedDomain"](personRole.ExcludedDomain.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("excludedPerson", this.PropertySerializerMap["excludedPerson"](personRole.ExcludedPerson.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("hyperLink", this.PropertySerializerMap["hyperLink"](personRole.HyperLink.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("iid", this.PropertySerializerMap["iid"](personRole.Iid));
            jsonObject.Add("isDeprecated", this.PropertySerializerMap["isDeprecated"](personRole.IsDeprecated));
            jsonObject.Add("modifiedOn", this.PropertySerializerMap["modifiedOn"](personRole.ModifiedOn));
            jsonObject.Add("name", this.PropertySerializerMap["name"](personRole.Name));
            jsonObject.Add("personPermission", this.PropertySerializerMap["personPermission"](personRole.PersonPermission.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("revisionNumber", this.PropertySerializerMap["revisionNumber"](personRole.RevisionNumber));
            jsonObject.Add("shortName", this.PropertySerializerMap["shortName"](personRole.ShortName));
            jsonObject.Add("thingPreference", this.PropertySerializerMap["thingPreference"](personRole.ThingPreference));
            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="PersonRole"/> class.
        /// </summary>
        public IReadOnlyDictionary<string, Func<object, JToken>> PropertySerializerMap 
        {
            get { return this.propertySerializerMap; }
        }

        /// <summary>
        /// Serialize the <see cref="Thing"/> to JObject
        /// </summary>
        /// <param name="thing">The <see cref="Thing"/> to serialize</param>
        /// <returns>The <see cref="JObject"/></returns>
        public JObject Serialize(Thing thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException($"The {nameof(thing)} may not be null.", nameof(thing));
            }

            var personRole = thing as PersonRole;
            if (personRole == null)
            {
                throw new InvalidOperationException("The thing is not a PersonRole.");
            }

            return this.Serialize(personRole);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
