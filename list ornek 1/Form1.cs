using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ornek_1
{
    public partial class Form1 : Form
    {
        List<int> sayilar = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayilar.Text);
            sayilar.Add(sayi);

            lbSayilar.DataSource = sayilar.ToList();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20;i++)
            {
                Random random = new Random();
                int sayi = random.Next(0, 101);
                lbSayilar.Items.Add(sayi);
            }
           
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = sayilar[0];
            MessageBox.Show(sayi.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = sayilar[sayilar.Count - 1];
            MessageBox.Show(sayi.ToString());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = sayilar.Max();
            MessageBox.Show(sayi.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi=sayilar.Min();
            MessageBox.Show(sayi.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayilar.Clear();
            MessageBox.Show(sayilar.ToString());
        }
    }
}
