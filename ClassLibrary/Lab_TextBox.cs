using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lab_TextBox : Lab_Control
    {
        /// <summary>
        /// Your text in the TextBox
        /// </summary>
        public string Text { get; set; } = "";
        /// <summary>
        /// Shows what scroll bar exists, where 0 - None, 1 - Horizontal, 2 - Vertical, 3 - Both
        /// </summary>
        private int scroll_bar;
        #region Properties
        public int Scroll_bar
        {
            get { return scroll_bar; }
            set
            {
                if (value > 3 || value < 0) throw new ArgumentException("Error! TextBox's scroll bar field has to be 0, 1, 2 or 3, where 0 - None, 1 - Horizontal, 2 - Vertical, 3 - Both.");
                else scroll_bar = value;
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
        /// <param name="scroll_bar">0 - None, 1 - Horizontal, 2 - Vertical, 3 - Both</param>
        public Lab_TextBox(string comment = "", ControlColor color = ControlColor.white, string font = "segoe ui", bool Border = true, int scroll_bar = 0) : base(comment, color, font, Border)
        {
            Scroll_bar = scroll_bar;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            string sb_value;
            if (scroll_bar == 0) sb_value = "none";
            else if (scroll_bar == 1) sb_value = "horizontal";
            else if (scroll_bar == 1) sb_value = "vertical";
            else sb_value = "both";
            string str_2 = String.Format("; Text: {0}; Scroll bar: {1}", this.Text, sb_value);
            return "TextBox " + base.ToString() + str_2;

        }
        public override void DisplayStats()
        {
            string sb_value;
            if (scroll_bar == 0) sb_value = "none";
            else if (scroll_bar == 1) sb_value = "horizontal";
            else if (scroll_bar == 1) sb_value = "vertical";
            else sb_value = "both";
            base.DisplayStats();
            Console.WriteLine("Text: {0}", Text);
            Console.WriteLine("Scroll bar: {0}", sb_value);
        }

        /// <summary>
        /// Sets the text associated with this control
        /// </summary>
        public override void UseIt()
        {
            Console.WriteLine("Write down the text:");
            try
            {
                Text = Console.ReadLine();
            }
            catch (ArgumentNullException)
            {
                Text = "";
            }
        }
        #endregion
    }
}
