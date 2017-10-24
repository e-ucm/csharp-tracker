using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetPackage.Plugins.SeriousGames.Definitions.Extensions
{
    public class Health : ExtensionDefinition
    {
        public override string getName()
        {
            return "progress";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/extensions/health";
        }
    }

    public class Position : ExtensionDefinition
    {
        public override string getName()
        {
            return "health";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/extensions/position";
        }
    }

    public class Progress : ExtensionDefinition
    {
        public override string getName()
        {
            return "progress";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/extensions/progress";
        }
    }
}
