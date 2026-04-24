using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SK_System
{
    /// <summary>
    /// Interaction logic for YouthManagement.xaml
    /// </summary>
    public partial class YouthManagement : Window
    {
        private ObservableCollection<YouthMember> _youthMembers;

        public YouthManagement()
        {
            InitializeComponent();
            InitializeDataGrid();
            PreviewMouseDown += NavigationPreviewMouseDown;
        }

        private void NavigationPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var source = e.OriginalSource as FrameworkElement;

            if (source != null)
            {
                Border navBorder = FindNavigationBorder(source);

                if (navBorder != null && navBorder.Child is StackPanel stackPanel && stackPanel.Children.Count > 1)
                {
                    if (stackPanel.Children[1] is TextBlock textBlock)
                    {
                        NavigateByText(textBlock.Text);
                        e.Handled = true;
                    }
                }
            }
        }

        private Border FindNavigationBorder(DependencyObject obj)
        {
            while (obj != null)
            {
                if (obj is Border border && border.Cursor == Cursors.Hand)
                {
                    return border;
                }
                obj = LogicalTreeHelper.GetParent(obj);
            }
            return null;
        }

        private void NavigateByText(string text)
        {
            switch (text)
            {
                case "Dashboard":
                    NavigationHelper.NavigateToDashboard(this);
                    break;
                case "User Management":
                    NavigationHelper.NavigateToUserManagement(this);
                    break;
                case "Events":
                    NavigationHelper.NavigateToEventManagement(this);
                    break;
                case "Attendance":
                    NavigationHelper.NavigateToAttendance(this);
                    break;
                case "Financial Approval":
                    NavigationHelper.NavigateToFinancialApproval(this);
                    break;
                case "Reports":
                    NavigationHelper.NavigateToReports(this);
                    break;
                case "Reconciliation":
                    NavigationHelper.NavigateToReconciliation(this);
                    break;
                case "Audit Trail":
                    NavigationHelper.NavigateToAuditTrail(this);
                    break;
            }
        }

        private void InitializeDataGrid()
        {
            _youthMembers = new ObservableCollection<YouthMember>();
            YouthDataGrid.ItemsSource = _youthMembers;
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Load sample data - replace this with actual database queries
            _youthMembers.Add(new YouthMember
            {
                RowNumber = 1,
                MemberId = "Y001",
                FullName = "Juan Dela Cruz",
                Age = 18,
                Gender = "Male",
                Address = "Purok 1, Barangay San Juan",
                Contact = "09171234567"
            });

            _youthMembers.Add(new YouthMember
            {
                RowNumber = 2,
                MemberId = "Y002",
                FullName = "Maria Garcia",
                Age = 19,
                Gender = "Female",
                Address = "Purok 2, Barangay San Juan",
                Contact = "09175678901"
            });

            _youthMembers.Add(new YouthMember
            {
                RowNumber = 3,
                MemberId = "Y003",
                FullName = "Pedro Santos",
                Age = 17,
                Gender = "Male",
                Address = "Purok 3, Barangay San Juan",
                Contact = "09179876543"
            });

            _youthMembers.Add(new YouthMember
            {
                RowNumber = 4,
                MemberId = "Y004",
                FullName = "Anna Rodriguez",
                Age = 20,
                Gender = "Female",
                Address = "Purok 1, Barangay San Juan",
                Contact = "09165432109"
            });

            _youthMembers.Add(new YouthMember
            {
                RowNumber = 5,
                MemberId = "Y005",
                FullName = "Carlos Mendoza",
                Age = 18,
                Gender = "Male",
                Address = "Purok 4, Barangay San Juan",
                Contact = "09188765432"
            });

            _youthMembers.Add(new YouthMember
            {
                RowNumber = 6,
                MemberId = "Y006",
                FullName = "Sofia Reyes",
                Age = 19,
                Gender = "Female",
                Address = "Purok 2, Barangay San Juan",
                Contact = "09154321098"
            });

            _youthMembers.Add(new YouthMember
            {
                RowNumber = 7,
                MemberId = "Y007",
                FullName = "Miguel Torres",
                Age = 21,
                Gender = "Male",
                Address = "Purok 5, Barangay San Juan",
                Contact = "09169876543"
            });

            UpdateResults();
        }

        private void UpdateResults()
        {
            ResultsCountText.Text = $"{_youthMembers.Count} result{(_youthMembers.Count != 1 ? "s" : "")}";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YouthDataGrid.SelectedItem is YouthMember selectedMember)
            {
                // Update member details panel on selection
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (YouthDataGrid.SelectedItem is YouthMember selectedMember)
            {
                // Open detail view or edit dialog
                MessageBox.Show($"Viewing member: {selectedMember.FullName}", "Member Details");
            }
        }
    }

    /// <summary>
    /// Data model for youth members displayed in the DataGrid
    /// </summary>
    public class YouthMember
    {
        public int RowNumber { get; set; }
        public string MemberId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}
