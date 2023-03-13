﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExchangeFileHeader.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
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

namespace CDP4JsonFileDal.Json
{
    using System;

    /// <summary>
    /// The ECSS-E-TM-10-25-AnnexC mandated exchange file header.
    /// This is to be included in the root of any exchange archive.
    /// </summary>
    public class ExchangeFileHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeFileHeader"/> class.
        /// </summary>
        public ExchangeFileHeader()
        {
            this.MediaType = "application/ecss-e-tm-10-25+json";
            this.ExchangeFileFormatVersion = "1.0.0";
            this.CreatedOn = new ExchangeDateTime(DateTime.Now);
        }

        /// <summary>
        /// Gets or sets the media type.
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or sets the data model version.
        /// </summary>
        public string DataModelVersion { get; set; }

        /// <summary>
        /// Gets or sets the exchange file format version.
        /// </summary>
        public string ExchangeFileFormatVersion { get; set; }

        /// <summary>
        /// Gets or sets the creator organization.
        /// </summary>
        public OrganizationInfo CreatorOrganization { get; set; }

        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the creator person.
        /// </summary>
        public ExchangeFileInitiator CreatorPerson { get; set; }

        /// <summary>
        /// Gets or sets the created on.
        /// </summary>
        public ExchangeDateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the last modified on.
        /// </summary>
        public ExchangeDateTime LastModifiedOn { get; set; }

        /// <summary>
        /// Gets or sets the remark.
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the extensions.
        /// </summary>
        public string Extensions { get; set; }
    }
}
