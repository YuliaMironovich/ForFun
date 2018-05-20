using System;
using MetroFramework.Forms;
using TroposphericDelayApplication.Models;

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
            if(AltitudeTextBox.Text == String.Empty || LatitudeTextBox.Text == String.Empty)
            {
                MessageBox messageBox = new MessageBox();
                messageBox.Show();
            }
            else
            {
                try
                {
                    Atmosphere atmosphere = new Atmosphere();
                    string delay = String.Empty;
                    string altstring = AltitudeTextBox.Text;
                    double altitude = Convert.ToDouble(altstring.Replace(".", ","));
                    string latstring = LatitudeTextBox.Text;
                    double latitude = Convert.ToDouble(latstring.Replace(".", ","));
                    if (choiceForm.RadioButton == "saastamoinen")
                    {
                        SaastamoinenModel saastamoinenModel = new SaastamoinenModel(latitude, altitude, atmosphere);
                        delay = saastamoinenModel.ToString();

                    }
                    if (choiceForm.RadioButton == "neil")
                    {
                        NeilModel neilModel = new NeilModel(altitude);
                        delay = neilModel.ToString();
                    }
                    if (choiceForm.RadioButton == "hopfield")
                    {
                        HopfieldModel hopfieldModel = new HopfieldModel(altitude, atmosphere);
                        delay = hopfieldModel.ToString();
                    }
                    if (choiceForm.RadioButton == "black")
                    {
                        BlackModel blackModel = new BlackModel(altitude, atmosphere);
                        delay = blackModel.ToString();
                    }
                    DelayTextBox.Text = delay;
                }
                catch
                {
                    MessageBox messageBox = new MessageBox();
                    messageBox.Show();
                }
              
            }
        }

        private void BackTile_Click(object sender, EventArgs e)
        {
            this.Close();
            choiceForm.Show();
        }
    }
}
