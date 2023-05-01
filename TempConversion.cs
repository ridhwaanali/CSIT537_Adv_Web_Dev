using System;

public partial class TemperatureConversion : System.Web.UI.Page
{
	protected void btnCToF_Click(object sender, EventArgs e)
	{

        / get the temperature entered in C
        double temperatureInC = Convert.ToDouble(txtCelsius.Text.Trim());
        //convert the temperature into F
        double temperatureInF = (temperatureInC * (9.0 / 5.0)) + 32.0;
        //display the temperature in F
        txtFahrenheit.Text = temperatureInF.ToString();
    }
    protected void btnFToC_Click(object sender, EventArgs e)
    {
        //get the temperature entered in F
        double temperatureInF = Convert.ToDouble(txtFahrenheit2.Text.Trim());
        //convert the temperature into C
        double temperatureInC = (temperatureInF - 32.0) * (5.0 / 9.0);
        //display the temperature in C
        txtCelsius2.Text = temperatureInC.ToString();
    }
}
