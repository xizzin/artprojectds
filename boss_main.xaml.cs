using iamapollojusticeandiamfine.ArtProjectDataSetTableAdapters;
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
using System.Windows.Shapes;

namespace iamapollojusticeandiamfine
{
    public partial class boss_main : Window
    {
        ProjectFilesTableAdapter prinfo = new ProjectFilesTableAdapter();
        public boss_main()
        {
            InitializeComponent();
            ProjectInfO_datagrid.ItemsSource = prinfo.GetData();
        }
        private void DoAfterLoad(object sender, RoutedEventArgs e)
        {
            ProjectInfO_datagrid.Columns[0].Visibility = Visibility.Collapsed;
        }
    }
}
