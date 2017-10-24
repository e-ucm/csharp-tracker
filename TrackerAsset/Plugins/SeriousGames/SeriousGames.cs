using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssetPackage;
using AssetPackage.Plugins;
using AssetPackage.Plugins.SeriousGames.Interfaces;
using AssetPackage.Plugins.SeriousGames.Definitions;
using AssetPackage.Exceptions;

namespace AssetPackage
{

    partial class TrackerAsset
    {
        #region SubTracker Fields

        /// <summary>
        /// Instance of AccessibleTracker
        /// </summary>
        private AccessibleTracker accessibletracker;

        /// <summary>
        /// Instance of AlternativeTracker
        /// </summary>
        private AlternativeTracker alternativetracker;

        /// <summary>
        /// Instance of CompletableTracker
        /// </summary>
        private CompletableTracker completabletracker;

        /// <summary>
        /// Instance of GameObjectTracker
        /// </summary>
        private GameObjectTracker gameobjecttracer;

        #endregion SubTracker Fields

        #region SubTracker Properties

        /// <summary>
        /// Access point for Accessible Traces generation
        /// </summary>
        public AccessibleTracker Accessible
        {
            get
            {
                if (accessibletracker == null)
                {
                    accessibletracker = new AccessibleTracker();
                    accessibletracker.setTracker(this);
                }

                return accessibletracker;
            }
        }

        /// <summary>
        /// Access point for Alternative Traces generation
        /// </summary>
        public AlternativeTracker Alternative
        {
            get
            {
                if (alternativetracker == null)
                {
                    alternativetracker = new AlternativeTracker();
                    alternativetracker.setTracker(this);
                }

                return alternativetracker;
            }
        }

        /// <summary>
        /// Access point for Completable Traces generation
        /// </summary>
        public CompletableTracker Completable
        {
            get
            {
                if (completabletracker == null)
                {
                    completabletracker = new CompletableTracker();
                    completabletracker.setTracker(this);
                }

                return completabletracker;
            }
        }

        /// <summary>
        /// Access point for Completable Traces generation
        /// </summary>
        public GameObjectTracker GameObject
        {
            get
            {
                if (gameobjecttracer == null)
                {
                    gameobjecttracer = new GameObjectTracker();
                    gameobjecttracer.setTracker(this);
                }

                return gameobjecttracer;
            }
        }

        /// <summary>
        /// Access point for Accessible Traces generation
        /// </summary>
        [Obsolete("Use TrackerAsset.Accessible")]
        public AccessibleTracker accessible
        {
            get { return Accessible; }
        }

        /// <summary>
        /// Access point for Alternative Traces generation
        /// </summary>
        [Obsolete("Use TrackerAsset.Alternative")]
        public AlternativeTracker alternative
        {
            get { return Alternative; }
        }

        /// <summary>
        /// Access point for Completable Traces generation
        /// </summary>
        [Obsolete("Use TrackerAsset.Completable")]
        public CompletableTracker completable
        {
            get { return Completable; }
        }

        /// <summary>
        /// Access point for Completable Traces generation
        /// </summary>
        [Obsolete("Use TrackerAsset.GameObject")]
        public GameObjectTracker trackedGameObject
        {
            get { return GameObject; }
        }

        #endregion SubTracker Properties

        #region Methods

        /// <summary>
        /// Sets the progress of the action. 
        /// </summary>
        /// <param name="progress">Progress. (Recomended between 0 and 1)</param>
        public void setProgress(float progress)
        {
            if (progress < 0 || progress > 1)
                Log(Severity.Warning, "Tracker: Progress recommended between 0 and 1 (Current: " + progress + ")");

            setVar(new Plugins.SeriousGames.Definitions.Extensions.Progress().getDefinition(), progress);
        }

        /// <summary>
        /// Sets the coords where the trace takes place.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="z">The z coordinate.</param>
        public void setPosition(float x, float y, float z)
        {
            if (float.IsNaN(x) || float.IsNaN(y) || float.IsNaN(z))
            {
                if (StrictMode)
                    throw new ValueExtensionException("Tracker: x, y or z cant be null.");
                else
                {
                    Log(Severity.Information, "Tracker: x, y or z cant be null, ignoring.");
                    return;
                }
            }

            addExtension(new Plugins.SeriousGames.Definitions.Extensions.Position().getDefinition(), "{\"x\":" + x + ", \"y\": " + y + ", \"z\": " + z + "}");
        }

        /// <summary>
        /// Sets the health of the player's character when the trace occurs. 
        /// </summary>
        /// <param name="health">Health.</param>
        public void setHealth(float health)
        {
            if (Utils.check<ValueExtensionException>(health, "Tracker: Health cant be null, ignoring.", "Tracker: Health cant be null."))
                addExtension(new Plugins.SeriousGames.Definitions.Extensions.Health().getDefinition(), health);
        }

        #endregion Methods

        [Obsolete("Use verbs from their own namespace")]
        public partial class Verb
        {
            public static VerbDefinition Initialized
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Initialized(); } }

            public static VerbDefinition Progressed
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Progressed(); } }

            public static VerbDefinition Completed
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Completed(); } }

            public static VerbDefinition Accessed
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Accessed(); } }

            public static VerbDefinition Skipped
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Skipped(); } }

            public static VerbDefinition Selected
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Selected(); } }

            public static VerbDefinition Unlocked
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Unlocked(); } }

            public static VerbDefinition Interacted
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Interacted(); } }

            public static VerbDefinition Used
            { get { return new Plugins.SeriousGames.Definitions.Verbs.Used(); } }

        }
    }
}