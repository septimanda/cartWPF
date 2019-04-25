using CartWPF.UserControls;
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

namespace CartWPF
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Menu_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Menu_ListView.SelectedIndex;
            moveCursorMenu(index);

            switch (index)
            {
                case 0:
                    Main_Grid.Children.Clear();
                    Main_Grid.Children.Add(new MainUserControl());
                    Title_TxtBlock.Text = "Main Menu";
                    break;
                case 1:
                    Main_Grid.Children.Clear();
                    Main_Grid.Children.Add(new SupplierUserControl());
                    Title_TxtBlock.Text = "Supplier Menu";
                    break;
                case 2:
                    Main_Grid.Children.Clear();
                    Main_Grid.Children.Add(new ItemUserControl());
                    Title_TxtBlock.Text = "Item Menu";
                    break;
                case 3:
                    Main_Grid.Children.Clear();
                    Main_Grid.Children.Add(new TransactionItemUserControl());
                    Title_TxtBlock.Text = "Cart Menu";
                    break;

                default:
                    break;
            }
        }

        void moveCursorMenu(int index)
        {
            Slide_TransitionContent.OnApplyTemplate();
            Cursor_Grid.Margin = new Thickness(0, (60 * index), 0, 0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main_Grid.Children.Clear();
            Main_Grid.Children.Add(new MainUserControl());

            ItemUserControl IUC = new ItemUserControl();
            IUC.LoadItem();
            IUC.LoadComboBox();

            SupplierUserControl SUC = new SupplierUserControl();
            SUC.LoadSupplier();
        }
    }
}
