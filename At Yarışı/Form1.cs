using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik,dorduncuatuzaklik,birinciatgenislik,ikinciatgenislik,ucuncuatgenislik,dorduncuatgenislik,kazanan1=0,kazanan2=0,kazanan3=0,kazanan4=0;

        private void button2_Click(object sender, EventArgs e)
        {
            kos.Enabled = false;
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;
            label6.Text = "";
            button1.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        Random rasgele = new Random();


        private void kos_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + rasgele.Next(5, 17);
            pictureBox2.Left = pictureBox2.Left + rasgele.Next(5, 17);
            pictureBox3.Left = pictureBox3.Left + rasgele.Next(5, 17);
            pictureBox4.Left = pictureBox3.Left + rasgele.Next(5, 17);

            birinciatgenislik = pictureBox1.Width;
            ikinciatgenislik = pictureBox2.Width;
            ucuncuatgenislik = pictureBox3.Width;
            dorduncuatgenislik = pictureBox4.Width;

            if (pictureBox1 .Left > pictureBox2 .Left + 5 && pictureBox1 .Left > pictureBox3 .Left + 5 && pictureBox1 .Left > pictureBox4 .Left + 5)
            {
                label6.Text = "1 NUMARALI RÜZGAR BATUR YARIŞI ÖNDE GÖTÜRÜYOR...!";

                if (pictureBox1.Left + birinciatgenislik >= label5.Left)
                {
                    label6.Text = "1 NUMARALI RÜZGAR BATUR YARIŞI KAZANDI.!";
                    kos.Enabled = false;
                    MessageBox.Show("1 NUMARALI RÜZGAR BATUR YARIŞI KAZANDI.!","KAZANAN");
                    kazanan1 = kazanan1 + 1;
                    label10.Text = kazanan1.ToString ();
                    button1.Enabled = false;
                    
                }

            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2 .Left > pictureBox4 .Left + 5)
            {
                label6.Text = "2 NUMARALI BABASININ OĞLU YARIŞI ÖNDE GÖTÜRÜYOR...!";


                if (pictureBox2.Left + ikinciatgenislik >= label5.Left)
                {
                    label6.Text = "2 NUMARALI BABASININ OĞLU YARIŞI KAZANDI.!";
                    kos.Enabled = false;
                    MessageBox.Show("2 NUMARALI BABASININ OĞLU YARIŞI KAZANDI.!", "KAZANAN");
                    kazanan2 = kazanan2 + 1;
                    label11.Text = kazanan2.ToString();
                    button1.Enabled = false;
                }
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3 .Left > pictureBox4 .Left + 5)
            {
                label6.Text = "3 NUMARALI TANGOCU YARIŞI ÖNDE GÖTÜRÜYOR...!";


                if (pictureBox3.Left + ucuncuatgenislik >= label5.Left)
                {
                    label6.Text = "3 NUMARALI TANGOCU YARIŞI KAZANDI.!";
                    kos.Enabled = false;
                    MessageBox.Show("3 NUMARALI TANGOCU YARIŞI KAZANDI.!", "KAZANAN");
                    kazanan3 = kazanan3 + 1;
                    label12.Text = kazanan3.ToString();
                    button1.Enabled = false;
                }
            }



            if (pictureBox4.Left > pictureBox1.Left + 5 && pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4 .Left > pictureBox3 .Left + 5)
            {
                label6.Text = "4 NUMARALI NARKIZ YARIŞI ÖNDE GÖTÜRÜYOR...!";


                if (pictureBox4.Left + dorduncuatgenislik >= label5.Left)
                {
                    label6.Text = "4 NUMARALI NARKIZ YARIŞI KAZANDI.!";
                    kos.Enabled = false;
                    MessageBox.Show("4 NUMARALI NARKIZ YARIŞI KAZANDI.!", "KAZANAN");
                    kazanan4 = kazanan4 + 1;
                    label15.Text = kazanan4.ToString();
                    button1.Enabled = false;
                }
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Start
            kos.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
            dorduncuatuzaklik = pictureBox4.Left;

            

        }
    }
}
