﻿#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedItemTestFixture.cs" company="RHEA System S.A.">
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

namespace CDP4Common.Tests.Types
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;
    using NUnit.Framework;

    /// <summary>
    /// Suite of tests for the <see cref="OrderedItem"/> class
    /// </summary>
    [TestFixture]
    public class OrderedItemTestFixture
    {
        [Test]
        public void VerifyThatMoveItemUpdatesTheIndex()
        {
            var key = 1;

            var value1 = new OrderedItem { K = key, V = "one" };
            var m = value1.M;

            value1.MoveItem(1, 1);
            Assert.AreEqual(m, value1.M);
            Assert.AreEqual(key, value1.K);
        }

        [Test]
        public void VerifyThatEqualityReturnsTrueWhenKeysAndValuesAreEqual()
        {
            var key = 1;
            var value1 = new OrderedItem { K = key, V = "one" };
            var value2 = new OrderedItem { K = key, V = "one" };

            Assert.AreEqual(value1, value2);
        }

        [Test]
        public void VerifyThatEqualityReturnsTrueWhenKeysAndValuesAreEqualWithGuid()
        {
            var key = 1;
            var value = Guid.NewGuid();
            var value1 = new OrderedItem { K = key, V = value };
            var value2 = new OrderedItem { K = key, V = value };

            Assert.AreEqual(value1, value2);
        }

        [Test]
        public void VerifyThatEqualityReturnsTrueWhenKeysAndValuesAreEqualWithThing()
        {
            var key = 1;
            var value = new Person();
            var value1 = new OrderedItem { K = key, V = value };
            var value2 = new OrderedItem { K = key, V = value };

            Assert.AreEqual(value1, value2);
        }

        [Test]
        public void VerifyThatEqualityReturnsTrueWhenReferencesAreEqual()
        {
            var key = 1;
            var value1 = new OrderedItem { K = key, V = "one" };
            var value2 = value1;
            Assert.IsTrue(value1.Equals(value2));
        }

        [Test]
        public void VerifyThatOrderedItemIsNeverEqualToNull()
        {
            var key = 1;
            var value1 = new OrderedItem { K = key, V = "one" };
            Assert.IsFalse(value1.Equals(null));
        }

        [Test]
        public void VerifyThatListOfOrderedItemComparisonWorks()
        {
            var item1 = new OrderedItem {K = 123, V = 1};
            var item2 = new OrderedItem {K = 456, V = 1};
            var item3 = new OrderedItem {K = 789, V = 2};
            var item4 = new OrderedItem {K = 123456, V = 2};

            var item1b = new OrderedItem {K = 123, V = 1};
            var item2b = new OrderedItem {K = 456, V = 1};
            var item3b = new OrderedItem {K = 789, V = 2};
            var item4b = new OrderedItem {K = 123456, V = 2};

            var item5 = new OrderedItem {K = 123456, V = 3};

            var list1 = new List<OrderedItem> {item1, item2, item3, item4};
            var list2 = new List<OrderedItem>{item1b, item2b, item3b, item4b};
            list2.Add(item5);

            Assert.AreEqual(4, list1.Intersect(list2).Count());
        }
    }
}
