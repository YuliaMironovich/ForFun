using System;
using MetroFramework.Controls;

namespace TroposphericDelayApplication
{
    public partial class AlgorithmChoiceForm : MetroFramework.Forms.MetroForm
    {
        public string Data { get; private set; }
        public string RadioButton { get; private set; }

        StartPage startPage;
        public AlgorithmChoiceForm(string data, StartPage startPage)
        {
            InitializeComponent();
            Data = data;
            this.startPage = startPage;
        }

        private void AlgorithmChoiceForm_Load(object sender, EventArgs e)
        {
        }

        private void SaastamoinenModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetroRadioButton radioButton = (MetroRadioButton)sender;
            if(radioButton.Checked == true)
            {
                RadioButton = "saastamoinen";
            }
        }

        private void NeilModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetroRadioButton radioButton = (MetroRadioButton)sender;
            if (radioButton.Checked == true)
            {
                RadioButton = "neil";
            }
        }

        private void HopfieldModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetroRadioButton radioButton = (MetroRadioButton)sender;
            if (radioButton.Checked == true)
            {
                RadioButton = "hopfield";
            }
        }

        private void BlackModelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetroRadioButton radioButton = (MetroRadioButton)sender;
            if (radioButton.Checked == true)
            {
                RadioButton = "black";
            }
        }

        private void ForwardTile_Click(object sender, EventArgs e)
        {
            if(Data == "user data")
            {
                CalculationDelayForm calculationForm = new CalculationDelayForm(this);
                this.Visible = false;
                calculationForm.Show();
            }
            else
            {
                StandartCalculationDelayForm standartCalculationForm = new StandartCalculationDelayForm(this);
                this.Visible = false;
                standartCalculationForm.Show();
            }          

        }

        private void BackTile_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage.Show();
        }
    }
}
