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

namespace TreeTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Adding test data -- Level 0

            TreeViewItem z = new TreeViewItem();
            z.Header = "Level 0 item 1";
            tvMain.Items.Add(z);

            z = new TreeViewItem();
            z.Header = "Level 0 item 2";
            tvMain.Items.Add(z);

            // Adding test data -- Level 1

            TreeViewItem z1 = new TreeViewItem();
            z1.Header = "Level 1 item 1";
            z.Items.Add(z1);

            // Adding test data -- Level 2

            TreeViewItem z2 = new TreeViewItem();
            z2.Header = "Level 2 item 1";
            z1.Items.Add(z2);

            z2 = new TreeViewItem();
            z2.Header = "Level 2 item 2";
            z1.Items.Add(z2);
        }

        private void TvMain_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            string result = "";

            TreeView tree = (TreeView) sender;

            TreeViewItem item = (TreeViewItem) tree.SelectedItem;
            result = item.Header.ToString();

            while (item.Parent is TreeViewItem && item.Parent != null)
            {
                item = (TreeViewItem)item.Parent;
                result = item.Header.ToString() + " \\ " + result;
            }

            MessageBox.Show(result);
        }
    }
}
