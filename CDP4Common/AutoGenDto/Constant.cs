// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constant.cs" company="RHEA System S.A.">
//   Copyright (c) 2017 RHEA System S.A.
// </copyright>
// <summary>
//   This is an auto-generated DTO Class. Any manual changes to this file will be overwritten!
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.DTO
{
    #pragma warning disable S1128
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;
    #pragma warning restore S1128

    /// <summary>
    /// A Data Transfer Object representation of the <see cref="Constant"/> class.
    /// </summary>
    [DataContract]
    [Container(typeof(ReferenceDataLibrary), "Constant")]
    public sealed partial class Constant : DefinedThing, ICategorizableThing, IDeprecatableThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Constant"/> class.
        /// </summary>
        public Constant()
        {
            this.Category = new List<Guid>();
            this.Value = new ValueArray<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Constant"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="rev">
        /// The revision number.
        /// </param>
        public Constant(Guid iid, int rev) : base(iid: iid, rev: rev)
        {
            this.Category = new List<Guid>();
            this.Value = new ValueArray<string>();
        }

        /// <summary>
        /// Gets or sets the list of unique identifiers of the referenced Category instances.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public List<Guid> Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsDeprecated.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public bool IsDeprecated { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ParameterType.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public Guid ParameterType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced Scale.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public Guid? Scale { get; set; }

        /// <summary>
        /// Gets or sets a list of ordered String.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: true, isNullable: false, isPersistent: true)]
        [DataMember]
        public ValueArray<string> Value { get; set; }

        /// <summary>
        /// Gets the route for the current <see ref="Constant"/>.
        /// </summary>
        public override string Route
        {
            get { return this.ComputedRoute(); }
        }

        /// <summary>
        /// Instantiate a <see cref="CDP4Common.SiteDirectoryData.Constant"/> from a <see cref="Constant"/>
        /// </summary>
        /// <param name="cache">The cache that stores all the <see cref="CommonData.Thing"/>s</param>.
        /// <param name="uri">The <see cref="Uri"/> of the <see cref="CDP4Common.SiteDirectoryData.Constant"/></param>.
        /// <returns>A new <see cref="CommonData.Thing"/></returns>
        public override CommonData.Thing InstantiatePoco(ConcurrentDictionary<CacheKey, Lazy<CommonData.Thing>> cache, Uri uri)
        {
            return new CDP4Common.SiteDirectoryData.Constant(this.Iid, cache, uri);
        }

        /// <summary>
        /// Resolves the properties of a copied <see cref="Thing"/> based on the original and a collection of copied <see cref="Thing"/>.
        /// </summary>
        /// <param name="originalThing">The original <see cref="Thing"/></param>.
        /// <param name="originalCopyMap">The map containig all instance of copied <see cref="Thing"/>s with their original</param>.
        public override void ResolveCopy(Thing originalThing, IReadOnlyDictionary<Thing, Thing> originalCopyMap)
        {
            var original = originalThing as Constant;
            if (original == null)
            {
                throw new InvalidOperationException("The originalThing cannot be null or is of the incorrect type");
            }

            foreach (var guid in original.Alias)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == guid);
                if (Equals(copy, default(KeyValuePair<Thing, Thing>)))
                {
                    throw new InvalidOperationException(string.Format("The copy could not be found for {0}", guid));
                }

                this.Alias.Add(copy.Value.Iid);
            }

            foreach (var guid in original.Category)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == guid);
                this.Category.Add(copy.Value == null ? guid : copy.Value.Iid);
            }

            foreach (var guid in original.Definition)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == guid);
                if (Equals(copy, default(KeyValuePair<Thing, Thing>)))
                {
                    throw new InvalidOperationException(string.Format("The copy could not be found for {0}", guid));
                }

                this.Definition.Add(copy.Value.Iid);
            }

            foreach (var guid in original.ExcludedDomain)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == guid);
                this.ExcludedDomain.Add(copy.Value == null ? guid : copy.Value.Iid);
            }

            foreach (var guid in original.ExcludedPerson)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == guid);
                this.ExcludedPerson.Add(copy.Value == null ? guid : copy.Value.Iid);
            }

            foreach (var guid in original.HyperLink)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == guid);
                if (Equals(copy, default(KeyValuePair<Thing, Thing>)))
                {
                    throw new InvalidOperationException(string.Format("The copy could not be found for {0}", guid));
                }

                this.HyperLink.Add(copy.Value.Iid);
            }

            this.IsDeprecated = original.IsDeprecated;

            this.ModifiedOn = original.ModifiedOn;

            this.Name = original.Name;

            var copyParameterType = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == original.ParameterType);
            this.ParameterType = copyParameterType.Value == null ? original.ParameterType : copyParameterType.Value.Iid;

            var copyScale = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == original.Scale);
            this.Scale = copyScale.Value == null ? original.Scale : copyScale.Value.Iid;

            this.ShortName = original.ShortName;

            this.Value = original.Value;
        }

        /// <summary>
        /// Resolves the references of a copied <see cref="Thing"/> based on a original to copy map.
        /// </summary>
        /// <param name="originalCopyMap">The map containig all instance of copied <see cref="Thing"/>s with their original</param>.
        /// <returns>True if a modification was done in the process of this method</returns>.
        public override bool ResolveCopyReference(IReadOnlyDictionary<Thing, Thing> originalCopyMap)
        {
            var hasChanges = false;

            for (var i = 0; i < this.Category.Count; i++)
            {
                var copy = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == this.Category[i]);
                if (copy.Key != null)
                {
                    this.Category[i] = copy.Value.Iid;
                    hasChanges = true;
                }
            }

            var copyParameterType = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == this.ParameterType);
            if (copyParameterType.Key != null)
            {
                this.ParameterType = copyParameterType.Value.Iid;
                hasChanges = true;
            }

            var copyScale = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == this.Scale);
            if (copyScale.Key != null)
            {
                this.Scale = copyScale.Value.Iid;
                hasChanges = true;
            }

            return hasChanges;
        }
    }
}
