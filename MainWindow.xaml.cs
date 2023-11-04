using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;

namespace Genshot
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

        private void select_game_folder(object sender, MouseButtonEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath.ToLower().Contains("genshin impact\\genshin impact game"))
                {
                    // Display a message box to the user indicating that the folder selected was ok!
                    System.Windows.MessageBox.Show("Game folder set at: " + folderBrowserDialog.SelectedPath);
                    this.game_path_tb.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    // Display a message box to the user
                    System.Windows.MessageBox.Show("Please select a folder under the game's folder!");
                }
            }
        }
    }
}
