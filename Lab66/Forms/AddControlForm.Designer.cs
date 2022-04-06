
namespace Lab66
{
    partial class AddControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.create = new System.Windows.Forms.Button();
            this.LabelType = new System.Windows.Forms.RadioButton();
            this.ButtonType = new System.Windows.Forms.RadioButton();
            this.TextBoxType = new System.Windows.Forms.RadioButton();
            this.RadioButtonType = new System.Windows.Forms.RadioButton();
            this.RadioButtonPanel = new System.Windows.Forms.Panel();
            this.TabStopOff = new System.Windows.Forms.RadioButton();
            this.TabStopLabel = new System.Windows.Forms.Label();
            this.TabStopOn = new System.Windows.Forms.RadioButton();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.StyleBox = new System.Windows.Forms.ComboBox();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.BorderOn = new System.Windows.Forms.RadioButton();
            this.BorderOff = new System.Windows.Forms.RadioButton();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.AlignmentBox = new System.Windows.Forms.ComboBox();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.ScrollBarComboBox = new System.Windows.Forms.ComboBox();
            this.TBtextBox = new System.Windows.Forms.TextBox();
            this.TextTBLabel = new System.Windows.Forms.Label();
            this.ScrollBarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButtonPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(474, 258);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(149, 38);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelType.Location = new System.Drawing.Point(341, 13);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(92, 36);
            this.LabelType.TabIndex = 9;
            this.LabelType.Text = "Label";
            this.LabelType.UseVisualStyleBackColor = true;
            this.LabelType.CheckedChanged += new System.EventHandler(this.label_CheckedChanged);
            // 
            // ButtonType
            // 
            this.ButtonType.AutoSize = true;
            this.ButtonType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonType.Location = new System.Drawing.Point(206, 13);
            this.ButtonType.Name = "ButtonType";
            this.ButtonType.Size = new System.Drawing.Size(108, 36);
            this.ButtonType.TabIndex = 8;
            this.ButtonType.Text = "Button";
            this.ButtonType.UseVisualStyleBackColor = true;
            this.ButtonType.CheckedChanged += new System.EventHandler(this.button_CheckedChanged);
            // 
            // TextBoxType
            // 
            this.TextBoxType.AutoSize = true;
            this.TextBoxType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxType.Location = new System.Drawing.Point(471, 13);
            this.TextBoxType.Name = "TextBoxType";
            this.TextBoxType.Size = new System.Drawing.Size(118, 36);
            this.TextBoxType.TabIndex = 10;
            this.TextBoxType.Text = "TextBox";
            this.TextBoxType.UseVisualStyleBackColor = true;
            this.TextBoxType.CheckedChanged += new System.EventHandler(this.textbox_CheckedChanged);
            // 
            // RadioButtonType
            // 
            this.RadioButtonType.AutoSize = true;
            this.RadioButtonType.Checked = true;
            this.RadioButtonType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonType.Location = new System.Drawing.Point(7, 13);
            this.RadioButtonType.Name = "RadioButtonType";
            this.RadioButtonType.Size = new System.Drawing.Size(168, 36);
            this.RadioButtonType.TabIndex = 7;
            this.RadioButtonType.TabStop = true;
            this.RadioButtonType.Text = "RadioButton";
            this.RadioButtonType.UseVisualStyleBackColor = true;
            this.RadioButtonType.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // RadioButtonPanel
            // 
            this.RadioButtonPanel.Controls.Add(this.TabStopOff);
            this.RadioButtonPanel.Controls.Add(this.TabStopLabel);
            this.RadioButtonPanel.Controls.Add(this.TabStopOn);
            this.RadioButtonPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonPanel.Location = new System.Drawing.Point(175, 0);
            this.RadioButtonPanel.Name = "RadioButtonPanel";
            this.RadioButtonPanel.Size = new System.Drawing.Size(202, 145);
            this.RadioButtonPanel.TabIndex = 11;
            // 
            // TabStopOff
            // 
            this.TabStopOff.AutoSize = true;
            this.TabStopOff.Checked = true;
            this.TabStopOff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabStopOff.Location = new System.Drawing.Point(46, 95);
            this.TabStopOff.Name = "TabStopOff";
            this.TabStopOff.Size = new System.Drawing.Size(66, 36);
            this.TabStopOff.TabIndex = 22;
            this.TabStopOff.TabStop = true;
            this.TabStopOff.Text = "off";
            this.TabStopOff.UseVisualStyleBackColor = true;
            // 
            // TabStopLabel
            // 
            this.TabStopLabel.AutoSize = true;
            this.TabStopLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabStopLabel.Location = new System.Drawing.Point(31, 16);
            this.TabStopLabel.Name = "TabStopLabel";
            this.TabStopLabel.Size = new System.Drawing.Size(109, 32);
            this.TabStopLabel.TabIndex = 20;
            this.TabStopLabel.Text = "Tab-Stop";
            // 
            // TabStopOn
            // 
            this.TabStopOn.AutoSize = true;
            this.TabStopOn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabStopOn.Location = new System.Drawing.Point(46, 62);
            this.TabStopOn.Name = "TabStopOn";
            this.TabStopOn.Size = new System.Drawing.Size(64, 36);
            this.TabStopOn.TabIndex = 21;
            this.TabStopOn.Text = "on";
            this.TabStopOn.UseVisualStyleBackColor = true;
            // 
            // CommentBox
            // 
            this.CommentBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentBox.Location = new System.Drawing.Point(28, 139);
            this.CommentBox.MaxLength = 12;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(166, 38);
            this.CommentBox.TabIndex = 12;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(67, 97);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(121, 32);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Comment";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(225, 97);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(72, 32);
            this.ColorLabel.TabIndex = 14;
            this.ColorLabel.Text = "Color";
            // 
            // ColorBox
            // 
            this.ColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Blue",
            "Green",
            "Red"});
            this.ColorBox.Location = new System.Drawing.Point(200, 138);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(128, 39);
            this.ColorBox.TabIndex = 15;
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontLabel.Location = new System.Drawing.Point(400, 97);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(63, 32);
            this.FontLabel.TabIndex = 16;
            this.FontLabel.Text = "Font";
            // 
            // FontBox
            // 
            this.FontBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Items.AddRange(new object[] {
            "Arial",
            "Arial Black",
            "Calibri",
            "Times New Roman",
            "Segoe UI"});
            this.FontBox.Location = new System.Drawing.Point(334, 138);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(211, 39);
            this.FontBox.TabIndex = 17;
            // 
            // BorderLabel
            // 
            this.BorderLabel.AutoSize = true;
            this.BorderLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BorderLabel.Location = new System.Drawing.Point(545, 97);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(86, 32);
            this.BorderLabel.TabIndex = 18;
            this.BorderLabel.Text = "Border";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.StyleBox);
            this.ButtonPanel.Controls.Add(this.StyleLabel);
            this.ButtonPanel.Controls.Add(this.RadioButtonPanel);
            this.ButtonPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPanel.Location = new System.Drawing.Point(643, 81);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(497, 215);
            this.ButtonPanel.TabIndex = 12;
            // 
            // StyleBox
            // 
            this.StyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StyleBox.Items.AddRange(new object[] {
            "Standard",
            "Graphical"});
            this.StyleBox.Location = new System.Drawing.Point(9, 58);
            this.StyleBox.Name = "StyleBox";
            this.StyleBox.Size = new System.Drawing.Size(160, 39);
            this.StyleBox.TabIndex = 21;
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StyleLabel.Location = new System.Drawing.Point(61, 16);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(66, 32);
            this.StyleLabel.TabIndex = 20;
            this.StyleLabel.Text = "Style";
            // 
            // BorderOn
            // 
            this.BorderOn.AutoSize = true;
            this.BorderOn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BorderOn.Location = new System.Drawing.Point(15, 3);
            this.BorderOn.Name = "BorderOn";
            this.BorderOn.Size = new System.Drawing.Size(64, 36);
            this.BorderOn.TabIndex = 19;
            this.BorderOn.Text = "on";
            this.BorderOn.UseVisualStyleBackColor = true;
            // 
            // BorderOff
            // 
            this.BorderOff.AutoSize = true;
            this.BorderOff.Checked = true;
            this.BorderOff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BorderOff.Location = new System.Drawing.Point(15, 38);
            this.BorderOff.Name = "BorderOff";
            this.BorderOff.Size = new System.Drawing.Size(66, 36);
            this.BorderOff.TabIndex = 20;
            this.BorderOff.TabStop = true;
            this.BorderOff.Text = "off";
            this.BorderOff.UseVisualStyleBackColor = true;
            // 
            // LabelPanel
            // 
            this.LabelPanel.Controls.Add(this.AlignmentBox);
            this.LabelPanel.Controls.Add(this.AlignmentLabel);
            this.LabelPanel.Controls.Add(this.textBoxLabel);
            this.LabelPanel.Controls.Add(this.TextLabel);
            this.LabelPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPanel.Location = new System.Drawing.Point(643, 58);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(497, 223);
            this.LabelPanel.TabIndex = 22;
            this.LabelPanel.Visible = false;
            // 
            // AlignmentBox
            // 
            this.AlignmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlignmentBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlignmentBox.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.AlignmentBox.Location = new System.Drawing.Point(318, 84);
            this.AlignmentBox.Name = "AlignmentBox";
            this.AlignmentBox.Size = new System.Drawing.Size(160, 39);
            this.AlignmentBox.TabIndex = 21;
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlignmentLabel.Location = new System.Drawing.Point(328, 39);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(126, 32);
            this.AlignmentLabel.TabIndex = 20;
            this.AlignmentLabel.Text = "Alignment";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLabel.Location = new System.Drawing.Point(19, 80);
            this.textBoxLabel.MaxLength = 100;
            this.textBoxLabel.Multiline = true;
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(276, 133);
            this.textBoxLabel.TabIndex = 21;
            this.textBoxLabel.Text = "Write down a text. Max length = 50.";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(120, 39);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(58, 32);
            this.TextLabel.TabIndex = 20;
            this.TextLabel.Text = "Text";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelType);
            this.panel1.Controls.Add(this.ButtonType);
            this.panel1.Controls.Add(this.TextBoxType);
            this.panel1.Controls.Add(this.RadioButtonType);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(280, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 62);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BorderOn);
            this.panel2.Controls.Add(this.BorderOff);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(551, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 87);
            this.panel2.TabIndex = 24;
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.Controls.Add(this.ScrollBarComboBox);
            this.TextBoxPanel.Controls.Add(this.TBtextBox);
            this.TextBoxPanel.Controls.Add(this.TextTBLabel);
            this.TextBoxPanel.Controls.Add(this.ScrollBarLabel);
            this.TextBoxPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPanel.Location = new System.Drawing.Point(643, 84);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(519, 208);
            this.TextBoxPanel.TabIndex = 25;
            this.TextBoxPanel.Visible = false;
            // 
            // ScrollBarComboBox
            // 
            this.ScrollBarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScrollBarComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrollBarComboBox.FormattingEnabled = true;
            this.ScrollBarComboBox.Items.AddRange(new object[] {
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.ScrollBarComboBox.Location = new System.Drawing.Point(9, 59);
            this.ScrollBarComboBox.Name = "ScrollBarComboBox";
            this.ScrollBarComboBox.Size = new System.Drawing.Size(121, 39);
            this.ScrollBarComboBox.TabIndex = 30;
            // 
            // TBtextBox
            // 
            this.TBtextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBtextBox.Location = new System.Drawing.Point(148, 54);
            this.TBtextBox.MaxLength = 100;
            this.TBtextBox.Multiline = true;
            this.TBtextBox.Name = "TBtextBox";
            this.TBtextBox.Size = new System.Drawing.Size(349, 133);
            this.TBtextBox.TabIndex = 29;
            this.TBtextBox.Text = "Write down a text. Max length = 100.";
            // 
            // TextTBLabel
            // 
            this.TextTBLabel.AutoSize = true;
            this.TextTBLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTBLabel.Location = new System.Drawing.Point(293, 13);
            this.TextTBLabel.Name = "TextTBLabel";
            this.TextTBLabel.Size = new System.Drawing.Size(58, 32);
            this.TextTBLabel.TabIndex = 28;
            this.TextTBLabel.Text = "Text";
            // 
            // ScrollBarLabel
            // 
            this.ScrollBarLabel.AutoSize = true;
            this.ScrollBarLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrollBarLabel.Location = new System.Drawing.Point(14, 13);
            this.ScrollBarLabel.Name = "ScrollBarLabel";
            this.ScrollBarLabel.Size = new System.Drawing.Size(117, 32);
            this.ScrollBarLabel.TabIndex = 26;
            this.ScrollBarLabel.Text = "Scroll-bar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choose control type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "*can be empty";
            // 
            // AddControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BorderLabel);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.create);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.LabelPanel);
            this.Controls.Add(this.TextBoxPanel);
            this.Name = "AddControlForm";
            this.Text = "Add";
            this.RadioButtonPanel.ResumeLayout(false);
            this.RadioButtonPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel RadioButtonPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label TabStopLabel;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Label AlignmentLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Label TextTBLabel;
        private System.Windows.Forms.Label ScrollBarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton LabelType;
        private System.Windows.Forms.RadioButton ButtonType;
        private System.Windows.Forms.RadioButton TextBoxType;
        private System.Windows.Forms.RadioButton RadioButtonType;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.ComboBox StyleBox;
        private System.Windows.Forms.RadioButton BorderOn;
        private System.Windows.Forms.RadioButton BorderOff;
        private System.Windows.Forms.RadioButton TabStopOff;
        private System.Windows.Forms.RadioButton TabStopOn;
        private System.Windows.Forms.ComboBox AlignmentBox;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox TBtextBox;
        private System.Windows.Forms.ComboBox ScrollBarComboBox;
    }
}