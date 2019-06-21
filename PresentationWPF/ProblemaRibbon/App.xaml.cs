using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProblemaRibbon
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            //Cambiando de tema 
            ApplicationThemeHelper.ApplicationThemeName = Theme.DeepBlue.FullName;
            base.OnStartup(e);

        }
    }
}
