using System;
using System.Windows;

namespace SK_System
{
    /// <summary>
    /// Navigation helper class for managing window navigation
    /// </summary>
    public static class NavigationHelper
    {
        /// <summary>
        /// Opens a window of the specified type and closes the current window
        /// </summary>
        public static void NavigateTo<T>(Window currentWindow) where T : Window, new()
        {
            try
            {
                T newWindow = new T();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens a dashboard window and closes the current window
        /// </summary>
        public static void NavigateToDashboard(Window currentWindow)
        {
            try
            {
                ChairpersonDashboard newWindow = new ChairpersonDashboard();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the User Management window and closes the current window
        /// </summary>
        public static void NavigateToUserManagement(Window currentWindow)
        {
            try
            {
                ChairpersonUserManagement newWindow = new ChairpersonUserManagement();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Youth Management window and closes the current window
        /// </summary>
        public static void NavigateToYouthManagement(Window currentWindow)
        {
            try
            {
                YouthManagement newWindow = new YouthManagement();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Event Management window and closes the current window
        /// </summary>
        public static void NavigateToEventManagement(Window currentWindow)
        {
            try
            {
                EventManagement newWindow = new EventManagement();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Attendance window and closes the current window
        /// </summary>
        public static void NavigateToAttendance(Window currentWindow)
        {
            try
            {
                Attendance newWindow = new Attendance();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Financial Approval window and closes the current window
        /// </summary>
        public static void NavigateToFinancialApproval(Window currentWindow)
        {
            try
            {
                FinancialApproval newWindow = new FinancialApproval();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Reports window and closes the current window
        /// </summary>
        public static void NavigateToReports(Window currentWindow)
        {
            try
            {
                Reports newWindow = new Reports();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Reconciliation window and closes the current window
        /// </summary>
        public static void NavigateToReconciliation(Window currentWindow)
        {
            try
            {
                Reconciliation newWindow = new Reconciliation();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Audit Trail window and closes the current window
        /// </summary>
        public static void NavigateToAuditTrail(Window currentWindow)
        {
            try
            {
                AuditTrail newWindow = new AuditTrail();
                newWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating: {ex.Message}", "Navigation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
