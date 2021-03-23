using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Client_Info_Tool
{
    public partial class ContactHD : UserControl
    {


        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public ContactHD()
        {
            InitializeComponent();
        }

        private void ContactHD_Load(object sender, EventArgs e)
        {

        }

        private void bt_sendmail_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(Environment.GetEnvironmentVariable("TEMP") + @"\info.txt");
            List<string> lista = new List<string>();
            while (!reader.EndOfStream)
            {
                string adat = reader.ReadLine();
                lista.Add(adat);

            }
            reader.Close();

            string clientname = lista[0];
            string dom = lista[1];
            string felh = lista[2];
            string szabad = lista[3];
            string op = lista[4];
            string b = lista[5];
            string friss = lista[6];
            string methernet = lista[7];
            string mwlan = lista[8];
            string ipcim = lista[9];
            string gyar = lista[10];
            string mod = lista[11];
            string biosinfo = lista[12];


            tb_uzenet.Text = tb_uzenet.Text + Environment.NewLine + "!!!!!!!DO NOT DELETE!!!!!!!" + Environment.NewLine + "Gépnév: " + clientname + Environment.NewLine + "Domain: " + dom + Environment.NewLine +
                "Felhasználó: " + felh + Environment.NewLine + "Szabad hely: " + szabad + Environment.NewLine +
                "Op. renszer: " + op + Environment.NewLine + "Build: " + b + Environment.NewLine +
                "Legutóbbi frissítés: " + friss + Environment.NewLine + "MAC (ethernet): " + methernet +
                Environment.NewLine + "MAC (WLAN): " + mwlan + Environment.NewLine + "IP cím: " + ipcim + Environment.NewLine +
                "Gyártó: " + gyar + Environment.NewLine + "Modell: " + mod + Environment.NewLine + "BIOS: " + biosinfo + Environment.NewLine + "!!!!!!!DO NOT DELETE!!!!!!!" + Environment.NewLine +
                Environment.NewLine;

            lista.Clear();
            


            login = new NetworkCredential(tb_cim.Text, tb_jelszo.Text);
            if (rb_gmail.Checked == true)
            {

                client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;

            }
            else
            {
                client = new SmtpClient(tb_smtp.Text);
                client.Port = Convert.ToInt32(tb_port.Text);
                client.EnableSsl = cb_ssl.Checked;
            }

            

            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(tb_cim.Text + tb_smtp.Text.Replace("smtp", "@"), "Ügyfél", Encoding.UTF8) };
            msg.To.Add(new MailAddress("bojtesoft@gmail.com"));
            msg.Subject = tb_targy.Text;
            
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            
            msg.Body = tb_uzenet.Text + Environment.NewLine + Environment.NewLine;


            msg.Priority = MailPriority.High;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Küldés folyamatban...";
            client.SendAsync(msg, userstate);

            tb_jelszo.Clear();
            tb_cim.Clear();
            tb_port.Clear();
            tb_smtp.Clear();
            tb_targy.Clear();
            tb_uzenet.Clear();
            rb_gmail.Checked = true;
            cb_ssl.Checked = false;
        }

        private static void SendCompletedCallback(object sebder, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} üzenet küldése megszakítva", e.UserState), "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format("Üzenet sikeresen elküldve."), "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                

        }



        private void rb_other_CheckedChanged(object sender, EventArgs e)
        {
            lb_port.Visible = true;
            tb_port.Visible = true;
            lb_smtp.Visible = true;
            tb_smtp.Visible = true;
            cb_ssl.Visible = true;
        }

        private void rb_gmail_CheckedChanged(object sender, EventArgs e)
        {
            lb_port.Visible = false;
            tb_port.Visible = false;
            lb_smtp.Visible = false;
            tb_smtp.Visible = false;
            cb_ssl.Visible = false;
        }


    }
}
