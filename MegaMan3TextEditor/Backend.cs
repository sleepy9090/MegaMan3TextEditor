using System;
using System.Collections.Generic;
using System.IO;
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
    class Backend {

        int textFlag = 0;

        public Backend() {

        }

        public void getText(string path, TextBox texboxname, int length, int offset, int decodeOption) {

            string romCodeString = "";
            string megamanAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read)) {
                try {
                    fileStream.Seek(offset, SeekOrigin.Begin);

                    while (x < length) {
                        romCodeString = fileStream.ReadByte().ToString("X");
                        //if length is single digit add a 0 ( 1 now is 01)
                        if (romCodeString.Length == 1) {
                            romCodeString = "0" + romCodeString;
                        }
                        tempHexString = romCodeString;
                        if (decodeOption == 0) {
                            decodeRomText1(tempHexString);
                            if (textFlag == 0) {
                                megamanAsciiOut += decodeRomText1(tempHexString);
                            }
                        } else {
                            decodeRomText2(tempHexString);
                            if (textFlag == 0) {
                                megamanAsciiOut += decodeRomText2(tempHexString);
                            }
                        }
                        x++;

                        texboxname.Text = megamanAsciiOut;
                    }

                    fileStream.Close();
                } catch (Exception e) {
                    MessageBox.Show("Error: " + e, "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void updateROMText(string absoluteFilename, int length, TextBox textBox, int offset, int decodeOption) {
            // TODO: Optimize/refactor, this is ugly
            string newMM3String = textBox.Text;

            newMM3String = newMM3String.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newMM3StringArray = new string[length];
            byte[] newMM3StringByteArray = new byte[length];
            int[] mm3Decimal = new int[length];
            string[] mm3Final = new string[length];
            string[] mm3s = new string[length];

            int x = 0;
            while (x < length) {
                newMM3StringArray[x] = newMM3String[x].ToString();
                tempascii = newMM3StringArray[x];
                if (decodeOption == 0) {
                    hexReturn += encodeRomText1(tempascii);
                } else {
                    hexReturn += encodeRomText2(tempascii);
                }
                
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                mm3s[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            x = 0;
            while (x < length) {
                mm3Decimal[x] = int.Parse(mm3s[x], System.Globalization.NumberStyles.HexNumber);
                mm3Final[x] = mm3Decimal[x].ToString();
                newMM3StringByteArray[x] = byte.Parse(mm3Final[x]);
                x++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write)) {
                try {
                    fileStream.Seek(offset, SeekOrigin.Begin);
                    x = 0;
                    while (x < length) {
                        fileStream.WriteByte(newMM3StringByteArray[x]);
                        x++;
                    }
                } catch (Exception e) {
                    MessageBox.Show("Error: " + e, "Mega Man 3 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string decodeRomText1(string tempHexString) {
            string megamanAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "00":
                    megamanAscii += "0";
                    break;
                case "01":
                    megamanAscii += "1";
                    break;
                case "02":
                    megamanAscii += "2";
                    break;
                case "03":
                    megamanAscii += "3";
                    break;
                case "04":
                    megamanAscii += "4";
                    break;
                case "05":
                    megamanAscii += "5";
                    break;
                case "06":
                    megamanAscii += "6";
                    break;
                case "07":
                    megamanAscii += "7";
                    break;
                case "08":
                    megamanAscii += "8";
                    break;
                case "09":
                    megamanAscii += "9";
                    break;
                case "0A":
                    megamanAscii += "A";
                    break;
                case "0B":
                    megamanAscii += "B";
                    break;
                case "0C":
                    megamanAscii += "C";
                    break;
                case "0D":
                    megamanAscii += "D";
                    break;
                case "0E":
                    megamanAscii += "E";
                    break;
                case "0F":
                    megamanAscii += "F";
                    break;
                case "10":
                    megamanAscii += "G";
                    break;
                case "11":
                    megamanAscii += "H";
                    break;
                case "12":
                    megamanAscii += "I";
                    break;
                case "13":
                    megamanAscii += "J";
                    break;
                case "14":
                    megamanAscii += "K";
                    break;
                case "15":
                    megamanAscii += "L";
                    break;
                case "16":
                    megamanAscii += "M";
                    break;
                case "17":
                    megamanAscii += "N";
                    break;
                case "18":
                    megamanAscii += "O";
                    break;
                case "19":
                    megamanAscii += "P";
                    break;
                case "1A":
                    megamanAscii += "Q";
                    break;
                case "1B":
                    megamanAscii += "R";
                    break;
                case "1C":
                    megamanAscii += "S";
                    break;
                case "1D":
                    megamanAscii += "T";
                    break;
                case "1E":
                    megamanAscii += "U";
                    break;
                case "1F":
                    megamanAscii += "V";
                    break;
                case "20":
                    megamanAscii += "W";
                    break;
                case "21":
                    megamanAscii += "X";
                    break;
                case "22":
                    megamanAscii += "Y";
                    break;
                case "23":
                    megamanAscii += "Z";
                    break;
                // TODO: figure this out: case 24 is 24= "invisible" space(first color in the palette)
                case "24":
                    megamanAscii += " ";
                    break;
                case "25":
                    megamanAscii += " ";
                    break;
                case "26":
                    megamanAscii += ".";
                    break;
                case "27":
                    megamanAscii += ",";
                    break;
                case "28":
                    megamanAscii += "'";
                    break;
                case "29":
                    megamanAscii += "!";
                    break;
                // 2A us "r."
                case "2A":
                    megamanAscii += "r.";
                    break;
                case "2B":
                    megamanAscii += ":";
                    break;
                case "3C":
                    megamanAscii += "©";
                    break;
                //case "67":
                //    megamanAscii += "©";
                //    break;
                default:
                    megamanAscii += " ";
                    textFlag = 1;
                    break;
            }

            return megamanAscii;
        }

        private string decodeRomText2(string tempHexString) {
            string megamanAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "00":
                    megamanAscii += " ";
                    break;
                case "01":
                    megamanAscii += "0";
                    break;
                case "02":
                    megamanAscii += "1";
                    break;
                case "03":
                    megamanAscii += "2";
                    break;
                case "04":
                    megamanAscii += "3";
                    break;
                case "05":
                    megamanAscii += "4";
                    break;
                case "06":
                    megamanAscii += "5";
                    break;
                case "07":
                    megamanAscii += "6";
                    break;
                case "08":
                    megamanAscii += "7";
                    break;
                case "09":
                    megamanAscii += "8";
                    break;
                case "0A":
                    megamanAscii += "9";
                    break;
                case "0B":
                    megamanAscii += "A";
                    break;
                case "0C":
                    megamanAscii += "B";
                    break;
                case "0D":
                    megamanAscii += "C";
                    break;
                case "0E":
                    megamanAscii += "D";
                    break;
                case "0F":
                    megamanAscii += "E";
                    break;
                case "10":
                    megamanAscii += "F";
                    break;
                case "11":
                    megamanAscii += "G";
                    break;
                case "12":
                    megamanAscii += "H";
                    break;
                case "13":
                    megamanAscii += "I";
                    break;
                case "14":
                    megamanAscii += "J";
                    break;
                case "15":
                    megamanAscii += "K";
                    break;
                case "16":
                    megamanAscii += "L";
                    break;
                case "17":
                    megamanAscii += "M";
                    break;
                case "18":
                    megamanAscii += "N";
                    break;
                case "19":
                    megamanAscii += "O";
                    break;
                case "1A":
                    megamanAscii += "P";
                    break;
                case "1B":
                    megamanAscii += "Q";
                    break;
                case "1C":
                    megamanAscii += "R";
                    break;
                case "1D":
                    megamanAscii += "S";
                    break;
                case "1E":
                    megamanAscii += "T";
                    break;
                case "1F":
                    megamanAscii += "U";
                    break;
                case "20":
                    megamanAscii += "V";
                    break;
                case "21":
                    megamanAscii += "W";
                    break;
                case "22":
                    megamanAscii += "X";
                    break;
                case "23":
                    megamanAscii += "Y";
                    break;
                case "24":
                    megamanAscii += "Z";
                    break;
                case "25":
                    megamanAscii += "r";
                    break;
                case "26":
                    megamanAscii += ".";
                    break;
                case "27":
                    megamanAscii += "'";
                    break;
                case "28":
                    megamanAscii += "!";
                    break;
                case "29":
                    megamanAscii += "?";
                    break;
                case "2A":
                    megamanAscii += ":";
                    break;
                case "2B":
                    megamanAscii += ",";
                    break;
                case "2C":
                    megamanAscii += "-";
                    break;
                case "3B":
                    megamanAscii += "©"; // experimental
                    break;
                default:
                    megamanAscii += " ";
                    textFlag = 1;
                    break;
            }

            return megamanAscii;
        }

        private string encodeRomText1(string tempAscii) {
            string megamanHex = "";
            tempAscii = tempAscii.ToUpper();

            switch (tempAscii) {
                case "0":
                    megamanHex += "00";
                    break;
                case "1":
                    megamanHex += "01";
                    break;
                case "2":
                    megamanHex += "02";
                    break;
                case "3":
                    megamanHex += "03";
                    break;
                case "4":
                    megamanHex += "04";
                    break;
                case "5":
                    megamanHex += "05";
                    break;
                case "6":
                    megamanHex += "06";
                    break;
                case "7":
                    megamanHex += "07";
                    break;
                case "8":
                    megamanHex += "08";
                    break;
                case "9":
                    megamanHex += "09";
                    break;
                case "A":
                    megamanHex += "0A";
                    break;
                case "B":
                    megamanHex += "0B";
                    break;
                case "C":
                    megamanHex += "0C";
                    break;
                case "D":
                    megamanHex += "0D";
                    break;
                case "E":
                    megamanHex += "0E";
                    break;
                case "F":
                    megamanHex += "0F";
                    break;
                case "G":
                    megamanHex += "10";
                    break;
                case "H":
                    megamanHex += "11";
                    break;
                case "I":
                    megamanHex += "12";
                    break;
                case "J":
                    megamanHex += "13";
                    break;
                case "K":
                    megamanHex += "14";
                    break;
                case "L":
                    megamanHex += "15";
                    break;
                case "M":
                    megamanHex += "16";
                    break;
                case "N":
                    megamanHex += "17";
                    break;
                case "O":
                    megamanHex += "18";
                    break;
                case "P":
                    megamanHex += "19";
                    break;
                case "Q":
                    megamanHex += "1A";
                    break;
                case "R":
                    megamanHex += "1B";
                    break;
                case "S":
                    megamanHex += "1C";
                    break;
                case "T":
                    megamanHex += "1D";
                    break;
                case "U":
                    megamanHex += "1E";
                    break;
                case "V":
                    megamanHex += "1F";
                    break;
                case "W":
                    megamanHex += "20";
                    break;
                case "X":
                    megamanHex += "21";
                    break;
                case "Y":
                    megamanHex += "22";
                    break;
                case "Z":
                    megamanHex += "23";
                    break;
                // TODO: figure this out: case 24 is 24= "invisible" space(first color in the palette)
                //case " ":
                //    megamanAscii += "24";
                //    break;
                case " ":
                    megamanHex += "25";
                    break;
                case ".":
                    megamanHex += "26";
                    break;
                case ",":
                    megamanHex += "27";
                    break;
                case "'":
                    megamanHex += "28";
                    break;
                case "!":
                    megamanHex += "29";
                    break;
                // TODO: this is a special case, ignoring for now
                case "r.":
                    megamanHex += "2A";
                    break;
                case ":":
                    megamanHex += "2B";
                    break;
                case "©":
                    megamanHex += "3C";
                    break;
                //case "67":
                //    megamanAscii += "©";
                //    break;
                default:
                    megamanHex += "25";
                    break;
            }

            return megamanHex;
        }

        private string encodeRomText2(string tempAscii) {
            string megamanHex = "";
            tempAscii = tempAscii.ToUpper();

            switch (tempAscii) {
                case " ":
                    megamanHex += "00";
                    break;
                case "0":
                    megamanHex += "01";
                    break;
                case "1":
                    megamanHex += "02";
                    break;
                case "2":
                    megamanHex += "03";
                    break;
                case "3":
                    megamanHex += "04";
                    break;
                case "4":
                    megamanHex += "05";
                    break;
                case "5":
                    megamanHex += "06";
                    break;
                case "6":
                    megamanHex += "07";
                    break;
                case "7":
                    megamanHex += "08";
                    break;
                case "8":
                    megamanHex += "09";
                    break;
                case "9":
                    megamanHex += "0A";
                    break;
                case "A":
                    megamanHex += "0B";
                    break;
                case "B":
                    megamanHex += "0C";
                    break;
                case "C":
                    megamanHex += "0D";
                    break;
                case "D":
                    megamanHex += "0E";
                    break;
                case "E":
                    megamanHex += "0F";
                    break;
                case "F":
                    megamanHex += "10";
                    break;
                case "G":
                    megamanHex += "11";
                    break;
                case "H":
                    megamanHex += "12";
                    break;
                case "I":
                    megamanHex += "13";
                    break;
                case "J":
                    megamanHex += "14";
                    break;
                case "K":
                    megamanHex += "15";
                    break;
                case "L":
                    megamanHex += "16";
                    break;
                case "M":
                    megamanHex += "17";
                    break;
                case "N":
                    megamanHex += "18";
                    break;
                case "O":
                    megamanHex += "19";
                    break;
                case "P":
                    megamanHex += "1A";
                    break;
                case "Q":
                    megamanHex += "1B";
                    break;
                case "R":
                    megamanHex += "1C";
                    break;
                case "S":
                    megamanHex += "1D";
                    break;
                case "T":
                    megamanHex += "1E";
                    break;
                case "U":
                    megamanHex += "1F";
                    break;
                case "V":
                    megamanHex += "20";
                    break;
                case "W":
                    megamanHex += "21";
                    break;
                case "X":
                    megamanHex += "22";
                    break;
                case "Y":
                    megamanHex += "23";
                    break;
                case "Z":
                    megamanHex += "24";
                    break;
                // TODO: this is a special case, ignoring for now
                case "r":
                    megamanHex += "25";
                    break;
                case ".":
                    megamanHex += "26";
                    break;
                case "'":
                    megamanHex += "27";
                    break;
                case "!":
                    megamanHex += "28";
                    break;
                case "?":
                    megamanHex += "29";
                    break;
                case ":":
                    megamanHex += "2A";
                    break;
                case ",":
                    megamanHex += "2B";
                    break;
                case "-":
                    megamanHex += "2C";
                    break;
                case "©":
                    megamanHex += "3B"; // experimental
                    break;
                default:
                    megamanHex += "00";
                    break;
            }

            return megamanHex;
        }
    }
}
