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
    [System.Obsolete("Use Plugins.SeriousGames.Interfaces.GameObjectTracker instead.")]
    public class GameObjectTracker : Plugins.SeriousGames.Interfaces.GameObjectTracker
    {
    };
}

namespace AssetPackage.Plugins.SeriousGames.Interfaces
{
    public class GameObjectTracker : TrackerAsset.ITrackerManager
    {

        private TrackerAsset tracker;

        public void setTracker(TrackerAsset tracker)
        {
            this.tracker = tracker;
        }


        /* GAMEOBJECT */

        public static TrackedGameObjectObjects TrackedGameObject
        {
            get
            {
                if (tgooinstance == null)
                    tgooinstance = new TrackedGameObjectObjects();
                return tgooinstance;
            }
        }

        private static TrackedGameObjectObjects tgooinstance;
        public class TrackedGameObjectObjects
        {
            public ObjectDefinition Enemy { get { return new Definitions.Objects.Enemy(); } }
            public ObjectDefinition Npc { get { return new Definitions.Objects.Npc(); } }
            public ObjectDefinition Item { get { return new Definitions.Objects.Item(); } }
            public ObjectDefinition GameObject { get { return new Definitions.Objects.GameObject(); } }
        }

        /// <summary>
        /// Player interacted with a game object.
        /// Type = GameObject 
        /// </summary>
        /// <param name="gameobjectId">Reachable identifier.</param>
        public void Interacted(string gameobjectId)
        {
            if (tracker.Utils.check<TargetXApiException>(gameobjectId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Interacted()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(TrackedGameObject.GameObject, gameobjectId)
                });
            }
        }

        /// <summary>
        /// Player interacted with a game object.
        /// </summary>
        /// <param name="gameobjectId">TrackedGameObject identifier.</param>
        public void Interacted(string gameobjectId, ObjectDefinition type)
        {
            if (tracker.Utils.check<TargetXApiException>(gameobjectId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Interacted()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(type, gameobjectId)
                });
            }
        }

        /// <summary>
        /// Player interacted with a game object.
        /// Type = GameObject 
        /// </summary>
        /// <param name="gameobjectId">Reachable identifier.</param>
        public void Used(string gameobjectId)
        {
            if (tracker.Utils.check<TargetXApiException>(gameobjectId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Used()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(TrackedGameObject.GameObject, gameobjectId)
                });
            }
        }

        /// <summary>
        /// Player interacted with a game object.
        /// </summary>
        /// <param name="gameobjectId">TrackedGameObject identifier.</param>
        public void Used(string gameobjectId, ObjectDefinition type)
        {
            if (tracker.Utils.check<TargetXApiException>(gameobjectId, "xAPI Exception: Target ID is null or empty. Ignoring.", "xAPI Exception: Target ID can't be null or empty."))
            {
                tracker.Trace(new TrackerAsset.TrackerEvent(tracker)
                {
                    Event = new TrackerAsset.TrackerEvent.TraceVerb(new Definitions.Verbs.Used()),
                    Target = new TrackerAsset.TrackerEvent.TraceObject(type, gameobjectId)
                });
            }
        }
    }
}