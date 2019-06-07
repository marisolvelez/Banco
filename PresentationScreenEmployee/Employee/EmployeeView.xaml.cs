using Presentation.EmployeeViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Helper;


namespace EmployeeView
{
    /// <summary>
    /// Lógica de interacción para EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : Window
    {
        private EmployeeViewModel EmployeeViewModel;
        public EmployeeView()
        {
            //InitializeComponent();
            EmployeeViewModel  = new EmployeeViewModel();
            DataContext = EmployeeViewModel;
        }
    }
}
