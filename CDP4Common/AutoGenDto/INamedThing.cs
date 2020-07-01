// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INamedThing.cs" company="RHEA System S.A.">
//   Copyright (c) 2017 RHEA System S.A.
// </copyright>
// <summary>
//   This is an auto-generated DTO Interface. Any manual changes to this file will be overwritten!
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.DTO
{
    #pragma warning disable S1128
    using System;
    using System.Collections.Generic;
    using CDP4Common.CommonData;
    #pragma warning restore S1128

    /// <summary>
    /// representation of a Thing that has a human readable name
    /// </summary>
    public partial interface INamedThing
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <remarks>
        /// human readable character string in English by which something can be       referred       to
        /// Note: The implied LanguageCode of <i>name</i> is "en-GB".
        /// </remarks>
        string Name { get; set; }
    }
}
