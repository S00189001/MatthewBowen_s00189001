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

namespace MatthewBowen_s00189001
{
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.PhoneDetails
                        select p;

            
            UI_PhoneDataListBox.ItemsSource = query.ToList();

            UI_PhoneDataListBox.SelectedItem = 0;

         
        }

        private void UI_PhoneDataListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = UI_PhoneDataListBox.SelectedItem as Phone;

            UI_PriceTB.Text = string.Format("Price: {0:C}", selectedPhone.Price);

            UI_DIsplayImage.Source = new BitmapImage(new Uri(selectedPhone.Phone_Image, UriKind.Relative));
        }
    }
}
  