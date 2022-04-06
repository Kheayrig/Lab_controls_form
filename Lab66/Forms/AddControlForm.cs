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

namespace Lab66
{
    public partial class AddControlForm : Form
    {
        Action<ControlsOfProgram> ifItemAdded; 
        Action<Exception> log; 
        ControlsOfProgram controls;
        public AddControlForm(Action<ControlsOfProgram> ifItemAdded, Action<Exception> log, ControlsOfProgram controls)
        {
            InitializeComponent();
            ColorBox.SelectedIndex = 0;
            FontBox.SelectedIndex = 4;
            StyleBox.SelectedIndex = 0;
            ScrollBarComboBox.SelectedIndex = 0;
            StyleBox.SelectedIndex = 0;
            AlignmentBox.SelectedIndex = 0;
            this.log = log;
            this.ifItemAdded = ifItemAdded;
            this.controls = controls;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButtonType.Checked)
            {
                RadioButtonPanel.Visible = true;
                LabelPanel.Visible = false;
                TextBoxPanel.Visible = false;
                ButtonPanel.Visible = true; 
            }
            
        }
        private void textbox_CheckedChanged(object sender, EventArgs e)
        {
            if (TextBoxType.Checked)
            {
                RadioButtonPanel.Visible = false;
                LabelPanel.Visible = false;
                TextBoxPanel.Visible = true;
                ButtonPanel.Visible = false;
            }
        }
        private void button_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonType.Checked)
            {
                RadioButtonPanel.Visible = false;
                LabelPanel.Visible = false;
                TextBoxPanel.Visible = false;
                ButtonPanel.Visible = true;    
            }
        }
        private void label_CheckedChanged(object sender, EventArgs e)
        {
            if (LabelType.Checked)
            {
                RadioButtonPanel.Visible = false;
                LabelPanel.Visible = true;
                TextBoxPanel.Visible = false;
                ButtonPanel.Visible = false;                
            }
        }


        private bool AddItem(ControlsOfProgram controls, Action<Exception> log)
        {
            try
            {
                ControlColor color = ControlColor.white;
                if (ColorBox.SelectedItem.ToString().ToLower() == "black") color = ControlColor.black;
                else if (ColorBox.SelectedItem.ToString().ToLower() == "blue") color = ControlColor.blue;
                else if (ColorBox.SelectedItem.ToString().ToLower() == "green") color = ControlColor.green;
                else if (ColorBox.SelectedItem.ToString().ToLower() == "red") color = ControlColor.red;
                //create new control
                if (RadioButtonType.Checked)
                {
                    bool border = false, TAB_stop = false; ButtonStyle style = ButtonStyle.Standard;
                    if (StyleBox.SelectedItem.ToString() == "Graphical") style = ButtonStyle.Graphical;
                    if (BorderOn.Checked) border = true;
                    if (TabStopOn.Checked) TAB_stop = true;
                    var tmp = new Lab_RadioButton(CommentBox.Text, color, FontBox.SelectedItem.ToString().ToLower(), border, style, TAB_stop);
                    controls.Add(tmp);
                    return true;
                }
                else if (ButtonType.Checked)
                {
                    bool border = false; ButtonStyle style = ButtonStyle.Standard;
                    if (StyleBox.SelectedItem.ToString() == "Graphical") style = ButtonStyle.Graphical;
                    if (BorderOn.Checked) border = true;
                    var tmp = new Lab_Button(CommentBox.Text, color, FontBox.SelectedItem.ToString().ToLower(), border, style);
                    controls.Add(tmp);
                    return true;
                }
                else if (LabelType.Checked)
                {
                    bool border = false;
                    if (BorderOn.Checked) border = true;
                    var tmp = new Lab_Label(CommentBox.Text, color, FontBox.SelectedItem.ToString().ToLower(), border, textBoxLabel.Text, AlignmentBox.SelectedIndex);
                    controls.Add(tmp);
                    return true;
                }
                else if (TextBoxType.Checked)
                {
                    bool border = false; var tmp = new Lab_TextBox(CommentBox.Text, color, FontBox.SelectedItem.ToString().ToLower(), border, ScrollBarComboBox.SelectedIndex);
                    tmp.Text = TBtextBox.Text;
                    controls.Add(tmp);
                    return true;
                }
                return false;
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show("Something is wrong but we are trying to fix it.");
                log(err);
                //MessageBox.Show(err.Message);
            }
            return false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (AddItem(controls, log))
            {
                ifItemAdded(controls);
                Close();
            }
        }
    }
}
