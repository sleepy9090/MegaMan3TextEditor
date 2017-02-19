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
    public partial class Form7_c : Form {

        string path = "";

        public Form7_c() {
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

                backend.updateROMText(absoluteFilename, 0x12, textBoxC1, 0x1E2D7, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC2, 0x1E2EC, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxC3, 0x1E2F7, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxC4, 0x1E303, 0);
                backend.updateROMText(absoluteFilename, 0x4, textBoxC5, 0x1E30F, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxC6, 0x1E316, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxC7, 0x1E320, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxC8, 0x1E330, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC9, 0x1E339, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxC10, 0x1E346, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxC11, 0x1E34C, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxC12, 0x1E352, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxC13, 0x1E35E, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC14, 0x1E368, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxC15, 0x1E373, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxC16, 0x1E382, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxC17, 0x1E390, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC18, 0x1E399, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxC19, 0x1E3A4, 0);
                backend.updateROMText(absoluteFilename, 0x10, textBoxC20, 0x1E3B5, 0);
                backend.updateROMText(absoluteFilename, 0xF, textBoxC21, 0x1E3C8, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxC22, 0x1E3DA, 0);
                backend.updateROMText(absoluteFilename, 0xF, textBoxC23, 0x1E3E8, 0);
                backend.updateROMText(absoluteFilename, 0xF, textBoxC24, 0x1E3FA, 0);
                backend.updateROMText(absoluteFilename, 0x12, textBoxC25, 0x1E40C, 0);
                backend.updateROMText(absoluteFilename, 0x10, textBoxC26, 0x1E421, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxC27, 0x1E434, 0);
                backend.updateROMText(absoluteFilename, 0x12, textBoxC28, 0x1E445, 0);
                backend.updateROMText(absoluteFilename, 0x10, textBoxC29, 0x1E45A, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxC30, 0x1E46D, 0);
                backend.updateROMText(absoluteFilename, 0xF, textBoxC31, 0x1E47E, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxC32, 0x1E490, 0);
                backend.updateROMText(absoluteFilename, 0x10, textBoxC33, 0x1E4A1, 0);
                backend.updateROMText(absoluteFilename, 0x11, textBoxC34, 0x1E4B4, 0);
                backend.updateROMText(absoluteFilename, 0x11, textBoxC35, 0x1E4C8, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxC36, 0x1E4DC, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxC37, 0x1E4EC, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxC38, 0x1E4FC, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxC39, 0x1E50B, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxC40, 0x1E51B, 0);
                backend.updateROMText(absoluteFilename, 0xF, textBoxC41, 0x1E52A, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxC42, 0x1E53C, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxC43, 0x1E54A, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxC44, 0x1E557, 0);
                backend.updateROMText(absoluteFilename, 0x11, textBoxC45, 0x1E567, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxC46, 0x1E57B, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxC47, 0x1E58B, 0);
                backend.updateROMText(absoluteFilename, 0x14, textBoxC48, 0x1E59C, 0);
                backend.updateROMText(absoluteFilename, 0x12, textBoxC49, 0x1E5B3, 0);
                backend.updateROMText(absoluteFilename, 0xF, textBoxC50, 0x1E5C8, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxC51, 0x1E5DA, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxC52, 0x1E5E9, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxC53, 0x1E5F6, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC54, 0x1E5FF, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC55, 0x1E60A, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxC56, 0x1E615, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxC57, 0x1E620, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxC58, 0x1E629, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxC59, 0x1E635, 0);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form7_c_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                // $1E2D7 - $1E639 - Game Credits
                backend.getText(path, textBoxC1, 0x12, 0x1E2D7, 0);
                backend.getText(path, textBoxC2, 0x8, 0x1E2EC, 0);
                backend.getText(path, textBoxC3, 0x9, 0x1E2F7, 0);
                backend.getText(path, textBoxC4, 0x9, 0x1E303, 0);
                backend.getText(path, textBoxC5, 0x4, 0x1E30F, 0);
                backend.getText(path, textBoxC6, 0x7, 0x1E316, 0);
                backend.getText(path, textBoxC7, 0xD, 0x1E320, 0);
                backend.getText(path, textBoxC8, 0x6, 0x1E330, 0);
                backend.getText(path, textBoxC9, 0xA, 0x1E339, 0);
                backend.getText(path, textBoxC10, 0x3, 0x1E346, 0);
                backend.getText(path, textBoxC11, 0x3, 0x1E34C, 0);
                backend.getText(path, textBoxC12, 0x9, 0x1E352, 0);
                backend.getText(path, textBoxC13, 0x7, 0x1E35E, 0);
                backend.getText(path, textBoxC14, 0x8, 0x1E368, 0);
                backend.getText(path, textBoxC15, 0xC, 0x1E373, 0);
                backend.getText(path, textBoxC16, 0xB, 0x1E382, 0);
                backend.getText(path, textBoxC17, 0x6, 0x1E390, 0);
                backend.getText(path, textBoxC18, 0x8, 0x1E399, 0);
                backend.getText(path, textBoxC19, 0xE, 0x1E3A4, 0);
                backend.getText(path, textBoxC20, 0x10, 0x1E3B5, 0);
                backend.getText(path, textBoxC21, 0xF, 0x1E3C8, 0);
                backend.getText(path, textBoxC22, 0xB, 0x1E3DA, 0);
                backend.getText(path, textBoxC23, 0xF, 0x1E3E8, 0);
                backend.getText(path, textBoxC24, 0xF, 0x1E3FA, 0);
                backend.getText(path, textBoxC25, 0x12, 0x1E40C, 0);
                backend.getText(path, textBoxC26, 0x10, 0x1E421, 0);
                backend.getText(path, textBoxC27, 0xE, 0x1E434, 0);
                backend.getText(path, textBoxC28, 0x12, 0x1E445, 0);
                backend.getText(path, textBoxC29, 0x10, 0x1E45A, 0);
                backend.getText(path, textBoxC30, 0xE, 0x1E46D, 0);
                backend.getText(path, textBoxC31, 0xF, 0x1E47E, 0);
                backend.getText(path, textBoxC32, 0xE, 0x1E490, 0);
                backend.getText(path, textBoxC33, 0x10, 0x1E4A1, 0);
                backend.getText(path, textBoxC34, 0x11, 0x1E4B4, 0);
                backend.getText(path, textBoxC35, 0x11, 0x1E4C8, 0);
                backend.getText(path, textBoxC36, 0xD, 0x1E4DC, 0);
                backend.getText(path, textBoxC37, 0xD, 0x1E4EC, 0);
                backend.getText(path, textBoxC38, 0xC, 0x1E4FC, 0);
                backend.getText(path, textBoxC39, 0xC, 0x1E50B, 0);
                backend.getText(path, textBoxC40, 0xC, 0x1E51B, 0);
                backend.getText(path, textBoxC41, 0xF, 0x1E52A, 0);
                backend.getText(path, textBoxC42, 0xB, 0x1E53C, 0);
                backend.getText(path, textBoxC43, 0xA, 0x1E54A, 0);
                backend.getText(path, textBoxC44, 0xD, 0x1E557, 0);
                backend.getText(path, textBoxC45, 0x11, 0x1E567, 0);
                backend.getText(path, textBoxC46, 0xD, 0x1E57B, 0);
                backend.getText(path, textBoxC47, 0xE, 0x1E58B, 0);
                backend.getText(path, textBoxC48, 0x14, 0x1E59C, 0);
                backend.getText(path, textBoxC49, 0x12, 0x1E5B3, 0);
                backend.getText(path, textBoxC50, 0xF, 0x1E5C8, 0);
                backend.getText(path, textBoxC51, 0xC, 0x1E5DA, 0);
                backend.getText(path, textBoxC52, 0xA, 0x1E5E9, 0);
                backend.getText(path, textBoxC53, 0x6, 0x1E5F6, 0);
                backend.getText(path, textBoxC54, 0x8, 0x1E5FF, 0);
                backend.getText(path, textBoxC55, 0x8, 0x1E60A, 0);
                backend.getText(path, textBoxC56, 0x8, 0x1E615, 0);
                backend.getText(path, textBoxC57, 0x6, 0x1E620, 0);
                backend.getText(path, textBoxC58, 0x9, 0x1E629, 0);
                backend.getText(path, textBoxC59, 0x5, 0x1E635, 0);


            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxC1.MaxLength = 0x12;
            textBoxC2.MaxLength = 0x8;
            textBoxC3.MaxLength = 0x9;
            textBoxC4.MaxLength = 0x9;
            textBoxC5.MaxLength = 0x4;
            textBoxC6.MaxLength = 0x7;
            textBoxC7.MaxLength = 0xD;
            textBoxC8.MaxLength = 0x6;
            textBoxC9.MaxLength = 0xA;
            textBoxC10.MaxLength = 0x3;
            textBoxC11.MaxLength = 0x3;
            textBoxC12.MaxLength = 0x9;
            textBoxC13.MaxLength = 0x7;
            textBoxC14.MaxLength = 0x8;
            textBoxC15.MaxLength = 0xC;
            textBoxC16.MaxLength = 0xB;
            textBoxC17.MaxLength = 0x6;
            textBoxC18.MaxLength = 0x8;
            textBoxC19.MaxLength = 0xE;
            textBoxC20.MaxLength = 0x10;
            textBoxC21.MaxLength = 0xF;
            textBoxC22.MaxLength = 0xB;
            textBoxC23.MaxLength = 0xF;
            textBoxC24.MaxLength = 0xF;
            textBoxC25.MaxLength = 0x12;
            textBoxC26.MaxLength = 0x10;
            textBoxC27.MaxLength = 0xE;
            textBoxC28.MaxLength = 0x12;
            textBoxC29.MaxLength = 0x10;
            textBoxC30.MaxLength = 0xE;
            textBoxC31.MaxLength = 0xF;
            textBoxC32.MaxLength = 0xE;
            textBoxC33.MaxLength = 0x10;
            textBoxC34.MaxLength = 0x11;
            textBoxC35.MaxLength = 0x11;
            textBoxC36.MaxLength = 0xD;
            textBoxC37.MaxLength = 0xD;
            textBoxC38.MaxLength = 0xC;
            textBoxC39.MaxLength = 0xC;
            textBoxC40.MaxLength = 0xC;
            textBoxC41.MaxLength = 0xF;
            textBoxC42.MaxLength = 0xB;
            textBoxC43.MaxLength = 0xA;
            textBoxC44.MaxLength = 0xD;
            textBoxC45.MaxLength = 0x11;
            textBoxC46.MaxLength = 0xD;
            textBoxC47.MaxLength = 0xE;
            textBoxC48.MaxLength = 0x14;
            textBoxC49.MaxLength = 0x12;
            textBoxC50.MaxLength = 0xF;
            textBoxC51.MaxLength = 0xC;
            textBoxC52.MaxLength = 0xA;
            textBoxC53.MaxLength = 0x6;
            textBoxC54.MaxLength = 0x8;
            textBoxC55.MaxLength = 0x8;
            textBoxC56.MaxLength = 0x8;
            textBoxC57.MaxLength = 0x6;
            textBoxC58.MaxLength = 0x9;
            textBoxC59.MaxLength = 0x5;
        }


    }
}
