using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetPackage.Plugins
{
    /// <summary>
    /// Interface for verb definition declaration
    /// </summary>
    public abstract class Definition
    {
        public abstract string getName();
        public abstract string getDefinition();

        public bool isThis(string name)
        {
            return name.ToLower() == getName().ToLower();
        }
    }

    public abstract class VerbDefinition : Definition { }

    public abstract class ObjectDefinition : Definition { }

    public abstract class ExtensionDefinition : Definition { }

    public class GenericVerbDefinition : VerbDefinition
    {
        private string name = "";
        private string definition = "";

        private GenericVerbDefinition() {}

        public GenericVerbDefinition(string name)
        {
            this.name = name;
            this.definition = name;
        }

        public GenericVerbDefinition(string name, string definition)
        {
            this.name = name;
            this.definition = definition;
        }

        public override string getDefinition()
        {
            return this.definition;
        }

        public override string getName()
        {
            return this.name;
        }
    }

    public class GenericObjectDefinition : ObjectDefinition
    {
        private string name = "";
        private string definition = "";

        private GenericObjectDefinition() { }

        public GenericObjectDefinition(string name)
        {
            this.name = name;
            this.definition = name;
        }

        public GenericObjectDefinition(string name, string definition)
        {
            this.name = name;
            this.definition = definition;
        }

        public override string getDefinition()
        {
            return this.definition;
        }

        public override string getName()
        {
            return this.name;
        }
    }

    public class GenericExtensionDefinition : ExtensionDefinition
    {
        private string name = "";
        private string definition = "";

        private GenericExtensionDefinition() { }

        public GenericExtensionDefinition(string name)
        {
            this.name = name;
            this.definition = name;
        }

        public GenericExtensionDefinition(string name, string definition)
        {
            this.name = name;
            this.definition = definition;
        }

        public override string getDefinition()
        {
            return this.definition;
        }

        public override string getName()
        {
            return this.name;
        }
    }
}
