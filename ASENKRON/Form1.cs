using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASENKRON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            Cikar(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text), Convert.ToInt32(txtNumber3.Text));
        }

        private async void btnBol_Click(object sender, EventArgs e)
        {
            await BolAsync(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
        }

        private async void btnBirlestir_Click(object sender, EventArgs e)
        {
            await BirlestirAsync(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text), Convert.ToInt32(txtNumber3.Text));
        }
        public void Cikar(int Number1,int Number2,int Number3)
        {

            MessageBox.Show((Number1-Number2-Number3).ToString());


        }
        public Task BolAsync(int Number1,int Number2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show((Number1 / Number2).ToString());


            });
        }
        public Task BirlestirAsync(int Number1,int Number2,int Number3)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show((Number1,Number2,Number3).ToString());


            });

        }
    }
}
