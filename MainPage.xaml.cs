using System.Runtime.Intrinsics.X86;
using Microsoft.Maui.Controls; // Ensure you have the correct using directive for ContentPage

namespace calculators
{
    public partial class MainPage : ContentPage
    {
        const double UnderWeight = 18.5;
        const double NormalWeight = 24.5;
        const double OverWeight = 29.9;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var weight = double.Parse(Weight.Text);
            var height = double.Parse(Height.Text);
            var imc = weight / (height * height);
            BMI.Text = imc.ToString("F2");
            string result = GetBmiMessage(imc);
            DisplayAlert("Result", result, "OK"); // Corrected single quotes to double quotes
        }

        private string GetBmiMessage(double imc)
        {
            if (imc < UnderWeight)
            {
                return "You have low weight";
            }
            else if (imc <= NormalWeight)
            {
                return "Your weight is normal";
            }
            else
            {
                return "You are overweight";
            }
        }
    }
}
