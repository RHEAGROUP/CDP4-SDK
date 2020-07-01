// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterOverrideValueSet.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object representation of the <see cref="ParameterOverrideValueSet"/> class.
    /// </summary>
    [DataContract]
    [Container(typeof(ParameterOverride), "ValueSet")]
    public sealed partial class ParameterOverrideValueSet : ParameterValueSetBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterOverrideValueSet"/> class.
        /// </summary>
        public ParameterOverrideValueSet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterOverrideValueSet"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="rev">
        /// The revision number.
        /// </param>
        public ParameterOverrideValueSet(Guid iid, int rev) : base(iid: iid, rev: rev)
        {
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ActualOption.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The ActualOption property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: false, isNullable: true, isPersistent: false)]
        [XmlIgnore]
        public override Guid? ActualOption
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterOverrideValueSet.ActualOption"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterOverrideValueSet.ActualOption"); }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ActualState.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The ActualState property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: false, isNullable: true, isPersistent: false)]
        [XmlIgnore]
        public override Guid? ActualState
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterOverrideValueSet.ActualState"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterOverrideValueSet.ActualState"); }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ParameterValueSet.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public Guid ParameterValueSet { get; set; }

        /// <summary>
        /// Gets the route for the current <see ref="ParameterOverrideValueSet"/>.
        /// </summary>
        public override string Route
        {
            get { return this.ComputedRoute(); }
        }

        /// <summary>
        /// Instantiate a <see cref="CDP4Common.EngineeringModelData.ParameterOverrideValueSet"/> from a <see cref="ParameterOverrideValueSet"/>
        /// </summary>
        /// <param name="cache">The cache that stores all the <see cref="CommonData.Thing"/>s</param>.
        /// <param name="uri">The <see cref="Uri"/> of the <see cref="CDP4Common.EngineeringModelData.ParameterOverrideValueSet"/></param>.
        /// <returns>A new <see cref="CommonData.Thing"/></returns>
        public override CommonData.Thing InstantiatePoco(ConcurrentDictionary<CacheKey, Lazy<CommonData.Thing>> cache, Uri uri)
        {
            return new CDP4Common.EngineeringModelData.ParameterOverrideValueSet(this.Iid, cache, uri);
        }

        /// <summary>
        /// Resolves the properties of a copied <see cref="Thing"/> based on the original and a collection of copied <see cref="Thing"/>.
        /// </summary>
        /// <param name="originalThing">The original <see cref="Thing"/></param>.
        /// <param name="originalCopyMap">The map containig all instance of copied <see cref="Thing"/>s with their original</param>.
        public override void ResolveCopy(Thing originalThing, IReadOnlyDictionary<Thing, Thing> originalCopyMap)
        {
            var original = originalThing as ParameterOverrideValueSet;
            if (original == null)
            {
                throw new InvalidOperationException("The originalThing cannot be null or is of the incorrect type");
            }

            this.Computed = original.Computed;

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

            this.Formula = original.Formula;

            this.Manual = original.Manual;

            this.ModifiedOn = original.ModifiedOn;

            var copyParameterValueSet = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == original.ParameterValueSet);
            this.ParameterValueSet = copyParameterValueSet.Value == null ? original.ParameterValueSet : copyParameterValueSet.Value.Iid;

            this.Published = original.Published;

            this.Reference = original.Reference;

            this.ValueSwitch = original.ValueSwitch;
        }

        /// <summary>
        /// Resolves the references of a copied <see cref="Thing"/> based on a original to copy map.
        /// </summary>
        /// <param name="originalCopyMap">The map containig all instance of copied <see cref="Thing"/>s with their original</param>.
        /// <returns>True if a modification was done in the process of this method</returns>.
        public override bool ResolveCopyReference(IReadOnlyDictionary<Thing, Thing> originalCopyMap)
        {
            var hasChanges = false;

            return hasChanges;
        }
    }
}
