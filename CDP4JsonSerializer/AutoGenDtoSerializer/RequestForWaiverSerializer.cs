// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="RequestForWaiverSerializer.cs" company="Starion Group S.A.">
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
    using RequestForWaiver = CDP4Common.DTO.RequestForWaiver;

    /// <summary>
    /// The purpose of the <see cref="RequestForWaiverSerializer"/> class is to provide a <see cref="RequestForWaiver"/> specific serializer
    /// </summary>
    public class RequestForWaiverSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="RequestForWaiver" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not RequestForWaiver requestForWaiver)
            {
                throw new ArgumentException("The thing shall be a RequestForWaiver", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.1.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of RequestForWaiver since Version is below 1.1.0");
                
                writer.WriteStartObject();
                writer.WriteEndObject();

                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing RequestForWaiver for Version 1.1.0");

                    //if (requestForWaiver.ApprovedBy.Count > 0)
                    //{
                        writer.WriteStartArray("approvedBy"u8);

                        foreach(var approvedByItem in requestForWaiver.ApprovedBy.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(approvedByItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(requestForWaiver.Author);

                    //if (requestForWaiver.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in requestForWaiver.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classification"u8);
                    writer.WriteStringValue(requestForWaiver.Classification.ToString());
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(requestForWaiver.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(requestForWaiver.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(requestForWaiver.CreatedOn.ToString(SerializerHelper.DateTimeFormat));

                    //if (requestForWaiver.Discussion.Count > 0)
                    //{
                        writer.WriteStartArray("discussion"u8);

                        foreach(var discussionItem in requestForWaiver.Discussion.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(discussionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (requestForWaiver.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in requestForWaiver.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (requestForWaiver.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in requestForWaiver.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(requestForWaiver.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(requestForWaiver.LanguageCode);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(requestForWaiver.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(requestForWaiver.Owner);
                    writer.WritePropertyName("primaryAnnotatedThing"u8);

                    if(requestForWaiver.PrimaryAnnotatedThing.HasValue)
                    {
                        writer.WriteStringValue(requestForWaiver.PrimaryAnnotatedThing.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    //if (requestForWaiver.RelatedThing.Count > 0)
                    //{
                        writer.WriteStartArray("relatedThing"u8);

                        foreach(var relatedThingItem in requestForWaiver.RelatedThing.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(relatedThingItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(requestForWaiver.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(requestForWaiver.ShortName);

                    //if (requestForWaiver.SourceAnnotation.Count > 0)
                    //{
                        writer.WriteStartArray("sourceAnnotation"u8);

                        foreach(var sourceAnnotationItem in requestForWaiver.SourceAnnotation.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(sourceAnnotationItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(requestForWaiver.Status.ToString());
                    writer.WritePropertyName("title"u8);
                    writer.WriteStringValue(requestForWaiver.Title);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing RequestForWaiver for Version 1.2.0");

                    //if (requestForWaiver.ApprovedBy.Count > 0)
                    //{
                        writer.WriteStartArray("approvedBy"u8);

                        foreach(var approvedByItem in requestForWaiver.ApprovedBy.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(approvedByItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(requestForWaiver.Author);

                    //if (requestForWaiver.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in requestForWaiver.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classification"u8);
                    writer.WriteStringValue(requestForWaiver.Classification.ToString());
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(requestForWaiver.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(requestForWaiver.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(requestForWaiver.CreatedOn.ToString(SerializerHelper.DateTimeFormat));

                    //if (requestForWaiver.Discussion.Count > 0)
                    //{
                        writer.WriteStartArray("discussion"u8);

                        foreach(var discussionItem in requestForWaiver.Discussion.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(discussionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (requestForWaiver.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in requestForWaiver.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (requestForWaiver.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in requestForWaiver.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(requestForWaiver.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(requestForWaiver.LanguageCode);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(requestForWaiver.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(requestForWaiver.Owner);
                    writer.WritePropertyName("primaryAnnotatedThing"u8);

                    if(requestForWaiver.PrimaryAnnotatedThing.HasValue)
                    {
                        writer.WriteStringValue(requestForWaiver.PrimaryAnnotatedThing.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    //if (requestForWaiver.RelatedThing.Count > 0)
                    //{
                        writer.WriteStartArray("relatedThing"u8);

                        foreach(var relatedThingItem in requestForWaiver.RelatedThing.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(relatedThingItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(requestForWaiver.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(requestForWaiver.ShortName);

                    //if (requestForWaiver.SourceAnnotation.Count > 0)
                    //{
                        writer.WriteStartArray("sourceAnnotation"u8);

                        foreach(var sourceAnnotationItem in requestForWaiver.SourceAnnotation.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(sourceAnnotationItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(requestForWaiver.Status.ToString());
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(requestForWaiver.ThingPreference);
                    writer.WritePropertyName("title"u8);
                    writer.WriteStringValue(requestForWaiver.Title);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing RequestForWaiver for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(requestForWaiver.Actor.HasValue)
                    {
                        writer.WriteStringValue(requestForWaiver.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    //if (requestForWaiver.ApprovedBy.Count > 0)
                    //{
                        writer.WriteStartArray("approvedBy"u8);

                        foreach(var approvedByItem in requestForWaiver.ApprovedBy.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(approvedByItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("author"u8);
                    writer.WriteStringValue(requestForWaiver.Author);

                    //if (requestForWaiver.Category.Count > 0)
                    //{
                        writer.WriteStartArray("category"u8);

                        foreach(var categoryItem in requestForWaiver.Category.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(categoryItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("classification"u8);
                    writer.WriteStringValue(requestForWaiver.Classification.ToString());
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(requestForWaiver.ClassKind.ToString());
                    writer.WritePropertyName("content"u8);
                    writer.WriteStringValue(requestForWaiver.Content);
                    writer.WritePropertyName("createdOn"u8);
                    writer.WriteStringValue(requestForWaiver.CreatedOn.ToString(SerializerHelper.DateTimeFormat));

                    //if (requestForWaiver.Discussion.Count > 0)
                    //{
                        writer.WriteStartArray("discussion"u8);

                        foreach(var discussionItem in requestForWaiver.Discussion.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(discussionItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (requestForWaiver.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in requestForWaiver.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (requestForWaiver.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in requestForWaiver.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(requestForWaiver.Iid);
                    writer.WritePropertyName("languageCode"u8);
                    writer.WriteStringValue(requestForWaiver.LanguageCode);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(requestForWaiver.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("owner"u8);
                    writer.WriteStringValue(requestForWaiver.Owner);
                    writer.WritePropertyName("primaryAnnotatedThing"u8);

                    if(requestForWaiver.PrimaryAnnotatedThing.HasValue)
                    {
                        writer.WriteStringValue(requestForWaiver.PrimaryAnnotatedThing.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    //if (requestForWaiver.RelatedThing.Count > 0)
                    //{
                        writer.WriteStartArray("relatedThing"u8);

                        foreach(var relatedThingItem in requestForWaiver.RelatedThing.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(relatedThingItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(requestForWaiver.RevisionNumber);
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(requestForWaiver.ShortName);

                    //if (requestForWaiver.SourceAnnotation.Count > 0)
                    //{
                        writer.WriteStartArray("sourceAnnotation"u8);

                        foreach(var sourceAnnotationItem in requestForWaiver.SourceAnnotation.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(sourceAnnotationItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(requestForWaiver.Status.ToString());
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(requestForWaiver.ThingPreference);
                    writer.WritePropertyName("title"u8);
                    writer.WriteStringValue(requestForWaiver.Title);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="RequestForWaiver"/> property into a <see cref="Utf8JsonWriter" />
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
                case "approvedby":
                    if(!AllowedVersionsPerProperty["approvedBy"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListApprovedBy && objectListApprovedBy.Any())
                    {
                        writer.WriteStartArray("approvedBy"u8);

                        foreach(var approvedByItem in objectListApprovedBy.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(approvedByItem);
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
                case "classification":
                    if(!AllowedVersionsPerProperty["classification"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("classification"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((AnnotationClassificationKind)value).ToString());
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
                case "discussion":
                    if(!AllowedVersionsPerProperty["discussion"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListDiscussion && objectListDiscussion.Any())
                    {
                        writer.WriteStartArray("discussion"u8);

                        foreach(var discussionItem in objectListDiscussion.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(discussionItem);
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
                case "primaryannotatedthing":
                    if(!AllowedVersionsPerProperty["primaryAnnotatedThing"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("primaryAnnotatedThing"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "relatedthing":
                    if(!AllowedVersionsPerProperty["relatedThing"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListRelatedThing && objectListRelatedThing.Any())
                    {
                        writer.WriteStartArray("relatedThing"u8);

                        foreach(var relatedThingItem in objectListRelatedThing.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(relatedThingItem);
                        }
                        writer.WriteEndArray();
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
                case "sourceannotation":
                    if(!AllowedVersionsPerProperty["sourceAnnotation"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListSourceAnnotation && objectListSourceAnnotation.Any())
                    {
                        writer.WriteStartArray("sourceAnnotation"u8);

                        foreach(var sourceAnnotationItem in objectListSourceAnnotation.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(sourceAnnotationItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "status":
                    if(!AllowedVersionsPerProperty["status"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("status"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((AnnotationStatusKind)value).ToString());
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
                case "title":
                    if(!AllowedVersionsPerProperty["title"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("title"u8);
                    
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
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the RequestForWaiver");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "approvedBy", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "author", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "category", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "classification", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "content", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "createdOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "discussion", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "languageCode", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "owner", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "primaryAnnotatedThing", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "relatedThing", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "shortName", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "sourceAnnotation", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "status", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
            { "title", new []{ "1.1.0", "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
