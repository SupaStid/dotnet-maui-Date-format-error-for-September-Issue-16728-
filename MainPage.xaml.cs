namespace MauiApp2;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();

		lbJan.Text = DateTime.Parse(Jan.Text).ToString("dd-MMM-yyyy");
        lbFeb.Text = DateTime.Parse(Feb.Text).ToString("dd-MMM-yyyy");
		lbMar.Text = DateTime.Parse(Mar.Text).ToString("dd-MMM-yyyy");

        lbApr.Text = DateTime.Parse(Apr.Text).ToString("dd-MMM-yyyy");
        lbMay.Text = DateTime.Parse(May.Text).ToString("dd-MMM-yyyy");
        lbJun.Text = DateTime.Parse(Jun.Text).ToString("dd-MMM-yyyy");

        lbJul.Text = DateTime.Parse(Jul.Text).ToString("dd-MMM-yyyy");
        lbAug.Text = DateTime.Parse(Aug.Text).ToString("dd-MMM-yyyy");
        lbSep.Text = DateTime.Parse(Sep.Text).ToString("dd-MMM-yyyy");

        lbOct.Text = DateTime.Parse(Oct.Text).ToString("dd-MMM-yyyy");
        lbNov.Text = DateTime.Parse(Nov.Text).ToString("dd-MMM-yyyy");
        lbDec.Text = DateTime.Parse(Dec.Text).ToString("dd-MMM-yyyy");


        
    }

	
}

