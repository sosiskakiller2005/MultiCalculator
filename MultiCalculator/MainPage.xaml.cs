namespace MultiCalculator;

public partial class MainPage : ContentPage
{
    double number1;
    double number2;
    string action;
    bool isSecond;
	public MainPage()
	{
		InitializeComponent();
        isSecond = false;
	}

    private void deleteBtn_Clicked(object sender, EventArgs e)
    {
		textEntry.Text = string.Empty;
    }

    public void backSpaceBtn_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textEntry.Text))
        {
            textEntry.Text = textEntry.Text;
        }
        else
        {
            string text = textEntry.Text;
            int length = textEntry.Text.Length;
            textEntry.Text = string.Empty;
            for (int i = 0; i < length - 1; i++)
            {
                textEntry.Text += text[i];
            }
            textEntry.CursorPosition = 0;
        }
        if (string.IsNullOrEmpty(smallTextEntry.Text))
        {
            smallTextEntry.Text = smallTextEntry.Text;
        }
        else
        {
            string text = smallTextEntry.Text;
            int length = smallTextEntry.Text.Length;
            smallTextEntry.Text = string.Empty;
            for (int i = 0; i < length - 1; i++)
            {
                smallTextEntry.Text += text[i];
            }
            smallTextEntry.CursorPosition = 0;
        }
    }

    private void plusBtn_Clicked(object sender, EventArgs e)
    {
        number1 = Convert.ToDouble(textEntry.Text);
        textEntry.Text = "";
        smallTextEntry.Text += "+";
        action = "+";
        isSecond = true;
    }

    private void equalsBtn_Clicked(object sender, EventArgs e)
    {
        smallTextEntry.Text += action;
        double result;
        double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        if (action == "+")
        {
            result = number1 + Convert.ToDouble(textEntry.Text);
            smallTextEntry.Text += $" = " + result;
            textEntry.Text = result.ToString();

        }
    }

    private void divModBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void divBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void multiBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void minusBtn_Clicked(object sender, EventArgs e)
    {

    }
    #region Кнопки цифр
    private void zero_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "0";
        smallTextEntry.Text += "0";
    }
    private void one_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "1";
        smallTextEntry.Text += "1";
    }
    private void two_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "2";
        smallTextEntry.Text += "2";
    }
    private void three_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "3";
        smallTextEntry.Text += "3";
    }
    private void four_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "4";
        smallTextEntry.Text += "4";
    }
    private void five_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "5";
        smallTextEntry.Text += "5";
    }
    private void six_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "6";
        smallTextEntry.Text += "6";
    }

    private void seven_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "7";
        smallTextEntry.Text += "7";
    }

    private void eight_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "8";
        smallTextEntry.Text += "8";
    }
    private void nine_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += "9";
        smallTextEntry.Text += "9";
    }
    private void comma_Clicked(object sender, EventArgs e)
    {
        textEntry.Text += ",";
        smallTextEntry.Text += ",";
    }
    #endregion
}

