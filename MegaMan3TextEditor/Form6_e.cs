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
    public partial class Form6_e : Form {

        string path = "";

        public Form6_e() {
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

                backend.updateROMText(absoluteFilename, 0x15, textBoxE1, 0x1C26C, 1);
                backend.updateROMText(absoluteFilename, 0x10, textBoxE2, 0x1C284, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxE3, 0x1A3BB, 1);
                backend.updateROMText(absoluteFilename, 0x18, textBoxE4, 0x1C297, 1);
                backend.updateROMText(absoluteFilename, 0x16, textBoxE5, 0x1C2B2, 1);
                backend.updateROMText(absoluteFilename, 0x15, textBoxE6, 0x1C2CB, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxE7, 0x1C2E3, 1);
                backend.updateROMText(absoluteFilename, 0x18, textBoxE8, 0x1C2EE, 1);
                backend.updateROMText(absoluteFilename, 0x7, textBoxE9, 0x1C309, 1);
                backend.updateROMText(absoluteFilename, 0x17, textBoxE10, 0x1C313, 1);
                backend.updateROMText(absoluteFilename, 0x14, textBoxE11, 0x1C32D, 1);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form6_e_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxE1, 0x15, 0x1C26C, 1);
                backend.getText(path, textBoxE2, 0x10, 0x1C284, 1);
                backend.getText(path, textBoxE3, 0x8, 0x1A3BB, 1);
                backend.getText(path, textBoxE4, 0x18, 0x1C297, 1);
                backend.getText(path, textBoxE5, 0x16, 0x1C2B2, 1);
                backend.getText(path, textBoxE6, 0x15, 0x1C2CB, 1);
                backend.getText(path, textBoxE7, 0x8, 0x1C2E3, 1);
                backend.getText(path, textBoxE8, 0x18, 0x1C2EE, 1);
                backend.getText(path, textBoxE9, 0x7, 0x1C309, 1);
                backend.getText(path, textBoxE10, 0x17, 0x1C313, 1);
                backend.getText(path, textBoxE11, 0x14, 0x1C32D, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxE1.MaxLength = 0x15;
            textBoxE2.MaxLength = 0x10;
            textBoxE3.MaxLength = 0x8;
            textBoxE4.MaxLength = 0x18;
            textBoxE5.MaxLength = 0x16;
            textBoxE6.MaxLength = 0x15;
            textBoxE7.MaxLength = 0x8;
            textBoxE8.MaxLength = 0x18;
            textBoxE9.MaxLength = 0x7;
            textBoxE10.MaxLength = 0x17;
            textBoxE11.MaxLength = 0x14;
        }
    }
}
