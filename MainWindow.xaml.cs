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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Logistics
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogisticsEntities Logistics;
        public MainWindow()
        {
            InitializeComponent();
            Logistics = new LogisticsEntities();
        }
        public void ShowTablesAndUpdate()
        {
            if (comboBox.SelectedIndex == 0)
            {
                FinanceDataGrid.ItemsSource = Logistics.Customer.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 1)
            {
                FinanceDataGrid.ItemsSource = Logistics.Delivery.ToList();
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 2)
            {
                FinanceDataGrid.ItemsSource = Logistics.Order.ToList();
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[7].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[8].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 3)
            {
                FinanceDataGrid.ItemsSource = Logistics.OrderDetail.ToList();
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 4)
            {
                FinanceDataGrid.ItemsSource = Logistics.Product.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[7].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[8].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 5)
            {
                FinanceDataGrid.ItemsSource = Logistics.Route.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 6)
            {
                FinanceDataGrid.ItemsSource = Logistics.RouteDetail.ToList();
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 7)
            {
                FinanceDataGrid.ItemsSource = Logistics.Shipment.ToList();
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[7].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 8)
            {
                FinanceDataGrid.ItemsSource = Logistics.Supplier.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 9)
            {
                FinanceDataGrid.ItemsSource = Logistics.Warehouse.ToList();
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
        }
        public void ShowTables()
        {
            if (comboBox.SelectedIndex == 0)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 1)
            {
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 2)
            {
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[7].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[8].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 3)
            {
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 4)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[7].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[8].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 5)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 6)
            {
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 7)
            {
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[7].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 8)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 9)
            {
                FinanceDataGrid.Columns[2].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[3].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[4].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[5].Visibility = Visibility.Hidden;
                FinanceDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowTablesAndUpdate();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputText = textBox.Text.ToLower();
            if (comboBox.SelectedIndex == 0 && textBox.Text != "")
            {
                List<Customer> list_customer = Logistics.Customer.ToList();
                var customer = list_customer.Where(
                l => l.CustomerID.ToString().ToLower().Contains(inputText) ||
                l.CustomerName.ToString().ToLower().Contains(inputText) ||
                l.CustomerAddress.ToString().ToLower().Contains(inputText) ||
                l.CustomerContact.ToString().ToLower().Contains(inputText) ||
                l.Order.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = customer.ToList();
            }
            else if (comboBox.SelectedIndex == 0 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 1 && textBox.Text != "")
            {
                List<Delivery> list_delivery = Logistics.Delivery.ToList();
                var delivery = list_delivery.Where(
                l => l.DeliveryID.ToString().ToLower().Contains(inputText) ||
                l.SupplierID.ToString().ToLower().Contains(inputText) ||
                l.ProductID.ToString().ToLower().Contains(inputText) ||
                l.DeliveryDate.ToString().ToLower().Contains(inputText) ||
                l.DeliveryQuantity.ToString().ToLower().Contains(inputText) ||
                l.Product.ToString().ToLower().Contains(inputText) ||
                l.Supplier.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = delivery.ToList();
            }
            else if (comboBox.SelectedIndex == 1 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 2 && textBox.Text != "")
            {
                List<Order> list_order = Logistics.Order.ToList();
                var order = list_order.Where(
                l => l.OrderID.ToString().ToLower().Contains(inputText) ||
                l.CustomerID.ToString().ToLower().Contains(inputText) ||
                l.OrderDate.ToString().ToLower().Contains(inputText) ||
                l.DeliveryDate.ToString().ToLower().Contains(inputText) ||
                l.OrderStatus.ToString().ToLower().Contains(inputText) ||
                l.Customer.ToString().ToLower().Contains(inputText) ||               
                l.OrderDetail.ToString().ToLower().Contains(inputText) ||
                l.Shipment.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = order.ToList();
            }
            else if (comboBox.SelectedIndex == 2 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 3 && textBox.Text != "")
            {
                List<OrderDetail> list_orderDetail = Logistics.OrderDetail.ToList();
                var orderDetail = list_orderDetail.Where(
                l => l.OrderID.ToString().ToLower().Contains(inputText) ||
                l.ProductID.ToString().ToLower().Contains(inputText) ||
                l.OrderQuantity.ToString().ToLower().Contains(inputText) ||
                l.Order.ToString().ToLower().Contains(inputText) ||
                l.Product.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = orderDetail.ToList();
            }
            else if (comboBox.SelectedIndex == 3 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 4 && textBox.Text != "")
            {
                List<Product> list_product = Logistics.Product.ToList();
                var product = list_product.Where(
                l => l.ProductID.ToString().ToLower().Contains(inputText) ||
                l.ProductName.ToString().ToLower().Contains(inputText) ||
                l.ProductDescription.ToString().ToLower().Contains(inputText) ||
                l.ProductPrice.ToString().ToLower().Contains(inputText) ||
                l.WarehouseID.ToString().ToLower().Contains(inputText) ||
                l.Delivery.ToString().ToLower().Contains(inputText) ||
                l.OrderDetail.ToString().ToLower().Contains(inputText) ||
                l.Warehouse.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = product.ToList();
            }
            else if (comboBox.SelectedIndex == 4 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 5 && textBox.Text != "")
            {
                List<Route> list_route = Logistics.Route.ToList();
                var route = list_route.Where(
                l => l.RouteID.ToString().ToLower().Contains(inputText) ||
                l.RouteDescription.ToString().ToLower().Contains(inputText) ||
                l.RouteDetail.ToString().ToLower().Contains(inputText) ||
                l.Shipment.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = route.ToList();
            }
            else if (comboBox.SelectedIndex == 5 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 6 && textBox.Text != "")
            {
                List<RouteDetail> list_routeDetail = Logistics.RouteDetail.ToList();
                var routeDetail = list_routeDetail.Where(
                l => l.RouteID.ToString().ToLower().Contains(inputText) ||
                l.WarehouseID.ToString().ToLower().Contains(inputText) ||
                l.Sequence.ToString().ToLower().Contains(inputText) ||
                l.Route.ToString().ToLower().Contains(inputText) ||
                l.Warehouse.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = routeDetail.ToList();
            }
            else if (comboBox.SelectedIndex == 6 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 7 && textBox.Text != "")
            {
                List<Shipment> list_shipment = Logistics.Shipment.ToList();
                var shipment = list_shipment.Where(
                l => l.ShipmentID.ToString().ToLower().Contains(inputText) ||
                l.OrderID.ToString().ToLower().Contains(inputText) ||
                l.RouteID.ToString().ToLower().Contains(inputText) ||
                l.ShipmentDate.ToString().ToLower().Contains(inputText) ||
                l.ShipmentStatus.ToString().ToLower().Contains(inputText) ||
                l.Order.ToString().ToLower().Contains(inputText) ||
                l.Route.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = shipment.ToList();
            }
            else if (comboBox.SelectedIndex == 7 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 8 && textBox.Text != "")
            {
                List<Warehouse> list_warehouse = Logistics.Warehouse.ToList();
                var warehouse = list_warehouse.Where(
                l => l.WarehouseID.ToString().ToLower().Contains(inputText) ||
                l.WarehouseName.ToString().ToLower().Contains(inputText) ||
                l.WarehouseAddress.ToString().ToLower().Contains(inputText) ||
                l.WarehouseCapacity.ToString().ToLower().Contains(inputText) ||
                l.Product.ToString().ToLower().Contains(inputText) ||
                l.RouteDetail.ToString().ToLower().Contains(inputText));
                FinanceDataGrid.ItemsSource = warehouse.ToList();
            }
            else if (comboBox.SelectedIndex == 8 && textBox.Text == "")
            {
                ShowTablesAndUpdate();
            }
            ShowTables();
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                Customer customer = new Customer();
                customer.CustomerName = null;
                customer.CustomerAddress = null;
                customer.CustomerContact = null;
                customer.Order = null;
                Logistics.Customer.Add(customer);
                Logistics.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 1)
            {
                Delivery delivery = new Delivery();
                delivery.Product = null;
                delivery.Supplier = null;
                Logistics.Delivery.Add(delivery);
                Logistics.SaveChanges();
                ShowTablesAndUpdate();
            }
            if (comboBox.SelectedIndex == 2)
            {
            }
            if (comboBox.SelectedIndex == 3)
            {

            }
            if (comboBox.SelectedIndex == 4)
            {
            }
            if (comboBox.SelectedIndex == 5)
            {
            }
            if (comboBox.SelectedIndex == 6)
            {
            }
        }
        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                Shipment shipment = FinanceDataGrid.SelectedItem as Shipment;
                Logistics.Shipment.Remove(shipment);
                Logistics.SaveChanges();
                FinanceDataGrid.ItemsSource = Logistics.Shipment.ToList();
                ShowTables();
            }
        }
        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            ShowTablesAndUpdate();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                Logistics.SaveChanges();
                ShowTablesAndUpdate();
            }
        }
    }
}
