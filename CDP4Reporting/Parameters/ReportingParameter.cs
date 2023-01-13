﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportingParameter.cs" company="RHEA System S.A.">
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

namespace CDP4Reporting.Parameters
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// class to be used to define dynamic report parameters in the Code editor of <see cref="Views.ReportDesigner"/>.
    /// </summary>
    public class ReportingParameter : IReportingParameter
    {
        /// <summary>
        /// The name prefix that every report parameter gets in the report designer.
        /// </summary>
        public const string NamePrefix = "dyn_";

        /// <summary>
        /// Gets or sets the name of the <see cref="IReportingParameter"/>.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the "calculated" parameter name to be used in the <see cref="Views.ReportDesigner"/>.
        /// </summary>
        public string ParameterName => $"{NamePrefix}{this.Name.Replace(" ", "_")}";

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the parameter.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Gets or sets the visibility of the report parameter.
        /// </summary>
        public bool Visible { get; set; } = true;

        /// <summary>
        /// Gets a <see cref="Dictionary{TKey,TValue}"/> that contains lookup values for a drop down report parameter.
        /// </summary>
        public Dictionary<object, string> LookUpValues { get; } = new Dictionary<object, string>();

        /// <summary>
        /// Gets or sets a value wheter multiple values should be selectable from the list of lookup values
        /// </summary>
        public bool IsMultiValue { get; set; }

        /// <summary>
        /// Gets or sets the default value of the report parameter.
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the filterexpression to be used for this report parameter.
        /// </summary>
        public string FilterExpression { get; set; }

        /// <summary>
        /// Indicates wether the <see cref="DefaultValue"/> should forcibly be written to existing report parameters
        /// </summary>
        public bool ForceDefaultValue { get; set; }

        /// <summary>
        /// Adds a lookup value to the <see cref="LookUpValues"/> property.
        /// </summary>
        /// <param name="value">
        /// The value. Could be any data type.
        /// </param>
        /// <param name="displayValue">
        /// The display value in the report designer.
        /// </param>
        /// <returns>
        /// The <see cref="IReportingParameter"/>.
        /// </returns>
        public IReportingParameter AddLookupValue(object value, string displayValue)
        {
            this.LookUpValues.Add(value, displayValue);

            return this;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReportingParameter"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter.
        /// </param>
        /// <param name="type">
        /// The data <see cref="Type"/> of the parameter.
        /// </param>
        /// <param name="defaultValue">
        /// The default value of the parameter.
        /// </param>
        /// <param name="filterExpression">
        /// A filter expression to be used on the report's DataSource.
        /// </param>
        public ReportingParameter(string name, Type type, object defaultValue, string filterExpression = "")
        {
            this.Name = name;
            this.Type = type;
            this.DefaultValue = defaultValue;

            this.ForceDefaultValue = defaultValue != null && this.GetDefault(type) != defaultValue;

            this.FilterExpression = filterExpression;
        }

        /// <summary>
        /// Get the default value of a specific <see cref="Type"/>
        /// </summary>
        /// <param name="type">The <see cref="Type"/></param>
        /// <returns>The default value</returns>
        private object GetDefault(Type type)
        {
            return this.GetType()
                .GetMethod(nameof(this.GetDefaultGeneric), BindingFlags.NonPublic | BindingFlags.Instance)
                ?.MakeGenericMethod(type).Invoke(this, null);
        }

        /// <summary>
        /// Get the default value of a specific generic type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <returns>The default value</returns>
        private T GetDefaultGeneric<T>()
        {
            return default;
        }
    }
}
