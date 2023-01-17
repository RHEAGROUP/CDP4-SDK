﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataCollectorSingleStatePerRowParameter.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft
//
//    This file is part of COMET-SDK Community Edition
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
// </copyright>
// -------------------------------------------------------------------------------------------------------------------------------

namespace CDP4Reporting.DataCollection
{
    using System.Data;
    using System.Linq;

    /// <summary>
    /// Abstract base class from which parameter columns, that result in seperate <see cref="DataRow"/>s per state, need to derive.
    /// </summary>
    public abstract class DataCollectorStateDependentPerRowParameter<TRow, TValue> : DataCollectorParameter<TRow, TValue>, IDataCollectorStateDependentPerRowParameter  where TRow : DataCollectorRow, new()
    {
        /// <summary>
        /// The name of the Parameter Name column
        /// </summary>
        private const string columnParameterName = "ParameterName";

        /// <summary>
        /// The name of the Parameter State column
        /// </summary>
        private const string columnStateName = "ParameterState";

        /// <summary>
        /// The name of the Value column
        /// </summary>
        private const string columnValue = "ParameterValue";

        /// <summary>
        /// Initialize a DataTable so the correct columns will be available when writing state dependent parameter data
        /// </summary>
        /// <param name="table">
        /// The <see cref="DataTable"/>.
        /// </param>
        public void InitializeColumns(DataTable table)
        {
            if (!table.Columns.Contains(columnParameterName))
            {
                table.Columns.Add(columnParameterName, typeof(string));
            }

            if (!table.Columns.Contains(columnStateName))
            {
                table.Columns.Add(columnStateName, typeof(string));
            }

            if (!table.Columns.Contains(columnValue))
            {
                table.Columns.Add(columnValue, typeof(TValue));
            }
        }

        /// <summary>
        /// Populates with data the <see cref="DataTable.Columns"/> associated with this object
        /// in the given <paramref name="row"/>.
        /// </summary>
        /// <param name="table">
        /// The <see cref="DataTable"/> to which the <paramref name="row"/> belongs to.
        /// </param>
        /// <param name="row">
        /// The <see cref="DataRow"/> to be populated.
        /// </param>
        public override void Populate(DataTable table, DataRow row)
        {
            if (this.HasValueSets)
            {
                var valueSet = this.ValueSets.First();

                row[columnParameterName] = this.FieldName;
                row[columnStateName] = valueSet.ActualState?.ShortName;
                row[columnValue] = this.GetValueSetValue(valueSet);
            }
        }
    }
}
