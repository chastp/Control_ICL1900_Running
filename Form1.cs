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
    public partial class Form1 : Form
    {
        private string coutext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = " R Run_ICL1904_G3 ";
            string wrkdir1 = "c:\\em1904s\\bin";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }
        private String ExecPro(string ProcessName, string args, string WrkDir, string cmdtxt)
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = ProcessName;
                cmd.StartInfo.Arguments = args;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.WorkingDirectory = WrkDir;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.ErrorDialog = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardError = true;

                cmd.Start();
                StreamWriter cin = cmd.StandardInput;
                StreamReader cout = cmd.StandardOutput;

                cin.WriteLine(cmdtxt);
                cin.Close();
                coutext = cout.ReadToEnd();
                cmd.WaitForExit();
                cmd.Close();
                return coutext;
            }
            catch (Exception ex)
            {
                Simplelogger log1;
                log1 = new Simplelogger();
                string commandfile = ProcessName;
                string filename = WrkDir + "\\" + cmdtxt;
                txtmessage.Text = ex.Message + "(" + commandfile + filename + " - " + args +  ")";
                log1.Fatal(ex.Message + "(" + commandfile + filename + " - " + args + ")");
                return "Error";
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = " R Run_ICL1904_G6 ";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtmessage.Text = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R printicltape ";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R printdrdump ";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "Notepad.exe ";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "lookmt.txt";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "Notepad.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "lookmt.list";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }




        private void Button6_Click_1(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R run_term ";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void COBOLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\g3exec\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R run ";
            string wrkdir1 = "c:\\g3exec\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\COBOL\\tp4427_Cobol.djvu");
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
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\COBOL\\tp4426_Cobol_Compilers.djvu");
            frm1.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\bin\\cardedit.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\bin\\CardViewer.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void runICL1904G3SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R Run_ICL1904_G3";
            string wrkdir1 = "c:\\em1904s\\bin";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void runICL1904G6SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R Run_ICL1904_G6";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void runICL1904G3EESystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadVDUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\RUN_ICL1900_Mainframe.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "R run_term";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void createCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\bin\\cardedit.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void createCardsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\bin\\cardedit.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void viewCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txtrun = "";
            string cmd = "c:\\em1904s\\bin\\CardViewer.exe";
            string process1 = "c:\\em1904s\\bin\\tcc.exe";
            string arg = "";
            string wrkdir1 = "c:\\em1904s\\bin\\";
            txtrun = ExecPro(process1, arg, wrkdir1, cmd);
        }

        private void programmingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\TPS_Manuals\\TPS_Programming_Part_1.pdf");
            frm1.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0899C-TB_DBMS-10admin.pdf");
            frm1.Show();
        }

        private void cobolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDocs frm1 = new frmDocs("C:\\em1904s\\ICL_1900_Manuals\\IDMS_Manuals\\AA-0901C-TB_DBMS-10prog.pdf");
            frm1.Show();
        }
    }
}
