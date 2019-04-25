using CartWPF.Applications;
using CartWPF.Interface;
using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CartWPF.UserControls
{
    /// <summary>
    /// Interaction logic for ItemUserControl.xaml
    /// </summary>
    public partial class ItemUserControl : UserControl
    {
        static MyContext myContext = new MyContext();
        static ISupplier iSupplier = new SupplierController();
        IItem iItem = new ItemController();
        string ItemId;

        Item item = new Item();

        List<Supplier> SupplierList = iSupplier.Get();

        SaveChange go = new SaveChange(myContext);

        public ItemUserControl()
        {
            InitializeComponent();
        }

        #region UserControl Loaded

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadItem();
            LoadComboBox();
            DeleteItem_Btn.IsEnabled = false;
        }

        public void LoadItem()
        {
            //Item_DataGrid.ItemsSource = iItem.Get(); // Not Updating Data Grid on Update
            Item_DataGrid.ItemsSource = myContext.Items.Include("Suppliers").Where(x => x.isDelete == false).ToList();
        }

        public void LoadComboBox()
        {
            Supplier_comboBox.ItemsSource = SupplierList;
        }

        #endregion UserControl Loaded

        void clearfield()
        {
            ItemId_Txt.Clear();
            ItemName_Txt.Clear();
            ItemStock_Txt.Clear();
            ItemPrice_Txt.Clear();
            Supplier_comboBox.SelectedIndex = -1;
        }

        private void Item_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void ItemPrice_Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            Supplier_comboBox.SelectedIndex = 0;
        }

        private void Item_DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = Item_DataGrid.SelectedItem;
            if (selectedItem != null)
            {
                ItemId_Txt.Text = (Item_DataGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ItemName_Txt.Text = (Item_DataGrid.SelectedCells[1].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ItemStock_Txt.Text = (Item_DataGrid.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text;
                ItemPrice_Txt.Text = (Item_DataGrid.SelectedCells[3].Column.GetCellContent(selectedItem) as TextBlock).Text;
                Supplier_comboBox.Text = (Item_DataGrid.SelectedCells[4].Column.GetCellContent(selectedItem) as TextBlock).Text;
            }
            DeleteItem_Btn.IsEnabled = true;

        }

        #region button

        private void SaveItem_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ItemName_Txt.Text == "" || ItemStock_Txt.Text == "" || ItemPrice_Txt.Text == "")
            {
                MessageBox.Show(" ");
                return;
            }

            if (Convert.ToInt32(Supplier_comboBox.SelectedIndex) == -1)
            {
                Supplier_comboBox.SelectedIndex = 0;
            }


            if (ItemId_Txt.Text == "")
            {
                item.Name = ItemName_Txt.Text;
                item.Stock = Convert.ToInt32(ItemStock_Txt.Text);
                item.Price = Convert.ToInt32(ItemPrice_Txt.Text);

                //Solution 1
                //item.Suppliers = myContext.Suppliers.Find(Convert.ToInt32(Supplier_comboBox.SelectedValue));
                //myContext.Items.Add(item);

                //Solution 2
                item.Suppliers = iSupplier.Get(Convert.ToInt32(Supplier_comboBox.SelectedValue));
                iItem.Insert(item);
            }
            else
            {
                var GetItem = myContext.Items.Find(Convert.ToInt32(ItemId_Txt.Text));
                GetItem.Name = ItemName_Txt.Text;
                GetItem.Stock = Convert.ToInt32(ItemStock_Txt.Text);
                GetItem.Price = Convert.ToInt32(ItemPrice_Txt.Text);

                //Solution 1
                //GetItem.Suppliers = myContext.Suppliers.Find(Convert.ToInt32(Supplier_comboBox.SelectedValue));
                //myContext.Entry(GetItem).State = EntityState.Modified;

                //Solution 2
                GetItem.Suppliers = iSupplier.Get(Convert.ToInt32(Supplier_comboBox.SelectedValue));
                iItem.Update(Convert.ToInt16(ItemId_Txt.Text), GetItem);
            }
            //Part of Solution 1
            //go.saved();
            LoadItem();
            clearfield();
        }

        private void DeleteItem_Btn_Click(object sender, RoutedEventArgs e)
        {
            ItemId = ItemId_Txt.Text;
            iItem.Delete(Convert.ToInt16(ItemId));

            LoadItem();
            DeleteItem_Btn.IsEnabled = false;
        }

        #endregion button

    }
}
