
namespace Lab6
{
    partial class FileNameForm
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
            this.buttonOKFileName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOKFileName
            // 
            this.buttonOKFileName.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOKFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOKFileName.Location = new System.Drawing.Point(141, 77);
            this.buttonOKFileName.Name = "buttonOKFileName";
            this.buttonOKFileName.Size = new System.Drawing.Size(79, 28);
            this.buttonOKFileName.TabIndex = 5;
            this.buttonOKFileName.Text = "OK";
            this.buttonOKFileName.UseVisualStyleBackColor = true;
            this.buttonOKFileName.Click += new System.EventHandler(this.buttonOKFileName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(26, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(267, 30);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileName.Location = new System.Drawing.Point(97, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(175, 29);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "Input file name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = ".txt";
            // 
            // FileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOKFileName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelFileName);
            this.Name = "FileNameForm";
            this.Text = "FileNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOKFileName;
        private System.Windows.Forms.Label labelFileName;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}