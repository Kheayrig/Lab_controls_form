using System;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab66
{
    public partial class MainForm : Form
    {
        //ControlContainer controls = new ControlContainer();
        public ControlsOfProgram controls = new ControlsOfProgram();
        public string Filter = "binary files (*.dat)|*.dat|xml files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.dat, *.xml, *.json)|*.dat;*.xml;*.json";
        public string FileName;
        Action<Exception> log;
        Action<ControlsOfProgram> ifItemAdded;
        Predicate<Lab_RadioButton> returnList; //unnecessary as i think
        public MainForm()
        {
            InitializeComponent();
            ResetFilterIndexes(controls);
            ifItemAdded += InvalidateTable;
            ifItemAdded += ResetFilterIndexes;
            log = LogToFile;

        }
        private void addAControlToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var form = new AddControlForm(ifItemAdded, log, controls);
            form.Show();           
        }
        private void ResetFilterIndexes(ControlsOfProgram controls)
        {
            TypeFilter.SelectedIndex = 0;
            AlignmentFilter.SelectedIndex = 0;
            BorderFilter.SelectedIndex = 0;
            ColorFilter.SelectedIndex = 0;
            FontFilter.SelectedIndex = 0;
            ScrollBarFilter.SelectedIndex = 0;
            StyleFilter.SelectedIndex = 0;
            TabStopFilter.SelectedIndex = 0;
        }
        private void ResetFilterIndexes()
        {
            AlignmentFilter.SelectedIndex = 0;
            BorderFilter.SelectedIndex = 0;
            ColorFilter.SelectedIndex = 0;
            FontFilter.SelectedIndex = 0;
            ScrollBarFilter.SelectedIndex = 0;
            StyleFilter.SelectedIndex = 0;
            TabStopFilter.SelectedIndex = 0;
        }
        private void loadControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FileNameForm(log, ifItemAdded, controls);
            form.Show();
        }
        private void AddToTable(object item)
        {
            
            if (item is Lab_Label)
            {
                //0 - left, 1 - right, 2 - center
                var c = (Lab_Label)item; string algnmt;
                if (c.Alignment == 0) algnmt = "Left";
                else if (c.Alignment == 1) algnmt = "Right";
                else algnmt = "Center";
                table.Rows.Add("Label", c.Comment, c.Color, c.Font, c.Border, null, null, c.Text, algnmt);
            }
            else if (item is Lab_RadioButton)
            {
                var c = (Lab_RadioButton)item;
                table.Rows.Add("RadioButton", c.Comment, c.Color, c.Font, c.Border, c.Style, c.Tab_stop);
            }
            else if (item is Lab_Button)
            {
                var c = (Lab_Button)item;
                table.Rows.Add("Button", c.Comment, c.Color, c.Font, c.Border, c.Style);
            }
            else if (item is Lab_TextBox)
            {
                var c = (Lab_TextBox)item; string scrlbr;
                //0 - None, 1 - Horizontal, 2 - Vertical, 3 - Both
                if (c.Scroll_bar == 0) scrlbr = "None";
                else if (c.Scroll_bar == 1) scrlbr = "Horizontal";
                else if (c.Scroll_bar == 2) scrlbr = "Vertical";
                else scrlbr = "Both";
                table.Rows.Add("TextBox", c.Comment, c.Color, c.Font, c.Border, null, null, c.Text, null, scrlbr);
            }
        }
        
        private void LogToFile(Exception e)
        {
            File.AppendAllLines("log.txt", new string[] { e.GetType().ToString(), e.Message, e.StackTrace, e.TargetSite.Name, e.InnerException == null ? "" : e.InnerException.Message });
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            controls = new ControlsOfProgram();
            ResetFilterIndexes(controls);
        }

        private void TypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            OffAllTypePanels();
            ResetFilterIndexes();

            ControlsOfProgram tmp = new ControlsOfProgram();
            if (TypeFilter.SelectedIndex == 1)
            {
                //rb
                TSpanel.Visible = true;
                Stylepanel.Visible = true;
                tmp = controls.RadioButtonsList();
            }
            else if (TypeFilter.SelectedIndex == 2)
            {
                //b
                Stylepanel.Visible = true;
                tmp = controls.ButtonsList();
            }
            else if (TypeFilter.SelectedIndex == 3)
            {
                //l
                Labelpanel.Visible = true;
                tmp = controls.LabelsList();
            }
            else if (TypeFilter.SelectedIndex == 4)
            {
                //tb
                SBpanel.Visible = true;
                tmp = controls.TextBoxesList();
            }
            else tmp = controls;
            InvalidateTable(tmp);

        }

        private void OffAllTypePanels()
        {
            Labelpanel.Visible = false;
            TSpanel.Visible = false;
            Stylepanel.Visible = false;
            SBpanel.Visible = false;
        }
        private void InvalidateTable(ControlsOfProgram tmp)
        {
            table.Rows.Clear();
            if (tmp.Count() != 0)
            {
                foreach (var item in tmp)
                {
                    AddToTable(item);
                }
            }
        }


        private bool RadioButtonCheck(Lab_RadioButton match)
        {
            if (TabStopFilter.SelectedIndex != 0 && StyleFilter.SelectedIndex != 0)
                return match.Style.ToString() == StyleFilter.SelectedItem.ToString() && match.Tab_stop.ToString() == TabStopFilter.SelectedItem.ToString();
            else if (TabStopFilter.SelectedIndex != 0) return match.Tab_stop.ToString() == TabStopFilter.SelectedItem.ToString();
            else if (StyleFilter.SelectedIndex != 0) return match.Style.ToString() == StyleFilter.SelectedItem.ToString();
            return true;
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlsOfProgram tmp = new ControlsOfProgram();
            returnList = RadioButtonCheck;
            tmp = controls;
            if (ColorFilter.SelectedIndex != 0)
            {
                switch (ColorFilter.SelectedIndex)
                {
                    case 1:
                        tmp = new ControlsOfProgram(tmp.FindAll(x => x.Color == ControlColor.white));
                        break;
                    case 2:
                        tmp = new ControlsOfProgram(tmp.FindAll(x => x.Color == ControlColor.black));
                        break;
                    case 3:
                        tmp = new ControlsOfProgram(tmp.FindAll(x => x.Color == ControlColor.blue));
                        break;
                    case 4:
                        tmp = new ControlsOfProgram(tmp.FindAll(x => x.Color == ControlColor.green));
                        break;
                    case 5:
                        tmp = new ControlsOfProgram(tmp.FindAll(x => x.Color == ControlColor.red));
                        break;
                }
            }
            if(FontFilter.SelectedIndex != 0)
            {
                tmp = new ControlsOfProgram(tmp.FindAll(x => x.Font == FontFilter.SelectedItem.ToString().ToLower()));
            }
            if(BorderFilter.SelectedIndex != 0)
            {
                tmp = new ControlsOfProgram(tmp.FindAll(x => x.Border.ToString() == BorderFilter.SelectedItem.ToString()));
            }
            if(TypeFilter.SelectedIndex == 0)
            {
                InvalidateTable(tmp);
                return;
            }
            //type
            switch (TypeFilter.SelectedIndex)
            {
                case 1:
                    var tmp1 = tmp.RadioButtonsList(true);
                    if (TabStopFilter.SelectedIndex != 0 || StyleFilter.SelectedIndex != 0)
                        tmp1 = tmp1.FindAll(returnList);
                    table.Rows.Clear();
                    if (tmp1.Count != 0)
                    {
                        foreach (var item in tmp1)
                        {
                            AddToTable(item);
                        }
                    }
                    break;
                case 2:
                    var tmp2 = tmp.ButtonsList(true);
                    if (StyleFilter.SelectedIndex != 0) tmp2 = tmp2.FindAll(x => x.Style.ToString() == StyleFilter.SelectedItem.ToString());
                    table.Rows.Clear();
                    if (tmp2.Count != 0)
                    {
                        foreach (var item in tmp2)
                        {
                            AddToTable(item);
                        }
                    }
                    break;
                case 3:
                    var tmp3 = tmp.LabelsList(true);
                    if (AlignmentFilter.SelectedIndex != 0) tmp3 = tmp3.FindAll(x => x.Alignment.ToString() == (AlignmentFilter.SelectedIndex-1).ToString());
                    table.Rows.Clear();
                    if (tmp3.Count != 0)
                    {
                        foreach (var item in tmp3)
                        {
                            AddToTable(item);
                        }
                    }
                    break;
                case 4:
                    var tmp4 = tmp.TextBoxesList(true);
                    if (ScrollBarFilter.SelectedIndex != 0) tmp4 = tmp4.FindAll(x => x.Scroll_bar.ToString() == (ScrollBarFilter.SelectedIndex-1).ToString());
                    table.Rows.Clear();
                    if (tmp4.Count != 0)
                    {
                        foreach (var item in tmp4)
                        {
                            AddToTable(item);
                        }
                    }
                    break;
            }
            
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var binary = new BinaryFormatter();
            var saveBinary = new SaveFileDialog()
            {
                Filter = Filter,
                FilterIndex = 1
            };
            if(saveBinary.ShowDialog() == DialogResult.OK)
            {
                using (var file = new FileStream(saveBinary.FileName, FileMode.Create))
                {
                    binary.Serialize(file, controls);
                }
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var xml = new XmlSerializer(
                typeof(ControlsOfProgram), 
                new Type[] { typeof(Lab_Control), typeof(Lab_Button), typeof(Lab_Label), typeof(Lab_RadioButton), typeof(Lab_TextBox) }
                );
            
            var saveXML = new SaveFileDialog()
            {
                Filter = Filter,
                FilterIndex = 2
            };
            if (saveXML.ShowDialog() == DialogResult.OK)
            {
                using (var file = new FileStream(saveXML.FileName, FileMode.Create))
                {
                    xml.Serialize(file, controls);              
                }
            }
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveJson = new SaveFileDialog()
            {
                Filter = Filter,
                FilterIndex = 3
            };
            if (saveJson.ShowDialog() == DialogResult.OK)
            {
                var json = JsonSerializer.Serialize(controls);
                using (var file = new StreamWriter(saveJson.FileName))
                {
                    file.Write(json);
                }
            }
        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openToDecode = new OpenFileDialog() { Filter = Filter, FilterIndex = 4, };
            if (openToDecode.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(openToDecode.FileName);

                if (extension == ".dat")
                {
                    var binary = new BinaryFormatter();
                    using (var file = File.OpenRead(openToDecode.FileName))
                    {
                        var tmpControls = binary.Deserialize(file);
                        controls = (ControlsOfProgram)tmpControls;
                    }
                    InvalidateTable(controls);
                }
                else if (extension == ".xml")
                {
                    var xml = new XmlSerializer(
                    typeof(ControlsOfProgram),
                    new Type[] { typeof(Lab_Control), typeof(Lab_Button), typeof(Lab_Label), typeof(Lab_RadioButton), typeof(Lab_TextBox) }
                    );
                    using (var file = File.OpenRead(openToDecode.FileName))
                    {
                        var tmpControls = xml.Deserialize(file);
                        controls = (ControlsOfProgram)tmpControls;
                    }
                    InvalidateTable(controls);
                }
                else if (extension == ".json")
                {
                    controls = JsonSerializer.Deserialize<ControlsOfProgram>(openToDecode.FileName);
                }
                else MessageBox.Show("Wrong file format");
            }
        }
    }
}
