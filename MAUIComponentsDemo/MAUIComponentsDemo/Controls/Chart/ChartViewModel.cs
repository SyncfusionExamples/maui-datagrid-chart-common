namespace MAUIComponentsDemo.Controls.Chart
{
    public class ChartViewModel
    {
        public List<Brush> PaletteBrushes { get; } = new()
        {
            new SolidColorBrush(Color.FromRgb(0x3B, 0x6B, 0xD5)), // blue
            new SolidColorBrush(Color.FromRgb(0x00, 0x6A, 0x6A)), // teal
            new SolidColorBrush(Color.FromRgb(0x9A, 0x6A, 0x00)), // amber
            new SolidColorBrush(Color.FromRgb(0x67, 0x50, 0xA4)), // purple
            new SolidColorBrush(Color.FromRgb(0xB3, 0x25, 0x5C)), // rose
        };

        public List<RevenuePoint> RevenueData { get; } = new()
        {
            new RevenuePoint { Month = "Jan", Revenue = 42 },
            new RevenuePoint { Month = "Feb", Revenue = 55 },
            new RevenuePoint { Month = "Mar", Revenue = 48 },
            new RevenuePoint { Month = "Apr", Revenue = 72 },
            new RevenuePoint { Month = "May", Revenue = 95 },
            new RevenuePoint { Month = "Jun", Revenue = 128 },
            new RevenuePoint { Month = "Jul", Revenue = 118 },
            new RevenuePoint { Month = "Aug", Revenue = 134 },
            new RevenuePoint { Month = "Sep", Revenue = 106 },
            new RevenuePoint { Month = "Oct", Revenue = 122 },
            new RevenuePoint { Month = "Nov", Revenue = 139 },
            new RevenuePoint { Month = "Dec", Revenue = 152 },
        };
        public List<ProductSales> LaptopSales { get; } = new()
        {
            new ProductSales { Quarter = "Q1", Sales = 180 },
            new ProductSales { Quarter = "Q2", Sales = 210 },
            new ProductSales { Quarter = "Q3", Sales = 260 },
            new ProductSales { Quarter = "Q4", Sales = 230 },
        };

        public List<ProductSales> TabletSales { get; } = new()
        {
            new ProductSales { Quarter = "Q1", Sales = 90 },
            new ProductSales { Quarter = "Q2", Sales = 120 },
            new ProductSales { Quarter = "Q3", Sales = 140 },
            new ProductSales { Quarter = "Q4", Sales = 175 },
        };

        public List<MarketShare> MarketShareData { get; } = new()
        {
            new MarketShare { Platform = "Mobile", Share = 48 },
            new MarketShare { Platform = "Desktop", Share = 27 },
            new MarketShare { Platform = "Tablet", Share = 13 },
            new MarketShare { Platform = "Smart TV", Share = 8 },
            new MarketShare { Platform = "Others", Share = 4 },
        };

        private static readonly DateTime Start = new(2025, 6, 2);

        public List<StockPrice> StockData { get; } = new()
        {
            // Week 1
            new StockPrice { Date = Start,           Open = 162, High = 168, Low = 160, Close = 166 },
            new StockPrice { Date = Start.AddDays(1), Open = 166, High = 172, Low = 164, Close = 171 },
            new StockPrice { Date = Start.AddDays(2), Open = 171, High = 174, Low = 165, Close = 167 },
            new StockPrice { Date = Start.AddDays(3), Open = 167, High = 170, Low = 161, Close = 162 },
            new StockPrice { Date = Start.AddDays(4), Open = 162, High = 169, Low = 160, Close = 168 },
            // Week 2
            new StockPrice { Date = Start.AddDays(7),  Open = 168, High = 175, Low = 166, Close = 174 },
            new StockPrice { Date = Start.AddDays(8),  Open = 174, High = 179, Low = 170, Close = 172 },
            new StockPrice { Date = Start.AddDays(9),  Open = 172, High = 176, Low = 163, Close = 165 },
            new StockPrice { Date = Start.AddDays(10), Open = 165, High = 171, Low = 158, Close = 170 },
            new StockPrice { Date = Start.AddDays(11), Open = 170, High = 178, Low = 169, Close = 177 },
            // Week 3
            new StockPrice { Date = Start.AddDays(14), Open = 177, High = 183, Low = 175, Close = 181 },
            new StockPrice { Date = Start.AddDays(15), Open = 181, High = 185, Low = 174, Close = 176 },
            new StockPrice { Date = Start.AddDays(16), Open = 176, High = 180, Low = 168, Close = 170 },
            new StockPrice { Date = Start.AddDays(17), Open = 170, High = 173, Low = 162, Close = 164 },
            new StockPrice { Date = Start.AddDays(18), Open = 164, High = 172, Low = 160, Close = 171 },
        };
    }
}
