# Syncfusion .NET MAUI Data Grid & Charts

## Overview

This repository demonstrates the **Syncfusion Data Grid** and **Syncfusion Charts** components for **.NET MAUI** in a single, cross-platform sample app that runs on Android, iOS, Mac Catalyst, and Windows from one shared codebase.

- **Syncfusion Data Grid** is a high-performance, enterprise-ready data presentation component designed to display, manage, and manipulate large volumes of structured data with ease. It provides a rich set of features including data binding, sorting, filtering, grouping, editing, virtualization, exporting, and adaptive layouts.
- **Syncfusion Charts** is a powerful, feature-rich data visualization library used to build interactive, high-performance charts — from basic line and bar charts to advanced financial, Cartesian, and circular visualizations with tooltips, annotations, plot bands, and export to image.

Both components are optimized for modern business applications such as CRM systems, ERP platforms, financial dashboards, reporting portals, inventory management solutions, healthcare systems, and data-intensive mobile/desktop applications.

## Supported Platforms

### .NET MAUI
![.NET MAUI](https://img.shields.io/badge/.NET_MAUI-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

### Android
![Android](https://img.shields.io/badge/Android-3DDC84?style=for-the-badge&logo=android&logoColor=white)

### iOS
![iOS](https://img.shields.io/badge/iOS-000000?style=for-the-badge&logo=apple&logoColor=white)

### macOS (Mac Catalyst)
![macOS](https://img.shields.io/badge/macOS-000000?style=for-the-badge&logo=apple&logoColor=white)

### Windows
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

## Key Features

Features are grouped by Syncfusion control below. Bullets marked with ✅ are demonstrated in this sample; the rest are part of the underlying component capabilities.

### 📊 Data Grid (`Syncfusion.Maui.DataGrid`)

#### Flexible Data Binding
- Bind to any `IEnumerable` / `ObservableCollection` / MVVM source ✅
- Live updates via `INotifyPropertyChanged` and `INotifyCollectionChanged` ✅
- Support for tables, custom collections, and dynamic data

#### Rich Column Types
- `DataGridTextColumn` ✅
- `DataGridNumericColumn` ✅
- `DataGridDateColumn` ✅
- Checkbox, image, combobox, picker, and template columns

#### Data Operations
- Sorting and multi-column sorting
- Filtering and advanced filtering ✅ (built-in column filter)
- Custom record filtering through `SfDataGrid.View.Filter` ✅
- Searching across columns ✅
- Grouping, aggregates, and summaries
- CRUD operations with in-place, dialog, and form editing ✅ (`AllowEditing="True"`, `NavigationMode="Cell"`)

#### Performance & Virtualization
- Row and column virtualization
- Incremental loading and paging
- Optimized rendering engine for large datasets ✅ (50+ records shown in the sample)

#### Advanced Views
- Master-detail view
- Record templates
- Unbound rows and unbound columns
- Stacked headers

#### Styling & Customization
- Conditional formatting
- Freeze panes
- Column resizing, reordering, and frozen columns
- Theme support

#### User Experience
- Adaptive and responsive layout ✅
- Touch and keyboard navigation ✅
- Swipe actions, drag-and-drop, and selection ✅ (`SelectionUnit="Row"`)

#### Exporting
- Excel export ✅ (`DataGridExcelExportingController` → `ExportFeature.xlsx`)
- PDF export ✅ (`DataGridPdfExportingController` → `ExportFeature.pdf`)
- Clipboard, CSV, and serialization

#### Globalization & Accessibility
- Localization (full support)
- RTL support (full support)
- Keyboard accessibility (full support)
- Screen reader compatibility (partial support)

---

### 📈 Cartesian Charts (`Syncfusion.Maui.Charts` — `SfCartesianChart`)

#### Chart Types
- `LineSeries` ✅ (Monthly Revenue Trend)
- `ColumnSeries` ✅ (Quarterly Sales by Product — multi-series)
- `BarSeries`, `AreaSeries`, `SplineSeries`, `ScatterSeries`
- Combination series for mixed visualizations

#### Data Binding
- MVVM-friendly binding with `ItemsSource`, `XBindingPath`, `YBindingPath` ✅
- Dynamic updates from the underlying view model ✅

#### Interactive Features
- Tooltips ✅ (`EnableTooltip="True"`)
- Data labels ✅ (`ShowDataLabels="True"`)
- Zooming and panning
- Selection and trackball interaction

#### Axes & Plot Elements
- `CategoryAxis` and `NumericalAxis` ✅
- Axis titles and labels ✅
- Numerical plot bands with custom label styles ✅ (Target zone)
- Multi-axis support

#### Annotations
- Vertical-line annotations with text labels ✅ (Mid-year peak)
- Shape, text, and view annotations

#### Trendlines
- Linear, exponential, logarithmic, polynomial, and power trendlines for statistical analysis

#### Legend
- Built-in `ChartLegend` ✅ with toggle and positioning

#### Visual Customization
- Custom palettes ✅ (`PaletteBrushes` in `ChartViewModel`)
- Axes, gridlines, labels, legends, and marker styling
- Themes (light/dark)

#### Exporting
- Save chart as image (PNG / JPEG) ✅ (`SaveAsImage`)

#### Globalization & Accessibility
- Localization (full support)
- Time zone support (full support)
- Keyboard accessibility (partial support)

---

### 🍩 Circular Charts (`Syncfusion.Maui.Charts` — `SfCircularChart`)

#### Chart Types
- `PieSeries` ✅ (Market Share Breakdown)
- `DoughnutSeries`
- `RadialBarSeries`

#### Data Binding
- ItemsSource with `XBindingPath` / `YBindingPath` ✅
- Dynamic and real-time updates

#### Interactive Features
- Tooltips ✅
- Data labels ✅
- Selection and explode interaction
- Legend ✅

#### Visual Customization
- Custom palette brushes ✅
- Smart labels, label connector lines, and start/end angles
- Center view for doughnut charts

#### Exporting
- Save chart as image (PNG / JPEG) ✅ (`SaveAsImage`)

#### Globalization & Accessibility
- Localization (full support)
- Time zone support (full support)

---

### 💹 Financial Charts (`Syncfusion.Maui.Charts` — `SfCartesianChart` with `HiLoOpenCloseSeries`)

#### Chart Types
- `HiLoOpenCloseSeries` ✅ (Stock Price candlestick)
- `Candle` series
- `OHLC` series

#### Data Binding
- Bound to `StockPrice` model with `Open`, `High`, `Low`, `Close` ✅
- Custom bull/bear colors ✅

#### Interactive Features
- Tooltips, data labels, zooming, panning
- Trackball for cross-data inspection

#### Visual Customization
- Bull / bear color customization
- Plot band annotations for sessions ✅
- Custom axis labels and ranges

---

## Benefits

- High-performance rendering for large datasets
- Reduced development effort with built-in features
- Consistent user experience across platforms
- Extensive customization capabilities
- Enterprise-grade reliability and scalability
- Modern and responsive user interface
- Single C#/XAML codebase for Android, iOS, macOS, and Windows

## Integration Support

The Data Grid and Charts integrate seamlessly with:

- REST APIs
- OData Services
- Entity Framework
- SQL Server and more
- Azure Services
- Cloud and On-Premises Data Sources
- In-memory collections 

## Documentation

Explore comprehensive documentation, API references, tutorials, and examples to accelerate development and implementation.

- [.NET MAUI Data Grid — Getting Started](https://help.syncfusion.com/maui/datagrid/getting-started)
- [.NET MAUI Data Grid — Overview](https://help.syncfusion.com/maui/datagrid/overview)
- [.NET MAUI Cartesian Charts — Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)
- [.NET MAUI Cartesian Charts — Overview](https://help.syncfusion.com/maui/cartesian-charts/overview)
- [.NET MAUI Circular Charts — Getting Started](https://help.syncfusion.com/maui/circular-charts/getting-started)
- [.NET MAUI Circular Charts — Overview](https://help.syncfusion.com/maui/circular-charts/overview)

## Getting Started

1. Install the .NET MAUI workload:
   ```bash
   dotnet workload install maui
   ```
2. Add the Syncfusion NuGet packages used by this sample:
   ```bash
   dotnet add package Syncfusion.Maui.DataGrid
   dotnet add package Syncfusion.Maui.DataGridExport
   dotnet add package Syncfusion.Maui.Charts
   ```
3. Register Syncfusion core in `MauiProgram.cs`:
   ```csharp
   builder
       .UseMauiApp<App>()
       .ConfigureSyncfusionCore();
   ```
4. Import the `SfDataGrid` and `SfCartesianChart` / `SfCircularChart` controls in your XAML pages.
5. Bind to your data source and configure columns / series, tooltips, filters, and export options.
6. Build and run on your target platform:
   ```bash
   dotnet build -f net10.0-windows10.0.19041.0
   dotnet run   -f net10.0-windows10.0.19041.0
   ```

## Additional Links

- [Syncfusion .NET MAUI Documentation](https://help.syncfusion.com/maui)
- [DataGrid Feature Tour](https://www.syncfusion.com/maui-controls/maui-datagrid)
- [Cartesian Charts Feature Tour](https://www.syncfusion.com/maui-controls/maui-cartesian-charts)
- [Circular Charts Feature Tour](https://www.syncfusion.com/maui-controls/maui-circular-charts)
- [Syncfusion MAUI Demos on GitHub](https://github.com/syncfusion/maui-demos)
