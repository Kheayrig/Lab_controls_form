using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLoadPrintSort;

namespace ClassLibrary
{
    public class ControlsOfProgram : IEnumerable, ILoadPrintSort
    {
        List<Lab_Control> controls;
        public ControlsOfProgram()
        {
            controls = new List<Lab_Control>();
        }
        public ControlsOfProgram(List<Lab_Control> controls)
        {
            this.controls = new List<Lab_Control>();
            AddRange(controls);
        }
        public ControlsOfProgram(Lab_Control[] controls)
        {
            this.controls = new List<Lab_Control>();
            this.controls = controls.ToList();
        }
        #region Standard
        public void AddRange(List<Lab_Control> obj)
        {
            controls.AddRange(obj);
        }
        public void Add(Lab_Control obj)
        {
            controls.Add(obj);
        }
        public void Clear()
        {
            controls.Clear();
        }
        public bool Contains(Lab_Control obj)
        {
            return controls.Contains(obj);
        }
        public List<Lab_Control> FindAll(Predicate<Lab_Control> match)
        {
            return controls.FindAll(match);
        }
        public int Count()
        {
            return controls.Count();
        }
        #endregion
        #region specific
        public ControlsOfProgram LabelsList()
        {
            var obj = new ControlsOfProgram(FindAll(x => x is Lab_Label));
            return obj;
        }
        public List<Lab_Label> LabelsList(bool l)
        {
            var tmp = FindAll(x => x is Lab_Label);
            var obj = new List<Lab_Label>();
            foreach (var item in tmp)
                obj.Add((Lab_Label)item);
            return obj;
        }
        public ControlsOfProgram RadioButtonsList()
        {
            var obj = new ControlsOfProgram(FindAll(x => x is Lab_RadioButton));
            return obj;
        }
        public List<Lab_RadioButton> RadioButtonsList(bool l)
        {
            var tmp = FindAll(x => x is Lab_RadioButton);
            var obj = new List<Lab_RadioButton>();
            foreach (var item in tmp)
                obj.Add((Lab_RadioButton)item);
            return obj;
        }
        public ControlsOfProgram ButtonsList()
        {
            var obj = new ControlsOfProgram(FindAll(x => x is Lab_Button && !(x is Lab_RadioButton)));
            return obj;
        }
        public List<Lab_Button> ButtonsList(bool l)
        {
            var tmp = FindAll(x => x is Lab_Button);
            var obj = new List<Lab_Button>();
            foreach (var item in tmp)
                obj.Add((Lab_Button)item);
            return obj;
        }

        public ControlsOfProgram TextBoxesList()
        {
            var obj = new ControlsOfProgram(FindAll(x => x is Lab_TextBox));
            return obj;
        }
        public List<Lab_TextBox> TextBoxesList(bool l)
        {
            var tmp = FindAll(x => x is Lab_TextBox);
            var obj = new List<Lab_TextBox>();
            foreach (var item in tmp)
                obj.Add((Lab_TextBox)item);
            return obj;
        }
        public void PrintConsole()
        {
            foreach (var obj in controls)
            {
                Console.WriteLine(obj);
            }
        }
        #endregion

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)controls).GetEnumerator();
        }

        #region IPrintAndSort
        public string[] Print()
        {
            string[] str = new string[controls.Count];
            for (int i = 0; i < controls.Count; i++)
            {
                str[i] = controls[i].ToString();
            }
            return str;
        }

        public void Load(string fileName)
        {
            using (var file = new StreamReader(fileName))
            {
                string[] lines = file.ReadToEnd().Split(new char[] { '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int i = 0;
                foreach (var line in lines)
                {
                    i++;
                    string[] el = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    ControlColor color = ControlColor.white; string font = "segoe ui"; bool border = true; string comment = "";
                    //first 3 field are common for all classes
                    if (el.Length > 3)
                    {
                        if (el[1] != "-") comment = el[1];
                        if (el[2] != "-") color = (ControlColor)Enum.Parse(typeof(ControlColor), el[2].ToLower());
                        if (el[3] != "-") font = el[3].ToLower();
                        if (el[4] != "-")
                        {
                            if (el[4] == "no") border = false;
                            else if (el[4] != "yes") throw new ArgumentException(string.Format("Error! Argument exception! Change {0} to 'yes' or 'no'!", el[4]));
                        }

                    }
                    switch (el[0].ToLower())
                    {
                        case "button":
                            if (el.Length == 6)
                            {
                                ButtonStyle style = ButtonStyle.Standard;
                                if (el[5] != "-")
                                {
                                    if (el[5].ToLower() == "graphical") style = ButtonStyle.Graphical;
                                    else if (el[5].ToLower() != "standard") style = (ButtonStyle)Enum.Parse(typeof(ButtonStyle), el[5].ToLower());
                                }
                                controls.Add(new Lab_Button(comment, color, font, border, style));
                                continue;
                            }
                            else throw new IncompleteDataException("Button", el.Length - 1, i);
                        case "radiobutton":
                            if (el.Length == 7)
                            {
                                ButtonStyle style = ButtonStyle.Standard; bool TAB_stop = false;
                                if (el[5] != "-")
                                {
                                    if (el[5].ToLower() == "graphical") style = ButtonStyle.Graphical;
                                    else if (el[5].ToLower() != "standard") style = (ButtonStyle)Enum.Parse(typeof(ButtonStyle), el[5].ToLower());
                                }
                                if (el[6] != "-")
                                {
                                    if (el[6] == "yes") TAB_stop = true;
                                    else if (el[6] != "no") throw new ArgumentException(string.Format("Error! Argument exception! Change {0} to 'yes' or 'no'!", el[6]));
                                }
                                controls.Add(new Lab_RadioButton(comment, color, font, border, style, TAB_stop));
                                continue;
                            }
                            else throw new IncompleteDataException("RadioButton", el.Length - 1, i);
                        case "label":
                            if (el.Length == 7)
                            {
                                string text = ""; int alignment = 0;
                                if (el[5] != "-") text = el[5];
                                if (el[6] != "-") alignment = int.Parse(el[6]);
                                controls.Add(new Lab_Label(comment, color, font, border, text, alignment));
                                continue;
                            }
                            else throw new IncompleteDataException("Label", el.Length - 1, i);
                        case "textbox":
                            if (el.Length == 6)
                            {
                                int scroll_bar = 0;
                                if (el[5] != "-") scroll_bar = int.Parse(el[5]);
                                controls.Add(new Lab_TextBox(comment, color, font, border, scroll_bar));
                                continue;
                            }
                            else throw new IncompleteDataException("TextBox", el.Length - 1, i);
                        default:
                            throw new NoClassException(el[0], i);
                    }
                }
            }
        }
        public void SortByName()
        {
            controls.Sort(new ControlTypeColorComparer());
        }
        public void SortByValue()
        {
            controls.Sort();
        }
        #endregion
    }
}
