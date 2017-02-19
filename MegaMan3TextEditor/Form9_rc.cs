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
    public partial class Form9_rc : Form {

        string path = "";

        public Form9_rc() {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x5, textBoxRC1, 0x1C0D3, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRC2, 0x1C0DB, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC3, 0x1C0E8, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC4, 0x1C0F3, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC5, 0x1C0FE, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRC6, 0x1C106, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC7, 0x1C113, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxRC8, 0x1C11D, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC9, 0x1C123, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRC10, 0x1C12B, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxRC11, 0x1C138, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC12, 0x1C144, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC13, 0x1C14E, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC14, 0x1C156, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC15, 0x1C161, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC16, 0x1C16C, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC17, 0x1C174, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC18, 0x1C17C, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC19, 0x1C186, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC20, 0x1C190, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC21, 0x1C19A, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxRC22, 0x1C1A2, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC23, 0x1C1AE, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC24, 0x1C1B8, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC25, 0x1C1C3, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxRC26, 0x1C1CB, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC27, 0x1C1D7, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxRC28, 0x1C1E2, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC29, 0x1C1EB, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxRC30, 0x1C1F3, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxRC31, 0x1C200, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxRC32, 0x1C20B, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxRC33, 0x188D3, 0);

                MessageBox.Show("Updated Text!", "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void Form9_rc_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxRC1, 0x5, 0x1C0D3, 0);
                backend.getText(path, textBoxRC2, 0xA, 0x1C0DB, 0);
                backend.getText(path, textBoxRC3, 0x8, 0x1C0E8, 0);
                backend.getText(path, textBoxRC4, 0x8, 0x1C0F3, 0);
                backend.getText(path, textBoxRC5, 0x5, 0x1C0FE, 0);
                backend.getText(path, textBoxRC6, 0xA, 0x1C106, 0);
                backend.getText(path, textBoxRC7, 0x7, 0x1C113, 0);
                backend.getText(path, textBoxRC8, 0x3, 0x1C11D, 0);
                backend.getText(path, textBoxRC9, 0x5, 0x1C123, 0);
                backend.getText(path, textBoxRC10, 0xA, 0x1C12B, 0);
                backend.getText(path, textBoxRC11, 0x9, 0x1C138, 0);
                backend.getText(path, textBoxRC12, 0x7, 0x1C144, 0);
                backend.getText(path, textBoxRC13, 0x5, 0x1C14E, 0);
                backend.getText(path, textBoxRC14, 0x8, 0x1C156, 0);
                backend.getText(path, textBoxRC15, 0x8, 0x1C161, 0);
                backend.getText(path, textBoxRC16, 0x5, 0x1C16C, 0);
                backend.getText(path, textBoxRC17, 0x5, 0x1C174, 0);
                backend.getText(path, textBoxRC18, 0x7, 0x1C17C, 0);
                backend.getText(path, textBoxRC19, 0x7, 0x1C186, 0);
                backend.getText(path, textBoxRC20, 0x7, 0x1C190, 0);
                backend.getText(path, textBoxRC21, 0x5, 0x1C19A, 0);
                backend.getText(path, textBoxRC22, 0x9, 0x1C1A2, 0);
                backend.getText(path, textBoxRC23, 0x7, 0x1C1AE, 0);
                backend.getText(path, textBoxRC24, 0x8, 0x1C1B8, 0);
                backend.getText(path, textBoxRC25, 0x5, 0x1C1C3, 0);
                backend.getText(path, textBoxRC26, 0x9, 0x1C1CB, 0);
                backend.getText(path, textBoxRC27, 0x8, 0x1C1D7, 0);
                backend.getText(path, textBoxRC28, 0x6, 0x1C1E2, 0);
                backend.getText(path, textBoxRC29, 0x5, 0x1C1EB, 0);
                backend.getText(path, textBoxRC30, 0xA, 0x1C1F3, 0);
                backend.getText(path, textBoxRC31, 0x8, 0x1C200, 0);
                backend.getText(path, textBoxRC32, 0x7, 0x1C20B, 0);
                backend.getText(path, textBoxRC33, 0x5, 0x188D3, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxRC1.MaxLength = 0x5;
            textBoxRC2.MaxLength = 0xA;
            textBoxRC3.MaxLength = 0x8;
            textBoxRC4.MaxLength = 0x8;
            textBoxRC5.MaxLength = 0x5;
            textBoxRC6.MaxLength = 0xA;
            textBoxRC7.MaxLength = 0x7;
            textBoxRC8.MaxLength = 0x3;
            textBoxRC9.MaxLength = 0x5;
            textBoxRC10.MaxLength = 0xA;
            textBoxRC11.MaxLength = 0x9;
            textBoxRC12.MaxLength = 0x7;
            textBoxRC13.MaxLength = 0x5;
            textBoxRC14.MaxLength = 0x8;
            textBoxRC15.MaxLength = 0x8;
            textBoxRC16.MaxLength = 0x5;
            textBoxRC17.MaxLength = 0x5;
            textBoxRC18.MaxLength = 0x7;
            textBoxRC19.MaxLength = 0x7;
            textBoxRC20.MaxLength = 0x7;
            textBoxRC21.MaxLength = 0x5;
            textBoxRC22.MaxLength = 0x9;
            textBoxRC23.MaxLength = 0x7;
            textBoxRC24.MaxLength = 0x8;
            textBoxRC25.MaxLength = 0x5;
            textBoxRC26.MaxLength = 0x9;
            textBoxRC27.MaxLength = 0x8;
            textBoxRC28.MaxLength = 0x6;
            textBoxRC29.MaxLength = 0x5;
            textBoxRC30.MaxLength = 0xA;
            textBoxRC31.MaxLength = 0x8;
            textBoxRC32.MaxLength = 0x7;
            textBoxRC33.MaxLength = 0x5;
        }
    }
}
