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
    public partial class Form8_rl : Form {

        string path = "";

        public Form8_rl() {
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

                backend.updateROMText(absoluteFilename, 0xB, textBoxRL1, 0x1A3C7, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxRL2, 0x1A3D5, 1);
                backend.updateROMText(absoluteFilename, 0xB, textBoxRL3, 0x1A3E1, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL4, 0x1A3EF, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxRL5, 0x1A3F8, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRL6, 0x1A409, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRL7, 0x1A412, 1);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRL8, 0x1A41B, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxRL9, 0x1A429, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL10, 0x1A43A, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRL11, 0x1A442, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL12, 0x1A44D, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxRL13, 0x1A456, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRL14, 0x1A467, 1);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRL15, 0x1A470, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL16, 0x1A47D, 1);
                backend.updateROMText(absoluteFilename, 0xD, textBoxRL17, 0x1A486, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxRL18, 0x1A496, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRL19, 0x1A4A2, 1);
                backend.updateROMText(absoluteFilename, 0xC, textBoxRL20, 0x1A4AD, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxRL21, 0x1A4BD, 1);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRL22, 0x1A4CE, 1);
                backend.updateROMText(absoluteFilename, 0xB, textBoxRL23, 0x1A4DB, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL24, 0x1A4E9, 1);
                backend.updateROMText(absoluteFilename, 0xD, textBoxRL25, 0x1A4F2, 1);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRL26, 0x1A502, 1);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRL27, 0x1A50C, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL28, 0x1A516, 1);
                backend.updateROMText(absoluteFilename, 0xB, textBoxRL29, 0x1A51F, 1);
                backend.updateROMText(absoluteFilename, 0xC, textBoxRL30, 0x1A52D, 1);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRL31, 0x1A53C, 1);
                backend.updateROMText(absoluteFilename, 0xE, textBoxRL32, 0x1A545, 1);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRL33, 0x1A556, 1);
                backend.updateROMText(absoluteFilename, 0xC, textBoxRL34, 0x1A55F, 1);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRL35, 0x1A56E, 1);
                backend.updateROMText(absoluteFilename, 0x10, textBoxRL36, 0x1A57A, 1);
                backend.updateROMText(absoluteFilename, 0x9, textBoxRL37, 0x1A58D, 1);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRL38, 0x1A599, 1);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRL39, 0x1A5A6, 1);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRL40, 0x1A5B3, 1);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form8_rl_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxRL1, 0xB, 0x1A3C7, 1);
                backend.getText(path, textBoxRL2, 0x9, 0x1A3D5, 1);
                backend.getText(path, textBoxRL3, 0xB, 0x1A3E1, 1);
                backend.getText(path, textBoxRL4, 0x5, 0x1A3EF, 1);
                backend.getText(path, textBoxRL5, 0xE, 0x1A3F8, 1);
                backend.getText(path, textBoxRL6, 0x6, 0x1A409, 1);
                backend.getText(path, textBoxRL7, 0x6, 0x1A412, 1);
                backend.getText(path, textBoxRL8, 0xA, 0x1A41B, 1);
                backend.getText(path, textBoxRL9, 0xE, 0x1A429, 1);
                backend.getText(path, textBoxRL10, 0x5, 0x1A43A, 1);
                backend.getText(path, textBoxRL11, 0x8, 0x1A442, 1);
                backend.getText(path, textBoxRL12, 0x5, 0x1A44D, 1);
                backend.getText(path, textBoxRL13, 0xE, 0x1A456, 1);
                backend.getText(path, textBoxRL14, 0x6, 0x1A467, 1);
                backend.getText(path, textBoxRL15, 0xA, 0x1A470, 1);
                backend.getText(path, textBoxRL16, 0x5, 0x1A47D, 1);
                backend.getText(path, textBoxRL17, 0xD, 0x1A486, 1);
                backend.getText(path, textBoxRL18, 0x9, 0x1A496, 1);
                backend.getText(path, textBoxRL19, 0x8, 0x1A4A2, 1);
                backend.getText(path, textBoxRL20, 0xC, 0x1A4AD, 1);
                backend.getText(path, textBoxRL21, 0xE, 0x1A4BD, 1);
                backend.getText(path, textBoxRL22, 0xA, 0x1A4CE, 1);
                backend.getText(path, textBoxRL23, 0xB, 0x1A4DB, 1);
                backend.getText(path, textBoxRL24, 0x5, 0x1A4E9, 1);
                backend.getText(path, textBoxRL25, 0xD, 0x1A4F2, 1);
                backend.getText(path, textBoxRL26, 0x7, 0x1A502, 1);
                backend.getText(path, textBoxRL27, 0x7, 0x1A50C, 1);
                backend.getText(path, textBoxRL28, 0x5, 0x1A516, 1);
                backend.getText(path, textBoxRL29, 0xB, 0x1A51F, 1);
                backend.getText(path, textBoxRL30, 0xC, 0x1A52D, 1);
                backend.getText(path, textBoxRL31, 0x5, 0x1A53C, 1);
                backend.getText(path, textBoxRL32, 0xE, 0x1A545, 1);
                backend.getText(path, textBoxRL33, 0x6, 0x1A556, 1);
                backend.getText(path, textBoxRL34, 0xC, 0x1A55F, 1);
                backend.getText(path, textBoxRL35, 0x8, 0x1A56E, 1);
                backend.getText(path, textBoxRL36, 0x10, 0x1A57A, 1);
                backend.getText(path, textBoxRL37, 0x9, 0x1A58D, 1);
                backend.getText(path, textBoxRL38, 0xA, 0x1A599, 1);
                backend.getText(path, textBoxRL39, 0xA, 0x1A5A6, 1);
                backend.getText(path, textBoxRL40, 0x7, 0x1A5B3, 1);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxRL1.MaxLength = 0xB;
            textBoxRL2.MaxLength = 0x9;
            textBoxRL3.MaxLength = 0xB;
            textBoxRL4.MaxLength = 0x5;
            textBoxRL5.MaxLength = 0xE;
            textBoxRL6.MaxLength = 0x6;
            textBoxRL7.MaxLength = 0x6;
            textBoxRL8.MaxLength = 0xA;
            textBoxRL9.MaxLength = 0xE;
            textBoxRL10.MaxLength = 0x5;
            textBoxRL11.MaxLength = 0x8;
            textBoxRL12.MaxLength = 0x5;
            textBoxRL13.MaxLength = 0xE;
            textBoxRL14.MaxLength = 0x6;
            textBoxRL15.MaxLength = 0xA;
            textBoxRL16.MaxLength = 0x5;
            textBoxRL17.MaxLength = 0xD;
            textBoxRL18.MaxLength = 0x9;
            textBoxRL19.MaxLength = 0x8;
            textBoxRL20.MaxLength = 0xC;
            textBoxRL21.MaxLength = 0xE;
            textBoxRL22.MaxLength = 0xA;
            textBoxRL23.MaxLength = 0xB;
            textBoxRL24.MaxLength = 0x5;
            textBoxRL25.MaxLength = 0xD;
            textBoxRL26.MaxLength = 0x7;
            textBoxRL27.MaxLength = 0x7;
            textBoxRL28.MaxLength = 0x5;
            textBoxRL29.MaxLength = 0xB;
            textBoxRL30.MaxLength = 0xC;
            textBoxRL31.MaxLength = 0x5;
            textBoxRL32.MaxLength = 0xE;
            textBoxRL33.MaxLength = 0x6;
            textBoxRL34.MaxLength = 0xC;
            textBoxRL35.MaxLength = 0x8;
            textBoxRL36.MaxLength = 0x10;
            textBoxRL37.MaxLength = 0x9;
            textBoxRL38.MaxLength = 0xA;
            textBoxRL39.MaxLength = 0xA;
            textBoxRL40.MaxLength = 0x7;
        }
    }
}
