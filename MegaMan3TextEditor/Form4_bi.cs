using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 03/27/2016
 */
namespace MegaMan3TextEditor {
    public partial class Form4_bi : Form {

        string path = "";

        public Form4_bi() {
            InitializeComponent();
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x13, textBoxBI1, 0x6502, 0);
                backend.updateROMText(absoluteFilename, 0x1F, textBoxBI2, 0x6518, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxBI3, 0x653B, 0);
                backend.updateROMText(absoluteFilename, 0x19, textBoxBI4, 0x6549, 0);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxBI1, 0x13, 0x6502, 0); // Getting a "I" here that is not supposed to be there if start is 0x6500 0x15 bytes "67"
                backend.getText(path, textBoxBI2, 0x1F, 0x6518, 0);
                backend.getText(path, textBoxBI3, 0xB, 0x653B, 0);
                backend.getText(path, textBoxBI4, 0x19, 0x6549, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxBI1.MaxLength = 0x15;
            textBoxBI2.MaxLength = 0x1E;
            textBoxBI3.MaxLength = 0xB;
            textBoxBI4.MaxLength = 0x19;
        }

        private void Form4_bi_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }
    }
}
