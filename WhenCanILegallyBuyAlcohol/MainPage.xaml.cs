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
                var timeBetweenYears = DateTime.Now.Subtract(DatePicker.Date);
                var dateThisYear = new DateTime(DateTime.Now.Year, DatePicker.Date.Month, DatePicker.Date.Day);

                int age = (int)timeBetweenYears.TotalDays / 365;
                if (dateThisYear > DateTime.Now && dateThisYear.Day > DateTime.Now.Day)
                {
                    age -= 1;
                }

                int yearsUntilLegal = 21 - age;

                string labelText;
                if (yearsUntilLegal == 1 && dateThisYear.Subtract(DateTime.Now).TotalDays < 365)
                {
                    labelText = $"You can buy alcohol in less than a year!";
                }
                else if (yearsUntilLegal > 0) {
                    
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
