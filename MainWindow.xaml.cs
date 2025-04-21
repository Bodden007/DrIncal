using System.IO;
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
using DrIncal.srs;
using DrIncal.srs.Entities;

namespace DrIncal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller = new Controller();

        Microsoft.Win32.OpenFolderDialog dialog = new();

        public MainWindow()
        {
            InitializeComponent();

            //TODO Add event
            controller.MessageSend += ContollMessage;
        }

        private void OpenFili_Click(object sender, RoutedEventArgs e)
        {

            dialog.Multiselect = false;
            dialog.Title = "Select a folder";

            bool? result = dialog.ShowDialog();

            // Process open folder dialog box results
            if (result == true)
            {
                var selectCorrectFolder = controller.Run(dialog.FolderName, dialog.SafeFolderName);
            }
        }
        private void ContollMessage(object sender, ControllerMessage e)
        {
            if (!e.IsError)
            {
                LogList.Items.Add(new TextBlock()
                {
                    Text = e.Message,
                    Foreground = Brushes.Green,
                    FontSize = 14
                });
            }
            else
            {
                LogList.Items.Add(new TextBlock()
                {
                    Text = e.Message,
                    Foreground = Brushes.Red,
                    FontSize = 14
                });
            }
        }

        private void ChangeData_Click(object sender, RoutedEventArgs e)
        {
            SelectDate.IsEnabled = true;
        }

        private void Select_Date_Picker(object sender, SelectionChangedEventArgs e)
        {
            var selectDate = SelectDate.SelectedDate;

            MessageBox.Show($" Дата {selectDate.Value.ToString("dd.MM.yyyy")}");
        }
    }
}