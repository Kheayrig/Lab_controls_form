using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Lab_Label : Lab_Control
    {
        /// <summary>
        /// Text of the label
        /// </summary>
        private string text;
        /// <summary>
        /// Alignment: where 0 - left, 1 - right, 2 - center
        /// </summary>
        private int alignment;
        #region Properties
        public string Text
        {
            get { return text; }
            set
            {
                if (string.IsNullOrEmpty(value)) text = "";
                else if (value.Length > 50) throw new ArgumentException("Label have to have text length less than 50!");
                else text = value;
            }
        }
        public int Alignment
        {
            get { return alignment; }
            set
            {
                if (value > 2 || value < 0) throw new ArgumentException("Error! Label's alignment field has to be 0, 1 or 2, where 0 - left, 1 - right, 2 - center.");
                else alignment = value;
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color">Available colors: white,black,red,blue</param>
        /// <param name="font">Available fonts: Segoe UI, Arial, Arial Black, Times New Roman</param>
        /// <param name="Border">Sets true if border is enabled</param>
        /// <param name="text">text</param>
        /// <param name="alignment">Alignment: where 0 - left, 1 - right, 2 - center</param>
        public Lab_Label()
        {
            Alignment = 0;
            Text = "";
        }
        public Lab_Label(string comment = "", ControlColor color = ControlColor.white, string font = "segoe ui", bool Border = true, string text = "", int alignment = 0) : base(comment, color, font, Border)
        {
            Text = text;
            Alignment = alignment;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            string alignment_value;
            if (alignment == 0) alignment_value = "left";
            else if (alignment == 1) alignment_value = "right";
            else alignment_value = "center";
            string str_2 = String.Format("; Text: {0}; Alignment: {1}", this.text, alignment_value);
            return "Label " + base.ToString() + str_2;

        }
        public override void DisplayStats()
        {
            string alignment_value;
            if (alignment == 0) alignment_value = "left";
            else if (alignment == 1) alignment_value = "right";
            else alignment_value = "center";
            base.DisplayStats();
            Console.WriteLine("Text: {0}", text);
            Console.WriteLine("Alignment: {0}", alignment_value);
        }

        /// <summary>
        /// Shows the text of the label on the console.
        /// </summary>
        public override void UseIt()
        {
            Console.WriteLine(text);
        }
        #endregion
    }
}
