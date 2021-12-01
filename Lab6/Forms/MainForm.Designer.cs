
namespace Lab6
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fontt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Border = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabStopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Textt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrollBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FontFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BorderFilter = new System.Windows.Forms.ComboBox();
            this.Stylepanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.StyleFilter = new System.Windows.Forms.ComboBox();
            this.Labelpanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AlignmentFilter = new System.Windows.Forms.ComboBox();
            this.SBpanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ScrollBarFilter = new System.Windows.Forms.ComboBox();
            this.TSpanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TabStopFilter = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.Stylepanel.SuspendLayout();
            this.Labelpanel.SuspendLayout();
            this.SBpanel.SuspendLayout();
            this.TSpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadControlsToolStripMenuItem,
            this.addAControlToolStripMenuItem,
            this.showToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadControlsToolStripMenuItem
            // 
            this.loadControlsToolStripMenuItem.Name = "loadControlsToolStripMenuItem";
            this.loadControlsToolStripMenuItem.Size = new System.Drawing.Size(172, 36);
            this.loadControlsToolStripMenuItem.Text = "Load controls";
            this.loadControlsToolStripMenuItem.Click += new System.EventHandler(this.loadControlsToolStripMenuItem_Click);
            // 
            // addAControlToolStripMenuItem
            // 
            this.addAControlToolStripMenuItem.Name = "addAControlToolStripMenuItem";
            this.addAControlToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.addAControlToolStripMenuItem.Text = "Add a control";
            this.addAControlToolStripMenuItem.Click += new System.EventHandler(this.addAControlToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.showToolStripMenuItem.Text = "Clear";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Comment,
            this.Color,
            this.Fontt,
            this.Border,
            this.Style,
            this.TabStopp,
            this.Textt,
            this.Alignment,
            this.ScrollBar});
            this.table.Location = new System.Drawing.Point(12, 43);
            this.table.Name = "table";
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(1299, 421);
            this.table.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 125;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 125;
            // 
            // Fontt
            // 
            this.Fontt.HeaderText = "Font";
            this.Fontt.MinimumWidth = 6;
            this.Fontt.Name = "Fontt";
            this.Fontt.Width = 125;
            // 
            // Border
            // 
            this.Border.HeaderText = "Border";
            this.Border.MinimumWidth = 6;
            this.Border.Name = "Border";
            this.Border.Width = 125;
            // 
            // Style
            // 
            this.Style.HeaderText = "Style";
            this.Style.MinimumWidth = 6;
            this.Style.Name = "Style";
            this.Style.Width = 125;
            // 
            // TabStopp
            // 
            this.TabStopp.HeaderText = "Tab-Stop";
            this.TabStopp.MinimumWidth = 6;
            this.TabStopp.Name = "TabStopp";
            this.TabStopp.Width = 125;
            // 
            // Textt
            // 
            this.Textt.HeaderText = "Text";
            this.Textt.MinimumWidth = 6;
            this.Textt.Name = "Textt";
            this.Textt.Width = 125;
            // 
            // Alignment
            // 
            this.Alignment.HeaderText = "Alignment";
            this.Alignment.MinimumWidth = 6;
            this.Alignment.Name = "Alignment";
            this.Alignment.Width = 125;
            // 
            // ScrollBar
            // 
            this.ScrollBar.HeaderText = "Scroll-Bar";
            this.ScrollBar.MinimumWidth = 6;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Width = 125;
            // 
            // TypeFilter
            // 
            this.TypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeFilter.FormattingEnabled = true;
            this.TypeFilter.Items.AddRange(new object[] {
            "All",
            "RadioButton",
            "Button",
            "Label",
            "TextBox"});
            this.TypeFilter.Location = new System.Drawing.Point(12, 547);
            this.TypeFilter.Name = "TypeFilter";
            this.TypeFilter.Size = new System.Drawing.Size(161, 39);
            this.TypeFilter.TabIndex = 3;
            this.TypeFilter.SelectedIndexChanged += new System.EventHandler(this.TypeFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(180, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color:";
            // 
            // ColorFilter
            // 
            this.ColorFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorFilter.FormattingEnabled = true;
            this.ColorFilter.Items.AddRange(new object[] {
            "All",
            "White",
            "Black",
            "Blue",
            "Green",
            "Red"});
            this.ColorFilter.Location = new System.Drawing.Point(179, 547);
            this.ColorFilter.Name = "ColorFilter";
            this.ColorFilter.Size = new System.Drawing.Size(161, 39);
            this.ColorFilter.TabIndex = 6;
            this.ColorFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Font:";
            // 
            // FontFilter
            // 
            this.FontFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontFilter.FormattingEnabled = true;
            this.FontFilter.Items.AddRange(new object[] {
            "All",
            "Arial",
            "Arial Black",
            "Calibri",
            "Times New Roman",
            "Segoe UI"});
            this.FontFilter.Location = new System.Drawing.Point(346, 547);
            this.FontFilter.Name = "FontFilter";
            this.FontFilter.Size = new System.Drawing.Size(161, 39);
            this.FontFilter.TabIndex = 8;
            this.FontFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(514, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Border:";
            // 
            // BorderFilter
            // 
            this.BorderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BorderFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BorderFilter.FormattingEnabled = true;
            this.BorderFilter.Items.AddRange(new object[] {
            "All",
            "True",
            "False"});
            this.BorderFilter.Location = new System.Drawing.Point(513, 547);
            this.BorderFilter.Name = "BorderFilter";
            this.BorderFilter.Size = new System.Drawing.Size(161, 39);
            this.BorderFilter.TabIndex = 10;
            this.BorderFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Stylepanel
            // 
            this.Stylepanel.Controls.Add(this.label6);
            this.Stylepanel.Controls.Add(this.StyleFilter);
            this.Stylepanel.Location = new System.Drawing.Point(680, 499);
            this.Stylepanel.Name = "Stylepanel";
            this.Stylepanel.Size = new System.Drawing.Size(210, 100);
            this.Stylepanel.TabIndex = 12;
            this.Stylepanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Style:";
            // 
            // StyleFilter
            // 
            this.StyleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StyleFilter.FormattingEnabled = true;
            this.StyleFilter.Items.AddRange(new object[] {
            "All",
            "Standard",
            "Graphical"});
            this.StyleFilter.Location = new System.Drawing.Point(14, 48);
            this.StyleFilter.Name = "StyleFilter";
            this.StyleFilter.Size = new System.Drawing.Size(161, 39);
            this.StyleFilter.TabIndex = 16;
            this.StyleFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Labelpanel
            // 
            this.Labelpanel.Controls.Add(this.label8);
            this.Labelpanel.Controls.Add(this.AlignmentFilter);
            this.Labelpanel.Location = new System.Drawing.Point(603, 499);
            this.Labelpanel.Name = "Labelpanel";
            this.Labelpanel.Size = new System.Drawing.Size(299, 100);
            this.Labelpanel.TabIndex = 20;
            this.Labelpanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(92, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alignment:";
            // 
            // AlignmentFilter
            // 
            this.AlignmentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlignmentFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlignmentFilter.FormattingEnabled = true;
            this.AlignmentFilter.Items.AddRange(new object[] {
            "All",
            "Left",
            "Right",
            "Center"});
            this.AlignmentFilter.Location = new System.Drawing.Point(91, 48);
            this.AlignmentFilter.Name = "AlignmentFilter";
            this.AlignmentFilter.Size = new System.Drawing.Size(161, 39);
            this.AlignmentFilter.TabIndex = 18;
            this.AlignmentFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // SBpanel
            // 
            this.SBpanel.Controls.Add(this.label11);
            this.SBpanel.Controls.Add(this.ScrollBarFilter);
            this.SBpanel.Location = new System.Drawing.Point(683, 491);
            this.SBpanel.Name = "SBpanel";
            this.SBpanel.Size = new System.Drawing.Size(210, 130);
            this.SBpanel.TabIndex = 20;
            this.SBpanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "Scroll-Bar:";
            // 
            // ScrollBarFilter
            // 
            this.ScrollBarFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScrollBarFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrollBarFilter.FormattingEnabled = true;
            this.ScrollBarFilter.Items.AddRange(new object[] {
            "All",
            "None",
            "Horizontal",
            "Vertical",
            "Both"});
            this.ScrollBarFilter.Location = new System.Drawing.Point(11, 56);
            this.ScrollBarFilter.Name = "ScrollBarFilter";
            this.ScrollBarFilter.Size = new System.Drawing.Size(161, 39);
            this.ScrollBarFilter.TabIndex = 16;
            this.ScrollBarFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // TSpanel
            // 
            this.TSpanel.Controls.Add(this.label7);
            this.TSpanel.Controls.Add(this.TabStopFilter);
            this.TSpanel.Location = new System.Drawing.Point(861, 488);
            this.TSpanel.Name = "TSpanel";
            this.TSpanel.Size = new System.Drawing.Size(205, 111);
            this.TSpanel.TabIndex = 21;
            this.TSpanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tab-stop:";
            // 
            // TabStopFilter
            // 
            this.TabStopFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TabStopFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabStopFilter.FormattingEnabled = true;
            this.TabStopFilter.Items.AddRange(new object[] {
            "All",
            "True",
            "False"});
            this.TabStopFilter.Location = new System.Drawing.Point(3, 59);
            this.TabStopFilter.Name = "TabStopFilter";
            this.TabStopFilter.Size = new System.Drawing.Size(161, 39);
            this.TabStopFilter.TabIndex = 20;
            this.TabStopFilter.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BorderFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FontFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeFilter);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TSpanel);
            this.Controls.Add(this.Labelpanel);
            this.Controls.Add(this.Stylepanel);
            this.Controls.Add(this.SBpanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Controls list";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.Stylepanel.ResumeLayout(false);
            this.Stylepanel.PerformLayout();
            this.Labelpanel.ResumeLayout(false);
            this.Labelpanel.PerformLayout();
            this.SBpanel.ResumeLayout(false);
            this.SBpanel.PerformLayout();
            this.TSpanel.ResumeLayout(false);
            this.TSpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ComboBox TypeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FontFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BorderFilter;
        private System.Windows.Forms.Panel Stylepanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StyleFilter;
        private System.Windows.Forms.Panel Labelpanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AlignmentFilter;
        private System.Windows.Forms.Panel SBpanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ScrollBarFilter;
        private System.Windows.Forms.Panel TSpanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TabStopFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fontt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Border;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabStopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Textt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrollBar;
    }
}

