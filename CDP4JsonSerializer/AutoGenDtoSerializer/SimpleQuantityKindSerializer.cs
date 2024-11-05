// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleQuantityKindSerializer.cs" company="Starion Group S.A.">
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
    using SimpleQuantityKind = CDP4Common.DTO.SimpleQuantityKind;

    /// <summary>
    /// The purpose of the <see cref="SimpleQuantityKindSerializer"/> class is to provide a <see cref="SimpleQuantityKind"/> specific serializer
    /// </summary>
    public class SimpleQuantityKindSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="SimpleQuantityKind" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not SimpleQuantityKind simpleQuantityKind)
            {
                throw new ArgumentException("The thing shall be a SimpleQuantityKind", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of SimpleQuantityKind since Version is below 1.0.0");
                
                writer.WriteStartObject();
                writer.WriteEndObject();

                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing SimpleQuantityKind for Version 1.0.0");

                    //if (simpleQuantityKind.Alias.Count > 0)
                    //{
                        writer.WriteStartArray("alias"u8);

                        foreach(var aliasItem in simpleQuantityKind.Alias.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(aliasItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in simpleQuantityKind.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(simpleQuantityKind.ClassKind.ToString());
                    writer.WritePropertyName("defaultScale"u8);
                    writer.WriteStringValue(simpleQuantityKind.DefaultScale);

                    //if (simpleQuantityKind.Definition.Count > 0)
                    //{
                        writer.WriteStartArray("definition"u8);

                        foreach(var definitionItem in simpleQuantityKind.Definition.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(definitionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.HyperLink.Count > 0)
                    //{
                        writer.WriteStartArray("hyperLink"u8);

                        foreach(var hyperLinkItem in simpleQuantityKind.HyperLink.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(hyperLinkItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(simpleQuantityKind.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(simpleQuantityKind.IsDeprecated);
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(simpleQuantityKind.Name);

                    //if (simpleQuantityKind.PossibleScale.Count > 0)
                    //{
                        writer.WriteStartArray("possibleScale"u8);

                        foreach(var possibleScaleItem in simpleQuantityKind.PossibleScale.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(possibleScaleItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("quantityDimensionSymbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.QuantityDimensionSymbol);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(simpleQuantityKind.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(simpleQuantityKind.ShortName);
                    writer.WritePropertyName("symbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.Symbol);
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing SimpleQuantityKind for Version 1.1.0");

                    //if (simpleQuantityKind.Alias.Count > 0)
                    //{
                        writer.WriteStartArray("alias"u8);

                        foreach(var aliasItem in simpleQuantityKind.Alias.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(aliasItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in simpleQuantityKind.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(simpleQuantityKind.ClassKind.ToString());
                    writer.WritePropertyName("defaultScale"u8);
                    writer.WriteStringValue(simpleQuantityKind.DefaultScale);

                    //if (simpleQuantityKind.Definition.Count > 0)
                    //{
                        writer.WriteStartArray("definition"u8);

                        foreach(var definitionItem in simpleQuantityKind.Definition.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(definitionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in simpleQuantityKind.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in simpleQuantityKind.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.HyperLink.Count > 0)
                    //{
                        writer.WriteStartArray("hyperLink"u8);

                        foreach(var hyperLinkItem in simpleQuantityKind.HyperLink.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(hyperLinkItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(simpleQuantityKind.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(simpleQuantityKind.IsDeprecated);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(simpleQuantityKind.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(simpleQuantityKind.Name);

                    //if (simpleQuantityKind.PossibleScale.Count > 0)
                    //{
                        writer.WriteStartArray("possibleScale"u8);

                        foreach(var possibleScaleItem in simpleQuantityKind.PossibleScale.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(possibleScaleItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("quantityDimensionSymbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.QuantityDimensionSymbol);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(simpleQuantityKind.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(simpleQuantityKind.ShortName);
                    writer.WritePropertyName("symbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.Symbol);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing SimpleQuantityKind for Version 1.2.0");

                    //if (simpleQuantityKind.Alias.Count > 0)
                    //{
                        writer.WriteStartArray("alias"u8);

                        foreach(var aliasItem in simpleQuantityKind.Alias.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(aliasItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in simpleQuantityKind.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(simpleQuantityKind.ClassKind.ToString());
                    writer.WritePropertyName("defaultScale"u8);
                    writer.WriteStringValue(simpleQuantityKind.DefaultScale);

                    //if (simpleQuantityKind.Definition.Count > 0)
                    //{
                        writer.WriteStartArray("definition"u8);

                        foreach(var definitionItem in simpleQuantityKind.Definition.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(definitionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in simpleQuantityKind.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in simpleQuantityKind.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.HyperLink.Count > 0)
                    //{
                        writer.WriteStartArray("hyperLink"u8);

                        foreach(var hyperLinkItem in simpleQuantityKind.HyperLink.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(hyperLinkItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(simpleQuantityKind.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(simpleQuantityKind.IsDeprecated);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(simpleQuantityKind.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(simpleQuantityKind.Name);

                    //if (simpleQuantityKind.PossibleScale.Count > 0)
                    //{
                        writer.WriteStartArray("possibleScale"u8);

                        foreach(var possibleScaleItem in simpleQuantityKind.PossibleScale.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(possibleScaleItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("quantityDimensionSymbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.QuantityDimensionSymbol);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(simpleQuantityKind.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(simpleQuantityKind.ShortName);
                    writer.WritePropertyName("symbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.Symbol);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(simpleQuantityKind.ThingPreference);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing SimpleQuantityKind for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(simpleQuantityKind.Actor.HasValue)
                    {
                        writer.WriteStringValue(simpleQuantityKind.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    //if (simpleQuantityKind.Alias.Count > 0)
                    //{
                        writer.WriteStartArray("alias"u8);

                        foreach(var aliasItem in simpleQuantityKind.Alias.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(aliasItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in simpleQuantityKind.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(simpleQuantityKind.ClassKind.ToString());
                    writer.WritePropertyName("defaultScale"u8);
                    writer.WriteStringValue(simpleQuantityKind.DefaultScale);

                    //if (simpleQuantityKind.Definition.Count > 0)
                    //{
                        writer.WriteStartArray("definition"u8);

                        foreach(var definitionItem in simpleQuantityKind.Definition.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(definitionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in simpleQuantityKind.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in simpleQuantityKind.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (simpleQuantityKind.HyperLink.Count > 0)
                    //{
                        writer.WriteStartArray("hyperLink"u8);

                        foreach(var hyperLinkItem in simpleQuantityKind.HyperLink.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(hyperLinkItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(simpleQuantityKind.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(simpleQuantityKind.IsDeprecated);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(simpleQuantityKind.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(simpleQuantityKind.Name);

                    //if (simpleQuantityKind.PossibleScale.Count > 0)
                    //{
                        writer.WriteStartArray("possibleScale"u8);

                        foreach(var possibleScaleItem in simpleQuantityKind.PossibleScale.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(possibleScaleItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("quantityDimensionSymbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.QuantityDimensionSymbol);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(simpleQuantityKind.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(simpleQuantityKind.ShortName);
                    writer.WritePropertyName("symbol"u8);
                    writer.WriteStringValue(simpleQuantityKind.Symbol);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(simpleQuantityKind.ThingPreference);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="SimpleQuantityKind"/> property into a <see cref="Utf8JsonWriter" />
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
                case "alias":
                    if(!AllowedVersionsPerProperty["alias"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListAlias && objectListAlias.Any())
                    {
                        writer.WriteStartArray("alias"u8);

                        foreach(var aliasItem in objectListAlias.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(aliasItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "category":
                    if(!AllowedVersionsPerProperty["category"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListCategory && objectListCategory.Any())
                    {
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in objectListCategory.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }
                        writer.WriteEndArray();
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
                case "defaultscale":
                    if(!AllowedVersionsPerProperty["defaultScale"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("defaultScale"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "definition":
                    if(!AllowedVersionsPerProperty["definition"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListDefinition && objectListDefinition.Any())
                    {
                        writer.WriteStartArray("definition"u8);

                        foreach(var definitionItem in objectListDefinition.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(definitionItem);
                        }
                        writer.WriteEndArray();
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
                case "hyperlink":
                    if(!AllowedVersionsPerProperty["hyperLink"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListHyperLink && objectListHyperLink.Any())
                    {
                        writer.WriteStartArray("hyperLink"u8);

                        foreach(var hyperLinkItem in objectListHyperLink.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(hyperLinkItem);
                        }
                        writer.WriteEndArray();
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
                case "isdeprecated":
                    if(!AllowedVersionsPerProperty["isDeprecated"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("isDeprecated"u8);
                    
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
                case "name":
                    if(!AllowedVersionsPerProperty["name"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("name"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "possiblescale":
                    if(!AllowedVersionsPerProperty["possibleScale"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListPossibleScale && objectListPossibleScale.Any())
                    {
                        writer.WriteStartArray("possibleScale"u8);

                        foreach(var possibleScaleItem in objectListPossibleScale.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(possibleScaleItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "quantitydimensionsymbol":
                    if(!AllowedVersionsPerProperty["quantityDimensionSymbol"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("quantityDimensionSymbol"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
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
                case "shortname":
                    if(!AllowedVersionsPerProperty["shortName"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("shortName"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "symbol":
                    if(!AllowedVersionsPerProperty["symbol"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("symbol"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
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
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the SimpleQuantityKind");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "alias", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "category", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "defaultScale", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "definition", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "hyperLink", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "isDeprecated", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "name", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "possibleScale", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "quantityDimensionSymbol", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "shortName", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "symbol", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
