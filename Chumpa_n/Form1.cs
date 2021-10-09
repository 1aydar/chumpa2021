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
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;

namespace Chumpa_n
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false; // костыль :(
            DateTime dateTime = DateTime.Now;
            textBox2.AppendText(dateTime.ToString("f"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Experimental mode unlocks few locked and unfinished functions, be careful!");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"C:\";
            p.StartInfo.UseShellExecute = false;
            p.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string URL = textBox1.Text;
            string ping_cmd = " -n 8";      // родил метод, как запускать через командную строку команду вместе с параметрами
            string strCmdText = "/c ping " + URL + ping_cmd;
            System.Diagnostics.Process.Start("CMD", strCmdText);
            //  textBox2.AppendText(" ping");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ip_external = new WebClient().DownloadString("http://icanhazip.com/"); // Получение внешнего IP
            label1.Text = ip_external.ToString();
            button3.Enabled = false; // костыль :(
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String host = System.Net.Dns.GetHostName(); // Получение имени машины.
            label3.Text = host.ToString();
            button1.Enabled = false; // костыль :(
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var local_ip = Dns.GetHostEntry(Dns.GetHostName()); // thx to https://www.delftstack.com/howto/csharp/get-local-ip-address-in-csharp/
            foreach (var ip in local_ip.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    label2.Text = ip.ToString();
                    button2.Enabled = false; // костыль :(
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;

            if (box.TextLength > 0)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void windowsVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("winver");
        }

        private void timeAndDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("timedate.cpl");
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr");
        }

        private void programsAndFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("appwiz.cpl");
        }

        private void networkConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }

        private void powerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg.cpl");
        }

        private void windowsFirewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Firewall.cpl");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Process.Start("hdwwiz.cpl");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Process.Start("compmgmt.msc");
        }

        private void systemPropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("sysdm.cpl");
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chkdsk");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Process.Start("regedit");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Process.Start("dxdiag");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Process.Start("diskmgmt.msc");
        }

        private void diskDefragmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("dfrgui.exe");
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Process.Start("diskpart");
        }

        private void eventViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("eventvwr.msc");
        }

        private void foldersPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strcntrlText = "/c folders ";
            System.Diagnostics.Process.Start("control", strcntrlText);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc");
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            string strcntrlText = "/c pause";
            System.Diagnostics.Process.Start("ipconfig", strcntrlText);
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chump-a 2021 is a simple launcher for Windows utilities.\nAuthor: Aydar Gainullin\nsadfrogpepe@ya.ru");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void systemConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msconfig.exe");
        }

        private void taskSchedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("taskschd.msc");
        }

        private void systemRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rstrui");
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\windows\system32\sysprep\sysprep.exe");
        }
    }
}
