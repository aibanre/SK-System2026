using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SK_System
{
    /// <summary>
    /// Interaction logic for Attendance.xaml
    /// </summary>
    public partial class Attendance : Window
    {
        public Attendance()
        {
            InitializeComponent();
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
                case "Youth Management":
                    NavigationHelper.NavigateToYouthManagement(this);
                    break;
                case "Events":
                    NavigationHelper.NavigateToEventManagement(this);
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
    }
}
