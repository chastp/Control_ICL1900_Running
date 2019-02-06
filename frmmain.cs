using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_ICL1904
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "Run_ICL1904_G3.btm";
            ExecPro(process1, arg);
        }
        private void ExecPro(string ProcessName, string args)
        {
            try
            {
                string drive1 = Properties.Settings.Default.Drive1;
                string drive2 = Properties.Settings.Default.Drive2;
                string wkdir = Properties.Settings.Default.Wkdir1;
                string wkdir2 = Properties.Settings.Default.wkdir2;
                txtmessage.Text = "";
                string command1 = drive1 + wkdir + "\\" + ProcessName;
                ProcessStartInfo processInfo;
                string arg1 = args;
                arg1 = drive2 + wkdir2 + "\\" + args;
                processInfo = new ProcessStartInfo
                {
                    UseShellExecute = true, // change value to false
                    FileName = command1,
                    Arguments = arg1,
                    RedirectStandardError = false,
                    RedirectStandardOutput = false
                };
                Process process1;
                process1 = new Process
                {
                    StartInfo = processInfo
                };
                txtcommand.Text = process1.StartInfo.FileName.ToString() + " " + arg1.ToString();
                process1.Start();
                process1.WaitForExit();
            }
            catch (Exception ex)
            {
                txtmessage.Text = ex.Message.ToString();
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "Run_ICL1904_G6.btm ";
            ExecPro(process1, arg);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtmessage.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "printdrdump.btm ";
            ExecPro(process1, arg);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "lookmt.txt ";
            ExecPro(process1, arg);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "lookmt.list ";
            ExecPro(process1, arg);
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "run_term.btm";
            ExecPro(process1, arg);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void COBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\COBOL\\tp4427_Cobol.djvu");
            frm1.Show();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImage frmimage1;
            frmimage1 = new frmImage();
            frmimage1.Show();
        }
        private void CompilingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\COBOL\\tp4426_Cobol_Compilers.djvu");
            frm1.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "cardedit.exe ";
            ExecPro(process1, arg);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "CardViewer.exe ";
            ExecPro(process1, arg);
        }

        private void RunICL1904G3SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_ICL1904s.btm ";
            ExecPro(process1, arg);
        }

        private void RunICL1904G6SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_ICL1905.btm ";
            ExecPro(process1, arg);
        }

        private void RunICL1904G3EESystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadVDUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_ICL_VDU.btm ";
            ExecPro(process1, arg);
        }

        private void CreateCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = " cardedit.exe";
            ExecPro(process1, arg);
        }

        private void CreateCardsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string process1 = "tcc.exe  ";
            string arg = "run_cardedit.btm ";
            ExecPro(process1, arg);
        }

        private void ViewCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "run_cardview.btm ";
            ExecPro(process1, arg);
        }

        private void ProgrammingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\TPS_Manuals\\TPS_Programming_Part_1.pdf");
            frm1.Show();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0899C-TB_DBMS-10admin.pdf");
            frm1.Show();
        }

        private void CobolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0901C-TB_DBMS-10prog.pdf");
            frm1.Show();
        }

        private void EmulateSystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenCOBOLIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "run_EditCobol.btm  " + txtCOBOL.Text.ToString();
            ExecPro(process1, arg);
        }

        private void TelnetOn1900ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe ";
            string arg = "  telnet.exe open localhost 10001 ";
            ExecPro(process1, arg);
        }

        private void InstalationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\NIMMs\\tp4248_MIMMS_Implementation.djvu");
            frm1.Show();
        }

        private void InstalationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Datafeed Installation
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\Datafeed\\tp4395_Datafeed_Systems.djvu");
            frm1.Show();
        }

        private void FileHandlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\NIMMs\\tp4243_NIMMS_File_Handler.djvu");
            frm1.Show();
        }

        private void DataManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nimms  Installation
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\NIMMs\\tp4250_NIMMS_Data_Management_System.djvu");
            frm1.Show();
        }

        private void IntroductionToCOBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // COBOL
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\COBOL\\tp4118_Introduction_COBOL.djvu");
            frm1.Show();
        }

        private void COBOLAncilliriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // COBOL
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\COBOL\\tp4217_COBOL_Ancilliries.djvuu");
            frm1.Show();
        }

        private void COBOLExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // COBOL
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\COBOL\\tp4436_Cobol_Extras.djvu");
            frm1.Show();
        }

        private void BasicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // BASIC
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\BASIC\\tp4281_Basic.djvu");
            frm1.Show();
        }

        private void CityAndGuildsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // City and Guilds
            frmDocs frm1 = new frmDocs("C:\\em1904\\ICL_1900_Manuals\\City_Guilds\\City and Guilds Mnemonic Manual.docx");
            frm1.Show();
        }

        private void AlterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frms;
            frms = new FrmSettings();
            frms.Show();
        }

        private void runICL1901SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_ICL1901A.btm ";
            ExecPro(process1, arg);
        }

        private void runICLTerminalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_ICL_VDU.btm ";
            ExecPro(process1, arg);
        }

        private void eDITMACROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_EditMacro.btm " + txtCOBOL.Text.ToString();
            ExecPro(process1, arg);
        }

        private void rUNCOBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_CobRun.btm " + txtCOBOL.Text.ToString();
            ExecPro(process1, arg);
        }

        private void compileCOBOLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string process1 = "tcc.exe";
            string arg = "run_Cobc.btm " + txtCOBOL.Text.ToString();
            ExecPro(process1, arg);
        }
    }
}
