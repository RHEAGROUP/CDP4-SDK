// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiagrammingStyle.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object representation of the <see cref="DiagrammingStyle"/> class.
    /// </summary>
    [DataContract]
    [CDPVersion("1.1.0")]
    public abstract partial class DiagrammingStyle : DiagramThingBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagrammingStyle"/> class.
        /// </summary>
        protected DiagrammingStyle()
        {
            this.UsedColor = new List<Guid>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagrammingStyle"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="rev">
        /// The revision number.
        /// </param>
        protected DiagrammingStyle(Guid iid, int rev) : base(iid: iid, rev: rev)
        {
            this.UsedColor = new List<Guid>();
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced FillColor.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual Guid? FillColor { get; set; }

        /// <summary>
        /// Gets or sets the FillOpacity.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual float? FillOpacity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether FontBold.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual bool? FontBold { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced FontColor.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual Guid? FontColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether FontItalic.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual bool? FontItalic { get; set; }

        /// <summary>
        /// Gets or sets the FontName.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual string FontName { get; set; }

        /// <summary>
        /// Gets or sets the FontSize.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual float? FontSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether FontStrokeThrough.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual bool? FontStrokeThrough { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether FontUnderline.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual bool? FontUnderline { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced StrokeColor.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual Guid? StrokeColor { get; set; }

        /// <summary>
        /// Gets or sets the StrokeOpacity.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual float? StrokeOpacity { get; set; }

        /// <summary>
        /// Gets or sets the StrokeWidth.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual float? StrokeWidth { get; set; }

        /// <summary>
        /// Gets or sets the unique identifiers of the contained UsedColor instances.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.Composite, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual List<Guid> UsedColor { get; set; }

        /// <summary>
        /// Gets an <see cref="IEnumerable{IEnumerable}"/> that references the composite properties of the current <see cref="DiagrammingStyle"/>.
        /// </summary>
        public override IEnumerable<IEnumerable> ContainerLists
        {
            get 
            {
                var containers = new List<IEnumerable>(base.ContainerLists);
                containers.Add(this.UsedColor);
                return containers;
            }
        }
    }
}
