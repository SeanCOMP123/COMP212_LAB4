using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using COMP212_LAB4.Models;
using COMP212_LAB4.ViewModels;

namespace COMP212_LAB4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        FoodViewModel fModel = new FoodViewModel();
      
        public MainWindow()
        {
            InitializeComponent();

            appetizer.ItemsSource = fModel.Appetizers;
            mainCourse.ItemsSource = fModel.MainCourses;
            BeverageComboBox.ItemsSource = fModel.Beverages;
            DessertComboBox.ItemsSource = fModel.Desserts;
            menuData.ItemsSource = fModel.DataMenu;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food appe = appetizer.SelectedItem as Food;
            if (menuData.Items.Count != 0)
            {
                bool matchedItem = false;
                foreach (Food food in menuData.Items)
                {
                    if (food.Item == appe.Item) 
                    {
                        matchedItem = true;
                        food.Quantity ++;
            

                    }
                }
                if (matchedItem == false)
                {
                    fModel.DataMenu.Add(appe);
                }
      
            }
            else 
            {
                fModel.DataMenu.Add(appe);
            }

            menuData.Items.Refresh();
            addSubTotalCalculator();
            taxCalculator();
            totalCalcualtor();
        }

        private void mainCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food main = mainCourse.SelectedItem as Food;
            if (menuData.Items.Count != 0)
            {
                bool matchedItem = false;
                foreach (Food food in menuData.Items)
                {
                    if (food.Item == main.Item)
                    {
                        matchedItem = true;
                        food.Quantity++;

                    }
                }
                if (matchedItem == false)
                {
                    fModel.DataMenu.Add(main);
                }

            }
            else
            {
                fModel.DataMenu.Add(main);
            }

            menuData.Items.Refresh();
            addSubTotalCalculator();
            taxCalculator();
            totalCalcualtor();
        }

        private void BeverageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food beverage = BeverageComboBox.SelectedItem as Food;
            if (menuData.Items.Count != 0)
            {
                bool matchedItem = false;
                foreach (Food food in menuData.Items)
                {
                    if (food.Item == beverage.Item)
                    {
                        matchedItem = true;
                        food.Quantity++;

                    }
                }
                if (matchedItem == false)
                {
                    fModel.DataMenu.Add(beverage);
                }

            }
            else
            {
                fModel.DataMenu.Add(beverage);
            }

            menuData.Items.Refresh();
            addSubTotalCalculator();
            taxCalculator();
            totalCalcualtor();

        }

        private void DessertComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food dessert = DessertComboBox.SelectedItem as Food;
            if (menuData.Items.Count != 0)
            {
                bool matchedItem = false;
                foreach (Food food in menuData.Items)
                {
                    if (food.Item == dessert.Item)
                    {
                        matchedItem = true;
                        food.Quantity++;

                    }
                }
                if (matchedItem == false)
                {
                    fModel.DataMenu.Add(dessert);
                }

            }
            else
            {
                fModel.DataMenu.Add(dessert);
            }

            menuData.Items.Refresh();
            addSubTotalCalculator();
            taxCalculator();
            totalCalcualtor();
        }
        private void addSubTotalCalculator() 
        {
            double sub = 0;
            foreach (Food food in menuData.Items) 
            {
                sub += food.TotalPrice;
            }
            subTextBox.Text = sub.ToString("C", CultureInfo.CurrentCulture);
            

        }
        private void taxCalculator() 
        {
    
            double tax = (double.Parse(subTextBox.Text.Replace("$","")))*0.13;
            taxTextBox.Text = tax.ToString("F");

        }
        private void totalCalcualtor() 
        {
            double total = 0;
            total = double.Parse(subTextBox.Text.Replace("$","")) + double.Parse(taxTextBox.Text.Replace("$",""));
            totalTextBox.Text = total.ToString("C", CultureInfo.CurrentCulture);        
        }
        private void deletedRow(object sender, RoutedEventArgs e)
        {
            DataGridRow selectedRow = sender as DataGridRow;
            Console.WriteLine(selectedRow.Item);
            Food thisFood = selectedRow.Item as Food;
            fModel.DataMenu.Remove(thisFood);
            addSubTotalCalculator();
            taxCalculator();
            totalCalcualtor();
            menuData.Items.Refresh();

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            fModel.DataMenu.Clear();
            subTextBox.Text = "$0";
            totalTextBox.Text = "$0";
            taxTextBox.Text = "$0";
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // for .NET Core you need to add UseShellExecute = true
            // see https://docs.microsoft.com/dotnet/api/system.diagnostics.processstartinfo.useshellexecute#property-value
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();
        }

        private void menuData_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            addSubTotalCalculator();
            taxCalculator();
            totalCalcualtor();
        }
    }
}
