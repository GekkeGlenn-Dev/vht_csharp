using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;

namespace StudentInfo
{
    public partial class StudentForm : Form
    {
        AddStudentForm addStudent = new AddStudentForm();
        static int studentAmount = 124;
        public string[] arrayStudentName = new string[studentAmount];
        public string[] arrayStudentClassName = new string[studentAmount];
        DateTime[] arrayStudentBirthday = new DateTime[studentAmount];
        public string[] arrayStudentnumber = new string[studentAmount];
        int indexStudent;                

        public StudentForm()
        {
            InitializeComponent();

            ReadStudentsName();
            ReadStudentClass();
            ShowStudents();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Debug.WriteLine("Application started");   
        }

        private void ReadStudentClass()
        {
            addStudent.arrayStudentClassName[0] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[1] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[2] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[3] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[4] = "RIO4-AMO1P";
            addStudent.arrayStudentClassName[5] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[6] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[7] = "RIO4-AMO1E";
            addStudent.arrayStudentClassName[8] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[9] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[10] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[11] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[12] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[13] = "RIO4-AMO1D";
            addStudent.arrayStudentClassName[14] = "RIO4-AMO1D";
            addStudent.arrayStudentClassName[15] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[16] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[17] = "RIO4-AMO1D";
            addStudent.arrayStudentClassName[18] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[19] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[20] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[21] = "RIO4-AMO1E";
            addStudent.arrayStudentClassName[22] = "RIO4-AMO1B";
            addStudent.arrayStudentClassName[23] = "RIO4-AMO1B";
            addStudent.arrayStudentClassName[24] = "RIO4-AMO1P";
            addStudent.arrayStudentClassName[25] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[26] = "RIO4-AMO1E";
            addStudent.arrayStudentClassName[27] = "RIO4-AMO1E";
            addStudent.arrayStudentClassName[28] = "RIO4-AMO1P";
            addStudent.arrayStudentClassName[29] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[30] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[31] = "RIO4-AMO1D";
            addStudent.arrayStudentClassName[32] = "RIO4-AMO1B";
            addStudent.arrayStudentClassName[33] = "RIO4-AMO1B";
            addStudent.arrayStudentClassName[34] = "RIO4-AMO1E";
            addStudent.arrayStudentClassName[35] = "RIO4-AMO1P";
            addStudent.arrayStudentClassName[36] = "RIO4-AMO1B";
            addStudent.arrayStudentClassName[37] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[38] = "RIO4-AMO1F";
            addStudent.arrayStudentClassName[39] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[40] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[41] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[42] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[43] = "RIO4-AMO1P";
            addStudent.arrayStudentClassName[44] = "RIO4-AMO1E";
            addStudent.arrayStudentClassName[45] = "RIO4-AMO1D";
            addStudent.arrayStudentClassName[46] = "RIO4-AMO1D";
            addStudent.arrayStudentClassName[47] = "RIO4-AMO1B";
            arrayStudentClassName[48] = "RIO4-AMO1C";
            arrayStudentClassName[49] = "RIO4-AMO1B";
            arrayStudentClassName[50] = "RIO4-AMO1D";
            arrayStudentClassName[51] = "RIO4-AMO1F";
            arrayStudentClassName[52] = "RIO4-AMO1D";
            arrayStudentClassName[53] = "RIO4-AMO1C";
            arrayStudentClassName[54] = "RIO4-AMO1B";
            arrayStudentClassName[55] = "RIO4-AMO1C";
            addStudent.arrayStudentClassName[56] = "RIO4-AMO1A";
            addStudent.arrayStudentClassName[57] = "RIO4-AMO1F";
            arrayStudentClassName[58] = "RIO4-AMO1A";
            arrayStudentClassName[59] = "RIO4-AMO1B";
            arrayStudentClassName[60] = "RIO4-AMO1F";
            arrayStudentClassName[61] = "RIO4-AMO1P";
            arrayStudentClassName[62] = "RIO4-AMO1P";
            arrayStudentClassName[63] = "RIO4-AMO1B";
            arrayStudentClassName[64] = "RIO4-AMO1E";
            arrayStudentClassName[65] = "RIO4-AMO1P";
            arrayStudentClassName[66] = "RIO4-AMO1P";
            arrayStudentClassName[67] = "RIO4-AMO1P";
            arrayStudentClassName[68] = "RIO4-AMO1C";
            arrayStudentClassName[69] = "RIO4-AMO1E";
            arrayStudentClassName[70] = "RIO4-AMO1F";
            arrayStudentClassName[71] = "RIO4-AMO1P";
            arrayStudentClassName[72] = "RIO4-AMO1F";
            arrayStudentClassName[73] = "RIO4-AMO1C";
            arrayStudentClassName[74] = "RIO4-AMO1A";
            arrayStudentClassName[75] = "RIO4-AMO1A";
            arrayStudentClassName[76] = "RIO4-AMO1F";
            arrayStudentClassName[77] = "RIO4-AMO1E";
            arrayStudentClassName[78] = "RIO4-AMO1D";
            arrayStudentClassName[79] = "RIO4-AMO1B";
            arrayStudentClassName[80] = "RIO4-AMO1P";
            arrayStudentClassName[81] = "RIO4-AMO1E";
            arrayStudentClassName[82] = "RIO4-AMO1D";
            arrayStudentClassName[83] = "RIO4-AMO1P";
            arrayStudentClassName[84] = "RIO4-AMO1P";
            arrayStudentClassName[85] = "RIO4-AMO1C";
            arrayStudentClassName[86] = "RIO4-AMO1E";
            arrayStudentClassName[87] = "RIO4-AMO1C";
            arrayStudentClassName[88] = "RIO4-AMO1B";
            arrayStudentClassName[89] = "RIO4-AMO1B";
            arrayStudentClassName[90] = "RIO4-AMO1B";
            arrayStudentClassName[91] = "RIO4-AMO1E";
            arrayStudentClassName[92] = "RIO4-AMO1P";
            arrayStudentClassName[93] = "RIO4-AMO1B";
            arrayStudentClassName[94] = "RIO4-AMO1E";
            arrayStudentClassName[95] = "RIO4-AMO1P";
            arrayStudentClassName[96] = "RIO4-AMO1B";
            arrayStudentClassName[97] = "RIO4-AMO1F";
            arrayStudentClassName[98] = "RIO4-AMO1E";
            arrayStudentClassName[99] = "RIO4-AMO1D";
            arrayStudentClassName[100] = "RIO4-AMO1D";
            arrayStudentClassName[101] = "RIO4-AMO1F";
            arrayStudentClassName[102] = "RIO4-AMO1C";
            arrayStudentClassName[103] = "RIO4-AMO1C";
            arrayStudentClassName[104] = "RIO4-AMO1D";
            arrayStudentClassName[105] = "RIO4-AMO1F";
            arrayStudentClassName[106] = "RIO4-AMO1F";
            arrayStudentClassName[107] = "RIO4-AMO1A";
            arrayStudentClassName[108] = "RIO4-AMO1D";
            arrayStudentClassName[109] = "RIO4-AMO1E";
            arrayStudentClassName[110] = "RIO4-AMO1B";
            arrayStudentClassName[111] = "RIO4-AMO1P";
            arrayStudentClassName[112] = "RIO4-AMO1D";
            arrayStudentClassName[113] = "RIO4-AMO1D";
            arrayStudentClassName[114] = "RIO4-AMO1D";
            arrayStudentClassName[115] = "RIO4-AMO1P";
            arrayStudentClassName[116] = "RIO4-AMO1D";
            arrayStudentClassName[117] = "RIO4-AMO1E";
            arrayStudentClassName[118] = "RIO4-AMO1A";
            arrayStudentClassName[119] = "RIO4-AMO1E";
            arrayStudentClassName[120] = "RIO4-AMO1F";
            arrayStudentClassName[121] = "RIO4-AMO1E";
            arrayStudentClassName[122] = "RIO4-AMO1A";

            ReadStudentNumber();
        }

        private int FindStudent(string studentName)
        {
            int i = 0;
            while (!(arrayStudentName[i].ToUpper().Contains(studentName.ToUpper())) && (i < studentAmount - 1)) i++;
            int indexStudent = i;
            if ((i < studentAmount - 1)) return i;
            return -1;
        }

        private void ReadStudentsName()
        {
            arrayStudentName[0] = "Robin Adriaensen";
            arrayStudentName[1] = "Tim Aerts";
            arrayStudentName[2] = "Nassima Ajary";
            arrayStudentName[3] = "Shaquille Albertus";
            arrayStudentName[4] = "Shadi Ali";
            arrayStudentName[5] = "Samuel Araya";
            arrayStudentName[6] = "Jesse Boer";
            arrayStudentName[7] = "Kayle Boersen";
            arrayStudentName[8] = "Jimmy Bogers";
            arrayStudentName[9] = "Jarno Böhmer";
            arrayStudentName[10] = "Sybrand Bos";
            arrayStudentName[11] = "Angelo Broek";
            arrayStudentName[12] = "Robin Brongers";
            arrayStudentName[13] = "Jamiro Bruijn";
            arrayStudentName[14] = "Jordan Bruijn";
            arrayStudentName[15] = "Florian Burg";
            arrayStudentName[16] = "Tobias Dekker";
            arrayStudentName[17] = "Donny Dongen";
            arrayStudentName[18] = "Stijn Dongen";
            arrayStudentName[19] = "Zeff Drent";
            arrayStudentName[20] = "Luner Driel";
            arrayStudentName[21] = "Justin Egbo";
            arrayStudentName[22] = "Carlo Elshout";
            arrayStudentName[23] = "Sem Elteren";
            arrayStudentName[24] = "Danny Engels";
            arrayStudentName[25] = "Angelo Esch";
            arrayStudentName[26] = "Renzo Fens";
            arrayStudentName[27] = "Salim Fenzar";
            arrayStudentName[28] = "Tony Graaf";
            arrayStudentName[29] = "Youssri Grebber";
            arrayStudentName[30] = "Camiel Groenendijk";
            arrayStudentName[31] = "Koen Grootjans";
            arrayStudentName[32] = "Nino Haan";
            arrayStudentName[33] = "Neall Haekens";
            arrayStudentName[34] = "Hassan Hassan";
            arrayStudentName[35] = "Guido Heer";
            arrayStudentName[36] = "Kane Heins";
            arrayStudentName[37] = "Jelle Helm";
            arrayStudentName[38] = "Timo Helmhout";
            arrayStudentName[39] = "Joeri Herpen";
            arrayStudentName[40] = "Loeciano Holt";
            arrayStudentName[41] = "Emir Ibrahimovic";
            arrayStudentName[42] = "Pepijn Isselt";
            arrayStudentName[43] = "Ruben Jansen";
            arrayStudentName[44] = "Sander Jongenelen";
            arrayStudentName[45] = "Rik Jurgens";
            arrayStudentName[46] = "Mohammed Kabalan";
            arrayStudentName[47] = "Feyza Keles";
            arrayStudentName[48] = "Bas Kemp";
            arrayStudentName[49] = "Aboker Khalif";
            arrayStudentName[50] = "Khaled Khodhir";
            arrayStudentName[51] = "Dion Klaassen";
            arrayStudentName[52] = "Teun Kok";
            arrayStudentName[53] = "Dani Kools";
            arrayStudentName[54] = "Dennis Krijnen";
            arrayStudentName[55] = "Yilmaz Kuru";
            arrayStudentName[56] = "Roy Kwisthout";
            arrayStudentName[57] = "Wouter Lagerwerf";
            arrayStudentName[58] = "Maher Lahlal";
            arrayStudentName[59] = "Kamiel Lande";
            arrayStudentName[60] = "Jordi Leenaars";
            arrayStudentName[61] = "John Leeuw";
            arrayStudentName[62] = "Mike Leeuwen";
            arrayStudentName[63] = "Jaibreyon Lourens";
            arrayStudentName[64] = "Mohamed Maachi";
            arrayStudentName[65] = "Doris Maas";
            arrayStudentName[66] = "Nick Meel";
            arrayStudentName[67] = "Andrea Meer";
            arrayStudentName[68] = "Glenn Meering";
            arrayStudentName[69] = "Jeremy Meijer";
            arrayStudentName[70] = "Chalome Miguel";
            arrayStudentName[71] = "Adriaan Mouthaan";
            arrayStudentName[72] = "Ajmal Muhammad";
            arrayStudentName[73] = "Ertugrul Nevik";
            arrayStudentName[74] = "Isabella Ngasiman";
            arrayStudentName[75] = "Simon Nuijten";
            arrayStudentName[76] = "Charlotte Oers";
            arrayStudentName[77] = "Griffin Paulus";
            arrayStudentName[78] = "Max Pimmelaar";
            arrayStudentName[79] = "Thomas Platjouw";
            arrayStudentName[80] = "Carlo Puijvelde";
            arrayStudentName[81] = "Kas Rasenberg";
            arrayStudentName[82] = "Donito Renne";
            arrayStudentName[83] = "Martijn Renne";
            arrayStudentName[84] = "Jessie Ridder";
            arrayStudentName[85] = "Lorenzo Rijnvos";
            arrayStudentName[86] = "Freek Roks";
            arrayStudentName[87] = "Jairo Roosenburg";
            arrayStudentName[88] = "Ronica Sahtoe";
            arrayStudentName[89] = "Batin Şimşek";
            arrayStudentName[90] = "Falco Snepvangers";
            arrayStudentName[91] = "Jermo Stadhouders";
            arrayStudentName[92] = "Alexander Staneke";
            arrayStudentName[93] = "Heinrich Steen";
            arrayStudentName[94] = "Sven Steggerda";
            arrayStudentName[95] = "Elwin Strookappe";
            arrayStudentName[96] = "Andy Sundert";
            arrayStudentName[97] = "Abdul Tarchihani";
            arrayStudentName[98] = "Martin Tax";
            arrayStudentName[99] = "Kyan Tempelaars";
            arrayStudentName[100] = "Bas Turnhout";
            arrayStudentName[101] = "Batu Ulu";
            arrayStudentName[102] = "Sofie Vaan";
            arrayStudentName[103] = "Daniël Vahabi";
            arrayStudentName[104] = "Xander Veen";
            arrayStudentName[105] = "Corwin Veltom";
            arrayStudentName[106] = "Enrico Verheij";
            arrayStudentName[107] = "Menno Vermeulen";
            arrayStudentName[108] = "Pieter Verschueren";
            arrayStudentName[109] = "Stijn Versluis";
            arrayStudentName[110] = "Aaron Vlak";
            arrayStudentName[111] = "Dimitri Vliet";
            arrayStudentName[112] = "Reno Voorwinde";
            arrayStudentName[113] = "Marieke Wempe";
            arrayStudentName[114] = "Marcel Wezel";
            arrayStudentName[115] = "Mitchel Wijt";
            arrayStudentName[116] = "Jamie Wissing";
            arrayStudentName[117] = "Esma Yilmaz";
            arrayStudentName[118] = "Floris Zanden";
            arrayStudentName[119] = "Nadir Zekari";
            arrayStudentName[120] = "Rick Zelst";
            arrayStudentName[121] = "Bart Zon";
            arrayStudentName[122] = "Bas Zuidema";
            arrayStudentName[123] = "";

            arrayStudentAbsent[10] = true;
            arrayStudentAbsent[20] = true;
            arrayStudentAbsent[13] = true;
            arrayStudentAbsent[19] = true;
            arrayStudentAbsent[10] = true;
            arrayStudentAbsent[50] = true;
            arrayStudentAbsent[53] = true;
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ToDo
        }

        bool[] arrayStudentAbsent = new bool[studentAmount];

        private void ShowStudent(int index)
        {
            studentNameLabel.Text = arrayStudentName[index];
            studentAbsentLabel.Text = arrayStudentAbsent[index].ToString();
            studentClassnameLabel.Text = arrayStudentClassName[index];

            Debug.WriteLine("Single student shown");
        }

        bool[] arrayStudentPresent = new bool[120];

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int indexStudent = FindStudent(searchEditBox.Text);

            if (indexStudent == -1)
            {
                MessageBox.Show("Error - Student not found");
            }
            else
            {
                ShowStudent(indexStudent);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[indexStudent].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[1, indexStudent];
            }


        }

        private void ReadStudentNumber()
        {
            arrayStudentnumber[0] = "234538";
            arrayStudentnumber[1] = "260504";
            arrayStudentnumber[2] = "250241";
            arrayStudentnumber[3] = "151722";
            arrayStudentnumber[4] = "270207";
            arrayStudentnumber[5] = "221207";
            arrayStudentnumber[6] = "264516";
            arrayStudentnumber[7] = "263497";
            arrayStudentnumber[8] = "263855";
            arrayStudentnumber[9] = "263576";
            arrayStudentnumber[10] = "262826";
            arrayStudentnumber[11] = "261466";
            arrayStudentnumber[12] = "250534";
            arrayStudentnumber[13] = "266558";
            arrayStudentnumber[14] = "263834";
            arrayStudentnumber[15] = "261296";
            arrayStudentnumber[16] = "263363";
            arrayStudentnumber[17] = "250629";
            arrayStudentnumber[18] = "264899";
            arrayStudentnumber[19] = "251053";
            arrayStudentnumber[20] = "267082";
            arrayStudentnumber[21] = "264380";
            arrayStudentnumber[22] = "261759";
            arrayStudentnumber[23] = "262417";
            arrayStudentnumber[24] = "267322";
            arrayStudentnumber[25] = "261331";
            arrayStudentnumber[26] = "265669";
            arrayStudentnumber[27] = "272999";
            arrayStudentnumber[28] = "267527";
            arrayStudentnumber[29] = "264156";
            arrayStudentnumber[30] = "152124";
            arrayStudentnumber[31] = "264629";
            arrayStudentnumber[32] = "265077";
            arrayStudentnumber[33] = "265381";
            arrayStudentnumber[34] = "270325";
            arrayStudentnumber[35] = "261748";
            arrayStudentnumber[36] = "252788";
            arrayStudentnumber[37] = "235401";
            arrayStudentnumber[38] = "266066";
            arrayStudentnumber[39] = "261478";
            arrayStudentnumber[40] = "267516";
            arrayStudentnumber[41] = "266214";
            arrayStudentnumber[42] = "263555";
            arrayStudentnumber[43] = "269010";
            arrayStudentnumber[44] = "257852";
            arrayStudentnumber[45] = "267091";
            arrayStudentnumber[46] = "270524";
            arrayStudentnumber[47] = "261472";
            arrayStudentnumber[48] = "266076";
            arrayStudentnumber[49] = "156561";
            arrayStudentnumber[50] = "259513";
            arrayStudentnumber[51] = "270274";
            arrayStudentnumber[52] = "261477";
            arrayStudentnumber[53] = "207374";
            arrayStudentnumber[54] = "265232";
            arrayStudentnumber[55] = "263881";
            arrayStudentnumber[56] = "266353";
            arrayStudentnumber[57] = "256768";
            arrayStudentnumber[58] = "261476";
            arrayStudentnumber[59] = "255174";
            arrayStudentnumber[60] = "264062";
            arrayStudentnumber[61] = "231093";
            arrayStudentnumber[62] = "260012";
            arrayStudentnumber[63] = "261463";
            arrayStudentnumber[64] = "251830";
            arrayStudentnumber[65] = "259420";
            arrayStudentnumber[66] = "164925";
            arrayStudentnumber[67] = "268448";
            arrayStudentnumber[68] = "262698";
            arrayStudentnumber[69] = "261333";
            arrayStudentnumber[70] = "215423";
            arrayStudentnumber[71] = "255330";
            arrayStudentnumber[72] = "255589";
            arrayStudentnumber[73] = "258308";
            arrayStudentnumber[74] = "113000";
            arrayStudentnumber[75] = "265430";
            arrayStudentnumber[76] = "204161";
            arrayStudentnumber[77] = "261475";
            arrayStudentnumber[78] = "265149";
            arrayStudentnumber[79] = "267159";
            arrayStudentnumber[80] = "254480";
            arrayStudentnumber[81] = "261874";
            arrayStudentnumber[82] = "147602";
            arrayStudentnumber[83] = "179172";
            arrayStudentnumber[84] = "232775";
            arrayStudentnumber[85] = "261445";
            arrayStudentnumber[86] = "263873";
            arrayStudentnumber[87] = "270764";
            arrayStudentnumber[88] = "261332";
            arrayStudentnumber[89] = "201115";
            arrayStudentnumber[90] = "252961";
            arrayStudentnumber[91] = "261875";
            arrayStudentnumber[92] = "221467";
            arrayStudentnumber[93] = "266188";
            arrayStudentnumber[94] = "199830";
            arrayStudentnumber[95] = "116809";
            arrayStudentnumber[96] = "264000";
            arrayStudentnumber[97] = "218984";
            arrayStudentnumber[98] = "178453";
            arrayStudentnumber[99] = "263998";
            arrayStudentnumber[100] = "228210";
            arrayStudentnumber[101] = "229187";
            arrayStudentnumber[102] = "262827";
            arrayStudentnumber[103] = "267088";
            arrayStudentnumber[104] = "261471";
            arrayStudentnumber[105] = "214464";
            arrayStudentnumber[106] = "264866";
            arrayStudentnumber[107] = "261430";
            arrayStudentnumber[108] = "262087";
            arrayStudentnumber[109] = "263999";
            arrayStudentnumber[110] = "267096";
            arrayStudentnumber[111] = "207201";
            arrayStudentnumber[112] = "265457";
            arrayStudentnumber[113] = "261474";
            arrayStudentnumber[114] = "155591";
            arrayStudentnumber[115] = "227266";
            arrayStudentnumber[116] = "269562";
            arrayStudentnumber[117] = "225629";
            arrayStudentnumber[118] = "262175";
            arrayStudentnumber[119] = "263968";
            arrayStudentnumber[120] = "272159";
            arrayStudentnumber[121] = "263528";
            arrayStudentnumber[122] = "263618";
        }

        private void ShowStudents()
        {
            {
                string[,] rows = new string[7, studentAmount-1];
                
                for(int i=0; i< studentAmount - 1; i++)
                {
                    string[] studentRow = new string[5];
                    studentRow[0] = i.ToString();
                    studentRow[1] = arrayStudentnumber[i];
                    studentRow[2] = arrayStudentName[i];
                    studentRow[3] = arrayStudentClassName[i];
                    studentRow[4] = arrayStudentAbsent[i].ToString();
                    dataGridView1.Rows.Add(studentRow);

                    if (arrayStudentAbsent[i] )
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                Debug.WriteLine("Student information added to datagridbox"); 
             }
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int studentIndex;
            int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Index"].Value.ToString(), out studentIndex);
            ShowStudent(studentIndex);
            Debug.WriteLine("Selection made from gridview");
        }

        private void openAddStudentFormButton_Click(object sender, EventArgs e)
        {
            addStudent.ShowDialog();
        }
    }
}
