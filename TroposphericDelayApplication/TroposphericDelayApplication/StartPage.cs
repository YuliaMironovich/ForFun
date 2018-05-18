using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TroposphericDelayApplication
{
    public partial class StartPage : MetroFramework.Forms.MetroForm
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userDataTileButton_Click(object sender, EventArgs e)
        {
            AlgorithmChoiceForm algorithmChoiseForm = new AlgorithmChoiceForm("user data", this);
            this.Visible = false;
            algorithmChoiseForm.Show(); 
        }

        private void standartDataTileButton_Click(object sender, EventArgs e)
        {
            AlgorithmChoiceForm algorithmChoiseForm = new AlgorithmChoiceForm("standart data", this);
            this.Visible = false;
            algorithmChoiseForm.Show();
        }
    }
}
