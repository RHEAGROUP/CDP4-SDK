// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="SiteReferenceDataLibrarySerializer.cs" company="Starion Group S.A.">
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
    using SiteReferenceDataLibrary = CDP4Common.DTO.SiteReferenceDataLibrary;

    /// <summary>
    /// The purpose of the <see cref="SiteReferenceDataLibrarySerializer"/> class is to provide a <see cref="SiteReferenceDataLibrary"/> specific serializer
    /// </summary>
    public class SiteReferenceDataLibrarySerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="SiteReferenceDataLibrary" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not SiteReferenceDataLibrary siteReferenceDataLibrary)
            {
                throw new ArgumentException("The thing shall be a SiteReferenceDataLibrary", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of SiteReferenceDataLibrary since Version is below 1.0.0");
                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteReferenceDataLibrary for Version 1.0.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in siteReferenceDataLibrary.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseQuantityKind"u8);

                    foreach(var baseQuantityKindItem in siteReferenceDataLibrary.BaseQuantityKind.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(baseQuantityKindItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseUnit"u8);

                    foreach(var baseUnitItem in siteReferenceDataLibrary.BaseUnit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(baseUnitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ClassKind.ToString());
                    writer.WriteStartArray("constant"u8);

                    foreach(var constantItem in siteReferenceDataLibrary.Constant.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(constantItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definedCategory"u8);

                    foreach(var definedCategoryItem in siteReferenceDataLibrary.DefinedCategory.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definedCategoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in siteReferenceDataLibrary.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("fileType"u8);

                    foreach(var fileTypeItem in siteReferenceDataLibrary.FileType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(fileTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("glossary"u8);

                    foreach(var glossaryItem in siteReferenceDataLibrary.Glossary.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(glossaryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in siteReferenceDataLibrary.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(siteReferenceDataLibrary.IsDeprecated);
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Name);
                    writer.WriteStartArray("parameterType"u8);

                    foreach(var parameterTypeItem in siteReferenceDataLibrary.ParameterType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(parameterTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("referenceSource"u8);

                    foreach(var referenceSourceItem in siteReferenceDataLibrary.ReferenceSource.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(referenceSourceItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("requiredRdl"u8);

                    if (siteReferenceDataLibrary.RequiredRdl.HasValue)
                    {
                        writer.WriteStringValue(siteReferenceDataLibrary.RequiredRdl.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteReferenceDataLibrary.RevisionNumber);
                    writer.WriteStartArray("rule"u8);

                    foreach(var ruleItem in siteReferenceDataLibrary.Rule.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(ruleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("scale"u8);

                    foreach(var scaleItem in siteReferenceDataLibrary.Scale.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(scaleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ShortName);
                    writer.WriteStartArray("unit"u8);

                    foreach(var unitItem in siteReferenceDataLibrary.Unit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("unitPrefix"u8);

                    foreach(var unitPrefixItem in siteReferenceDataLibrary.UnitPrefix.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitPrefixItem);
                    }

                    writer.WriteEndArray();
                    
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteReferenceDataLibrary for Version 1.1.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in siteReferenceDataLibrary.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseQuantityKind"u8);

                    foreach(var baseQuantityKindItem in siteReferenceDataLibrary.BaseQuantityKind.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(baseQuantityKindItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseUnit"u8);

                    foreach(var baseUnitItem in siteReferenceDataLibrary.BaseUnit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(baseUnitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ClassKind.ToString());
                    writer.WriteStartArray("constant"u8);

                    foreach(var constantItem in siteReferenceDataLibrary.Constant.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(constantItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definedCategory"u8);

                    foreach(var definedCategoryItem in siteReferenceDataLibrary.DefinedCategory.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definedCategoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in siteReferenceDataLibrary.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in siteReferenceDataLibrary.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in siteReferenceDataLibrary.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("fileType"u8);

                    foreach(var fileTypeItem in siteReferenceDataLibrary.FileType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(fileTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("glossary"u8);

                    foreach(var glossaryItem in siteReferenceDataLibrary.Glossary.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(glossaryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in siteReferenceDataLibrary.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(siteReferenceDataLibrary.IsDeprecated);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Name);
                    writer.WriteStartArray("parameterType"u8);

                    foreach(var parameterTypeItem in siteReferenceDataLibrary.ParameterType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(parameterTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("referenceSource"u8);

                    foreach(var referenceSourceItem in siteReferenceDataLibrary.ReferenceSource.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(referenceSourceItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("requiredRdl"u8);

                    if (siteReferenceDataLibrary.RequiredRdl.HasValue)
                    {
                        writer.WriteStringValue(siteReferenceDataLibrary.RequiredRdl.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteReferenceDataLibrary.RevisionNumber);
                    writer.WriteStartArray("rule"u8);

                    foreach(var ruleItem in siteReferenceDataLibrary.Rule.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(ruleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("scale"u8);

                    foreach(var scaleItem in siteReferenceDataLibrary.Scale.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(scaleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ShortName);
                    writer.WriteStartArray("unit"u8);

                    foreach(var unitItem in siteReferenceDataLibrary.Unit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("unitPrefix"u8);

                    foreach(var unitPrefixItem in siteReferenceDataLibrary.UnitPrefix.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitPrefixItem);
                    }

                    writer.WriteEndArray();
                    
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteReferenceDataLibrary for Version 1.2.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in siteReferenceDataLibrary.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseQuantityKind"u8);

                    foreach(var baseQuantityKindItem in siteReferenceDataLibrary.BaseQuantityKind.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(baseQuantityKindItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseUnit"u8);

                    foreach(var baseUnitItem in siteReferenceDataLibrary.BaseUnit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(baseUnitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ClassKind.ToString());
                    writer.WriteStartArray("constant"u8);

                    foreach(var constantItem in siteReferenceDataLibrary.Constant.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(constantItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definedCategory"u8);

                    foreach(var definedCategoryItem in siteReferenceDataLibrary.DefinedCategory.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definedCategoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in siteReferenceDataLibrary.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in siteReferenceDataLibrary.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in siteReferenceDataLibrary.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("fileType"u8);

                    foreach(var fileTypeItem in siteReferenceDataLibrary.FileType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(fileTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("glossary"u8);

                    foreach(var glossaryItem in siteReferenceDataLibrary.Glossary.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(glossaryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in siteReferenceDataLibrary.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(siteReferenceDataLibrary.IsDeprecated);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Name);
                    writer.WriteStartArray("parameterType"u8);

                    foreach(var parameterTypeItem in siteReferenceDataLibrary.ParameterType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(parameterTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("referenceSource"u8);

                    foreach(var referenceSourceItem in siteReferenceDataLibrary.ReferenceSource.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(referenceSourceItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("requiredRdl"u8);

                    if (siteReferenceDataLibrary.RequiredRdl.HasValue)
                    {
                        writer.WriteStringValue(siteReferenceDataLibrary.RequiredRdl.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteReferenceDataLibrary.RevisionNumber);
                    writer.WriteStartArray("rule"u8);

                    foreach(var ruleItem in siteReferenceDataLibrary.Rule.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(ruleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("scale"u8);

                    foreach(var scaleItem in siteReferenceDataLibrary.Scale.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(scaleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ShortName);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ThingPreference);
                    writer.WriteStartArray("unit"u8);

                    foreach(var unitItem in siteReferenceDataLibrary.Unit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("unitPrefix"u8);

                    foreach(var unitPrefixItem in siteReferenceDataLibrary.UnitPrefix.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitPrefixItem);
                    }

                    writer.WriteEndArray();
                    
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing SiteReferenceDataLibrary for Version 1.3.0");
                    writer.WriteStartArray("alias"u8);

                    foreach(var aliasItem in siteReferenceDataLibrary.Alias.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(aliasItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseQuantityKind"u8);

                    foreach(var baseQuantityKindItem in siteReferenceDataLibrary.BaseQuantityKind.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(baseQuantityKindItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("baseUnit"u8);

                    foreach(var baseUnitItem in siteReferenceDataLibrary.BaseUnit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(baseUnitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ClassKind.ToString());
                    writer.WriteStartArray("constant"u8);

                    foreach(var constantItem in siteReferenceDataLibrary.Constant.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(constantItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definedCategory"u8);

                    foreach(var definedCategoryItem in siteReferenceDataLibrary.DefinedCategory.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definedCategoryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("definition"u8);

                    foreach(var definitionItem in siteReferenceDataLibrary.Definition.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(definitionItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in siteReferenceDataLibrary.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in siteReferenceDataLibrary.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("fileType"u8);

                    foreach(var fileTypeItem in siteReferenceDataLibrary.FileType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(fileTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("glossary"u8);

                    foreach(var glossaryItem in siteReferenceDataLibrary.Glossary.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(glossaryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("hyperLink"u8);

                    foreach(var hyperLinkItem in siteReferenceDataLibrary.HyperLink.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(hyperLinkItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Iid);
                    writer.WritePropertyName("isDeprecated"u8);
                    writer.WriteBooleanValue(siteReferenceDataLibrary.IsDeprecated);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.Name);
                    writer.WriteStartArray("parameterType"u8);

                    foreach(var parameterTypeItem in siteReferenceDataLibrary.ParameterType.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(parameterTypeItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("referenceSource"u8);

                    foreach(var referenceSourceItem in siteReferenceDataLibrary.ReferenceSource.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(referenceSourceItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("requiredRdl"u8);

                    if (siteReferenceDataLibrary.RequiredRdl.HasValue)
                    {
                        writer.WriteStringValue(siteReferenceDataLibrary.RequiredRdl.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(siteReferenceDataLibrary.RevisionNumber);
                    writer.WriteStartArray("rule"u8);

                    foreach(var ruleItem in siteReferenceDataLibrary.Rule.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(ruleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("scale"u8);

                    foreach(var scaleItem in siteReferenceDataLibrary.Scale.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(scaleItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("shortName"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ShortName);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(siteReferenceDataLibrary.ThingPreference);
                    writer.WriteStartArray("unit"u8);

                    foreach(var unitItem in siteReferenceDataLibrary.Unit.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("unitPrefix"u8);

                    foreach(var unitPrefixItem in siteReferenceDataLibrary.UnitPrefix.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(unitPrefixItem);
                    }

                    writer.WriteEndArray();
                    
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
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="SiteReferenceDataLibrary" /></exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer)
        {
            if (thing is not SiteReferenceDataLibrary siteReferenceDataLibrary)
            {
                throw new ArgumentException("The thing shall be a SiteReferenceDataLibrary", nameof(thing));
            }

            writer.WriteStartObject();

                writer.WriteStartArray("alias"u8);

                foreach(var aliasItem in siteReferenceDataLibrary.Alias.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(aliasItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("baseQuantityKind"u8);

                foreach(var baseQuantityKindItem in siteReferenceDataLibrary.BaseQuantityKind.OrderBy(x => x, this.OrderedItemComparer))
                {
                    writer.WriteOrderedItem(baseQuantityKindItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("baseUnit"u8);

                foreach(var baseUnitItem in siteReferenceDataLibrary.BaseUnit.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(baseUnitItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("classKind"u8);
                writer.WriteStringValue(siteReferenceDataLibrary.ClassKind.ToString());

                writer.WriteStartArray("constant"u8);

                foreach(var constantItem in siteReferenceDataLibrary.Constant.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(constantItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("definedCategory"u8);

                foreach(var definedCategoryItem in siteReferenceDataLibrary.DefinedCategory.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(definedCategoryItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("definition"u8);

                foreach(var definitionItem in siteReferenceDataLibrary.Definition.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(definitionItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("excludedDomain"u8);

                foreach(var excludedDomainItem in siteReferenceDataLibrary.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(excludedDomainItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("excludedPerson"u8);

                foreach(var excludedPersonItem in siteReferenceDataLibrary.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(excludedPersonItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("fileType"u8);

                foreach(var fileTypeItem in siteReferenceDataLibrary.FileType.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(fileTypeItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("glossary"u8);

                foreach(var glossaryItem in siteReferenceDataLibrary.Glossary.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(glossaryItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("hyperLink"u8);

                foreach(var hyperLinkItem in siteReferenceDataLibrary.HyperLink.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(hyperLinkItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("iid"u8);
                writer.WriteStringValue(siteReferenceDataLibrary.Iid);
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(siteReferenceDataLibrary.IsDeprecated);
                writer.WritePropertyName("modifiedOn"u8);
                writer.WriteStringValue(siteReferenceDataLibrary.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(siteReferenceDataLibrary.Name);

                writer.WriteStartArray("parameterType"u8);

                foreach(var parameterTypeItem in siteReferenceDataLibrary.ParameterType.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(parameterTypeItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("referenceSource"u8);

                foreach(var referenceSourceItem in siteReferenceDataLibrary.ReferenceSource.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(referenceSourceItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("requiredRdl"u8);

                if (siteReferenceDataLibrary.RequiredRdl.HasValue)
                {
                    writer.WriteStringValue(siteReferenceDataLibrary.RequiredRdl.Value);
                }
                else
                {
                    writer.WriteNullValue();
                }

                writer.WritePropertyName("revisionNumber"u8);
                writer.WriteNumberValue(siteReferenceDataLibrary.RevisionNumber);

                writer.WriteStartArray("rule"u8);

                foreach(var ruleItem in siteReferenceDataLibrary.Rule.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(ruleItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("scale"u8);

                foreach(var scaleItem in siteReferenceDataLibrary.Scale.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(scaleItem);
                }

                writer.WriteEndArray();
                
                writer.WritePropertyName("shortName"u8);
                writer.WriteStringValue(siteReferenceDataLibrary.ShortName);
                writer.WritePropertyName("thingPreference"u8);
                writer.WriteStringValue(siteReferenceDataLibrary.ThingPreference);

                writer.WriteStartArray("unit"u8);

                foreach(var unitItem in siteReferenceDataLibrary.Unit.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(unitItem);
                }

                writer.WriteEndArray();
                

                writer.WriteStartArray("unitPrefix"u8);

                foreach(var unitPrefixItem in siteReferenceDataLibrary.UnitPrefix.OrderBy(x => x, this.GuidComparer))
                {
                    writer.WriteStringValue(unitPrefixItem);
                }

                writer.WriteEndArray();
                

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="SiteReferenceDataLibrary"/> property into a <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="propertyName">The name of the property to serialize</param>
        /// <param name="value">The object value to serialize</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <remarks>This method should only be used in the scope of serializing a <see cref="ClasslessDTO" /></remarks>
        public void SerializeProperty(string propertyName, object value, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            var requestedVersion = requestedDataModelVersion.ToString(3);

            if(!AllowedVersionsPerProperty[""].Contains(requestedVersion))
            {
                return;
            }

            this.SerializeProperty(propertyName, value, writer);
        }

        /// <summary>
        /// Serialize a value for a <see cref="SiteReferenceDataLibrary"/> property into a <see cref="Utf8JsonWriter" />
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
                case "basequantitykind":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListBaseQuantityKind && objectListBaseQuantityKind.Any())
                    {
                        writer.WriteStartArray("baseQuantityKind"u8);

                        foreach(var baseQuantityKindItem in objectListBaseQuantityKind.OfType<OrderedItem>().OrderBy(x => x, this.OrderedItemComparer))
                        {
                            writer.WriteOrderedItem(baseQuantityKindItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "baseunit":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListBaseUnit && objectListBaseUnit.Any())
                    {
                        writer.WriteStartArray("baseUnit"u8);

                        foreach(var baseUnitItem in objectListBaseUnit.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(baseUnitItem);
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
                case "constant":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListConstant && objectListConstant.Any())
                    {
                        writer.WriteStartArray("constant"u8);

                        foreach(var constantItem in objectListConstant.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(constantItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "definedcategory":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListDefinedCategory && objectListDefinedCategory.Any())
                    {
                        writer.WriteStartArray("definedCategory"u8);

                        foreach(var definedCategoryItem in objectListDefinedCategory.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(definedCategoryItem);
                        }
                        writer.WriteEndArray();
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
                case "filetype":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListFileType && objectListFileType.Any())
                    {
                        writer.WriteStartArray("fileType"u8);

                        foreach(var fileTypeItem in objectListFileType.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(fileTypeItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "glossary":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListGlossary && objectListGlossary.Any())
                    {
                        writer.WriteStartArray("glossary"u8);

                        foreach(var glossaryItem in objectListGlossary.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(glossaryItem);
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
                case "parametertype":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListParameterType && objectListParameterType.Any())
                    {
                        writer.WriteStartArray("parameterType"u8);

                        foreach(var parameterTypeItem in objectListParameterType.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(parameterTypeItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "referencesource":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListReferenceSource && objectListReferenceSource.Any())
                    {
                        writer.WriteStartArray("referenceSource"u8);

                        foreach(var referenceSourceItem in objectListReferenceSource.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(referenceSourceItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "requiredrdl":
                    writer.WritePropertyName("requiredRdl"u8);
                    
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
                case "rule":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListRule && objectListRule.Any())
                    {
                        writer.WriteStartArray("rule"u8);

                        foreach(var ruleItem in objectListRule.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(ruleItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "scale":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListScale && objectListScale.Any())
                    {
                        writer.WriteStartArray("scale"u8);

                        foreach(var scaleItem in objectListScale.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(scaleItem);
                        }
                        writer.WriteEndArray();
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
                case "unit":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListUnit && objectListUnit.Any())
                    {
                        writer.WriteStartArray("unit"u8);

                        foreach(var unitItem in objectListUnit.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(unitItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                case "unitprefix":
                    if (value == null)
                    {
                        break;
                    }

                    if (value is IEnumerable<object> objectListUnitPrefix && objectListUnitPrefix.Any())
                    {
                        writer.WriteStartArray("unitPrefix"u8);

                        foreach(var unitPrefixItem in objectListUnitPrefix.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(unitPrefixItem);
                        }
                        writer.WriteEndArray();
                    }
                    break;
                default:
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the SiteReferenceDataLibrary");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "alias", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "baseQuantityKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "baseUnit", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "constant", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "definedCategory", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "definition", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "fileType", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "glossary", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "hyperLink", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "isDeprecated", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "name", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "parameterType", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "referenceSource", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "requiredRdl", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "rule", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "scale", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "shortName", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
            { "unit", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "unitPrefix", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
