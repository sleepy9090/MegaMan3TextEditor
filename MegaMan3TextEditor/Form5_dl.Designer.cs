namespace MegaMan3TextEditor {
    partial class Form5_dl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_dl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDL5 = new System.Windows.Forms.TextBox();
            this.textBoxDL4 = new System.Windows.Forms.TextBox();
            this.textBoxDL3 = new System.Windows.Forms.TextBox();
            this.textBoxDL2 = new System.Windows.Forms.TextBox();
            this.textBoxDL1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDL5);
            this.groupBox1.Controls.Add(this.textBoxDL4);
            this.groupBox1.Controls.Add(this.textBoxDL3);
            this.groupBox1.Controls.Add(this.textBoxDL2);
            this.groupBox1.Controls.Add(this.textBoxDL1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dr. Light";
            // 
            // textBoxDL5
            // 
            this.textBoxDL5.Location = new System.Drawing.Point(6, 123);
            this.textBoxDL5.Name = "textBoxDL5";
            this.textBoxDL5.Size = new System.Drawing.Size(426, 20);
            this.textBoxDL5.TabIndex = 4;
            // 
            // textBoxDL4
            // 
            this.textBoxDL4.Location = new System.Drawing.Point(6, 97);
            this.textBoxDL4.Name = "textBoxDL4";
            this.textBoxDL4.Size = new System.Drawing.Size(426, 20);
            this.textBoxDL4.TabIndex = 3;
            // 
            // textBoxDL3
            // 
            this.textBoxDL3.Location = new System.Drawing.Point(6, 71);
            this.textBoxDL3.Name = "textBoxDL3";
            this.textBoxDL3.Size = new System.Drawing.Size(426, 20);
            this.textBoxDL3.TabIndex = 2;
            // 
            // textBoxDL2
            // 
            this.textBoxDL2.Location = new System.Drawing.Point(6, 45);
            this.textBoxDL2.Name = "textBoxDL2";
            this.textBoxDL2.Size = new System.Drawing.Size(426, 20);
            this.textBoxDL2.TabIndex = 1;
            // 
            // textBoxDL1
            // 
            this.textBoxDL1.Location = new System.Drawing.Point(6, 19);
            this.textBoxDL1.Name = "textBoxDL1";
            this.textBoxDL1.Size = new System.Drawing.Size(426, 20);
            this.textBoxDL1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(375, 172);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // Form5_dl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 202);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5_dl";
            this.Text = "MegaMan III Text Editor";
            this.Load += new System.EventHandler(this.Form5_dl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDL5;
        private System.Windows.Forms.TextBox textBoxDL4;
        private System.Windows.Forms.TextBox textBoxDL3;
        private System.Windows.Forms.TextBox textBoxDL2;
        private System.Windows.Forms.TextBox textBoxDL1;
        private System.Windows.Forms.Button buttonUpdateText;
    }
}