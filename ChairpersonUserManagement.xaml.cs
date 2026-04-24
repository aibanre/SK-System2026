using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SK_System
{
    /// <summary>
    /// Interaction logic for ChairpersonUserManagement.xaml
    /// </summary>
    public partial class ChairpersonUserManagement : Window
    {
        private ObservableCollection<UserItem> _users;

        public ChairpersonUserManagement()
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
                case "Youth Management":
                    NavigationHelper.NavigateToYouthManagement(this);
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
            _users = new ObservableCollection<UserItem>();
            UsersDataGrid.ItemsSource = _users;
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Load sample data - replace this with actual database queries
            _users.Add(new UserItem
            {
                RowNumber = 1,
                UserId = "001",
                Username = "john.doe",
                Role = "SK Chairperson",
                Status = "Active",
                StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#10B981")),
                LastLogin = DateTime.Now.AddDays(-1)
            });

            _users.Add(new UserItem
            {
                RowNumber = 2,
                UserId = "002",
                Username = "maria.garcia",
                Role = "Secretary",
                Status = "Active",
                StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#10B981")),
                LastLogin = DateTime.Now.AddHours(-3)
            });

            _users.Add(new UserItem
            {
                RowNumber = 3,
                UserId = "003",
                Username = "robert.cruz",
                Role = "Treasurer",
                Status = "Active",
                StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#10B981")),
                LastLogin = DateTime.Now.AddDays(-5)
            });

            _users.Add(new UserItem
            {
                RowNumber = 4,
                UserId = "004",
                Username = "anna.santos",
                Role = "Member",
                Status = "Inactive",
                StatusColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EF4444")),
                LastLogin = DateTime.Now.AddMonths(-1)
            });

            UpdateUserCount();
        }

        private void UpdateUserCount()
        {
            UserCountText.Text = $"{_users.Count} user{(_users.Count != 1 ? "s" : "")}";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle row selection if needed
            if (UsersDataGrid.SelectedItem is UserItem selectedUser)
            {
                // You can implement selection logic here
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (UsersDataGrid.SelectedItem is UserItem selectedUser)
            {
                // Open edit dialog or navigate to edit view
                MessageBox.Show($"Editing user: {selectedUser.Username}", "Edit User");
            }
        }
    }

    /// <summary>
    /// Data model for user items displayed in the DataGrid
    /// </summary>
    public class UserItem
    {
        public int RowNumber { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public Brush StatusColor { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
