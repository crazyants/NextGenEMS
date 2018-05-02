using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NextGenEMS.Data;
using NextGenEMS.Frontend;
using NextGenEMS.People;

namespace NextGenEMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Database.Initalize();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientInfoEditor newWindow = new PatientInfoEditor();
            newWindow.ShowDialog();
        }
    }
}
