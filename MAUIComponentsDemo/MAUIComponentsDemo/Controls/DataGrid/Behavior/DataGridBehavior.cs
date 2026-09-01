using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Exporting;

namespace MAUIComponentsDemo.Behavior
{
    internal class DataGridBehavior
    {
        private SearchBar? _searchBar;
        private SfDataGrid? _dataGrid;

        public DataGridBehavior(SfDataGrid dataGrid, SearchBar searchBar)
        {
            _dataGrid = dataGrid;
            _searchBar = searchBar;
        }

        public void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            // Apply filter when text changes
            if (_dataGrid?.View != null)
            {
                _dataGrid.View.Filter = FilterRecords;
                _dataGrid.View.RefreshFilter();
            }
        }

        public bool FilterRecords(object record)
        {
            if (string.IsNullOrEmpty(_searchBar?.Text))
                return true;

            string searchText = _searchBar.Text.ToLower();

            if (record is OrderInfo orderInfo)
            {
                return orderInfo.OrderID.ToString().ToLower().Contains(searchText) ||
                       orderInfo.CustomerID.ToString().ToLower().Contains(searchText) ||
                       (orderInfo.Name?.ToLower().Contains(searchText) ?? false) ||
                       (orderInfo.ShipCity?.ToLower().Contains(searchText) ?? false) ||
                       orderInfo.ShipCountry.ToString().ToLower().Contains(searchText) ||
                       orderInfo.ShippingDate.ToString().ToLower().Contains(searchText);
            }

            return false;
        }

        public void ExportToPdf()
        {
            #region Pdf Document
            MemoryStream stream = new MemoryStream();
            DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
            DataGridPdfExportingOption option = new DataGridPdfExportingOption();
            var pdfDoc = pdfExport.ExportToPdf(_dataGrid, option);
            pdfDoc.Save(stream);
            pdfDoc.Close(true);
            SaveService saveService = new();
            saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
            #endregion
        }

        public void ExportToExcel()
        {
            #region Excel Document
            DataGridExcelExportingController excelExport = new DataGridExcelExportingController();
            DataGridExcelExportingOption option = new DataGridExcelExportingOption();
            var excelEngine = excelExport.ExportToExcel(_dataGrid, option);
            var workbook = excelEngine.Excel.Workbooks[0];
            MemoryStream stream = new MemoryStream();
            workbook.SaveAs(stream);
            workbook.Close();
            excelEngine.Dispose();
            string OutputFilename = "ExportFeature.xlsx";
            SaveService saveService = new();
            saveService.SaveAndView(OutputFilename, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", stream);
            #endregion
        }
    }
}
