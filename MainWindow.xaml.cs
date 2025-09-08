using System.Windows;
using System.Windows.Controls;

namespace CMCSPrototype
{
    public partial class MainWindow : Window
    {
        private readonly string _role;

        public MainWindow(string role)
        {
            InitializeComponent();
            _role = role;

            if (_role == "Lecturer")
            {
                tabControl.SelectedItem = lecturerTab;
                approverTab.Visibility = Visibility.Collapsed;
            }
            else if (_role is "Programme Coordinator" or "Academic Manager")
            {
                tabControl.SelectedItem = approverTab;
                lecturerTab.Visibility = Visibility.Collapsed;
            }
        }
    }
}