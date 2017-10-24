using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssetPackage;
using AssetPackage.Plugins;

namespace AssetPackage
{
    partial class TrackerAsset
    {
        public partial class Extension
        {
            public static ExtensionDefinition Score { get { return new Plugins.xAPIBasic.Extensions.Score(); } }
            public static ExtensionDefinition Success { get { return new Plugins.xAPIBasic.Extensions.Success(); } }
            public static ExtensionDefinition Response { get { return new Plugins.xAPIBasic.Extensions.Response(); } }
            public static ExtensionDefinition Completion { get { return new Plugins.xAPIBasic.Extensions.Completion(); } }
        }
    }
}

namespace AssetPackage.Plugins.xAPIBasic
{
    namespace Extensions
    {
        /* Special extensions, 
        those extensions are stored reparatedly in xAPI, e.g.:
        result: {
            score: {
                raw: <score_value: float>
            },
            success: <success_value: bool>,
            completion: <completion_value: bool>,
            response: <response_value: string>
            ...
        }
        */

        public class Score : ExtensionDefinition
        {
            public override string getName()
            {
                return "score";
            }

            public override string getDefinition()
            {
                return "score";
            }
        }

        public class Success : ExtensionDefinition
        {
            public override string getName()
            {
                return "success";
            }

            public override string getDefinition()
            {
                return "success";
            }
        }

        public class Response : ExtensionDefinition
        {
            public override string getName()
            {
                return "response";
            }

            public override string getDefinition()
            {
                return "response";
            }
        }

        public class Completion : ExtensionDefinition
        {
            public override string getName()
            {
                return "completion";
            }

            public override string getDefinition()
            {
                return "completion";
            }
        }
    }
}