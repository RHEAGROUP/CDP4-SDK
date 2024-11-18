// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ReferenceSourceSerializer.cs" company="Starion Group S.A.">
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
    using ReferenceSource = CDP4Common.DTO.ReferenceSource;

    /// <summary>
    /// The purpose of the <see cref="ReferenceSourceSerializer"/> class is to provide a <see cref="ReferenceSource"/> specific serializer
    /// </summary>
    public class ReferenceSourceSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="ReferenceSource" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not ReferenceSource referenceSource)
            {
                throw new ArgumentException("The thing shall be a ReferenceSource", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of ReferenceSource since Version is below 1.0.0");
                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing ReferenceSource for Version 1.0.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in referenceSource.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(referenceSource.Author);
                    writer.WriteStartArray("category"u8);

                    foreach(var categoryItem in referenceSource.Category.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(categoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(referenceSource.ClassKind.ToString());
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in referenceSource.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in referenceSource.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(referenceSource.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(referenceSource.IsDeprecated);
                    writer.WritePropertyName("language"u8);
                    writer.WriteStringValue(referenceSource.Language);
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(referenceSource.Name);
                    writer.WritePropertyName("publicationYear"u8);

                    if (referenceSource.PublicationYear.HasValue)
                    {
                        writer.WriteNumberValue(referenceSource.PublicationYear.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publishedIn"u8);

                    if (referenceSource.PublishedIn.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.PublishedIn.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publisher"u8);

                    if (referenceSource.Publisher.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.Publisher.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(referenceSource.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(referenceSource.ShortName);
                    writer.WritePropertyName("versionDate"u8);

                    if (referenceSource.VersionDate.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.VersionDate.Value.ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("versionIdentifier"u8);
                    writer.WriteStringValue(referenceSource.VersionIdentifier);
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing ReferenceSource for Version 1.1.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in referenceSource.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(referenceSource.Author);
                    writer.WriteStartArray("category"u8);

                    foreach(var categoryItem in referenceSource.Category.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(categoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(referenceSource.ClassKind.ToString());
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in referenceSource.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in referenceSource.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in referenceSource.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in referenceSource.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(referenceSource.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(referenceSource.IsDeprecated);
                    writer.WritePropertyName("language"u8);
                    writer.WriteStringValue(referenceSource.Language);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(referenceSource.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(referenceSource.Name);
                    writer.WritePropertyName("publicationYear"u8);

                    if (referenceSource.PublicationYear.HasValue)
                    {
                        writer.WriteNumberValue(referenceSource.PublicationYear.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publishedIn"u8);

                    if (referenceSource.PublishedIn.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.PublishedIn.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publisher"u8);

                    if (referenceSource.Publisher.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.Publisher.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(referenceSource.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(referenceSource.ShortName);
                    writer.WritePropertyName("versionDate"u8);

                    if (referenceSource.VersionDate.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.VersionDate.Value.ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("versionIdentifier"u8);
                    writer.WriteStringValue(referenceSource.VersionIdentifier);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing ReferenceSource for Version 1.2.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in referenceSource.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(referenceSource.Author);
                    writer.WriteStartArray("category"u8);

                    foreach(var categoryItem in referenceSource.Category.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(categoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(referenceSource.ClassKind.ToString());
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in referenceSource.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in referenceSource.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in referenceSource.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in referenceSource.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(referenceSource.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(referenceSource.IsDeprecated);
                    writer.WritePropertyName("language"u8);
                    writer.WriteStringValue(referenceSource.Language);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(referenceSource.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(referenceSource.Name);
                    writer.WritePropertyName("publicationYear"u8);

                    if (referenceSource.PublicationYear.HasValue)
                    {
                        writer.WriteNumberValue(referenceSource.PublicationYear.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publishedIn"u8);

                    if (referenceSource.PublishedIn.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.PublishedIn.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publisher"u8);

                    if (referenceSource.Publisher.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.Publisher.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(referenceSource.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(referenceSource.ShortName);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(referenceSource.ThingPreference);
                    writer.WritePropertyName("versionDate"u8);

                    if (referenceSource.VersionDate.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.VersionDate.Value.ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("versionIdentifier"u8);
                    writer.WriteStringValue(referenceSource.VersionIdentifier);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing ReferenceSource for Version 1.3.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in referenceSource.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(referenceSource.Author);
                    writer.WriteStartArray("category"u8);

                    foreach(var categoryItem in referenceSource.Category.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(categoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(referenceSource.ClassKind.ToString());
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in referenceSource.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in referenceSource.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in referenceSource.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in referenceSource.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(referenceSource.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(referenceSource.IsDeprecated);
                    writer.WritePropertyName("language"u8);
                    writer.WriteStringValue(referenceSource.Language);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(referenceSource.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(referenceSource.Name);
                    writer.WritePropertyName("publicationYear"u8);

                    if (referenceSource.PublicationYear.HasValue)
                    {
                        writer.WriteNumberValue(referenceSource.PublicationYear.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publishedIn"u8);

                    if (referenceSource.PublishedIn.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.PublishedIn.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("publisher"u8);

                    if (referenceSource.Publisher.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.Publisher.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(referenceSource.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(referenceSource.ShortName);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(referenceSource.ThingPreference);
                    writer.WritePropertyName("versionDate"u8);

                    if (referenceSource.VersionDate.HasValue)
                    {
                        writer.WriteStringValue(referenceSource.VersionDate.Value.ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("versionIdentifier"u8);
                    writer.WriteStringValue(referenceSource.VersionIdentifier);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="ReferenceSource" /></exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer)
        {
            if (thing is not ReferenceSource referenceSource)
            {
                throw new ArgumentException("The thing shall be a ReferenceSource", nameof(thing));
            }

            writer.WriteStartObject();

                writer.WriteStartArray("alias"u8);

                foreach(var aliasItem in referenceSource.Alias.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(aliasItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("author"u8);
                writer.WriteStringValue(referenceSource.Author);

                writer.WriteStartArray("category"u8);

                foreach(var categoryItem in referenceSource.Category.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(categoryItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("classKind"u8);
                writer.WriteStringValue(referenceSource.ClassKind.ToString());

                writer.WriteStartArray("definition"u8);

                foreach(var definitionItem in referenceSource.Definition.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(definitionItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("excludedDomain"u8);

                foreach(var excludedDomainItem in referenceSource.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(excludedDomainItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("excludedPerson"u8);

                foreach(var excludedPersonItem in referenceSource.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(excludedPersonItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("hyperLink"u8);

                foreach(var hyperLinkItem in referenceSource.HyperLink.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(hyperLinkItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("iid"u8);
                writer.WriteStringValue(referenceSource.Iid);
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(referenceSource.IsDeprecated);
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(referenceSource.Language);
                writer.WritePropertyName("modifiedOn"u8);
                writer.WriteStringValue(referenceSource.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(referenceSource.Name);
                writer.WritePropertyName("publicationYear"u8);

                if (referenceSource.PublicationYear.HasValue)
                {
                    writer.WriteNumberValue(referenceSource.PublicationYear.Value);
                }
                else
                {
                    writer.WriteNullValue();
                }

                writer.WritePropertyName("publishedIn"u8);

                if (referenceSource.PublishedIn.HasValue)
                {
                    writer.WriteStringValue(referenceSource.PublishedIn.Value);
                }
                else
                {
                    writer.WriteNullValue();
                }

                writer.WritePropertyName("publisher"u8);

                if (referenceSource.Publisher.HasValue)
                {
                    writer.WriteStringValue(referenceSource.Publisher.Value);
                }
                else
                {
                    writer.WriteNullValue();
                }

                writer.WritePropertyName("revisionNumber"u8);
                writer.WriteNumberValue(referenceSource.RevisionNumber);
                writer.WritePropertyName("shortName"u8);
                writer.WriteStringValue(referenceSource.ShortName);
                writer.WritePropertyName("thingPreference"u8);
                writer.WriteStringValue(referenceSource.ThingPreference);
                writer.WritePropertyName("versionDate"u8);

                if (referenceSource.VersionDate.HasValue)
                {
                    writer.WriteStringValue(referenceSource.VersionDate.Value.ToString(SerializerHelper.DateTimeFormat));
                }
                else
                {
                    writer.WriteNullValue();
                }

                writer.WritePropertyName("versionIdentifier"u8);
                writer.WriteStringValue(referenceSource.VersionIdentifier);

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="ReferenceSource"/> property into a <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="propertyName">The name of the property to serialize</param>
        /// <param name="value">The object value to serialize</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <remarks>This method should only be used in the scope of serializing a <see cref="ClasslessDTO" /></remarks>
        public void SerializeProperty(string propertyName, object value, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            var requestedVersion = requestedDataModelVersion.ToString(3);

            if(!AllowedVersionsPerProperty[propertyName].Contains(requestedVersion))
            {
                return;
            }

            this.SerializeProperty(propertyName, value, writer);
        }

        /// <summary>
        /// Serialize a value for a <see cref="ReferenceSource"/> property into a <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="propertyName">The name of the property to serialize</param>
        /// <param name="value">The object value to serialize</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <remarks>This method should only be used in the scope of serializing a <see cref="ClasslessDTO" /></remarks>
        public void SerializeProperty(string propertyName, object value, Utf8JsonWriter writer)
        {
            switch(propertyName.ToLower())
            {
                case "alias":
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
                case "author":
                    writer.WritePropertyName("author"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "category":
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
                case "definition":
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
                case "language":
                    writer.WritePropertyName("language"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "modifiedon":
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
                case "publicationyear":
                    writer.WritePropertyName("publicationYear"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((int)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "publishedin":
                    writer.WritePropertyName("publishedIn"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "publisher":
                    writer.WritePropertyName("publisher"u8);
                    
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
                case "thingpreference":
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
                case "versiondate":
                    writer.WritePropertyName("versionDate"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((DateTime)value).ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "versionidentifier":
                    writer.WritePropertyName("versionIdentifier"u8);
                    
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
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the ReferenceSource");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "alias", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "author", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "category", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "definition", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "hyperLink", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "isDeprecated", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "language", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "name", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "publicationYear", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "publishedIn", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "publisher", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "shortName", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
            { "versionDate", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "versionIdentifier", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
