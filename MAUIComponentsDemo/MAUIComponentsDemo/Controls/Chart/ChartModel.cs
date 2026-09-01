namespace MAUIComponentsDemo.Controls.Chart
{
    public class RevenuePoint
    {
        public string Month { get; set; } = string.Empty;
        public double Revenue { get; set; }
    }

    public class ProductSales
    {
        public string Quarter { get; set; } = string.Empty;
        public double Sales { get; set; }
    }

    public class MarketShare
    {
        public string Platform { get; set; } = string.Empty;
        public double Share { get; set; }
    }

    public class StockPrice
    {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
    }
}
