using System;
using MetroFramework.Forms;

namespace TroposphericDelayApplication
{
    public partial class StandartCalculationDelayForm : MetroForm
    {
        AlgorithmChoiceForm choiceForm;
        public StandartCalculationDelayForm(AlgorithmChoiceForm choiceForm)
        {
            this.choiceForm = choiceForm;
            InitializeComponent();
        }

        private void StandartCalculationDelayForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculateTile_Click(object sender, EventArgs e)
        {
            double value;
            MetroFramework.Controls.MetroUserControl sdsdsd = new MetroFramework.Controls.MetroUserControl();
            if(AltitudeTextBox.Text == String.Empty || LatitudeTextBox.Text == String.Empty || Double.TryParse(AltitudeTextBox.Text, out value) || Double.TryParse(LatitudeTextBox.Text, out value))
            {
                MessageBox messageBox = new MessageBox();
                messageBox.Show();
            }
            else
            {

            }
        }

        private void AltitudeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void LatitudeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void DelayTextBox_Click(object sender, EventArgs e)
        {

        }

        private void BackTile_Click(object sender, EventArgs e)
        {
            this.Close();
            choiceForm.Show();
        }
    }
}
