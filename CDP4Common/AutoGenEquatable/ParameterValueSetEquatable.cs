// ------------------------------------------------------------------------------------------------
// <copyright file="ParameterValueSetEquatable.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2024 Starion Group S.A.
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
// ------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

/* -------------------------------------------- | ---------------------------- | ----------- | ------- *
 | index | name                                 | Type                         | Cardinality | version |
 | -------------------------------------------- | ---------------------------- | ----------- | ------- |
 | 0     | iid                                  | Guid                         |  1..1       |  1.0.0  |
 | 1     | revisionNumber                       | int                          |  1..1       |  1.0.0  |
 | -------------------------------------------- | ---------------------------- | ----------- | ------- |
 | 2     | actualOption                         | Guid                         | 0..1        |  1.0.0  |
 | 3     | actualState                          | Guid                         | 0..1        |  1.0.0  |
 | 4     | computed                             | ValueArray<string>           | 1..*        |  1.0.0  |
 | 5     | formula                              | ValueArray<string>           | 1..*        |  1.0.0  |
 | 6     | manual                               | ValueArray<string>           | 1..*        |  1.0.0  |
 | 7     | published                            | ValueArray<string>           | 1..*        |  1.0.0  |
 | 8     | reference                            | ValueArray<string>           | 1..*        |  1.0.0  |
 | 9     | valueSwitch                          | ParameterSwitchKind          | 1..1        |  1.0.0  |
 | 10    | excludedDomain                       | Guid                         | 0..*        |  1.1.0  |
 | 11    | excludedPerson                       | Guid                         | 0..*        |  1.1.0  |
 | 12    | modifiedOn                           | DateTime                     | 1..1        |  1.1.0  |
 | 13    | thingPreference                      | string                       | 0..1        |  1.2.0  |
 | 14    | actor                                | Guid                         | 0..1        |  1.3.0  |
 * -------------------------------------------- | ---------------------------- | ----------- | ------- */

namespace CDP4Common.DTO.Equatable
{
    using System.Linq;

    using CDP4Common.DTO;

    /// <summary>
    /// An extension class for the <see cref="ParameterValueSet"/> to support the computation
    /// of property based equality
    /// </summary>
    public static class ParameterValueSetEquatable
    {
        /// <summary>
        /// Determines whether 2 <see cref="ParameterValueSet"/> objects are the same
        /// by comparing all the properties
        /// </summary>
        /// <param name="me">
        /// The current <see cref="ParameterValueSet"/>
        /// </param>
        /// <param name="other">
        /// The <see cref="ParameterValueSet"/> that the <paramref name="me"/> is
        /// compared to
        /// </param>
        /// <returns>
        /// returns true when all the properties of the <see cref="ParameterValueSet"/> objects
        /// have the same value
        /// </returns>
        public static bool ArePropertiesEqual(this ParameterValueSet me, ParameterValueSet other)
        {
            if (me == null && other == null) return true;

            if (me == null || other == null) return false;

            if (!me.Iid.Equals(other.Iid)) return false;

            if (!me.RevisionNumber.Equals(other.RevisionNumber)) return false;

            if (me.ActualOption.HasValue != other.ActualOption.HasValue) return false;
            if (!me.ActualOption.Equals(other.ActualOption)) return false;

            if (me.ActualState.HasValue != other.ActualState.HasValue) return false;
            if (!me.ActualState.Equals(other.ActualState)) return false;

            if (!me.Computed.SequenceEqual(other.Computed)) return false;

            if (!me.Formula.SequenceEqual(other.Formula)) return false;

            if (!me.Manual.SequenceEqual(other.Manual)) return false;

            if (!me.Published.SequenceEqual(other.Published)) return false;

            if (!me.Reference.SequenceEqual(other.Reference)) return false;

            if (!me.ValueSwitch.Equals(other.ValueSwitch)) return false;

            if (!me.ExcludedDomain.OrderBy(x => x).SequenceEqual(other.ExcludedDomain.OrderBy(x => x))) return false;

            if (!me.ExcludedPerson.OrderBy(x => x).SequenceEqual(other.ExcludedPerson.OrderBy(x => x))) return false;

            if (!me.ModifiedOn.Equals(other.ModifiedOn)) return false;

            if (me.ThingPreference == null && other.ThingPreference != null) return false;
            if (me.ThingPreference != null && !me.ThingPreference.Equals(other.ThingPreference)) return false;

            if (me.Actor.HasValue != other.Actor.HasValue) return false;
            if (!me.Actor.Equals(other.Actor)) return false;

            return true;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
