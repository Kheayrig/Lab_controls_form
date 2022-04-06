using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum ButtonStyle
    {
        Standard = 0,
        Graphical = 1
    }
    [Serializable]
    public class Lab_Button : Lab_Control
    {
        /// <summary>
        /// If the button was pressed
        /// </summary>
        public bool On_mouse_down { get; set; } = false; //shows if the button was pressed
        /// <summary>
        /// Style of the button: Graphical or Standard
        /// </summary>
        public ButtonStyle Style { get; set; }
        #region Properties

        #endregion
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color">Available colors: white,black,red,blue</param>
        /// <param name="font">Available fonts: Segoe UI, Arial, Arial Black, Times New Roman</param>
        /// <param name="Border">Sets true if border is enabled</param>
        /// <param name="style">Style of the button: graphical or Standard</param>
        public Lab_Button()
        {
            Style = ButtonStyle.Standard;
        }
        public Lab_Button(string comment = "", ControlColor color = ControlColor.white, string font = "segoe ui", bool Border = true, ButtonStyle style = ButtonStyle.Standard) : base(comment, color, font, Border)
        {
            Style = style;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            string str_2 = String.Format("; Style: {0}; Button was pressed: {1}", this.Style, this.On_mouse_down);
            return "Button " + base.ToString() + str_2;

        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Style: {0}", Style);
            Console.WriteLine("Button was pressed: {0}", On_mouse_down);
        }

        /// <summary>
        /// Changes the value on_mouse_down to true and shows the message, that button was just pressed.
        /// </summary>
        public override void UseIt()
        {
            On_mouse_down = true;
            Console.WriteLine("Button was pressed just now...");
        }
        #endregion

    }
}
