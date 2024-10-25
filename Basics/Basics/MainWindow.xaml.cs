using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        { 

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            WeldCheckBox.IsChecked = false;
            AssemblyCheckBox.IsChecked = false;
            PlasmaCheckBox.IsChecked = false;
            LaserCheckBox.IsChecked = false;
            PurchaseCheckBox.IsChecked = false;
            LatheCheckBox.IsChecked = false;
            DrillCheckBox.IsChecked = false;
            FoldCheckBox.IsChecked = false;
            RollCheckBox.IsChecked = false;
            SawCheckbox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextBox.Text += ((CheckBox)sender).Content;

        }

        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteTextBox is null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.NoteTextBox.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_SelectionChanged(this.FinishComboBox, null);
        }
    }
}