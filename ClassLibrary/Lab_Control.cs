using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum ControlColor
    {
        white,
        black,
        blue,
        green,
        red
    }
    public abstract class Lab_Control : IComparable<Lab_Control>
    {
        List<string> fonts = new List<string> { "arial", "arial black", "calibri", "times new roman", "segoe ui" };
        // Field data.
        /// <summary>
        /// Color of the control
        /// </summary>
        public ControlColor Color { get; set; }
        /// <summary>
        /// Font
        /// </summary>
        private string font;
        /// <summary>
        /// Border
        /// </summary>
        public bool Border { get; set; }
        private string comment;

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color">Available colors: white,black,red,blue</param>
        /// <param name="font">Available fonts: Segoe UI, Arial, Arial Black, Times New Roman</param>
        /// <param name="Border">Sets true if border is enabled</param>
        public Lab_Control(string comment = "", ControlColor color = ControlColor.white, string font = "segoe ui", bool Border = true)
        {
            Comment = comment;
            Color = color;
            Font = font;
            this.Border = Border;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Returns string with display stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Color: {0}; Font: {1}; Is a Border enabled: {2}", Color, Font, Border);
        }
        /// <summary>
        /// Shows display stats on the console
        /// </summary>
        public virtual void DisplayStats()
        {
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Font: {0}", Font);
            if (Border == true) Console.WriteLine("Border is enabled.");
            else Console.WriteLine("Border is disabled.");
        }
        public abstract void UseIt();
        #endregion

        #region Properties
        public string Comment
        {
            get { return comment; }
            set
            {
                if (value == null) comment = "";
                else if (value.Length < 20) comment = value;
                else throw new ArgumentException("Length of the comment has to be less than 20");
            }
        }
        public string Font
        {
            get { return font; }
            set
            {
                bool exist = false;
                foreach (var f in fonts)
                {
                    if (value == f)
                    {
                        font = value;
                        exist = true;
                        break;
                    }
                }
                if (exist == false) throw new ArgumentException("Font {0} is not available. Please, change it to 'arial', 'arial black', 'calibri', 'times new roman', 'segoe ui'", value);
            }
        }
        #endregion
        #region Overloaded OPS
        /// <summary>
        /// Equals if types of the objects and all fields are same
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Lab_Control && this is Lab_Control)
            {
                var tmp = (Lab_Control)obj;
                if (tmp.Color == Color && tmp.font == font && tmp.Border == Border)
                {
                    if (obj is Lab_Button && this is Lab_Button)
                    {
                        var tmp1 = (Lab_Button)obj; var tmp2 = (Lab_Button)this;
                        if (tmp1.On_mouse_down == tmp2.On_mouse_down && tmp1.Style == tmp2.Style)
                        {
                            if (obj is Lab_RadioButton && this is Lab_RadioButton)
                            {
                                var tmp11 = (Lab_RadioButton)obj; var tmp22 = (Lab_RadioButton)this;
                                if (tmp11.Tab_stop == tmp22.Tab_stop) return true;
                                return false;
                            }
                            return true;
                        }
                        return false;
                    }
                    else if (obj is Lab_Label && this is Lab_Label)
                    {
                        var tmp1 = (Lab_Label)obj; var tmp2 = (Lab_Label)this;
                        if (tmp1.Alignment == tmp2.Alignment && tmp1.Text == tmp2.Text) return true;
                        return false;
                    }
                    else if (obj is Lab_TextBox && this is Lab_TextBox)
                    {
                        var tmp1 = (Lab_TextBox)obj; var tmp2 = (Lab_TextBox)this;
                        if (tmp1.Scroll_bar == tmp2.Scroll_bar && tmp1.Text == tmp2.Text) return true;
                        return false;
                    }
                    return true;
                }
                return false;
            }
            else return false;
        }
        /// <summary>
        /// Compare Control objects by subclasses(Button < Label < TextBox < RadioButton), by their fields(Text < Alignment for Label; Text < Scroll bar for TextBox; Style < On mouse down check for Button and RadioButton(<Tab stop check) and only then by base class fields(Font<Color<Border)
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Lab_Control other)
        {
            if (this == other) return 0;
            else if (GetNumType(this) != GetNumType(other)) return GetNumType(this).CompareTo(GetNumType(other));
            else
            {
                if (other is Lab_Label)
                {
                    var tmp2 = (Lab_Label)other; var tmp = (Lab_Label)this;
                    if (tmp.Text != tmp2.Text) return tmp.Text.CompareTo(tmp2.Text);
                    else return tmp.Alignment.CompareTo(tmp2.Alignment);
                }
                else if (other is Lab_TextBox)
                {
                    var tmp2 = (Lab_TextBox)other; var tmp = (Lab_TextBox)this;
                    if (tmp.Text != tmp2.Text) return tmp.Text.CompareTo(tmp2.Text);
                    else return tmp.Scroll_bar.CompareTo(tmp2.Scroll_bar);
                }
                else if (other is Lab_Button)
                {
                    var tmp2 = (Lab_Button)other; var tmp = (Lab_Button)this;
                    if (tmp.Style != tmp2.Style) return tmp.Style.CompareTo(tmp2.Style);
                    else return tmp.On_mouse_down.CompareTo(tmp2.On_mouse_down);
                }
                else if (other is Lab_RadioButton)
                {
                    var tmp2 = (Lab_RadioButton)other; var tmp = (Lab_RadioButton)this;
                    if (tmp.Style != tmp2.Style) return tmp.Style.CompareTo(tmp2.Style);
                    else if (tmp.On_mouse_down != tmp2.On_mouse_down) return tmp.On_mouse_down.CompareTo(tmp2.On_mouse_down);
                    else return tmp.Tab_stop.CompareTo(tmp2.Tab_stop);
                }
                else if (font != other.font) return font.CompareTo(other.font);
                else if (Color != other.Color) return Color.CompareTo(other.Color);
                else return Border.CompareTo(other.Border);
            }
        }
        private int GetNumType(Lab_Control obj)
        {
            if (obj is Lab_RadioButton) return 5;
            else if (obj is Lab_Button) return 1;
            else if (obj is Lab_Label) return 2;
            else return 3;
        }
        public static IComparer<Lab_Control> GetTypeColorComparer()
        {
            return new ControlTypeColorComparer();
        }
        public static IComparer<Lab_Control> GetFontComparer()
        {
            return new ControlFontComparer();
        }
        public static bool operator ==(Lab_Control p1, Lab_Control p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Lab_Control p1, Lab_Control p2)
        {
            return !p1.Equals(p2);
        }
        #endregion



    }
}
