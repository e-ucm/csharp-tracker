using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetPackage.Plugins.SeriousGames.Definitions.Verbs
{
    public class Initialized : VerbDefinition
    {
        public override string getName()
        {
            return "initialized";
        }

        public override string getDefinition()
        {
            return "http://adlnet.gov/expapi/verbs/initialized";
        }
    }

    public class Progressed : VerbDefinition
    {
        public override string getName()
        {
            return "progressed";
        }

        public override string getDefinition()
        {
            return "http://adlnet.gov/expapi/verbs/progressed";
        }
    }

    public class Completed : VerbDefinition
    {
        public override string getName()
        {
            return "completed";
        }

        public override string getDefinition()
        {
            return "http://adlnet.gov/expapi/verbs/completed";
        }
    }

    public class Accessed : VerbDefinition
    {
        public override string getName()
        {
            return "accessed";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/verbs/accessed";
        }
    }

    public class Skipped : VerbDefinition
    {
        public override string getName()
        {
            return "skipped";
        }

        public override string getDefinition()
        {
            return "http://id.tincanapi.com/verb/skipped";
        }
    }

    public class Selected : VerbDefinition
    {
        public override string getName()
        {
            return "selected";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/adb/verbs/selected";
        }
    }

    public class Unlocked : VerbDefinition
    {
        public override string getName()
        {
            return "unlocked";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/verbs/unlocked";
        }
    }

    public class Interacted : VerbDefinition
    {
        public override string getName()
        {
            return "interacted";
        }

        public override string getDefinition()
        {
            return "http://adlnet.gov/expapi/verbs/interacted";
        }
    }

    public class Used : VerbDefinition
    {
        public override string getName()
        {
            return "used";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/verbs/used";
        }
    }
}

