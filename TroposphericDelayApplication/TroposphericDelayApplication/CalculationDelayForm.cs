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
    public partial class CalculationDelayForm : MetroFramework.Forms.MetroForm
    {
        AlgorithmChoiceForm choiceForm;
        public CalculationDelayForm(AlgorithmChoiceForm choiceForm)
        {
            this.choiceForm = choiceForm;
            InitializeComponent();
        }

        private void CalculationDelayForm_Load(object sender, EventArgs e)
        {

        }

        private void BackTile_Click(object sender, EventArgs e)
        {
            this.Close();
            choiceForm.Show();
        }

        private void LatitudeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void LongitudeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTile_Click(object sender, EventArgs e)
        {

        }
    }
}
