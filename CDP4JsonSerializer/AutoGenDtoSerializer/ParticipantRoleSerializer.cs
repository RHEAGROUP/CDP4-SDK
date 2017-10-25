// --------------------------------------------------------------------------------------------------------------------
// <copyright file "ParticipantRoleSerializer.cs" company="RHEA System S.A.">
//   Copyright (c) 2017 RHEA System S.A.
// </copyright>
// <summary>
//   This is an auto-generated Serializer class. Any manual changes on this file will be overwritten!
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
    /// The purpose of the <see cref="ParticipantRoleSerializer"/> class is to provide a <see cref="ParticipantRole"/> specific serializer
    /// </summary>
    public class ParticipantRoleSerializer : IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JToken>> propertySerializerMap = new Dictionary<string, Func<object, JToken>>
        {
            { "alias", alias => new JArray(alias) },
            { "classKind", classKind => new JValue(classKind.ToString()) },
            { "definition", definition => new JArray(definition) },
            { "excludedDomain", excludedDomain => new JArray(excludedDomain) },
            { "excludedPerson", excludedPerson => new JArray(excludedPerson) },
            { "hyperLink", hyperLink => new JArray(hyperLink) },
            { "iid", iid => new JValue(iid) },
            { "isDeprecated", isDeprecated => new JValue(isDeprecated) },
            { "modifiedOn", modifiedOn => new JValue(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => new JValue(name) },
            { "participantPermission", participantPermission => new JArray(participantPermission) },
            { "revisionNumber", revisionNumber => new JValue(revisionNumber) },
            { "shortName", shortName => new JValue(shortName) },
        };

        /// <summary>
        /// Serialize the <see cref="ParticipantRole"/>
        /// </summary>
        /// <param name="participantRole">The <see cref="ParticipantRole"/> to serialize</param>
        /// <returns>The <see cref="JObject"/></returns>
        private JObject Serialize(ParticipantRole participantRole)
        {
            var jsonObject = new JObject();
            jsonObject.Add("alias", this.PropertySerializerMap["alias"](participantRole.Alias));
            jsonObject.Add("classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), participantRole.ClassKind)));
            jsonObject.Add("definition", this.PropertySerializerMap["definition"](participantRole.Definition));
            jsonObject.Add("excludedDomain", this.PropertySerializerMap["excludedDomain"](participantRole.ExcludedDomain));
            jsonObject.Add("excludedPerson", this.PropertySerializerMap["excludedPerson"](participantRole.ExcludedPerson));
            jsonObject.Add("hyperLink", this.PropertySerializerMap["hyperLink"](participantRole.HyperLink));
            jsonObject.Add("iid", this.PropertySerializerMap["iid"](participantRole.Iid));
            jsonObject.Add("isDeprecated", this.PropertySerializerMap["isDeprecated"](participantRole.IsDeprecated));
            jsonObject.Add("modifiedOn", this.PropertySerializerMap["modifiedOn"](participantRole.ModifiedOn));
            jsonObject.Add("name", this.PropertySerializerMap["name"](participantRole.Name));
            jsonObject.Add("participantPermission", this.PropertySerializerMap["participantPermission"](participantRole.ParticipantPermission));
            jsonObject.Add("revisionNumber", this.PropertySerializerMap["revisionNumber"](participantRole.RevisionNumber));
            jsonObject.Add("shortName", this.PropertySerializerMap["shortName"](participantRole.ShortName));
            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="ParticipantRole"/> class.
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

            var participantRole = thing as ParticipantRole;
            if (participantRole == null)
            {
                throw new InvalidOperationException("The thing is not a ParticipantRole.");
            }

            return this.Serialize(participantRole);
        }
    }
}
