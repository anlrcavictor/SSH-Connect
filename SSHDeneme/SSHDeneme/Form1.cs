using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Renci.SshNet;
namespace SSHDeneme
{
    public partial class FormSSHMain : Form
    {
        private SshClient sshClient = null;
        private ShellStream shellStreamSSH = null;

        public FormSSHMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.sshClient = new SshClient(txtHostAdress.Text, Convert.ToInt32(txtPortNumber.Text), txtUsername.Text,
                    txtPassword.Text);

                this.sshClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(120);
                this.sshClient.Connect();

               this.shellStreamSSH=this.sshClient.CreateShellStream("vt100", 80, 60, 800, 600, 65536);
                this.lbStatus.Text = "Status: Connected.";
                this.lbStatus.ForeColor = Color.Green;


            }
            catch(Exception exp)
            {
                this.lbStatus.Text = "Status: Disconnected.";
                this.lbStatus.ForeColor = Color.Red;
                MessageBox.Show("ERROR : " + exp.Message);
            }
        }

        private void FormSSHMain_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadStart threadStart = new System.Threading.ThreadStart(recvSSHData);
            System.Threading.Thread thread = new System.Threading.Thread(threadStart);

            thread.IsBackground = true;
            thread.Start();
        }

        private void recvSSHData()
        {
            while (true)
            {
                try
                {
                    if (this.shellStreamSSH !=null && this.shellStreamSSH.DataAvailable)
                    {
                        String strData = this.shellStreamSSH.Read();

                        strData = strData.Replace("[01;34m", "");
                        strData = strData.Replace("[00m", "");
                        strData = strData.Replace("[m", "");
                        strData = strData.Replace("[0m", "");
                        //strData = strData.Replace("", "");
                        appendTextBoxInThread(txtSSHConsole, strData);
                    }
                }
                catch
                {

                }
                System.Threading.Thread.Sleep(200);
            }
        }
        private void appendTextBoxInThread(TextBox t,String s)
        {
            if (t.InvokeRequired)
            {
                t.Invoke(new Action<TextBox, string>(appendTextBoxInThread), new object[] { t, s });
            }
            else
            {
                t.AppendText(s);
            }
        }


        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    this.shellStreamSSH.Write(txtCommand.Text + ";\r\n");
                    this.shellStreamSSH.Flush();

                    txtCommand.Text = "";
                    txtCommand.Focus();

                }
            }
            catch(Exception exp)
            {

            }
        }

        private void FormSSHMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.shellStreamSSH.Close();

            }
            catch
            {

            }

            try
            {
                this.sshClient.Disconnect();
            }
            catch
            {

            }
        }


        int index;
        string[] dizi;
        string rep;
        private void btnIfconfig_Click(object sender, EventArgs e)
        {

            


            //string sonuc = sshClient.RunCommand("ifconfig;\r\n").Result;
            shellStreamSSH.Write("ifconfig;\r\n");
            rep = this.shellStreamSSH.Expect("test@ubuntu:~$");
            txtSSHConsole.AppendText(rep);
            //rep=this.shellStreamSSH.Expect(new Regex(@"[$>]"));
            dizi = rep.Split('\n');

            


                    lbMac.Text = "Mac : " + Atomik.SatırSonunaKadarKes(dizi[1], "HWaddr", 6);
                    lbIp.Text = "IP : " + Atomik.belirttiginYereKadarKes(dizi[2], "inet addr:", 10, 14);
                    lbSubnetMask.Text = "Subnet Mask:" + Atomik.SatırSonunaKadarKes(dizi[2], "Mask:", 5);


                        string rep2 = this.shellStreamSSH.Expect("test@ubuntu:~$");
                        label1.Text = rep2;
                        //string rep2 = this.shellStreamSSH.Expect(new Regex(@"[$>]"));

                        shellStreamSSH.Write("ping -c 5 "+txtHostAdress.Text+";\r\n");
                        
                        //string rep1 = this.shellStreamSSH.Expect(new Regex(@"[$>]"));
                        string rep1 = this.shellStreamSSH.Expect("test@ubuntu:~$");
                        txtSSHConsole.AppendText(rep1);

                if (rep1.Contains("rtt"))
                        {
                            lbPing.Text = "Ping : Başarılı";
                        }
                        else
                        {
                            lbPing.Text = "Ping : Başarısız";
                        }
                    
                //}

            





            //txtSSHConsole.Text = @"ens33     Link encap:Ethernet  HWaddr 00:0c:29:7e:24:c5  
            //          inet addr:192.168.1.41  Bcast: 192.168.1.255  Mask: 255.255.255.0
            //          inet6 addr: fe80::3564:d530: 6b52: fbd8 / 64 Scope: Link
            //               UP BROADCAST RUNNING MULTICAST MTU:1500  Metric: 1
            //          RX packets:397 errors: 0 dropped: 0 overruns: 0 frame: 0
            //          TX packets:160 errors: 0 dropped: 0 overruns: 0 carrier: 0
            //          collisions: 0 txqueuelen: 1000
            //          RX bytes:56259(56.2 KB)  TX bytes:23319(23.3 KB)

            //lo Link encap: Local Loopback
            //          inet addr:127.0.0.1  Mask: 255.0.0.0
            //          inet6 addr: ::1 / 128 Scope: Host
            //             UP LOOPBACK RUNNING  MTU: 65536  Metric: 1
            //          RX packets:197 errors: 0 dropped: 0 overruns: 0 frame: 0
            //          TX packets:197 errors: 0 dropped: 0 overruns: 0 carrier: 0
            //          collisions: 0 txqueuelen: 1
            //          RX bytes:14685(14.6 KB)  TX bytes:14685(14.6 KB)";


            //lbMac.Text = "Mac : " + Atomik.SatırSonunaKadarKes(dizi[0], "HWaddr", 6);
            //lbIp.Text = "IP : " + Atomik.belirttiginYereKadarKes(dizi[1], "inet addr:", 10, 14);
            //lbSubnetMask.Text = "Subnet Mask:" + Atomik.SatırSonunaKadarKes(dizi[1], "Mask:", 5);

            //this.shellStreamSSH.Expect(new Regex(@"[$>]"));
        }

        private void txtSSHConsole_TextChanged(object sender, EventArgs e)
        {

            string kayıt = txtSSHConsole.Text;
            string txtIsim = @"c:\SSHKayıt\"+DateTime.Now.ToShortDateString()+".txt";
            StreamWriter dosya = File.AppendText(txtIsim);
            dosya.WriteLine(txtSSHConsole.Text + "\r\n"+"\r\n");
            dosya.WriteLine("-----------------------------------------------------------");
            dosya.Close();
        }

        private void lbSubnetMask_Click(object sender, EventArgs e)
        {

        }

        

        private void txtHostAdress_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
