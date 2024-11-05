// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="NestedParameterSerializer.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2024 Starion Group S.A.
// 
//    Authors: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, Antoine Théate, Omar Elebiary, Jaime Bernar
// 
//    This file is part of CDP4-COMET SDK Community Edition
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
// </copyright>
// -------------------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;

    using CDP4Common;
    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    using NLog;

    using Thing = CDP4Common.DTO.Thing;
    using NestedParameter = CDP4Common.DTO.NestedParameter;

    /// <summary>
    /// The purpose of the <see cref="NestedParameterSerializer"/> class is to provide a <see cref="NestedParameter"/> specific serializer
    /// </summary>
    public class NestedParameterSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="NestedParameter" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not NestedParameter nestedParameter)
            {
                throw new ArgumentException("The thing shall be a NestedParameter", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of NestedParameter since Version is below 1.0.0");
                
                writer.WriteStartObject();
                writer.WriteEndObject();

                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedParameter for Version 1.0.0");
                    writer.WritePropertyName("actualState"u8);

                    if(nestedParameter.ActualState.HasValue)
                    {
                        writer.WriteStringValue(nestedParameter.ActualState.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("actualValue"u8);
                    writer.WriteStringValue(nestedParameter.ActualValue);
                    writer.WritePropertyName("associatedParameter"u8);
                    writer.WriteStringValue(nestedParameter.AssociatedParameter);
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedParameter.ClassKind.ToString());
                    writer.WritePropertyName("formula"u8);
                    writer.WriteStringValue(nestedParameter.Formula);
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedParameter.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedParameter.IsVolatile);
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(nestedParameter.Owner);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedParameter.RevisionNumber);
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedParameter for Version 1.1.0");
                    writer.WritePropertyName("actualState"u8);

                    if(nestedParameter.ActualState.HasValue)
                    {
                        writer.WriteStringValue(nestedParameter.ActualState.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("actualValue"u8);
                    writer.WriteStringValue(nestedParameter.ActualValue);
                    writer.WritePropertyName("associatedParameter"u8);
                    writer.WriteStringValue(nestedParameter.AssociatedParameter);
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedParameter.ClassKind.ToString());

                    //if (nestedParameter.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in nestedParameter.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (nestedParameter.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in nestedParameter.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("formula"u8);
                    writer.WriteStringValue(nestedParameter.Formula);
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedParameter.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedParameter.IsVolatile);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(nestedParameter.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(nestedParameter.Owner);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedParameter.RevisionNumber);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedParameter for Version 1.2.0");
                    writer.WritePropertyName("actualState"u8);

                    if(nestedParameter.ActualState.HasValue)
                    {
                        writer.WriteStringValue(nestedParameter.ActualState.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("actualValue"u8);
                    writer.WriteStringValue(nestedParameter.ActualValue);
                    writer.WritePropertyName("associatedParameter"u8);
                    writer.WriteStringValue(nestedParameter.AssociatedParameter);
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedParameter.ClassKind.ToString());

                    //if (nestedParameter.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in nestedParameter.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (nestedParameter.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in nestedParameter.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("formula"u8);
                    writer.WriteStringValue(nestedParameter.Formula);
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedParameter.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedParameter.IsVolatile);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(nestedParameter.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(nestedParameter.Owner);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedParameter.RevisionNumber);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(nestedParameter.ThingPreference);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedParameter for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(nestedParameter.Actor.HasValue)
                    {
                        writer.WriteStringValue(nestedParameter.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("actualState"u8);

                    if(nestedParameter.ActualState.HasValue)
                    {
                        writer.WriteStringValue(nestedParameter.ActualState.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("actualValue"u8);
                    writer.WriteStringValue(nestedParameter.ActualValue);
                    writer.WritePropertyName("associatedParameter"u8);
                    writer.WriteStringValue(nestedParameter.AssociatedParameter);
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedParameter.ClassKind.ToString());

                    //if (nestedParameter.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in nestedParameter.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (nestedParameter.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in nestedParameter.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("formula"u8);
                    writer.WriteStringValue(nestedParameter.Formula);
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedParameter.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedParameter.IsVolatile);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(nestedParameter.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(nestedParameter.Owner);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedParameter.RevisionNumber);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(nestedParameter.ThingPreference);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="NestedParameter"/> property into a <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="propertyName">The name of the property to serialize</param>
        /// <param name="value">The object value to serialize</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <remarks>This method should only be used in the scope of serializing a <see cref="ClasslessDTO" /></remarks>
        public void SerializeProperty(string propertyName, object value, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            var requestedVersion = requestedDataModelVersion.ToString(3);

            switch(propertyName.ToLower())
            {
                case "actor":
                    if(!AllowedVersionsPerProperty["actor"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("actor"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "actualstate":
                    if(!AllowedVersionsPerProperty["actualState"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("actualState"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "actualvalue":
                    if(!AllowedVersionsPerProperty["actualValue"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("actualValue"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "associatedparameter":
                    if(!AllowedVersionsPerProperty["associatedParameter"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("associatedParameter"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "classkind":
                    if(!AllowedVersionsPerProperty["classKind"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("classKind"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((ClassKind)value).ToString());
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "excludeddomain":
                    if(!AllowedVersionsPerProperty["excludedDomain"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListExcludedDomain && objectListExcludedDomain.Any())
                    {
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in objectListExcludedDomain.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "excludedperson":
                    if(!AllowedVersionsPerProperty["excludedPerson"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListExcludedPerson && objectListExcludedPerson.Any())
                    {
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in objectListExcludedPerson.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "formula":
                    if(!AllowedVersionsPerProperty["formula"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("formula"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "iid":
                    if(!AllowedVersionsPerProperty["iid"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("iid"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "isvolatile":
                    if(!AllowedVersionsPerProperty["isVolatile"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("isVolatile"u8);
                    
                    if(value != null)
                    {
                        writer.WriteBooleanValue((bool)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "modifiedon":
                    if(!AllowedVersionsPerProperty["modifiedOn"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("modifiedOn"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((DateTime)value).ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "owner":
                    if(!AllowedVersionsPerProperty["owner"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("owner"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "revisionnumber":
                    if(!AllowedVersionsPerProperty["revisionNumber"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((int)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "thingpreference":
                    if(!AllowedVersionsPerProperty["thingPreference"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("thingPreference"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                default:
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the NestedParameter");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "actualState", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "actualValue", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "associatedParameter", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "formula", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "isVolatile", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "owner", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
