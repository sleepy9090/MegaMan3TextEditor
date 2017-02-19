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
    public partial class Form3_wn : Form {

        string path = "";

        public Form3_wn() {
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

                backend.updateROMText(absoluteFilename, 0x7, textBoxWN1, 0x641E, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxWN2, 0x6429, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxWN3, 0x6439, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxWN4, 0x643F, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxWN5, 0x644C, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxWN6, 0x645E, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxWN7, 0x646E, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxWN8, 0x647E, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxWN9, 0x648A, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxWN10, 0x649A, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxWN11, 0x64A9, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxWN12, 0x64B8, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxWN13, 0x64BE, 0);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_wn_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxWN1, 0x7, 0x641E, 0);
                backend.getText(path, textBoxWN2, 0xD, 0x6429, 0);
                backend.getText(path, textBoxWN3, 0x3, 0x6439, 0);
                backend.getText(path, textBoxWN4, 0x9, 0x643F, 0);
                backend.getText(path, textBoxWN5, 0xE, 0x644C, 0);
                backend.getText(path, textBoxWN6, 0xC, 0x645E, 0);
                backend.getText(path, textBoxWN7, 0xC, 0x646E, 0);
                backend.getText(path, textBoxWN8, 0x8, 0x647E, 0);
                backend.getText(path, textBoxWN9, 0xC, 0x648A, 0);
                backend.getText(path, textBoxWN10, 0xB, 0x649A, 0);
                backend.getText(path, textBoxWN11, 0xC, 0x64A9, 0);
                backend.getText(path, textBoxWN12, 0x3, 0x64B8, 0);
                backend.getText(path, textBoxWN13, 0xB, 0x64BE, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxWN1.MaxLength = 0x7;
            textBoxWN2.MaxLength = 0xD;
            textBoxWN3.MaxLength = 0x3;
            textBoxWN4.MaxLength = 0x9;
            textBoxWN5.MaxLength = 0xE;
            textBoxWN6.MaxLength = 0xC;
            textBoxWN7.MaxLength = 0xC;
            textBoxWN8.MaxLength = 0x8;
            textBoxWN9.MaxLength = 0xC;
            textBoxWN10.MaxLength = 0xB;
            textBoxWN11.MaxLength = 0xC;
            textBoxWN12.MaxLength = 0x3;
            textBoxWN13.MaxLength = 0xB;
        }
    }
}
