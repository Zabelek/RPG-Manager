using RPG_Manager.data_model;
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

namespace RPG_Manager.views
{
    /// <summary>
    /// Logika interakcji dla klasy AddItemMenu.xaml
    /// </summary>
    public partial class AddItemMenu : Window
    {
        private BackpackView backpackView;
        public AddItemMenu(BackpackView backpackView)
        {
            InitializeComponent();
            this.backpackView = backpackView;
            addItemCombvoBox.ItemsSource = Session.registeredItemCategories;
            addItemCombvoBox.DisplayMemberPath = "name";
            addItemCombvoBox.SelectedItem = Session.registeredItemCategories.Find(x => String.Compare(x.name, "Pozostałe")==0);
            foreach (ItemType item in Session.registeredItems)
            {
                Button button = new Button();
                button.Margin = new Thickness(10, 5, 10, 0);
                button.FontSize = 14;
                button.FontWeight = FontWeights.Bold;
                button.Content = item.name;
                itemsStackPanel.Children.Add(button);
                button.Click+= new RoutedEventHandler((sendItem, args) => {
                    backpackView.addItemToHero(new Item(item, 0, 0, false, false));
                    this.Close();
            });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(addItemTextBox.Text!=null && addItemTextBox.Text.Length>0)
            {
                ItemType item = new ItemType(addItemTextBox.Text, "Brak", (ItemCategory)addItemCombvoBox.SelectedItem, "Brak");
                Session.registeredItems.Add(item);
                backpackView.addItemToHero(new Item(item, 0, 0, false, false));
                this.Close();
            }
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                itemsStackPanel.Children.Clear();
                foreach (ItemType item in Session.registeredItems)
                {
                    if (item.name.ToLower().Contains(searchBar.Text.ToLower()))
                    {
                        Button button = new Button();
                        button.Margin = new Thickness(10, 5, 10, 0);
                        button.FontSize = 14;
                        button.FontWeight = FontWeights.Bold;
                        button.Content = item.name;
                        itemsStackPanel.Children.Add(button);
                        button.Click += new RoutedEventHandler((sendItem, args) =>
                        {
                            backpackView.addItemToHero(new Item(item, 0, 0, false, false));
                            this.Close();
                        });
                    }
                }
            }
        }
    }
}
