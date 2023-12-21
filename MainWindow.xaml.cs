using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using static Genshot.Init;

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
            Init.initSettings();
        }

        private void select_game_folder(object sender, MouseButtonEventArgs e)
        {
            if (!Init.openGameFolderDiag()) return;
        }
    }
}
