# SK System DataGrid Standardization Guide

## Overview
This document outlines the standardized DataGrid design and implementation used across the SK System application.

## Benefits of Standardization
- **Consistent User Experience**: All DataGrids have the same look and feel across the application
- **Maintainability**: Centralized style definitions make it easy to update the design globally
- **Reusability**: Shared styles can be applied to new DataGrids without duplicating code
- **Professional Appearance**: Clean, modern design following Material Design principles

## Architecture

### 1. Central Style Repository: `DataGridStyles.xaml`
Located in the project root, this ResourceDictionary contains all reusable DataGrid styles.

**Included Styles:**
- `DataGridColumnHeaderStyle`: Column header styling
- `DataGridCellStyle`: Individual cell styling with selection states
- `DataGridRowStyle`: Row styling with hover effects
- `ProfessionalDataGridStyle`: Complete DataGrid style combining all above
- `DataGridActionButtonStyle`: Standardized button styling for action columns
- `StatusBadgeStyle`: Status indicator styling

### 2. Implementation Pattern

#### Step 1: Add ResourceDictionary Reference
```xaml
<Window.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="DataGridStyles.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Window.Resources>
```

#### Step 2: Create XAML DataGrid
```xaml
<DataGrid Name="YourDataGrid" Height="480" Style="{StaticResource ProfessionalDataGridStyle}"
          SelectionChanged="DataGrid_SelectionChanged" MouseDoubleClick="DataGrid_MouseDoubleClick">
    <DataGrid.Columns>
        <!-- Define columns here -->
    </DataGrid.Columns>
</DataGrid>
```

#### Step 3: Define Data Model in Code-Behind
```csharp
public class YourDataModel
{
    public int RowNumber { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    // Add other properties as needed
}
```

#### Step 4: Bind Data in Code-Behind
```csharp
private ObservableCollection<YourDataModel> _items;

public YourWindow()
{
    InitializeComponent();
    _items = new ObservableCollection<YourDataModel>();
    YourDataGrid.ItemsSource = _items;
    LoadData();
}
```

## Implemented Windows

### 1. ChairpersonUserManagement.xaml
**Purpose**: Manage system user accounts and roles
**DataGrid**: `UsersDataGrid`
**Data Model**: `UserItem`
**Columns**:
- Row Number (#)
- Username
- Role
- Status (with color-coded badges)
- Last Login (datetime)
- Actions (Edit, Deactivate, Reset Password)

**Features**:
- Double-click to edit
- Row selection
- Color-coded status indicators (green=Active, red=Inactive)

### 2. YouthManagement.xaml
**Purpose**: Manage youth member records
**DataGrid**: `YouthDataGrid`
**Data Model**: `YouthMember`
**Columns**:
- Row Number (#)
- Full Name
- Age
- Gender
- Address
- Contact Number

**Features**:
- Search functionality integrated
- Member details panel on selection
- Double-click to view details

## Color Scheme
The DataGrid uses the following color palette (Tailwind CSS compatible):

| Element | Color | Hex Value |
|---------|-------|-----------|
| Header Background | Light Gray | #F9FAFB |
| Header Text | Dark Gray | #6B7280 |
| Border | Light Border | #E5E7EB |
| Row Background | White | White |
| Row Hover | Light Gray | #F9FAFB |
| Row Selected | Light Gray | #F3F4F6 |
| Cell Text | Dark Text | #1F2937 |
| Status Active | Green | #10B981 |
| Status Inactive | Red | #EF4444 |

## Key Properties

### Column Sizing
```xaml
<DataGridTextColumn Header="Full Name" Width="2*" />  <!-- Proportional -->
<DataGridTextColumn Header="Age" Width="80" />         <!-- Fixed -->
```

### Cell Styling
```xaml
<DataGridTextColumn.ElementStyle>
    <Style TargetType="TextBlock">
        <Setter Property="VerticalAlignment" Value="Center"/>
        <Setter Property="Foreground" Value="#6B7280"/>
    </Style>
</DataGridTextColumn.ElementStyle>
```

### Action Buttons
```xaml
<Button Style="{StaticResource DataGridActionButtonStyle}" 
        Content="Edit" Margin="0,0,8,0" Tag="{Binding UserId}"/>
```

## Responsive Behavior

| Screen Size | Behavior |
|-------------|----------|
| > 1200px | Full display, all columns visible |
| 1024-1200px | Slightly condensed spacing |
| < 1024px | Consider scrollable columns |

## Best Practices

1. **Always use ProfessionalDataGridStyle**: Ensures consistency
2. **Include RowNumber column**: Makes data more readable
3. **Use proper column widths**: Mix of proportional (Width="2*") and fixed (Width="80")
4. **Implement SelectionChanged event**: For detail views or updates
5. **Add MouseDoubleClick handler**: For edit/detail actions
6. **Use ObservableCollection**: For dynamic data binding
7. **Load sample data**: In development, use LoadSampleData() pattern
8. **Update counts**: Use TextBlock to show row counts

## Customization

### Adding Status Badges
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

### Adding Custom Columns
```xaml
<DataGridTextColumn Header="Your Column" Binding="{Binding YourProperty}" Width="1.5*" IsReadOnly="True">
    <DataGridTextColumn.ElementStyle>
        <Style TargetType="TextBlock">
            <Setter Property="VerticalAlignment" Value="Center"/>
        </Style>
    </DataGridTextColumn.ElementStyle>
</DataGridTextColumn>
```

## Future Windows Using This Design

When implementing DataGrids in the following windows, follow the same pattern:
- EventManagement.xaml
- Attendance.xaml
- Reports.xaml
- AuditTrail.xaml
- And any other data-heavy interfaces

## Troubleshooting

### DataGrid not showing data
- Ensure `ItemsSource` is set to an `ObservableCollection`
- Verify column `Binding` properties match object properties
- Check that `AutoGenerateColumns="False"` is set

### Styling not applying
- Verify `DataGridStyles.xaml` is referenced in Window.Resources
- Check that style name matches StaticResource reference
- Build project to ensure XAML is parsed correctly

### Performance issues with large datasets
- Consider implementing virtualization
- Use asynchronous data loading
- Implement pagination or filtering

---

**Version**: 1.0.0  
**Last Updated**: 2026  
**SK System Development Team**
