using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetPackage.Plugins.SeriousGames.Definitions.Objects
{
    public class Game : ObjectDefinition
    {
        public override string getName()
        {
            return "game";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/serious-game";
        }
    }

    public class Session : ObjectDefinition
    {
        public override string getName()
        {
            return "session";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/session";
        }
    }

    public class Level : ObjectDefinition
    {
        public override string getName()
        {
            return "level";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/level";
        }
    }

    public class Quest : ObjectDefinition
    {
        public override string getName()
        {
            return "quest";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/quest";
        }
    }

    public class Stage : ObjectDefinition
    {
        public override string getName()
        {
            return "stage";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/stage";
        }
    }

    public class Combat : ObjectDefinition
    {
        public override string getName()
        {
            return "combat";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/combat";
        }
    }

    public class StoryNode : ObjectDefinition
    {
        public override string getName()
        {
            return "storynode";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/story-node";
        }
    }

    public class Race : ObjectDefinition
    {
        public override string getName()
        {
            return "race";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/race";
        }
    }

    public class Completable : ObjectDefinition
    {
        public override string getName()
        {
            return "completable";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/completable";
        }
    }

    public class Screen : ObjectDefinition
    {
        public override string getName()
        {
            return "screen";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/screen";
        }
    }

    public class Area : ObjectDefinition
    {
        public override string getName()
        {
            return "area";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/area";
        }
    }

    public class Zone : ObjectDefinition
    {
        public override string getName()
        {
            return "zone";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/zone";
        }
    }

    public class Cutscene : ObjectDefinition
    {
        public override string getName()
        {
            return "cutscene";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/cutscene";
        }
    }

    public class Accessible : ObjectDefinition
    {
        public override string getName()
        {
            return "accessible";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/accessible";
        }
    }

    public class Question : ObjectDefinition
    {
        public override string getName()
        {
            return "question";
        }

        public override string getDefinition()
        {
            return "http://adlnet.gov/expapi/activities/question";
        }
    }

    public class Menu : ObjectDefinition
    {
        public override string getName()
        {
            return "menu";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/menu";
        }
    }

    public class Dialog : ObjectDefinition
    {
        public override string getName()
        {
            return "dialog";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/dialog-tree";
        }
    }

    public class Path : ObjectDefinition
    {
        public override string getName()
        {
            return "path";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/path";
        }
    }

    public class Arena : ObjectDefinition
    {
        public override string getName()
        {
            return "arena";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/arena";
        }
    }

    public class Alternative : ObjectDefinition
    {
        public override string getName()
        {
            return "alternative";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/alternative";
        }
    }

    public class Enemy : ObjectDefinition
    {
        public override string getName()
        {
            return "enemy";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/enemy";
        }
    }

    public class Npc : ObjectDefinition
    {
        public override string getName()
        {
            return "npc";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/non-player-character";
        }
    }

    public class Item : ObjectDefinition
    {
        public override string getName()
        {
            return "item";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/item";
        }
    }

    public class GameObject : ObjectDefinition
    {
        public override string getName()
        {
            return "gameobject";
        }

        public override string getDefinition()
        {
            return "https://w3id.org/xapi/seriousgames/activity-types/game-object";
        }
    }
}
