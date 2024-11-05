// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="OwnedStyleSerializer.cs" company="Starion Group S.A.">
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
    using OwnedStyle = CDP4Common.DTO.OwnedStyle;

    /// <summary>
    /// The purpose of the <see cref="OwnedStyleSerializer"/> class is to provide a <see cref="OwnedStyle"/> specific serializer
    /// </summary>
    public class OwnedStyleSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="OwnedStyle" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not OwnedStyle ownedStyle)
            {
                throw new ArgumentException("The thing shall be a OwnedStyle", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.1.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of OwnedStyle since Version is below 1.1.0");
                
                writer.WriteStartObject();
                writer.WriteEndObject();

                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing OwnedStyle for Version 1.1.0");
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(ownedStyle.ClassKind.ToString());

                    //if (ownedStyle.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in ownedStyle.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (ownedStyle.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in ownedStyle.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("fillColor"u8);

                    if(ownedStyle.FillColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.FillColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fillOpacity"u8);

                    if(ownedStyle.FillOpacity.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.FillOpacity.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontBold"u8);

                    if(ownedStyle.FontBold.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontBold.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontColor"u8);

                    if(ownedStyle.FontColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.FontColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontItalic"u8);

                    if(ownedStyle.FontItalic.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontItalic.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontName"u8);
                    writer.WriteStringValue(ownedStyle.FontName);
                    writer.WritePropertyName("fontSize"u8);

                    if(ownedStyle.FontSize.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.FontSize.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontStrokeThrough"u8);

                    if(ownedStyle.FontStrokeThrough.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontStrokeThrough.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontUnderline"u8);

                    if(ownedStyle.FontUnderline.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontUnderline.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(ownedStyle.Iid);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(ownedStyle.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(ownedStyle.Name);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(ownedStyle.RevisionNumber);
                    writer.WritePropertyName("strokeColor"u8);

                    if(ownedStyle.StrokeColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.StrokeColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("strokeOpacity"u8);

                    if(ownedStyle.StrokeOpacity.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.StrokeOpacity.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("strokeWidth"u8);

                    if(ownedStyle.StrokeWidth.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.StrokeWidth.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    //if (ownedStyle.UsedColor.Count > 0)
                    //{
                        writer.WriteStartArray("usedColor"u8);

                        foreach(var usedColorItem in ownedStyle.UsedColor.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(usedColorItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing OwnedStyle for Version 1.2.0");
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(ownedStyle.ClassKind.ToString());

                    //if (ownedStyle.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in ownedStyle.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (ownedStyle.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in ownedStyle.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("fillColor"u8);

                    if(ownedStyle.FillColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.FillColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fillOpacity"u8);

                    if(ownedStyle.FillOpacity.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.FillOpacity.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontBold"u8);

                    if(ownedStyle.FontBold.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontBold.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontColor"u8);

                    if(ownedStyle.FontColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.FontColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontItalic"u8);

                    if(ownedStyle.FontItalic.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontItalic.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontName"u8);
                    writer.WriteStringValue(ownedStyle.FontName);
                    writer.WritePropertyName("fontSize"u8);

                    if(ownedStyle.FontSize.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.FontSize.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontStrokeThrough"u8);

                    if(ownedStyle.FontStrokeThrough.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontStrokeThrough.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontUnderline"u8);

                    if(ownedStyle.FontUnderline.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontUnderline.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(ownedStyle.Iid);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(ownedStyle.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(ownedStyle.Name);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(ownedStyle.RevisionNumber);
                    writer.WritePropertyName("strokeColor"u8);

                    if(ownedStyle.StrokeColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.StrokeColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("strokeOpacity"u8);

                    if(ownedStyle.StrokeOpacity.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.StrokeOpacity.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("strokeWidth"u8);

                    if(ownedStyle.StrokeWidth.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.StrokeWidth.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(ownedStyle.ThingPreference);

                    //if (ownedStyle.UsedColor.Count > 0)
                    //{
                        writer.WriteStartArray("usedColor"u8);

                        foreach(var usedColorItem in ownedStyle.UsedColor.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(usedColorItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing OwnedStyle for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(ownedStyle.Actor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(ownedStyle.ClassKind.ToString());

                    //if (ownedStyle.ExcludedDomain.Count > 0)
                    //{
                        writer.WriteStartArray("excludedDomain"u8);

                        foreach(var excludedDomainItem in ownedStyle.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }

                        writer.WriteEndArray();
                    //}
                    

                    //if (ownedStyle.ExcludedPerson.Count > 0)
                    //{
                        writer.WriteStartArray("excludedPerson"u8);

                        foreach(var excludedPersonItem in ownedStyle.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    writer.WritePropertyName("fillColor"u8);

                    if(ownedStyle.FillColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.FillColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fillOpacity"u8);

                    if(ownedStyle.FillOpacity.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.FillOpacity.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontBold"u8);

                    if(ownedStyle.FontBold.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontBold.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontColor"u8);

                    if(ownedStyle.FontColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.FontColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontItalic"u8);

                    if(ownedStyle.FontItalic.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontItalic.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontName"u8);
                    writer.WriteStringValue(ownedStyle.FontName);
                    writer.WritePropertyName("fontSize"u8);

                    if(ownedStyle.FontSize.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.FontSize.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontStrokeThrough"u8);

                    if(ownedStyle.FontStrokeThrough.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontStrokeThrough.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("fontUnderline"u8);

                    if(ownedStyle.FontUnderline.HasValue)
                    {
                        writer.WriteBooleanValue(ownedStyle.FontUnderline.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(ownedStyle.Iid);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(ownedStyle.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(ownedStyle.Name);
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(ownedStyle.RevisionNumber);
                    writer.WritePropertyName("strokeColor"u8);

                    if(ownedStyle.StrokeColor.HasValue)
                    {
                        writer.WriteStringValue(ownedStyle.StrokeColor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("strokeOpacity"u8);

                    if(ownedStyle.StrokeOpacity.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.StrokeOpacity.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("strokeWidth"u8);

                    if(ownedStyle.StrokeWidth.HasValue)
                    {
                        writer.WriteNumberValue(ownedStyle.StrokeWidth.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(ownedStyle.ThingPreference);

                    //if (ownedStyle.UsedColor.Count > 0)
                    //{
                        writer.WriteStartArray("usedColor"u8);

                        foreach(var usedColorItem in ownedStyle.UsedColor.OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(usedColorItem);
                        }

                        writer.WriteEndArray();
                    //}
                    
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="OwnedStyle"/> property into a <see cref="Utf8JsonWriter" />
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
                case "fillcolor":
                    if(!AllowedVersionsPerProperty["fillColor"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fillColor"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fillopacity":
                    if(!AllowedVersionsPerProperty["fillOpacity"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fillOpacity"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((float)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontbold":
                    if(!AllowedVersionsPerProperty["fontBold"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontBold"u8);
                    
                    if(value != null)
                    {
                        writer.WriteBooleanValue((bool)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontcolor":
                    if(!AllowedVersionsPerProperty["fontColor"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontColor"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontitalic":
                    if(!AllowedVersionsPerProperty["fontItalic"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontItalic"u8);
                    
                    if(value != null)
                    {
                        writer.WriteBooleanValue((bool)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontname":
                    if(!AllowedVersionsPerProperty["fontName"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontName"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontsize":
                    if(!AllowedVersionsPerProperty["fontSize"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontSize"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((float)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontstrokethrough":
                    if(!AllowedVersionsPerProperty["fontStrokeThrough"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontStrokeThrough"u8);
                    
                    if(value != null)
                    {
                        writer.WriteBooleanValue((bool)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "fontunderline":
                    if(!AllowedVersionsPerProperty["fontUnderline"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("fontUnderline"u8);
                    
                    if(value != null)
                    {
                        writer.WriteBooleanValue((bool)value);
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
                case "strokecolor":
                    if(!AllowedVersionsPerProperty["strokeColor"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("strokeColor"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "strokeopacity":
                    if(!AllowedVersionsPerProperty["strokeOpacity"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("strokeOpacity"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((float)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "strokewidth":
                    if(!AllowedVersionsPerProperty["strokeWidth"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("strokeWidth"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((float)value);
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
                case "usedcolor":
                    if(!AllowedVersionsPerProperty["usedColor"].Contains(requestedVersion))
                    {
                        return;
                    }

                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListUsedColor && objectListUsedColor.Any())
                    {
                        writer.WriteStartArray("usedColor"u8);

                        foreach(var usedColorItem in objectListUsedColor.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(usedColorItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                default:
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the OwnedStyle");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "classKind", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fillColor", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fillOpacity", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontBold", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontColor", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontItalic", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontName", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontSize", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontStrokeThrough", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fontUnderline", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "name", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "strokeColor", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "strokeOpacity", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "strokeWidth", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
            { "usedColor", new []{ "1.1.0", "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
