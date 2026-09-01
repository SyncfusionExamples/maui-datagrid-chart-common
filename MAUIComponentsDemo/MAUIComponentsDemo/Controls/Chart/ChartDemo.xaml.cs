namespace MAUIComponentsDemo.Controls.Chart;

public partial class ChartDemo : ContentPage
{
	public ChartDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        pieChart.SaveAsImage("PieChart.jpeg");
    }

    private void Button_Clicked1(object sender, EventArgs e)
    {
        columnChart.SaveAsImage("ColumnChart.jpeg");
    }
}