// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeProposalResolver.cs" company="RHEA System S.A.">
//   Copyright (c) 2017 RHEA System S.A.
// </copyright>
// <summary>
//   This is an auto-generated Resolver class. Any manual changes on this file will be overwritten!
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    #pragma warning disable S1128
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;
    using Newtonsoft.Json.Linq;
    #pragma warning restore S1128

    /// <summary>
    /// The purpose of the <see cref="ChangeProposalResolver"/> is to deserialize a JSON object to a <see cref="ChangeProposal"/>
    /// </summary>
    public static class ChangeProposalResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <paramref name="ChangeProposal"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JObject"/> containing the data</param>
        /// <returns>The <see cref="ChangeProposal"/> to instantiate</returns>
        public static CDP4Common.DTO.ChangeProposal FromJsonObject(JObject jObject)
        {
            var iid = jObject["iid"].ToObject<Guid>();
            var revisionNumber = jObject["revisionNumber"].IsNullOrEmpty() ? 0 : jObject["revisionNumber"].ToObject<int>();
            var changeProposal = new CDP4Common.DTO.ChangeProposal(iid, revisionNumber);

            if (!jObject["approvedBy"].IsNullOrEmpty())
            {
                changeProposal.ApprovedBy.AddRange(jObject["approvedBy"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["author"].IsNullOrEmpty())
            {
                changeProposal.Author = jObject["author"].ToObject<Guid>();
            }

            if (!jObject["category"].IsNullOrEmpty())
            {
                changeProposal.Category.AddRange(jObject["category"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["changeRequest"].IsNullOrEmpty())
            {
                changeProposal.ChangeRequest = jObject["changeRequest"].ToObject<Guid>();
            }

            if (!jObject["classification"].IsNullOrEmpty())
            {
                changeProposal.Classification = jObject["classification"].ToObject<AnnotationClassificationKind>();
            }

            if (!jObject["content"].IsNullOrEmpty())
            {
                changeProposal.Content = jObject["content"].ToObject<string>();
            }

            if (!jObject["createdOn"].IsNullOrEmpty())
            {
                changeProposal.CreatedOn = jObject["createdOn"].ToObject<DateTime>();
            }

            if (!jObject["discussion"].IsNullOrEmpty())
            {
                changeProposal.Discussion.AddRange(jObject["discussion"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedDomain"].IsNullOrEmpty())
            {
                changeProposal.ExcludedDomain.AddRange(jObject["excludedDomain"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedPerson"].IsNullOrEmpty())
            {
                changeProposal.ExcludedPerson.AddRange(jObject["excludedPerson"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["languageCode"].IsNullOrEmpty())
            {
                changeProposal.LanguageCode = jObject["languageCode"].ToObject<string>();
            }

            if (!jObject["modifiedOn"].IsNullOrEmpty())
            {
                changeProposal.ModifiedOn = jObject["modifiedOn"].ToObject<DateTime>();
            }

            if (!jObject["owner"].IsNullOrEmpty())
            {
                changeProposal.Owner = jObject["owner"].ToObject<Guid>();
            }

            if (!jObject["primaryAnnotatedThing"].IsNullOrEmpty())
            {
                changeProposal.PrimaryAnnotatedThing = jObject["primaryAnnotatedThing"].ToObject<Guid?>();
            }

            if (!jObject["relatedThing"].IsNullOrEmpty())
            {
                changeProposal.RelatedThing.AddRange(jObject["relatedThing"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["shortName"].IsNullOrEmpty())
            {
                changeProposal.ShortName = jObject["shortName"].ToObject<string>();
            }

            if (!jObject["sourceAnnotation"].IsNullOrEmpty())
            {
                changeProposal.SourceAnnotation.AddRange(jObject["sourceAnnotation"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["status"].IsNullOrEmpty())
            {
                changeProposal.Status = jObject["status"].ToObject<AnnotationStatusKind>();
            }

            if (!jObject["title"].IsNullOrEmpty())
            {
                changeProposal.Title = jObject["title"].ToObject<string>();
            }

            return changeProposal;
        }
    }
}
