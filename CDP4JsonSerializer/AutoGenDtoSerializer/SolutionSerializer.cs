#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolutionSerializer.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2018 RHEA System S.A.
//
//    Author: Sam Geren�, Merlin Bieze, Alex Vorobiev, Naron Phou
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
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

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
    /// The purpose of the <see cref="SolutionSerializer"/> class is to provide a <see cref="Solution"/> specific serializer
    /// </summary>
    public class SolutionSerializer : IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JToken>> propertySerializerMap = new Dictionary<string, Func<object, JToken>>
        {
            { "author", author => new JValue(author) },
            { "classKind", classKind => new JValue(classKind.ToString()) },
            { "content", content => new JValue(content) },
            { "createdOn", createdOn => new JValue(((DateTime)createdOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "excludedDomain", excludedDomain => new JArray(excludedDomain) },
            { "excludedPerson", excludedPerson => new JArray(excludedPerson) },
            { "iid", iid => new JValue(iid) },
            { "languageCode", languageCode => new JValue(languageCode) },
            { "modifiedOn", modifiedOn => new JValue(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "owner", owner => new JValue(owner) },
            { "revisionNumber", revisionNumber => new JValue(revisionNumber) },
        };

        /// <summary>
        /// Serialize the <see cref="Solution"/>
        /// </summary>
        /// <param name="solution">The <see cref="Solution"/> to serialize</param>
        /// <returns>The <see cref="JObject"/></returns>
        private JObject Serialize(Solution solution)
        {
            var jsonObject = new JObject();
            jsonObject.Add("author", this.PropertySerializerMap["author"](solution.Author));
            jsonObject.Add("classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), solution.ClassKind)));
            jsonObject.Add("content", this.PropertySerializerMap["content"](solution.Content));
            jsonObject.Add("createdOn", this.PropertySerializerMap["createdOn"](solution.CreatedOn));
            jsonObject.Add("excludedDomain", this.PropertySerializerMap["excludedDomain"](solution.ExcludedDomain));
            jsonObject.Add("excludedPerson", this.PropertySerializerMap["excludedPerson"](solution.ExcludedPerson));
            jsonObject.Add("iid", this.PropertySerializerMap["iid"](solution.Iid));
            jsonObject.Add("languageCode", this.PropertySerializerMap["languageCode"](solution.LanguageCode));
            jsonObject.Add("modifiedOn", this.PropertySerializerMap["modifiedOn"](solution.ModifiedOn));
            jsonObject.Add("owner", this.PropertySerializerMap["owner"](solution.Owner));
            jsonObject.Add("revisionNumber", this.PropertySerializerMap["revisionNumber"](solution.RevisionNumber));
            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="Solution"/> class.
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
                throw new ArgumentNullException("thing");
            }

            var solution = thing as Solution;
            if (solution == null)
            {
                throw new InvalidOperationException("The thing is not a Solution.");
            }

            return this.Serialize(solution);
        }
    }
}
