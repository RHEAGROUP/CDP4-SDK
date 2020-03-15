﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterBase.cs" company="RHEA System S.A.">
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

namespace CDP4Common.DTO
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The extended part of the auto-generated <see cref="ParameterBase"/>
    /// </summary>
    public partial class ParameterBase
    {
        /// <summary>
        /// Gets the <see cref="Guid"/> of the value-sets of this <see cref="ParameterBase"/>
        /// </summary>
        /// <remarks>
        /// This is a convenience method to retrieve <see cref="Parameter.ValueSet"/>, 
        /// <see cref="ParameterOverride.ValueSet"/> or <see cref="ParameterSubscription.ValueSet"/>
        /// </remarks>
        public IEnumerable<Guid> ValueSets
        {
            get
            {
                var parameter = this as Parameter;
                if (parameter != null)
                {
                    return parameter.ValueSet;
                }

                var parameterOverride = this as ParameterOverride;
                if (parameterOverride != null)
                {
                    return parameterOverride.ValueSet;
                }

                var subscription = (ParameterSubscription)this;
                return subscription.ValueSet;
            }
        }
    }
}