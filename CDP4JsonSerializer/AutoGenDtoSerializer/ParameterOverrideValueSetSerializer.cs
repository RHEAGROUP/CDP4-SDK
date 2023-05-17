// --------------------------------------------------------------------------------------------------------------------
// <copyright file "ParameterOverrideValueSetSerializer.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Alexander van Delft, Nathanael Smiechowski, Jaime Bernar
//
//    This file is part of CDP4-SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json.Nodes;

    using CDP4Common.DTO;
    using CDP4Common.Types;
    
    /// <summary>
    /// The purpose of the <see cref="ParameterOverrideValueSetSerializer"/> class is to provide a <see cref="ParameterOverrideValueSet"/> specific serializer
    /// </summary>
    public class ParameterOverrideValueSetSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            
             
             
             
             
             
            
            
            
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            
            
            
            
            
            { "computed", computed => JsonValue.Create(((ValueArray<string>)computed).ToJsonString()) },
            
            
            
            
            
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            
            
            
            
            
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            
            
            
            
            
            { "formula", formula => JsonValue.Create(((ValueArray<string>)formula).ToJsonString()) },
            
            
            
            
            
            { "iid", iid => JsonValue.Create(iid) },
            
            
            
            
            
            { "manual", manual => JsonValue.Create(((ValueArray<string>)manual).ToJsonString()) },
            
            
            
            
            
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            
            
             
             
            
            
            
            { "parameterValueSet", parameterValueSet => JsonValue.Create(parameterValueSet) },
            
            
            
            
            
            { "published", published => JsonValue.Create(((ValueArray<string>)published).ToJsonString()) },
            
            
            
            
            
            { "reference", reference => JsonValue.Create(((ValueArray<string>)reference).ToJsonString()) },
            
            
            
            
            
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            
            
            
            
            
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
            
            
            
            
            
            { "valueSwitch", valueSwitch => JsonValue.Create(valueSwitch.ToString()) },
            
            
        };

        /// <summary>
        /// Serialize the <see cref="ParameterOverrideValueSet"/>
        /// </summary>
        /// <param name="parameterOverrideValueSet">The <see cref="ParameterOverrideValueSet"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(ParameterOverrideValueSet parameterOverrideValueSet)
        {
            var jsonObject = new JsonObject
            {
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), parameterOverrideValueSet.ClassKind))},
                {"computed", this.PropertySerializerMap["computed"](parameterOverrideValueSet.Computed)},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](parameterOverrideValueSet.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](parameterOverrideValueSet.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"formula", this.PropertySerializerMap["formula"](parameterOverrideValueSet.Formula)},
                {"iid", this.PropertySerializerMap["iid"](parameterOverrideValueSet.Iid)},
                {"manual", this.PropertySerializerMap["manual"](parameterOverrideValueSet.Manual)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](parameterOverrideValueSet.ModifiedOn)},
                {"parameterValueSet", this.PropertySerializerMap["parameterValueSet"](parameterOverrideValueSet.ParameterValueSet)},
                {"published", this.PropertySerializerMap["published"](parameterOverrideValueSet.Published)},
                {"reference", this.PropertySerializerMap["reference"](parameterOverrideValueSet.Reference)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](parameterOverrideValueSet.RevisionNumber)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](parameterOverrideValueSet.ThingPreference)},
                {"valueSwitch", this.PropertySerializerMap["valueSwitch"](Enum.GetName(typeof(CDP4Common.EngineeringModelData.ParameterSwitchKind), parameterOverrideValueSet.ValueSwitch))},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="ParameterOverrideValueSet"/> class.
        /// </summary>
        public IReadOnlyDictionary<string, Func<object, JsonValue>> PropertySerializerMap => this.propertySerializerMap;

        /// <summary>
        /// Serialize the <see cref="Thing"/> to JObject
        /// </summary>
        /// <param name="thing">The <see cref="Thing"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        public JsonObject Serialize(Thing thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException($"The {nameof(thing)} may not be null.", nameof(thing));
            }

            if (thing is not ParameterOverrideValueSet parameterOverrideValueSet)
            {
                throw new InvalidOperationException("The thing is not a ParameterOverrideValueSet.");
            }

            return this.Serialize(parameterOverrideValueSet);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
