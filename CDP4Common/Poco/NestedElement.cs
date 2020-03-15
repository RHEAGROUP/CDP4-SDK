﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NestedElement.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2020 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou
//
//    This file is part of CDP4-SDK Community Edition
//
//    The CDP4-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The CDP4-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.EngineeringModelData
{
    using System.Collections.Generic;
    using System.Linq;

    using CDP4Common.SiteDirectoryData;

    /// <summary>
    /// Extended part for the auto-generated <see cref="NestedElement"/>
    /// </summary>
    public partial class NestedElement
    {
        /// <summary>
        /// Returns the <see cref="Name"/> value
        /// </summary>
        /// <returns>The <see cref="Name"/> value</returns>
        protected string GetDerivedName()
        {
            var lastElementUsage = this.ElementUsage.LastOrDefault();
            return lastElementUsage == null ? this.RootElement.Name : lastElementUsage.Name;
        }

        /// <summary>
        /// Returns the <see cref="ShortName"/> value
        /// </summary>
        /// <returns>The <see cref="ShortName"/> value</returns>
        protected string GetDerivedShortName()
        {
            var shortNameComponents = new List<string> { this.RootElement.ShortName };

            foreach (ElementUsage usage in this.ElementUsage)
            {
                shortNameComponents.Add(usage.ShortName);
            }

            return string.Join(".", shortNameComponents);
        }

        /// <summary>
        /// Returns the <see cref="Owner"/> value
        /// </summary>
        /// <returns>The <see cref="Owner"/> value</returns>
        protected DomainOfExpertise GetDerivedOwner()
        {
            return this.ElementUsage.Count == 0 ? this.RootElement.Owner : this.ElementUsage.Last().Owner;
        }
        
        /// <summary>
        /// Gets a value indicating whether the current <see cref="NestedElement"/>
        /// is the root of the Nested tree.
        /// </summary>
        public bool IsRootElement { get; internal set; }
    }
}