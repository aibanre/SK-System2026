# Quick Reference: DataGrid Implementation Template

## Copy-Paste Template for New DataGrids

### XAML Template
```xaml
<Window x:Class="SK_System.YourWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Your Title" Height="768" Width="1200"
        FontFamily="Segoe UI" Background="#F9FAFB">

    <Window.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="DataGridStyles.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Window.Resources>

    <!-- Your content here -->
    <Border Background="White" BorderBrush="#E5E7EB" BorderThickness="1" CornerRadius="4">
        <StackPanel>
            <!-- Header -->
            <Border Background="#F9FAFB" BorderBrush="#E5E7EB" BorderThickness="0,0,0,1" Padding="20,16" CornerRadius="4,4,0,0">
                <Grid>
                    <TextBlock Text="Items" FontSize="14" Foreground="#4B5563" />
                    <TextBlock Name="ItemCountText" Text="0 items" FontSize="12" Foreground="#9CA3AF" HorizontalAlignment="Right" VerticalAlignment="Center" />
                </Grid>
            </Border>

            <!-- DataGrid -->
            <DataGrid Name="YourDataGrid" Height="400" Style="{StaticResource ProfessionalDataGridStyle}"
                      SelectionChanged="DataGrid_SelectionChanged" MouseDoubleClick="DataGrid_MouseDoubleClick">
                <DataGrid.Columns>
                    <!-- # Column -->
                    <DataGridTextColumn Header="#" Binding="{Binding RowNumber}" Width="40" IsReadOnly="True">
                        <DataGridTextColumn.ElementStyle>
                            <Style TargetType="TextBlock">
                                <Setter Property="Foreground" Value="#9CA3AF"/>
                                <Setter Property="TextAlignment" Value="Center"/>
                            </Style>
                        </DataGridTextColumn.ElementStyle>
                    </DataGridTextColumn>

                    <!-- Your columns here -->
                    <DataGridTextColumn Header="Name" Binding="{Binding Name}" Width="2*" IsReadOnly="True">
                        <DataGridTextColumn.ElementStyle>
                            <Style TargetType="TextBlock">
                                <Setter Property="VerticalAlignment" Value="Center"/>
                            </Style>
                        </DataGridTextColumn.ElementStyle>
                    </DataGridTextColumn>

                    <DataGridTextColumn Header="Status" Binding="{Binding Status}" Width="1*" IsReadOnly="True">
                        <DataGridTextColumn.ElementStyle>
                            <Style TargetType="TextBlock">
                                <Setter Property="VerticalAlignment" Value="Center"/>
                                <Setter Property="TextAlignment" Value="Center"/>
                            </Style>
                        </DataGridTextColumn.ElementStyle>
                    </DataGridTextColumn>
                </DataGrid.Columns>
            </DataGrid>
        </StackPanel>
    </Border>
</Window>
```

### C# Code-Behind Template
```csharp
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace SK_System
{
    public partial class YourWindow : Window
    {
        private ObservableCollection<YourDataModel> _items;

        public YourWindow()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            _items = new ObservableCollection<YourDataModel>();
            YourDataGrid.ItemsSource = _items;
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // TODO: Replace with actual database queries
            _items.Add(new YourDataModel
            {
                RowNumber = 1,
                Id = "001",
                Name = "Sample Item",
                Status = "Active"
            });

            UpdateItemCount();
        }

        private void UpdateItemCount()
        {
            ItemCountText.Text = $"{_items.Count} item{(_items.Count != 1 ? "s" : "")}";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YourDataGrid.SelectedItem is YourDataModel selectedItem)
            {
                // Handle selection
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (YourDataGrid.SelectedItem is YourDataModel selectedItem)
            {
                // Handle double-click (edit, view details, etc.)
            }
        }
    }

    /// <summary>
    /// Data model for items displayed in the DataGrid
    /// </summary>
    public class YourDataModel
    {
        public int RowNumber { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        // Add your properties here
    }
}
```

## Available Styles to Use

### In XAML
```xaml
<!-- Apply to DataGrid -->
<DataGrid Style="{StaticResource ProfessionalDataGridStyle}" />

<!-- Apply to Buttons -->
<Button Style="{StaticResource DataGridActionButtonStyle}" Content="Edit" />

<!-- Apply to Status Badges -->
<Border Style="{StaticResource StatusBadgeStyle}" Background="#10B981" />
```

## Common Column Types

### Text Column (Read-Only)
```xaml
<DataGridTextColumn Header="Name" Binding="{Binding Name}" Width="2*" IsReadOnly="True">
    <DataGridTextColumn.ElementStyle>
        <Style TargetType="TextBlock">
            <Setter Property="VerticalAlignment" Value="Center"/>
        </Style>
    </DataGridTextColumn.ElementStyle>
</DataGridTextColumn>
```

### Centered Text Column
```xaml
<DataGridTextColumn Header="Age" Binding="{Binding Age}" Width="1*" IsReadOnly="True">
    <DataGridTextColumn.ElementStyle>
        <Style TargetType="TextBlock">
            <Setter Property="TextAlignment" Value="Center"/>
            <Setter Property="VerticalAlignment" Value="Center"/>
        </Style>
    </DataGridTextColumn.ElementStyle>
</DataGridTextColumn>
```

### Status Badge Column
```xaml
<DataGridTemplateColumn Header="Status" Width="1.5*">
    <DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <Border Background="{Binding StatusColor}" CornerRadius="4" Padding="8,4" Margin="4,0">
                <TextBlock Text="{Binding Status}" Foreground="White" FontSize="12" 
                           FontWeight="SemiBold" TextAlignment="Center" VerticalAlignment="Center"/>
            </Border>
        </DataTemplate>
    </DataGridTemplateColumn.CellTemplate>
</DataGridTemplateColumn>
```

### Action Buttons Column
```xaml
<DataGridTemplateColumn Header="Actions" Width="200">
    <DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal" VerticalAlignment="Center" Margin="4,0">
                <Button Style="{StaticResource DataGridActionButtonStyle}" 
                        Content="Edit" Margin="0,0,8,0" Tag="{Binding Id}"/>
                <Button Style="{StaticResource DataGridActionButtonStyle}" 
                        Content="Delete" Tag="{Binding Id}"/>
            </StackPanel>
        </DataTemplate>
    </DataGridTemplateColumn.CellTemplate>
</DataGridTemplateColumn>
```

### Formatted DateTime Column
```xaml
<DataGridTextColumn Header="Last Updated" 
                    Binding="{Binding LastUpdated, StringFormat='yyyy-MM-dd HH:mm'}" 
                    Width="2*" IsReadOnly="True">
    <DataGridTextColumn.ElementStyle>
        <Style TargetType="TextBlock">
            <Setter Property="VerticalAlignment" Value="Center"/>
            <Setter Property="Foreground" Value="#6B7280"/>
        </Style>
    </DataGridTextColumn.ElementStyle>
</DataGridTextColumn>
```

## Color Reference

```csharp
// In code-behind, for status colors:
using System.Windows.Media;

// Active (Green)
new SolidColorBrush((Color)ColorConverter.ConvertFromString("#10B981"))

// Inactive (Red)
new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF4444"))

// Warning (Yellow)
new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F59E0B"))

// Pending (Blue)
new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B82F6"))
```

## Data Binding Tips

### One-Way Binding (Recommended for Display)
```xaml
<DataGridTextColumn Binding="{Binding PropertyName, Mode=OneWay}" />
```

### Two-Way Binding (For Editable Cells)
```xaml
<DataGridTextColumn Binding="{Binding PropertyName, Mode=TwoWay}" />
```

### Format Binding (Dates, Numbers)
```xaml
<!-- Date Format -->
<DataGridTextColumn Binding="{Binding CreatedDate, StringFormat='yyyy-MM-dd'}" />

<!-- Currency Format -->
<DataGridTextColumn Binding="{Binding Amount, StringFormat=C}" />

<!-- Percentage Format -->
<DataGridTextColumn Binding="{Binding Percentage, StringFormat='0%'}" />
```

## Event Handlers

### Selection Changed
```csharp
private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (YourDataGrid.SelectedItem is YourDataModel selected)
    {
        // Do something with selected item
        MessageBox.Show($"Selected: {selected.Name}");
    }
}
```

### Double Click
```csharp
private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
{
    if (YourDataGrid.SelectedItem is YourDataModel selected)
    {
        // Open edit window, dialog, or navigate
        var editWindow = new EditWindow(selected);
        editWindow.ShowDialog();
    }
}
```

### Button Click in Action Column
```xaml
<Button Style="{StaticResource DataGridActionButtonStyle}" 
        Content="Edit" Click="EditButton_Click" Tag="{Binding Id}"/>
```

```csharp
private void EditButton_Click(object sender, RoutedEventArgs e)
{
    Button btn = (Button)sender;
    string id = btn.Tag.ToString();
    // Handle edit
}
```

## Troubleshooting Checklist

- [ ] ResourceDictionary reference added to Window.Resources?
- [ ] Data model class created with public properties?
- [ ] ObservableCollection<T> instantiated?
- [ ] ItemsSource bound to ObservableCollection?
- [ ] Column Binding paths match object property names?
- [ ] AutoGenerateColumns="False" set (if using styles)?
- [ ] IsReadOnly="True" set (if not editable)?
- [ ] Build successful?

---

**Quick Reference Version**: 1.0.0
