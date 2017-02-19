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
    public partial class Form2_pg : Form {

        string path = "";

        public Form2_pg() {
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

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x10, textBoxPG1, 0x6310, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxPG2, 0x6323, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxPG4, 0x6338, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxPG6, 0x634D, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxPG7, 0x636B, 0);
                backend.updateROMText(absoluteFilename, 0x10, textBoxPG9, 0x64E0, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxPG10, 0x64F3, 0);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_pg_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxPG1, 0x10, 0x6310, 0);
                backend.getText(path, textBoxPG2, 0xB, 0x6323, 0);
                //backend.getText(path, textBoxPG3, 0x3, 0x6330, 0); // should be "END" but showing "NDZ"
                backend.getText(path, textBoxPG4, 0xB, 0x6338, 0);
                //backend.getText(path, textBoxPG5, 0x3, 0x6345, 0); // should be "END" but showing "NDY"
                backend.getText(path, textBoxPG6, 0xD, 0x634D, 0);
                backend.getText(path, textBoxPG7, 0x8, 0x636B, 0);
                //backend.getText(path, textBoxPG8, 0x3, 0x6375, 0); // should be "END" but showing "NDW"
                backend.getText(path, textBoxPG9, 0x10, 0x64E0, 0);
                backend.getText(path, textBoxPG10, 0xB, 0x64F3, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxPG1.MaxLength = 0x10;
            textBoxPG2.MaxLength = 0xB;
            //textBoxPG3.MaxLength = 0x3;
            textBoxPG4.MaxLength = 0xB;
            //textBoxPG5.MaxLength = 0x3;
            textBoxPG6.MaxLength = 0xD;
            textBoxPG7.MaxLength = 0x8;
            //textBoxPG8.MaxLength = 0x3;
            textBoxPG9.MaxLength = 0x10;
            textBoxPG10.MaxLength = 0xB;
        }
    }
}
