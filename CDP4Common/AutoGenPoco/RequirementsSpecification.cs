// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequirementsSpecification.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2021 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Alexander van Delft, Nathanael Smiechowski
//
//    This file is part of COMET-SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
//
//    The COMET-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The COMET-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.EngineeringModelData
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.Serialization;
    using CDP4Common.CommonData;
    using CDP4Common.DiagramData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.Helpers;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    /// <summary>
    /// representation of a requirements specification
    /// Note: Requirements in a RequirementsSpecification may be grouped in a
    /// hierarchy through a RequirementsGroup structure.
    /// </summary>
    [Container(typeof(Iteration), "RequirementsSpecification")]
    public sealed partial class RequirementsSpecification : RequirementsContainer, IDeprecatableThing
    {
        /// <summary>
        /// Representation of the default value for the accessRight property of a PersonPermission for the affected class
        /// </summary>
        public new const PersonAccessRightKind DefaultPersonAccess = PersonAccessRightKind.NOT_APPLICABLE;

        /// <summary>
        /// Representation of the default value for the accessRight property of a PersonPermission for the affected class
        /// </summary>
        public new const ParticipantAccessRightKind DefaultParticipantAccess = ParticipantAccessRightKind.NONE;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementsSpecification"/> class.
        /// </summary>
        public RequirementsSpecification()
        {
            this.Requirement = new ContainerList<Requirement>(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementsSpecification"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{T, U}"/> where the current thing is stored.
        /// The <see cref="CacheKey"/> is the key used to store this thing.
        /// The key is a combination of this thing's identifier and the identifier of its <see cref="Iteration"/> container if applicable or null.
        /// </param>
        /// <param name="iDalUri">
        /// The <see cref="Uri"/> of this thing
        /// </param>
        public RequirementsSpecification(Guid iid, ConcurrentDictionary<CacheKey, Lazy<CommonData.Thing>> cache, Uri iDalUri) : base(iid, cache, iDalUri)
        {
            this.Requirement = new ContainerList<Requirement>(this);
        }

        /// <summary>
        /// Gets or sets a value indicating whether IsDeprecated.
        /// </summary>
        /// <remarks>
        /// assertion whether a DeprecatableThing is deprecated or not
        /// </remarks>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        public bool IsDeprecated { get; set; }

        /// <summary>
        /// Gets or sets a list of contained Requirement.
        /// </summary>
        /// <remarks>
        /// collection of Requirements in this RequirementsSpecification
        /// </remarks>
        [UmlInformation(aggregation: AggregationKind.Composite, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        public ContainerList<Requirement> Requirement { get; protected set; }

        /// <summary>
        /// Gets an <see cref="IEnumerable{IEnumerable}"/> that references the composite properties of the current <see cref="RequirementsSpecification"/>.
        /// </summary>
        public override IEnumerable<IEnumerable> ContainerLists
        {
            get 
            {
                var containers = new List<IEnumerable>(base.ContainerLists);
                containers.Add(this.Requirement);
                return containers;
            }
        }

        /// <summary>
        /// Creates and returns a copy of this <see cref="RequirementsSpecification"/> for edit purpose.
        /// </summary>
        /// <param name="cloneContainedThings">A value that indicates whether the contained <see cref="Thing"/>s should be cloned or not.</param>
        /// <returns>
        /// A cloned instance of <see cref="RequirementsSpecification"/>.
        /// </returns>
        protected override Thing GenericClone(bool cloneContainedThings)
        {
            var clone = (RequirementsSpecification)this.MemberwiseClone();
            clone.Alias = cloneContainedThings ? new ContainerList<Alias>(clone) : new ContainerList<Alias>(this.Alias, clone);
            clone.Attachment = cloneContainedThings ? new ContainerList<Attachment>(clone) : new ContainerList<Attachment>(this.Attachment, clone);
            clone.Category = new List<Category>(this.Category);
            clone.Definition = cloneContainedThings ? new ContainerList<Definition>(clone) : new ContainerList<Definition>(this.Definition, clone);
            clone.ExcludedDomain = new List<DomainOfExpertise>(this.ExcludedDomain);
            clone.ExcludedPerson = new List<Person>(this.ExcludedPerson);
            clone.Group = cloneContainedThings ? new ContainerList<RequirementsGroup>(clone) : new ContainerList<RequirementsGroup>(this.Group, clone);
            clone.HyperLink = cloneContainedThings ? new ContainerList<HyperLink>(clone) : new ContainerList<HyperLink>(this.HyperLink, clone);
            clone.ParameterValue = cloneContainedThings ? new ContainerList<RequirementsContainerParameterValue>(clone) : new ContainerList<RequirementsContainerParameterValue>(this.ParameterValue, clone);
            clone.Requirement = cloneContainedThings ? new ContainerList<Requirement>(clone) : new ContainerList<Requirement>(this.Requirement, clone);

            if (cloneContainedThings)
            {
                clone.Alias.AddRange(this.Alias.Select(x => x.Clone(true)));
                clone.Attachment.AddRange(this.Attachment.Select(x => x.Clone(true)));
                clone.Definition.AddRange(this.Definition.Select(x => x.Clone(true)));
                clone.Group.AddRange(this.Group.Select(x => x.Clone(true)));
                clone.HyperLink.AddRange(this.HyperLink.Select(x => x.Clone(true)));
                clone.ParameterValue.AddRange(this.ParameterValue.Select(x => x.Clone(true)));
                clone.Requirement.AddRange(this.Requirement.Select(x => x.Clone(true)));
            }

            clone.Original = this;
            clone.ResetCacheId();
            return clone;
        }

        /// <summary>
        /// Creates and returns a copy of this <see cref="RequirementsSpecification"/> for edit purpose.
        /// </summary>
        /// <param name="cloneContainedThings">A value that indicates whether the contained <see cref="Thing"/>s should be cloned or not.</param>
        /// <returns>
        /// A cloned instance of <see cref="RequirementsSpecification"/>.
        /// </returns>
        public new RequirementsSpecification Clone(bool cloneContainedThings)
        {
            this.ChangeKind = ChangeKind.Update;
            return (RequirementsSpecification)this.GenericClone(cloneContainedThings);
        }

        /// <summary>
        /// Validates the cardinalities of the properties of this <see cref="RequirementsSpecification"/>.
        /// </summary>
        /// <returns>
        /// A list of potential errors.
        /// </returns>
        protected override IEnumerable<string> ValidatePocoCardinality()
        {
            var errorList = new List<string>(base.ValidatePocoCardinality());

            return errorList;
        }

        /// <summary>
        /// Resolve the properties of the current <see cref="RequirementsSpecification"/> from its <see cref="DTO.Thing"/> counter-part
        /// </summary>
        /// <param name="dtoThing">The source <see cref="DTO.Thing"/></param>
        internal override void ResolveProperties(DTO.Thing dtoThing)
        {
            if (dtoThing == null)
            {
                throw new ArgumentNullException("dtoThing");
            }

            var dto = dtoThing as DTO.RequirementsSpecification;
            if (dto == null)
            {
                throw new InvalidOperationException(string.Format("The DTO type {0} does not match the type of the current RequirementsSpecification POCO.", dtoThing.GetType()));
            }

            this.Alias.ResolveList(dto.Alias, dto.IterationContainerId, this.Cache);
            this.Attachment.ResolveList(dto.Attachment, dto.IterationContainerId, this.Cache);
            this.Category.ResolveList(dto.Category, dto.IterationContainerId, this.Cache);
            this.Definition.ResolveList(dto.Definition, dto.IterationContainerId, this.Cache);
            this.ExcludedDomain.ResolveList(dto.ExcludedDomain, dto.IterationContainerId, this.Cache);
            this.ExcludedPerson.ResolveList(dto.ExcludedPerson, dto.IterationContainerId, this.Cache);
            this.Group.ResolveList(dto.Group, dto.IterationContainerId, this.Cache);
            this.HyperLink.ResolveList(dto.HyperLink, dto.IterationContainerId, this.Cache);
            this.IsDeprecated = dto.IsDeprecated;
            this.ModifiedOn = dto.ModifiedOn;
            this.Name = dto.Name;
            this.Owner = this.Cache.Get<DomainOfExpertise>(dto.Owner, dto.IterationContainerId) ?? SentinelThingProvider.GetSentinel<DomainOfExpertise>();
            this.ParameterValue.ResolveList(dto.ParameterValue, dto.IterationContainerId, this.Cache);
            this.Requirement.ResolveList(dto.Requirement, dto.IterationContainerId, this.Cache);
            this.RevisionNumber = dto.RevisionNumber;
            this.ShortName = dto.ShortName;
            this.ThingPreference = dto.ThingPreference;

            this.ResolveExtraProperties();
        }

        /// <summary>
        /// Generates a <see cref="DTO.Thing"/> from the current <see cref="RequirementsSpecification"/>
        /// </summary>
        public override DTO.Thing ToDto()
        {
            var dto = new DTO.RequirementsSpecification(this.Iid, this.RevisionNumber);

            dto.Alias.AddRange(this.Alias.Select(x => x.Iid));
            dto.Attachment.AddRange(this.Attachment.Select(x => x.Iid));
            dto.Category.AddRange(this.Category.Select(x => x.Iid));
            dto.Definition.AddRange(this.Definition.Select(x => x.Iid));
            dto.ExcludedDomain.AddRange(this.ExcludedDomain.Select(x => x.Iid));
            dto.ExcludedPerson.AddRange(this.ExcludedPerson.Select(x => x.Iid));
            dto.Group.AddRange(this.Group.Select(x => x.Iid));
            dto.HyperLink.AddRange(this.HyperLink.Select(x => x.Iid));
            dto.IsDeprecated = this.IsDeprecated;
            dto.ModifiedOn = this.ModifiedOn;
            dto.Name = this.Name;
            dto.Owner = this.Owner != null ? this.Owner.Iid : Guid.Empty;
            dto.ParameterValue.AddRange(this.ParameterValue.Select(x => x.Iid));
            dto.Requirement.AddRange(this.Requirement.Select(x => x.Iid));
            dto.RevisionNumber = this.RevisionNumber;
            dto.ShortName = this.ShortName;
            dto.ThingPreference = this.ThingPreference;

            dto.IterationContainerId = this.CacheKey.Iteration;
            dto.RegisterSourceThing(this);
            this.BuildDtoPartialRoutes(dto);
            return dto;
        }
    }
}
