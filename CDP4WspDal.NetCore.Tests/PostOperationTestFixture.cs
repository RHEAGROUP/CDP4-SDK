﻿#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PostOperationTestFixture.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2018 RHEA System S.A.
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
#endregion

namespace CDP4WspDal.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using CDP4Common;
    using CDP4Common.MetaInfo;
    using CDP4JsonSerializer;
    using CDP4Dal.Operations;
    using CDP4WspDal.Tests.Helper;
    using Newtonsoft.Json;
    using NUnit.Framework;

    [TestFixture]
    public class PostOperationTestFixture
    {
        private Cdp4JsonSerializer serializer;

        [SetUp]
        public void Setup()
        {
            var metamodel = new MetaDataProvider();
            this.serializer = new Cdp4JsonSerializer(metamodel, new Version(1, 1, 0));
        }

        [Test]
        public void Verify_that_deserialization_of_Post_Operation_does_not_throw_an_exception()
        {
            var response = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "TestData/PostOperation.json"));
            using (var stream = StreamHelper.GenerateStreamFromString(response))
            {
                Assert.DoesNotThrow(() => this.serializer.Deserialize<TestPostOperation>(stream));
            }
        }

        private class TestPostOperation : PostOperation
        {
            public override void ConstructFromOperation(Operation operation)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Gets or sets the collection of DTOs to delete.
            /// </summary>
            [JsonProperty("_delete")]
            public override List<ClasslessDTO> Delete { get; set; }

            /// <summary>
            /// Gets or sets the collection of DTOs to create.
            /// </summary>
            [JsonProperty("_create")]
            public override List<CDP4Common.DTO.Thing> Create { get; set; }

            /// <summary>
            /// Gets or sets the collection of DTOs to update.
            /// </summary>
            [JsonProperty("_update")]
            public override List<ClasslessDTO> Update { get; set; }

            /// <summary>
            /// Gets or sets the collection of DTOs to update.
            /// </summary>
            [JsonProperty("_copy")]
            public override List<ClasslessDTO> Copy { get; set; }
        }
    }
}
