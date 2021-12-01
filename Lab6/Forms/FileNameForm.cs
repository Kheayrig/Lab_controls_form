using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;

namespace Lab6
{
    public partial class FileNameForm : Form
    {
        Action<Exception> log;
        ControlsOfProgram controls;
        Action<ControlsOfProgram> ifItemAdded;
        public FileNameForm(Action<Exception> log, Action<ControlsOfProgram> ifItemAdded, ControlsOfProgram controls)
        {
            InitializeComponent();
            this.log = log;
            this.controls = controls;
            this.ifItemAdded = ifItemAdded;
        }
        private ControlsOfProgram GetFromFile(ControlsOfProgram controls, string fileName)
        {
            using (var file = new StreamReader(fileName))
            {
                string[] lines = file.ReadToEnd().Split(new char[] { '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int i = 0;
                foreach (var line in lines)
                {
                    i++;
                    try
                    {
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
                    catch (ArgumentException e)
                    {
                        MessageBox.Show($"In line №{i}: {e.Message}");
                    }
                    catch (IncompleteDataException e)
                    {
                        MessageBox.Show(e.Info());
                    }
                    catch (NoClassException e)
                    {
                        MessageBox.Show(e.Info());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Something is wrong but we are trying to fix it.");
                        log(e);
                        //MessageBox.Show(e.Message);
                    }
                }
            }
            return controls;
        }
        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonOKFileName.PerformClick();
        }

        private void buttonOKFileName_Click(object sender, EventArgs e)
        {
            string FileName = textBoxName.Text;
            if (!string.IsNullOrEmpty(FileName))
            {
                try
                {
                    controls = GetFromFile(controls, FileName + ".txt");
                    ifItemAdded(controls);
                    Close();
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("You have no access. Please, call the administrator.");
                    log(ex);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File not found.");
                }
                
            }
        }
    }
}
