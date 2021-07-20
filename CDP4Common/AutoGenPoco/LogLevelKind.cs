// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogLevelKind.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2021 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Alexander van Delft, Nathanael Smiechowski
//
//    This file is part of COMET-SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
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
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.CommonData
{
    /// <summary>
    /// enumeration datatype that defines the possible levels for a LogEntry
    /// </summary>
    public enum LogLevelKind
    {
        /// <summary>
        /// designation of a trace level log entry used to mark and annotate very low level detailed event logging for software development or problem fixing purposes
        /// </summary>
        TRACE,

        /// <summary>
        /// designation of a debug level log entry used to mark and annotate low level detailed event logging for software development or problem fixing purposes
        /// </summary>
        DEBUG,

        /// <summary>
        /// designation of an information level log entry used to mark and annotate event logging for informationNote: Information level LogEntry instances are typically produced automatically by executing applications.
        /// </summary>
        INFO,

        /// <summary>
        /// designation of a user level log entry used to mark and annotate event logging with user defined contentNote: User level LogEntry instances are typically produced on demand by a human user and its <i>content</i> is typically manually written. Its use is similar to the log message used upon commit or check-in in a configuration control system.
        /// </summary>
        USER,
    }
}
