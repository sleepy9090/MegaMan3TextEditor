namespace MegaMan3TextEditor {
    partial class Form2_pg {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_pg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPG10 = new System.Windows.Forms.TextBox();
            this.textBoxPG9 = new System.Windows.Forms.TextBox();
            this.textBoxPG7 = new System.Windows.Forms.TextBox();
            this.textBoxPG6 = new System.Windows.Forms.TextBox();
            this.textBoxPG4 = new System.Windows.Forms.TextBox();
            this.textBoxPG2 = new System.Windows.Forms.TextBox();
            this.textBoxPG1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPG10);
            this.groupBox1.Controls.Add(this.textBoxPG9);
            this.groupBox1.Controls.Add(this.textBoxPG7);
            this.groupBox1.Controls.Add(this.textBoxPG6);
            this.groupBox1.Controls.Add(this.textBoxPG4);
            this.groupBox1.Controls.Add(this.textBoxPG2);
            this.groupBox1.Controls.Add(this.textBoxPG1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password/Gameover";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxPG10
            // 
            this.textBoxPG10.Location = new System.Drawing.Point(324, 45);
            this.textBoxPG10.Name = "textBoxPG10";
            this.textBoxPG10.Size = new System.Drawing.Size(100, 20);
            this.textBoxPG10.TabIndex = 6;
            // 
            // textBoxPG9
            // 
            this.textBoxPG9.Location = new System.Drawing.Point(6, 45);
            this.textBoxPG9.Name = "textBoxPG9";
            this.textBoxPG9.Size = new System.Drawing.Size(206, 20);
            this.textBoxPG9.TabIndex = 4;
            // 
            // textBoxPG7
            // 
            this.textBoxPG7.Location = new System.Drawing.Point(218, 45);
            this.textBoxPG7.Name = "textBoxPG7";
            this.textBoxPG7.Size = new System.Drawing.Size(100, 20);
            this.textBoxPG7.TabIndex = 5;
            // 
            // textBoxPG6
            // 
            this.textBoxPG6.Location = new System.Drawing.Point(324, 19);
            this.textBoxPG6.Name = "textBoxPG6";
            this.textBoxPG6.Size = new System.Drawing.Size(100, 20);
            this.textBoxPG6.TabIndex = 3;
            // 
            // textBoxPG4
            // 
            this.textBoxPG4.Location = new System.Drawing.Point(218, 19);
            this.textBoxPG4.Name = "textBoxPG4";
            this.textBoxPG4.Size = new System.Drawing.Size(100, 20);
            this.textBoxPG4.TabIndex = 2;
            // 
            // textBoxPG2
            // 
            this.textBoxPG2.Location = new System.Drawing.Point(112, 19);
            this.textBoxPG2.Name = "textBoxPG2";
            this.textBoxPG2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPG2.TabIndex = 1;
            // 
            // textBoxPG1
            // 
            this.textBoxPG1.Location = new System.Drawing.Point(6, 19);
            this.textBoxPG1.Name = "textBoxPG1";
            this.textBoxPG1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPG1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(361, 98);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // Form2_pg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 127);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2_pg";
            this.Text = "MegaMan III Text Editor";
            this.Load += new System.EventHandler(this.Form2_pg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPG10;
        private System.Windows.Forms.TextBox textBoxPG9;
        private System.Windows.Forms.TextBox textBoxPG7;
        private System.Windows.Forms.TextBox textBoxPG6;
        private System.Windows.Forms.TextBox textBoxPG4;
        private System.Windows.Forms.TextBox textBoxPG2;
        private System.Windows.Forms.TextBox textBoxPG1;
        private System.Windows.Forms.Button buttonUpdateText;
    }
}