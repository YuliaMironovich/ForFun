using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TroposphericDelayApplication.Api;
using TroposphericDelayApplication.Models;

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

        private void CalculateTile_Click(object sender, EventArgs e)
        {    
            if (LongitudeTextBox.Text == String.Empty || LatitudeTextBox.Text == String.Empty)
            {
                MessageBox messageBox = new MessageBox();
                messageBox.Show();
            }
            else
            {
                try
                {
                    string longstring = LongitudeTextBox.Text;
                    double longitude = Convert.ToDouble(longstring.Replace(".", ","));
                    string latstring = LatitudeTextBox.Text;
                    double latitude = Convert.ToDouble(latstring.Replace(".", ","));
                    string delay = String.Empty;
                    Client client = new Client();
                    client.Url = client.Url + latitude.ToString() + "," + longitude.ToString();
                    try
                    {
                        Parameters parameters = new Parameters(client.GetMethod());
                        Atmosphere atmosphere = new Atmosphere(parameters.Pressure, parameters.Temperature, parameters.Humidity);
                        if (choiceForm.RadioButton == "saastamoinen")
                        {
                            SaastamoinenModel saastamoinenModel = new SaastamoinenModel(parameters.Latitude, parameters.Elevation, atmosphere);
                            delay = saastamoinenModel.ToString();
                        }
                        if (choiceForm.RadioButton == "neil")
                        {
                            NeilModel neilModel = new NeilModel(parameters.Elevation);
                            delay = neilModel.ToString();
                        }
                        if (choiceForm.RadioButton == "hopfield")
                        {
                            HopfieldModel hopfieldModel = new HopfieldModel(parameters.Elevation, atmosphere);
                            delay = hopfieldModel.ToString();
                        }
                        if (choiceForm.RadioButton == "black")
                        {
                            BlackModel blackModel = new BlackModel(parameters.Elevation, atmosphere);
                            delay = blackModel.ToString();
                        }
                        DelayTextBox.Text = delay;
                    }
                    catch
                    {
                        BadRequestForm badRequestForm = new BadRequestForm();
                        badRequestForm.Show();
                    }                 
                }
                catch
                {
                    MessageBox messageBox = new MessageBox();
                    messageBox.Show();
                }           
            }
        }
    }
}
