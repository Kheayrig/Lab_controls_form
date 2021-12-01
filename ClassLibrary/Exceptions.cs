using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// The exception that is thrown when your data has missing field for a class.
    /// </summary>
    [Serializable]
    public class IncompleteDataException : ArgumentException
    {
        private string c_class { get; set; }
        private int default_fields { get; set; }
        private int exist_fields { get; set; }
        private int str { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c_class">current class</param>
        /// <param name="exist_fields">number of existing fields</param>
        public IncompleteDataException(string c_class, int exist_fields, int str)
        {
            this.c_class = c_class;
            switch (c_class.ToLower())
            {
                case "button":
                    default_fields = 4;
                    return;
                case "radiobutton":
                    default_fields = 5;
                    return;
                case "label":
                    default_fields = 5;
                    return;
                case "textbox":
                    default_fields = 4;
                    return;
            }
            this.exist_fields = exist_fields;
            this.str = str;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c_class">current class</param>
        /// <param name="default_fields">default number of fields</param>
        /// <param name="exist_fields">number of existing fields</param>
        public IncompleteDataException(string c_class, int default_fields, int exist_fields, int str)
        {
            this.c_class = c_class;
            this.default_fields = default_fields;
            this.exist_fields = exist_fields;
            this.str = str;
        }
        public IncompleteDataException(string message, Exception inner, string c_class, int exist_fields, int str) : base(message, inner)
        {
            this.c_class = c_class;
            switch (c_class.ToLower())
            {
                case "button":
                    default_fields = 4;
                    return;
                case "radiobutton":
                    default_fields = 5;
                    return;
                case "label":
                    default_fields = 5;
                    return;
                case "textbox":
                    default_fields = 4;
                    return;
            }
            this.exist_fields = exist_fields;
            this.str = str;
        }
        public string Info()
        {
            return ($"Error in {str} line! Incomplete data exception. The object '{c_class}' has to have {default_fields} fields: color, font, border, style, tab-stop. You have only {exist_fields}!");
        }
        protected IncompleteDataException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    /// <summary>
    /// The exception that is thrown when you try to create other class except: Button, RadioButton, Label or TextBox
    /// </summary>
    [Serializable]
    public class NoClassException : ArgumentException
    {
        private string c_class;
        private int str;
        public NoClassException(string c_class, int str)
        {
            this.c_class = c_class;
            this.str = str;
        }
        //public NoClassException() { }
        //public NoClassException(string message) : base(message) { }
        public NoClassException(string message, Exception inner, string c_class, int str) : base(message, inner)
        {
            this.c_class = c_class;
            this.str = str;
        }
        public string Info()
        {
            return ($"Error in {str} line! No class {c_class} exception! Please, check your data. Available classes: Button, Label, RadioButton and TextBox.");
        }
        protected NoClassException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
