using MAUIComponentsDemo.Behavior;

namespace MAUIComponentsDemo.Controls.DataGrid.Sample;

public partial class SfDataGridDemo : ContentPage
{
    private DataGridBehavior? _gridBehavior;

    public SfDataGridDemo()
    {
        InitializeComponent();
       _gridBehavior = new DataGridBehavior(dataGrid, searchBar);
    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        _gridBehavior?.OnSearchBarTextChanged(sender, e);
    }

    private void Button_Clicked(object? sender, EventArgs e)
    {
        _gridBehavior?.ExportToPdf();
    }

    private void Button_Clicked_1(object? sender, EventArgs e)
    {
        _gridBehavior?.ExportToExcel();
    }
}