#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TelephoneNumberSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="TelephoneNumberSerializer"/> class is to provide a <see cref="TelephoneNumber"/> specific serializer
    /// </summary>
    public class TelephoneNumberSerializer : IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JToken>> propertySerializerMap = new Dictionary<string, Func<object, JToken>>
        {
            { "classKind", classKind => new JValue(classKind.ToString()) },
            { "excludedDomain", excludedDomain => new JArray(excludedDomain) },
            { "excludedPerson", excludedPerson => new JArray(excludedPerson) },
            { "iid", iid => new JValue(iid) },
            { "modifiedOn", modifiedOn => new JValue(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "revisionNumber", revisionNumber => new JValue(revisionNumber) },
            { "value", value => new JValue(value) },
            { "vcardType", vcardType => new JArray(vcardType) },
        };

        /// <summary>
        /// Serialize the <see cref="TelephoneNumber"/>
        /// </summary>
        /// <param name="telephoneNumber">The <see cref="TelephoneNumber"/> to serialize</param>
        /// <returns>The <see cref="JObject"/></returns>
        private JObject Serialize(TelephoneNumber telephoneNumber)
        {
            var jsonObject = new JObject();
            jsonObject.Add("classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), telephoneNumber.ClassKind)));
            jsonObject.Add("excludedDomain", this.PropertySerializerMap["excludedDomain"](telephoneNumber.ExcludedDomain));
            jsonObject.Add("excludedPerson", this.PropertySerializerMap["excludedPerson"](telephoneNumber.ExcludedPerson));
            jsonObject.Add("iid", this.PropertySerializerMap["iid"](telephoneNumber.Iid));
            jsonObject.Add("modifiedOn", this.PropertySerializerMap["modifiedOn"](telephoneNumber.ModifiedOn));
            jsonObject.Add("revisionNumber", this.PropertySerializerMap["revisionNumber"](telephoneNumber.RevisionNumber));
            jsonObject.Add("value", this.PropertySerializerMap["value"](telephoneNumber.Value));
            jsonObject.Add("vcardType", this.PropertySerializerMap["vcardType"](telephoneNumber.VcardType.Select(e => Enum.GetName(typeof(CDP4Common.SiteDirectoryData.VcardTelephoneNumberKind), e))));
            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="TelephoneNumber"/> class.
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

            var telephoneNumber = thing as TelephoneNumber;
            if (telephoneNumber == null)
            {
                throw new InvalidOperationException("The thing is not a TelephoneNumber.");
            }

            return this.Serialize(telephoneNumber);
        }
    }
}
