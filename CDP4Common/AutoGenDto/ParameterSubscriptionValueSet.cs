// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterSubscriptionValueSet.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, 
//            Antoine Théate, Omar Elebiary, Jaime Bernar
//
//    This file is part of CDP4-COMET SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
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
// --------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4Common.DTO
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    using CDP4Common.CommonData;
    using CDP4Common.DiagramData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    /// <summary>
    /// A Data Transfer Object representation of the <see cref="ParameterSubscriptionValueSet"/> class.
    /// </summary>
    [DataContract]
    [Container(typeof(ParameterSubscription), "ValueSet")]
    public partial class ParameterSubscriptionValueSet : Thing, IOwnedThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterSubscriptionValueSet"/> class.
        /// </summary>
        public ParameterSubscriptionValueSet()
        {
            this.Manual = new ValueArray<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterSubscriptionValueSet"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="rev">
        /// The revision number.
        /// </param>
        public ParameterSubscriptionValueSet(Guid iid, int rev) : base(iid: iid, rev: rev)
        {
            this.Manual = new ValueArray<string>();
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ActualOption.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The ActualOption property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: false, isNullable: true, isPersistent: false)]
        [XmlIgnore]
        public Guid? ActualOption
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterSubscriptionValueSet.ActualOption"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterSubscriptionValueSet.ActualOption"); }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ActualState.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The ActualState property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: false, isNullable: true, isPersistent: false)]
        [XmlIgnore]
        public Guid? ActualState
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterSubscriptionValueSet.ActualState"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterSubscriptionValueSet.ActualState"); }
        }

        /// <summary>
        /// Gets or sets a list of ordered String.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The ActualValue property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: true, isNullable: false, isPersistent: false)]
        [XmlIgnore]
        public ValueArray<string> ActualValue
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterSubscriptionValueSet.ActualValue"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterSubscriptionValueSet.ActualValue"); }
        }

        /// <summary>
        /// Gets or sets a list of ordered String.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The Computed property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: true, isNullable: false, isPersistent: false)]
        [XmlIgnore]
        public ValueArray<string> Computed
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterSubscriptionValueSet.Computed"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterSubscriptionValueSet.Computed"); }
        }

        /// <summary>
        /// Gets or sets a list of ordered String.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: true, isNullable: false, isPersistent: true)]
        [DataMember]
        public ValueArray<string> Manual { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced Owner.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The Owner property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: false, isNullable: false, isPersistent: false)]
        [XmlIgnore]
        public Guid Owner
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterSubscriptionValueSet.Owner"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterSubscriptionValueSet.Owner"); }
        }

        /// <summary>
        /// Gets or sets a list of ordered String.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The Reference property is a derived property; when the getter and setter are invoked an InvalidOperationException will be thrown.
        /// </exception>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: true, isOrdered: true, isNullable: false, isPersistent: false)]
        [XmlIgnore]
        public ValueArray<string> Reference
        {
            get { throw new InvalidOperationException("Forbidden Get value for the derived property ParameterSubscriptionValueSet.Reference"); }
            set { throw new InvalidOperationException("Forbidden Set value for the derived property ParameterSubscriptionValueSet.Reference"); }
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced SubscribedValueSet.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public Guid SubscribedValueSet { get; set; }

        /// <summary>
        /// Gets or sets the ValueSwitch.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public ParameterSwitchKind ValueSwitch { get; set; }

        /// <summary>
        /// Gets the route for the current <see ref="ParameterSubscriptionValueSet"/>.
        /// </summary>
        public override string Route
        {
            get { return this.ComputedRoute(); }
        }

        /// <summary>
        /// Get all Reference Properties by their Name and id's of instance values
        /// </summary>
        /// <returns>A dictionary of string (Name) and a collections of Guid's (id's of instance values)</returns>
        public override IDictionary<string, IEnumerable<Guid>> GetReferenceProperties()
        {
            var dictionary = new Dictionary<string, IEnumerable<Guid>>();

            dictionary.Add("ExcludedDomain", this.ExcludedDomain);

            dictionary.Add("ExcludedPerson", this.ExcludedPerson);

            if (this.SubscribedValueSet != default)
            {
                dictionary.Add("SubscribedValueSet", new [] { this.SubscribedValueSet });
            }

            return dictionary;
        }

        /// <summary>
        /// Tries to remove references to id's if they exist in a collection of id's (Guid's)
        /// </summary>
        /// <param name="ids">The collection of Guids to remove references for.</param>
        /// <param name="errors">The errors collected while trying to remove references</param>
        /// <returns>True if no errors were found while trying to remove references</returns>
        public override bool TryRemoveReferences(IEnumerable<Guid> ids, out List<string> errors)
        {
            errors = new List<string>();
            var referencedProperties = this.GetReferenceProperties();
            var addModelErrors = !ids.Contains(this.Iid);
            var result = true;

            foreach (var id in ids)
            {
                var foundProperty = referencedProperties.Where(x => x.Value.Contains(id)).ToList();

                if (foundProperty.Any())
                {
                    foreach (var kvp in foundProperty)
                    {
                        switch (kvp.Key)
                        {
                            case "ExcludedDomain":
                                this.ExcludedDomain.Remove(id);
                                break;

                            case "ExcludedPerson":
                                this.ExcludedPerson.Remove(id);
                                break;

                            case "SubscribedValueSet":
                                if (addModelErrors)
                                {
                                    errors.Add($"Remove reference '{id}' from SubscribedValueSet property is not allowed.");
                                }
                                result = false;
                                break;
                        }
                    }
                }
            }
            
            return result;
        }

        /// <summary>
        /// Instantiate a <see cref="CDP4Common.EngineeringModelData.ParameterSubscriptionValueSet"/> from a <see cref="ParameterSubscriptionValueSet"/>
        /// </summary>
        /// <param name="cache">The cache that stores all the <see cref="CommonData.Thing"/>s</param>.
        /// <param name="uri">The <see cref="Uri"/> of the <see cref="CDP4Common.EngineeringModelData.ParameterSubscriptionValueSet"/></param>.
        /// <returns>A new <see cref="CommonData.Thing"/></returns>
        public override CommonData.Thing InstantiatePoco(ConcurrentDictionary<CacheKey, Lazy<CommonData.Thing>> cache, Uri uri)
        {
            return new CDP4Common.EngineeringModelData.ParameterSubscriptionValueSet(this.Iid, cache, uri);
        }

        /// <summary>
        /// Resolves the properties of a copied <see cref="Thing"/> based on the original and a collection of copied <see cref="Thing"/>.
        /// </summary>
        /// <param name="originalThing">The original <see cref="Thing"/></param>.
        /// <param name="originalCopyMap">The map containig all instance of copied <see cref="Thing"/>s with their original</param>.
        public override void ResolveCopy(Thing originalThing, IReadOnlyDictionary<Thing, Thing> originalCopyMap)
        {
            var original = originalThing as ParameterSubscriptionValueSet;
            if (original == null)
            {
                throw new InvalidOperationException("The originalThing cannot be null or is of the incorrect type");
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

            this.Manual = original.Manual;

            this.ModifiedOn = original.ModifiedOn;

            var copySubscribedValueSet = originalCopyMap.SingleOrDefault(kvp => kvp.Key.Iid == original.SubscribedValueSet);
            this.SubscribedValueSet = copySubscribedValueSet.Value == null ? original.SubscribedValueSet : copySubscribedValueSet.Value.Iid;

            this.ThingPreference = original.ThingPreference;

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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
