using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Lab_RadioButton : Lab_Button
    {
        //Field data
        /// <summary>
        /// Shows if you can use 'TAB' key to give the focus to this control: true or false
        /// </summary>
        public bool Tab_stop { get; set; }
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
        /// <param name="Tab_stop">true if you can use 'TAB' key to give the focus to this control</param>
        public Lab_RadioButton()
        {
            Tab_stop = false;
        }
        public Lab_RadioButton(string comment = "", ControlColor color = ControlColor.white, string font = "segoe ui", bool Border = true, ButtonStyle style = ButtonStyle.Standard, bool Tab_stop = false) : base(comment, color, font, Border, style)
        {
            this.Tab_stop = Tab_stop;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return string.Format("RadioButton Color: {0}; Font: {1}; Is a Border enabled: {2}; Style: {3}; This element is chosen: {4}; You can use 'TAB' key to give the focus to this control: {5}", Color, Font, Border, Style, On_mouse_down, Tab_stop);
        }
        public override void DisplayStats()
        {
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Font: {0}", Font);
            if (Border == true) Console.WriteLine("Border is enabled.");
            else Console.WriteLine("Border is disabled.");
            Console.WriteLine("Style: {0}", Style);
            Console.WriteLine("This element is chosen: {0}", On_mouse_down);
            Console.WriteLine("You can use 'TAB' key to give the focus to this control: {0}", Tab_stop);
        }

        /// <summary>
        /// Change the value of radio button from true to false and the way round.
        /// </summary>
        public override void UseIt()
        {
            if (On_mouse_down == false)
            {
                Console.WriteLine("This element is chosen now...");
                On_mouse_down = true;
            }
            else
            {
                Console.WriteLine("This element isn't chosen now...");
                On_mouse_down = false;
            }
        }
        #endregion
    }
}
