/*
 * Copyright 2016 Open University of the Netherlands
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * This project has received funding from the European Union’s Horizon
 * 2020 research and innovation programme under grant agreement No 644187.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.Collections;
using AssetPackage;
using AssetPackage.Utils;
using AssetPackage.Exceptions;
using System;
using AssetPackage.Plugins;

namespace AssetPackage
{
    [Obsolete("Use Plugins.SeriousGames.Interfaces.AccessibleTracker instead.")]
    public class AccessibleTracker : Plugins.SeriousGames.Interfaces.AccessibleTracker {
    };
}

namespace AssetPackage.Plugins.SeriousGames.Interfaces
{
    public class AccessibleTracker : TrackerAsset.ITrackerManager
    {

        private TrackerAsset tracker;

        public void setTracker(TrackerAsset tracker)
        {
            this.tracker = tracker;
        }

        /* ACCESSIBLES */

        public static AccessibleObjects Accessible
        {
           get {
                if (aoinstance == null)
                    aoinstance = new AccessibleObjects();
                return aoinstance; 
            }
        }

        private static AccessibleObjects aoinstance;
        public class AccessibleObjects
        {
            public ObjectDefinition Screen { get { return new Definitions.Objects.Screen(); } }
            public ObjectDefinition Area { get { return new Definitions.Objects.Area(); } }
            public ObjectDefinition Zone { get { return new Definitions.Objects.Zone(); } }
            public ObjectDefinition Cutscene { get { return new Definitions.Objects.Cutscene(); } }
            public ObjectDefinition Accessible { get { return new Definitions.Objects.Accessible(); } }
        }

        /// <summary>
        /// Player accessed a reachable.
        /// Type = Accessible 
        /// </summary>
        /// <param name="reachableId">Reachable identifier.</param>
        public void Accessed(string reachableId)
        {
            if (tracker.Utils.check<TargetXApiException>(reachableId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Accessed()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(Accessible.Accessible, reachableId)
                });
            }
        }

        /// <summary>
        /// Player accessed a reachable.
        /// </summary>
        /// <param name="reachableId">Reachable identifier.</param>
        /// <param name="type">Reachable type.</param>
        public void Accessed(string reachableId, ObjectDefinition type)
        {
            if (tracker.Utils.check<TargetXApiException>(reachableId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Accessed()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(type, reachableId)
                });
            }
        }

        /// <summary>
        /// Player skipped a reachable.
        /// Type = Accessible
        /// </summary>
        /// <param name="reachableId">Reachable identifier.</param>
        public void Skipped(string reachableId)
        {
            if (tracker.Utils.check<TargetXApiException>(reachableId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Skipped()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(Accessible.Accessible, reachableId)
                });
            }
        }

        /// <summary>
        /// Player skipped a reachable.
        /// </summary>
        /// <param name="reachableId">Reachable identifier.</param>
        /// <param name="type">Reachable type.</param>
        public void Skipped(string reachableId, ObjectDefinition type)
        {
            if (tracker.Utils.check<TargetXApiException>(reachableId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Skipped()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(type, reachableId)
                });
            }
        }
    }
}