using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginRoleCombo.SelectedItem is ComboBoxItem selectedItem && selectedItem.Content != null)
            {
                string role = selectedItem.Content.ToString()!;
                if (role is "Lecturer" or "Programme Coordinator" or "Academic Manager")
                {
                    MainWindow main = new MainWindow(role);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select a valid role.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (registerRoleCombo.SelectedItem is ComboBoxItem selectedItem && selectedItem.Content != null)
            {
                string role = selectedItem.Content.ToString()!;
                if (role is "Lecturer" or "Programme Coordinator" or "Academic Manager")
                {
                    MessageBox.Show("Registered successfully. Please login.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    tabControl.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Please select a valid role.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}