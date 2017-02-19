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
    public partial class Form5_dl : Form {

        string path = "";

        public Form5_dl() {
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

                backend.updateROMText(absoluteFilename, 0x15, textBoxDL1, 0x1C215, 1);
                backend.updateROMText(absoluteFilename, 0x11, textBoxDL2, 0x1C22D, 1);
                backend.updateROMText(absoluteFilename, 0xB, textBoxDL3, 0x1C241, 1);
                backend.updateROMText(absoluteFilename, 0x12, textBoxDL4, 0x1C24E, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxDL5, 0x1C263, 1);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_dl_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxDL1, 0x15, 0x1C215, 1);
                backend.getText(path, textBoxDL2, 0x11, 0x1C22D, 1);
                backend.getText(path, textBoxDL3, 0xB, 0x1C241, 1);
                backend.getText(path, textBoxDL4, 0x12, 0x1C24E, 1);
                backend.getText(path, textBoxDL5, 0x6, 0x1C263, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxDL1.MaxLength = 0x15;
            textBoxDL2.MaxLength = 0x11;
            textBoxDL3.MaxLength = 0xB;
            textBoxDL4.MaxLength = 0x12;
            textBoxDL5.MaxLength = 0x6;
        }
    }
}
