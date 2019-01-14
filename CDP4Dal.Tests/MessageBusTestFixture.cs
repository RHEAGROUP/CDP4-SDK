﻿#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBusTestFixture.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2019 RHEA System S.A.
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

namespace CDP4Dal.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CDP4Common.SiteDirectoryData;
    using CDP4Dal.DAL;
    using CDP4Dal.Events;
    using Moq;
    using NUnit.Framework;
    using ElementUsage = CDP4Common.EngineeringModelData.ElementUsage;
    using MeasurementUnit = CDP4Common.SiteDirectoryData.MeasurementUnit;
    using Person = CDP4Common.SiteDirectoryData.Person;
    using SiteDirectory = CDP4Common.DTO.SiteDirectory;
    using Thing = CDP4Common.CommonData.Thing;

    [TestFixture]
    public class MessageBusTestFixture
    {
        private Uri uri;
        private int messagesReceivedCounter;

        private List<Thing> cache;

        private List<CDP4Common.DTO.Thing> testInput;
        private CDP4Common.DTO.Person person;
        private CDP4Common.DTO.Person person2;

        private CDP4Common.DTO.ConversionBasedUnit conversionBasedUnitType;
        private CDP4Common.DTO.LinearConversionUnit linearConversionUnitType;
        private CDP4Common.DTO.PrefixedUnit prefixedUnitType;
        private CDP4Common.DTO.DerivedUnit derivedUnitType;
        private CDP4Common.DTO.SimpleUnit simpleUnitUnitType;

        [SetUp]
        public void SetUp()
        {
            this.uri = new Uri("http://www.rheagroup.com");
            this.cache = new List<Thing>();
            this.testInput = new List<CDP4Common.DTO.Thing>();

            this.person = new CDP4Common.DTO.Person(Guid.NewGuid(), 0) { Surname = "test", Password = "test2", IsActive = true };
            this.person2 = new CDP4Common.DTO.Person(Guid.NewGuid(), 0) { Surname = "test2", Password = "test4", IsActive = true };
            var phone1 = new CDP4Common.DTO.TelephoneNumber(Guid.NewGuid(), 0) { Value = "123" };
            phone1.VcardType.Add(VcardTelephoneNumberKind.HOME);
            var phone2 = new CDP4Common.DTO.TelephoneNumber(Guid.NewGuid(), 0) { Value = "456" };
            phone2.VcardType.Add(VcardTelephoneNumberKind.WORK);
            var phone3 = new CDP4Common.DTO.TelephoneNumber(Guid.NewGuid(), 0) { Value = "789" };
            phone3.VcardType.Add(VcardTelephoneNumberKind.FAX);

            this.linearConversionUnitType = new CDP4Common.DTO.LinearConversionUnit(Guid.NewGuid(), 0);
            this.prefixedUnitType = new CDP4Common.DTO.PrefixedUnit(Guid.NewGuid(), 0);
            this.derivedUnitType = new CDP4Common.DTO.DerivedUnit(Guid.NewGuid(), 0);
            this.simpleUnitUnitType = new CDP4Common.DTO.SimpleUnit(Guid.NewGuid(), 0);

            this.person.TelephoneNumber.Add(phone1.Iid);
            this.person.TelephoneNumber.Add(phone2.Iid);
            this.person.TelephoneNumber.Add(phone3.Iid);

            this.testInput.Add(new SiteDirectory(Guid.NewGuid(), 1));
            this.testInput.Add(this.person);
            this.testInput.Add(this.person2);
            this.testInput.Add(phone1);
            this.testInput.Add(phone2);
            this.testInput.Add(phone3);

            this.testInput.Add(this.linearConversionUnitType);
            this.testInput.Add(this.prefixedUnitType);
            this.testInput.Add(this.derivedUnitType);
            this.testInput.Add(this.simpleUnitUnitType);
        }

        [TearDown]
        public void TearDown()
        {
            CDPMessageBus.Current.ClearSubscriptions();
            this.cache.Clear();
            this.messagesReceivedCounter = 0;
        }

        [Test]
        public async Task VerifyThatSubscribeToTypeGetsEvent()
        {
            // The ViewModel subscribes to events
            CDPMessageBus.Current.Listen<ObjectChangedEvent>(typeof(Person)).Subscribe(x => this.OnEvent(x.ChangedThing));

            // The assembler will raise and event when something changes
            var assembler = new Assembler(this.uri);
            await assembler.Synchronize(this.testInput);

            // Check that the viewModel catches the event
            Assert.AreEqual(2, this.cache.Count);

            Assert.NotNull(this.cache.FirstOrDefault(p => p.Iid == this.person.Iid));
            Assert.NotNull(this.cache.FirstOrDefault(p => p.Iid == this.person2.Iid));
        }

        [Test]
        public async Task VerifyThatSubscribeToTypeSuperclassGetsEvent()
        {
            // The ViewModel subscribes to events
            CDPMessageBus.Current.Listen<ObjectChangedEvent>(typeof(MeasurementUnit)).Subscribe(x => this.OnEvent(x.ChangedThing));

            // The assembler will raise and event when something changes
            var assembler = new Assembler(this.uri);
            await assembler.Synchronize(this.testInput);

            // Check that the viewModel catches the event
            Assert.AreEqual(4, this.cache.Count);

            Assert.NotNull(this.cache.FirstOrDefault(p => p.Iid == this.linearConversionUnitType.Iid));
            Assert.IsTrue(this.cache.Any(p => p.Iid == this.prefixedUnitType.Iid));
            Assert.IsTrue(this.cache.Any(p => p.Iid == this.derivedUnitType.Iid));
            Assert.IsTrue(this.cache.Any(p => p.Iid == this.simpleUnitUnitType.Iid));
        }

        [Test]
        public void VerifyThatSubscribeToObjectWorks()
        {
            var eu1 = new CDP4Common.EngineeringModelData.ElementUsage();
            var eu2 = new CDP4Common.EngineeringModelData.ElementUsage();

            // The ViewModel subscribes to events
            CDPMessageBus.Current.Listen<ObjectChangedEvent>(eu1).Subscribe(x => this.OnEvent(x.ChangedThing));

            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu1), target: eu1);
            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu1), target: eu1.GetType());

            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu2), target: eu2);
            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu2), target: eu2.GetType());

            Assert.AreEqual(1, this.cache.Count);

            this.cache.Clear();

            CDPMessageBus.Current.Listen<ObjectChangedEvent>(typeof(ElementUsage)).Subscribe(x => this.OnEvent(x.ChangedThing));

            CDPMessageBus.Current.SendObjectChangeEvent(eu1, EventKind.Updated);
            CDPMessageBus.Current.SendObjectChangeEvent(eu2, EventKind.Updated);

            // 3 because the top subscription still exists.
            Assert.AreEqual(3, this.cache.Count);
        }

        //TODO: remove this test from this project. This project should not have a dependency on CDP4Composition
        [Test]
        public void VerifyThatAfterClearHasBeenCalledNoMoreSubscriptionsAreReceived()
        {
            var eu1 = new CDP4Common.EngineeringModelData.ElementUsage();
            CDPMessageBus.Current.Listen<ObjectChangedEvent>(eu1).Subscribe(x => this.OnEvent(x.ChangedThing));
            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu1), target: eu1);
            Assert.AreEqual(1, this.cache.Count);

            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu1), target: eu1);
            Assert.AreEqual(2, this.cache.Count);

            CDPMessageBus.Current.ClearSubscriptions();
            CDPMessageBus.Current.SendMessage(new ObjectChangedEvent(eu1), target: eu1);
            Assert.AreEqual(2, this.cache.Count);
        }

        [Test]
        public void VerifyThatAnyObjectCanServeAsAMessageAndBeReceived()
        {
            var mockedDal = new Mock<IDal>();
            var credentials = new Credentials(" ", " ", this.uri);
            var session = new Session(mockedDal.Object, credentials);
            var sessionEvent = new SessionEvent(session, SessionStatus.Open);
            Assert.AreEqual(0, this.messagesReceivedCounter);
            CDPMessageBus.Current.Listen<SessionEvent>().Subscribe(x => this.MesssageReceived());                   
            CDPMessageBus.Current.SendMessage(sessionEvent, null, null);
            Assert.AreEqual(1, this.messagesReceivedCounter);
        }

        [Test]
        public void VerifyNullEventTypeTargetIsFalse()
        {
            var ett = new EventTypeTarget(typeof(SessionEvent));

            Guid? test = null;

            Assert.IsFalse(ett.Equals(test));
        }

        private void MesssageReceived()
        {
            this.messagesReceivedCounter++;
        }

        private void OnEvent(Thing thing)
        {
            this.cache.Add(thing);
        }
    }
}