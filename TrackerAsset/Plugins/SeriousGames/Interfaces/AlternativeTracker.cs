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

namespace AssetPackage
{
    [System.Obsolete("Use Plugins.SeriousGames.Interfaces.AccessibleTracker instead.")]
    public class AlternativeTracker : Plugins.SeriousGames.Interfaces.AlternativeTracker
    {
    };
}

namespace AssetPackage.Plugins.SeriousGames.Interfaces
{
    public class AlternativeTracker : TrackerAsset.ITrackerManager
    {

        private TrackerAsset tracker;

        public void setTracker(TrackerAsset tracker)
        {
            this.tracker = tracker;
        }

        /* ALTERNATIVES */

        public static AlternativeObjects Alternative
        {
            get
            {
                if (aoinstance == null)
                    aoinstance = new AlternativeObjects();
                return aoinstance;
            }
        }

        private static AlternativeObjects aoinstance;
        public class AlternativeObjects
        {
            public ObjectDefinition Question { get { return new Definitions.Objects.Question(); } }
            public ObjectDefinition Menu { get { return new Definitions.Objects.Menu(); } }
            public ObjectDefinition Dialog { get { return new Definitions.Objects.Dialog(); } }
            public ObjectDefinition Path { get { return new Definitions.Objects.Path(); } }
            public ObjectDefinition Arena { get { return new Definitions.Objects.Arena(); } }
            public ObjectDefinition Alternative { get { return new Definitions.Objects.Alternative(); } }
        }

        /// <summary>
        /// Player selected an option in a presented alternative
        /// Type = Alternative
        /// </summary>
        /// <param name="alternativeId">Alternative identifier.</param>
        /// <param name="optionId">Option identifier.</param>
        public void Selected(string alternativeId, string optionId)
        {
            bool check = true;

            check &= tracker.Utils.check<TargetXApiException>(alternativeId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty.");
            check &= tracker.Utils.check<ValueExtensionException>(optionId, "xAPI Exception: Selected alternative is null or empty", "xAPI Exception: Selected alternative can't be null or empty");

            if (check)
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Selected()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(Alternative.Alternative, alternativeId),
                    Result = new TrackerAsset.TrackerEvent.TraceResult()
                    {
                        Response = optionId
                    }
                });
            }
        }

        /// <summary>
        /// Player selected an option in a presented alternative
        /// </summary>
        /// <param name="alternativeId">Alternative identifier.</param>
        /// <param name="optionId">Option identifier.</param>
        /// <param name="type">Alternative type.</param>
        public void Selected(string alternativeId, string optionId, ObjectDefinition type)
        {
            bool check = true;

            check &= tracker.Utils.check<TargetXApiException>(alternativeId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty.");
            check &= tracker.Utils.check<ValueExtensionException>(optionId, "xAPI Exception: Selected alternative is null or empty", "xAPI Exception: Selected alternative can't be null or empty");

            if (check)
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Selected()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(type, alternativeId),
                    Result = new TrackerAsset.TrackerEvent.TraceResult()
                    {
                        Response = optionId
                    }
                });
            }
        }

        /// <summary>
        /// Player unlocked an option
        /// Type = Alternative
        /// </summary>
        /// <param name="alternativeId">Alternative identifier.</param>
        /// <param name="optionId">Option identifier.</param>
        public void Unlocked(string alternativeId, string optionId)
        {
            bool check = true;

            check &= tracker.Utils.check<TargetXApiException>(alternativeId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty.");
            check &= tracker.Utils.check<ValueExtensionException>(optionId, "xAPI Exception: Selected alternative is null or empty", "xAPI Exception: Selected alternative can't be null or empty");

            if (check)
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Unlocked()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(Alternative.Alternative, alternativeId),
                    Result = new TrackerAsset.TrackerEvent.TraceResult()
                    {
                        Response = optionId
                    }
                });
            }
        }

        /// <summary>
        /// Player unlocked an option
        /// </summary>
        /// <param name="alternativeId">Alternative identifier.</param>
        /// <param name="optionId">Option identifier.</param>
        /// <param name="type">Alternative type.</param>
        public void Unlocked(string alternativeId, string optionId, ObjectDefinition type)
        {
            bool check = true;

            check &= tracker.Utils.check<TargetXApiException>(alternativeId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty.");
            check &= tracker.Utils.check<ValueExtensionException>(optionId, "xAPI Exception: Selected alternative is null or empty", "xAPI Exception: Selected alternative can't be null or empty");

            if (check)
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Unlocked()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(type, alternativeId),
                    Result = new TrackerAsset.TrackerEvent.TraceResult()
                    {
                        Response = optionId
                    }
                });
            }
        }

    }
}