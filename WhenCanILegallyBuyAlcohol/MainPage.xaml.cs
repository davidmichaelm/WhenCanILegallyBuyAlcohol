using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WhenCanILegallyBuyAlcohol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void SubmitButton_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                int age = Int32.Parse(AgeInput.Text);
                int yearsUntilLegal = 21 - age;

                string labelText;
                if (yearsUntilLegal > 0) {
                    labelText = $"You can buy alcohol in {yearsUntilLegal} year{(yearsUntilLegal > 1 ? "s" : "")}.";
                }
                else
                {
                    labelText = "You can legally buy alcohol!";
                }
                YearsLabel.Text = labelText;
            }
            catch
            {
                YearsLabel.Text = "Input error";
            }
        }
    }
}
