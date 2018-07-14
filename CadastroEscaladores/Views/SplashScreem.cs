using CadastroEscalador;
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

namespace CadastroEscaladores.Views
{
    public partial class SplashScreem : Form
    {
       
        public SplashScreem()
        {
            InitializeComponent();
            new Thread(() => new Principal()).Start();

        }

        private void TimerSplashScreem_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                
                TimerSplashScreem.Enabled = false;


                new Principal().Show();
                this.Visible = false;
            }
        }
    }
}
