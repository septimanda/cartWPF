using CartWPF.Applications;
using CartWPF.Interface;
using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for TransactionItemUserControl.xaml
    /// </summary>
    public partial class TransactionItemUserControl : UserControl
    {
        static MyContext myContext = new MyContext();
        ITransactionItem iTransactionItem = new TransactionItemController();
        ISell iSell = new SellController();
        IItem iItem = new ItemController();
        static ISupplier iSupplier = new SupplierController();
        List<Supplier> SupplierList = iSupplier.Get();

        TransactionItem transactionItem = new TransactionItem();
        Sell sell = new Sell();

        Collection<TransactionItem> ListCart = new Collection<TransactionItem>();

        decimal qty, prc;
        //int prices = 0;

        SaveChange go = new SaveChange(myContext);

        public TransactionItemUserControl()
        {
            InitializeComponent();
        }

        private void Supplier_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = Supplier_comboBox.SelectedValue;
            if (selectedItem != null)
            {
                List<Item> ItemList = iItem.GetList(Convert.ToInt16(selectedItem));
                Item_comboBox.ItemsSource = ItemList;
                Item_comboBox.SelectedIndex = 0;
                Item_comboBox.Focus();

            }
        }

        private void Item_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = Item_comboBox.SelectedValue;

            if (selectedItem != null)
            {
                Item ItemPriceList = iItem.Get(Convert.ToInt16(selectedItem));
                ItemPrice_Txt.Text = ItemPriceList.Price.ToString() ;
                //ItemQuantity_Txt.Focus();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            Supplier_comboBox.ItemsSource = SupplierList;
        }

        void AddToCartClearField()
        {
            Supplier_comboBox.SelectedIndex = -1;
            Item_comboBox.SelectedIndex = -1;
            ItemPrice_Txt.Clear();
            ItemQuantity_Txt.Clear();
        }

        void PayClearField()
        {
            Supplier_comboBox.SelectedIndex = -1;
            Item_comboBox.SelectedIndex = -1;
            ItemPrice_Txt.Clear();
            ItemQuantity_Txt.Clear();

            TotalPrice_Txt.Clear();
            PPN_Txt.Clear();
            Payment_Txt.Clear();
            ReturnPayment_Txt.Clear();
        }

        private void AddToCart_Btn_Click(object sender, RoutedEventArgs e)
        {
            //transactionItem.Quantity = Convert.ToInt32(ItemQuantity_Txt.Text);
            //transactionItem.Items = iItem.Get(Convert.ToInt32(Item_comboBox.SelectedValue));
            //ListOf.Add(transactionItem);

            Cart_DataGrid.Items.Add(
                 new
                 {
                     Id = Item_comboBox.SelectedValue,
                     Name = Item_comboBox.Text,
                     Quantity = ItemQuantity_Txt.Text,
                     Price = ItemPrice_Txt.Text
                 }
             );
            

            if (TotalPrice_Txt.Text == "") { TotalPrice_Txt.Text = "0"; }

            TotalPrice_Txt.Text = (Convert.ToInt32(TotalPrice_Txt.Text) + (Convert.ToInt32(ItemQuantity_Txt.Text) * Convert.ToInt32(ItemPrice_Txt.Text))).ToString();
            PPN_Txt.Text = (Convert.ToInt32(TotalPrice_Txt.Text) * 0.1).ToString();

            AddToCartClearField();


            //decimal sum = 0;
            //try
            //{
            //    for (int i = 0; i <= Cart_DataGrid.Items.Count; ++i)
            //    {
            //        qty = Convert.ToDecimal((Cart_DataGrid.Columns[2].GetCellContent(Cart_DataGrid.Items[i]) as TextBlock).Text);
            //        prc = Convert.ToDecimal((Cart_DataGrid.Columns[3].GetCellContent(Cart_DataGrid.Items[i]) as TextBlock).Text);

            //        sum += (qty * prc);
            //        TotalPrice_Txt.Text = sum.ToString();
            //        PPN_Txt.Text = (sum / 10).ToString();
            //}
            //}
            //catch (Exception ex)
            //{
            //    Console.Write(ex.Message);
            //    Console.Write(ex.StackTrace);
            //}
        }

        private void Cancel_Btn_Click(object sender, RoutedEventArgs e)
        {
            object selectedIndex = Cart_DataGrid.SelectedIndex;
            object selectedItem = Cart_DataGrid.SelectedItem;

            if (selectedItem != null)
            {
                qty = Convert.ToDecimal((Cart_DataGrid.SelectedCells[2].Column.GetCellContent(selectedItem) as TextBlock).Text);
                prc = Convert.ToDecimal((Cart_DataGrid.SelectedCells[3].Column.GetCellContent(selectedItem) as TextBlock).Text);
                TotalPrice_Txt.Text = (Convert.ToInt32(TotalPrice_Txt.Text) - (Convert.ToInt32(qty) * Convert.ToInt32(prc))).ToString();
                PPN_Txt.Text = (Convert.ToInt32(TotalPrice_Txt.Text) * 0.1).ToString();
                Cart_DataGrid.Items.RemoveAt(Convert.ToInt32(selectedIndex));
            }
        }

        private void Payment_Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            int ReturnPayment = (Convert.ToInt32(Payment_Txt.Text) - (Convert.ToInt32(TotalPrice_Txt.Text) + Convert.ToInt32(PPN_Txt.Text)));
            ReturnPayment_Txt.Text = ReturnPayment.ToString();
            if (ReturnPayment < 0)
            {
                //Payment_Txt.Focus();
                Payment_Txt.Foreground = Brushes.Red;
                Payment_Txt.BorderBrush = Brushes.Red;
            }
        }

        private void PayCart_Btn_Click(object sender, RoutedEventArgs e)
        {
            sell.OrderDate = DateTimeOffset.UtcNow.ToLocalTime();
            iSell.Insert(sell);

            for (int i = 0; i < Cart_DataGrid.Items.Count; ++i)
            {
                //MessageBox.Show(""+x.Items+" "+x.Quantity);
                transactionItem.Sells = iSell.Get(sell.Id);
                transactionItem.Quantity = Convert.ToInt32((Cart_DataGrid.Columns[2].GetCellContent(Cart_DataGrid.Items[i]) as TextBlock).Text);
                transactionItem.Items = iItem.Get(Convert.ToInt32((Cart_DataGrid.Columns[0].GetCellContent(Cart_DataGrid.Items[i]) as TextBlock).Text));
                //iTransactionItem.Insert(x);
                ListCart.Insert(i,transactionItem);
                //myContext.Entry(transactionItem.Sells).State = System.Data.Entity.EntityState.Unchanged;
                //myContext.Entry(transactionItem.Items).State = System.Data.Entity.EntityState.Unchanged;
                //myContext.TransactionItems.Add(transactionItem);
            }

            //go.saved();
            ListCart.Clear();
            Cart_DataGrid.Items.Clear();

            //for (int i = 0; i <= Cart_DataGrid.Items.Count; ++i)
            //{
            //    try
            //    {
            //        transactionItem.Sells = iSell.Get(sell.Id);
            //        transactionItem.Items = iItem.Get(Convert.ToInt32((Cart_DataGrid.Columns[0].GetCellContent(Cart_DataGrid.Items[i]) as TextBlock).Text));
            //        transactionItem.Quantity = Convert.ToInt32((Cart_DataGrid.Columns[2].GetCellContent(Cart_DataGrid.Items[i]) as TextBlock).Text);
            //        iTransactionItem.Insert(transactionItem);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        MessageBox.Show(ex.InnerException.ToString());
            //        MessageBox.Show(ex.StackTrace);
            //    }
            //}

        }

        private void Input_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }
    }
}
