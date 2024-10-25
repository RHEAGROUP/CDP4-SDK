// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SiteLogEntrySerializer.cs" company="Starion Group S.A.">
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
    using SiteLogEntry = CDP4Common.DTO.SiteLogEntry;

    /// <summary>
    /// The purpose of the <see cref="SiteLogEntrySerializer"/> class is to provide a <see cref="SiteLogEntry"/> specific serializer
    /// </summary>
    public class SiteLogEntrySerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="SiteLogEntry" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not SiteLogEntry siteLogEntry)
            {
                throw new ArgumentException("The thing shall be a SiteLogEntry", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of SiteLogEntry since Version is below 1.0.0");
                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteLogEntry for Version 1.0.0");

                    if (siteLogEntry.AffectedDomainIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedDomainIid"u8);

                        foreach(var affectedDomainIidItem in siteLogEntry.AffectedDomainIid)
                        {
                            writer.WriteStringValue(affectedDomainIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.AffectedItemIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedItemIid"u8);

                        foreach(var affectedItemIidItem in siteLogEntry.AffectedItemIid)
                        {
                            writer.WriteStringValue(affectedItemIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("author"u8);

                    if(siteLogEntry.Author.HasValue)
                    {
                        writer.WriteStringValue(siteLogEntry.Author.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    if (siteLogEntry.Category.Count > 0)
                    {
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in siteLogEntry.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteLogEntry.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(siteLogEntry.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(siteLogEntry.CreatedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteLogEntry.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(siteLogEntry.LanguageCode);
                    writer.WritePropertyName("level"u8);
                    writer.WriteStringValue(siteLogEntry.Level.ToString());
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteLogEntry.RevisionNumber);
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteLogEntry for Version 1.1.0");

                    if (siteLogEntry.AffectedDomainIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedDomainIid"u8);

                        foreach(var affectedDomainIidItem in siteLogEntry.AffectedDomainIid)
                        {
                            writer.WriteStringValue(affectedDomainIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.AffectedItemIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedItemIid"u8);

                        foreach(var affectedItemIidItem in siteLogEntry.AffectedItemIid)
                        {
                            writer.WriteStringValue(affectedItemIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("author"u8);

                    if(siteLogEntry.Author.HasValue)
                    {
                        writer.WriteStringValue(siteLogEntry.Author.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    if (siteLogEntry.Category.Count > 0)
                    {
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in siteLogEntry.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteLogEntry.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(siteLogEntry.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(siteLogEntry.CreatedOn.ToString(SerializerHelper.DateTimeFormat));

                    if (siteLogEntry.ExcludedDomain.Count > 0)
                    {
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in siteLogEntry.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.ExcludedPerson.Count > 0)
                    {
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in siteLogEntry.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteLogEntry.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(siteLogEntry.LanguageCode);
                    writer.WritePropertyName("level"u8);
                    writer.WriteStringValue(siteLogEntry.Level.ToString());
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(siteLogEntry.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteLogEntry.RevisionNumber);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteLogEntry for Version 1.2.0");

                    if (siteLogEntry.AffectedDomainIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedDomainIid"u8);

                        foreach(var affectedDomainIidItem in siteLogEntry.AffectedDomainIid)
                        {
                            writer.WriteStringValue(affectedDomainIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.AffectedItemIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedItemIid"u8);

                        foreach(var affectedItemIidItem in siteLogEntry.AffectedItemIid)
                        {
                            writer.WriteStringValue(affectedItemIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("author"u8);

                    if(siteLogEntry.Author.HasValue)
                    {
                        writer.WriteStringValue(siteLogEntry.Author.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    if (siteLogEntry.Category.Count > 0)
                    {
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in siteLogEntry.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteLogEntry.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(siteLogEntry.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(siteLogEntry.CreatedOn.ToString(SerializerHelper.DateTimeFormat));

                    if (siteLogEntry.ExcludedDomain.Count > 0)
                    {
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in siteLogEntry.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.ExcludedPerson.Count > 0)
                    {
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in siteLogEntry.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteLogEntry.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(siteLogEntry.LanguageCode);
                    writer.WritePropertyName("level"u8);
                    writer.WriteStringValue(siteLogEntry.Level.ToString());

                    if (siteLogEntry.LogEntryChangelogItem.Count > 0)
                    {
                        writer.WriteStartArray("logEntryChangelogItem"u8);

                        foreach(var logEntryChangelogItemItem in siteLogEntry.LogEntryChangelogItem.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(logEntryChangelogItemItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(siteLogEntry.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteLogEntry.RevisionNumber);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(siteLogEntry.ThingPreference);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteLogEntry for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(siteLogEntry.Actor.HasValue)
                    {
                        writer.WriteStringValue(siteLogEntry.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    if (siteLogEntry.AffectedDomainIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedDomainIid"u8);

                        foreach(var affectedDomainIidItem in siteLogEntry.AffectedDomainIid)
                        {
                            writer.WriteStringValue(affectedDomainIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.AffectedItemIid.Count > 0)
                    {
                        writer.WriteStartArray("affectedItemIid"u8);

                        foreach(var affectedItemIidItem in siteLogEntry.AffectedItemIid)
                        {
                            writer.WriteStringValue(affectedItemIidItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("author"u8);

                    if(siteLogEntry.Author.HasValue)
                    {
                        writer.WriteStringValue(siteLogEntry.Author.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    if (siteLogEntry.Category.Count > 0)
                    {
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in siteLogEntry.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteLogEntry.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(siteLogEntry.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(siteLogEntry.CreatedOn.ToString(SerializerHelper.DateTimeFormat));

                    if (siteLogEntry.ExcludedDomain.Count > 0)
                    {
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in siteLogEntry.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    }
                    

                    if (siteLogEntry.ExcludedPerson.Count > 0)
                    {
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in siteLogEntry.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteLogEntry.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(siteLogEntry.LanguageCode);
                    writer.WritePropertyName("level"u8);
                    writer.WriteStringValue(siteLogEntry.Level.ToString());

                    if (siteLogEntry.LogEntryChangelogItem.Count > 0)
                    {
                        writer.WriteStartArray("logEntryChangelogItem"u8);

                        foreach(var logEntryChangelogItemItem in siteLogEntry.LogEntryChangelogItem.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(logEntryChangelogItemItem);
                        }

                        writer.WriteEndArray();
                    }
                    
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(siteLogEntry.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteLogEntry.RevisionNumber);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(siteLogEntry.ThingPreference);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="SiteLogEntry"/> property into a <see cref="Utf8JsonWriter" />
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
                case "affecteddomainiid":
                    if(!AllowedVersionsPerProperty["affectedDomainIid"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value is IEnumerable<object> objectListAffectedDomainIid && objectListAffectedDomainIid.Any())
                    {
                        writer.WriteStartArray("affectedDomainIid"u8);

                        foreach (var affectedDomainIidItem in objectListAffectedDomainIid)
                        {
                            writer.WriteStringValue((Guid)affectedDomainIidItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "affecteditemiid":
                    if(!AllowedVersionsPerProperty["affectedItemIid"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value is IEnumerable<object> objectListAffectedItemIid && objectListAffectedItemIid.Any())
                    {
                        writer.WriteStartArray("affectedItemIid"u8);

                        foreach (var affectedItemIidItem in objectListAffectedItemIid)
                        {
                            writer.WriteStringValue((Guid)affectedItemIidItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "author":
                    if(!AllowedVersionsPerProperty["author"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("author"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "category":
                    if(!AllowedVersionsPerProperty["category"].Contains(requestedVersion))
                    {
                        return;
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
                case "content":
                    if(!AllowedVersionsPerProperty["content"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("content"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "createdon":
                    if(!AllowedVersionsPerProperty["createdOn"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("createdOn"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((DateTime)value).ToString(SerializerHelper.DateTimeFormat));
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
                case "languagecode":
                    if(!AllowedVersionsPerProperty["languageCode"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("languageCode"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "level":
                    if(!AllowedVersionsPerProperty["level"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("level"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((LogLevelKind)value).ToString());
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "logentrychangelogitem":
                    if(!AllowedVersionsPerProperty["logEntryChangelogItem"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value is IEnumerable<object> objectListLogEntryChangelogItem && objectListLogEntryChangelogItem.Any())
                    {
                        writer.WriteStartArray("logEntryChangelogItem"u8);

                        foreach(var logEntryChangelogItemItem in objectListLogEntryChangelogItem.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(logEntryChangelogItemItem);
                        }
                        writer.WriteEndArray();
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
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the SiteLogEntry");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "affectedDomainIid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "affectedItemIid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "author", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "category", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "content", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "createdOn", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "languageCode", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "level", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "logEntryChangelogItem", new []{ "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
