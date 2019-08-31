﻿// <copyright file="UserRuleVerificationRuleChecker.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2019 RHEA System S.A.
//
//    Author: Sam Gerené
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

namespace CDP4Rules.RuleCheckers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Rules.Common;

    /// <summary>
    /// The purpose of the <see cref="UserRuleVerificationRuleChecker"/> is to execute the rules for instances of type <see cref="UserRuleVerification"/>
    /// </summary>
    [RuleChecker(typeof(UserRuleVerification))]
    public class UserRuleVerificationRuleChecker : RuleChecker
    {
        /// <summary>
        /// Checks whether a referenced <see cref="IDeprecatableThing"/> is deprecated
        /// </summary>
        /// <param name="thing">
        /// The subject <see cref="UserRuleVerification"/>
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{RuleCheckResult}"/> which is empty when no rule violations are encountered.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="thing"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// thrown when <paramref name="thing"/> is not an <see cref="UserRuleVerification"/>
        /// </exception>
        [Rule("MA-0500")]
        public IEnumerable<RuleCheckResult> ChecksWhetherAReferencedDeprecatableThingIsDeprecated(Thing thing)
        {
            var userRuleVerification = this.VerifyThingArgument(thing);

            var results = new List<RuleCheckResult>();
            var ruleAttribute = System.Reflection.MethodBase.GetCurrentMethod().GetCustomAttribute<RuleAttribute>();
            var rule = StaticRuleProvider.QueryRules().Single(r => r.Id == ruleAttribute.Id);

            if (userRuleVerification.Rule.IsDeprecated)
            {
                var result = new RuleCheckResult(thing, rule.Id,
                    $"The referenced Rule {userRuleVerification.Rule.Iid}:{userRuleVerification.Rule.ShortName} of UserRuleVerification.Rule is deprecated",
                    SeverityKind.Warning);
                results.Add(result);
            }

            return results;
        }

        /// <summary>
        /// Checks whether the referenced <see cref="Rule"/> is in the chain of <see cref="ReferenceDataLibrary"/>
        /// </summary>
        /// <param name="thing">
        /// The subject <see cref="UserRuleVerification"/>
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{RuleCheckResult}"/> which is empty when no rule violations are encountered.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="thing"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// thrown when <paramref name="thing"/> is not an <see cref="UserRuleVerification"/>
        /// </exception>
        [Rule("MA-0250")]
        public IEnumerable<RuleCheckResult> CheckWhetherReferencedRuleIsInChainOfRlds(Thing thing)
        {
            var userRuleVerification = this.VerifyThingArgument(thing);

            var results = new List<RuleCheckResult>();
            var ruleAttribute = System.Reflection.MethodBase.GetCurrentMethod().GetCustomAttribute<RuleAttribute>();
            var rule = StaticRuleProvider.QueryRules().Single(r => r.Id == ruleAttribute.Id);

            var engineeringModel = thing.TopContainer as EngineeringModel;

            var modelReferenceDataLibrary = engineeringModel.EngineeringModelSetup.RequiredRdl.Single();
            
            if (!modelReferenceDataLibrary.IsRuleInChainOfRdls(userRuleVerification.Rule))
            {
                var result = new RuleCheckResult(thing, rule.Id, $"The referenced Rule {userRuleVerification.Rule.Iid}:{userRuleVerification.Rule.ShortName} of UserRuleVerification.Rule is not in the chain of Reference Data Libraries", SeverityKind.Error);
                results.Add(result);
            }
            
            return results;
        }

        /// <summary>
        /// Verifies that the <see cref="Thing"/> is of the correct type
        /// </summary>
        /// <param name="thing">
        /// the subject <see cref="Thing"/>
        /// </param>
        /// <returns>
        /// an instance of <see cref="UserRuleVerification"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// thrown when <paramref name="thing"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// thrown when <paramref name="thing"/> is not an <see cref="UserRuleVerification"/>
        /// </exception>
        private UserRuleVerification VerifyThingArgument(Thing thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException($"The {nameof(thing)} may not be null");
            }

            var userRuleVerification = thing as UserRuleVerification;
            if (userRuleVerification == null)
            {
                throw new ArgumentException($"{nameof(thing)} with Iid:{thing.Iid} is not a UserRuleVerification");
            }

            return userRuleVerification;
        }
    }
}