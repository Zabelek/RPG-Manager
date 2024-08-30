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
    /// Logika interakcji dla klasy ItemEditingView.xaml
    /// </summary>
    public partial class ItemEditingView : Window
    {
        private BackpackView view;
        private Item item;

        public ItemEditingView(BackpackView view, Item item)
        {
            InitializeComponent();
            this.view = view;
            this.item = item;
            itemCategoryComboBox.ItemsSource = Session.registeredItemCategories;
            itemCategoryComboBox.DisplayMemberPath = "name";
            itemCategoryComboBox.SelectedItem = item.type.category;
            itemNameTextBox.Text = item.type.name;
            if(item.type.description != null && item.type.description.Length>0) 
            {
                itemDescriptionTextBox.Text = item.type.description;
            }
            if (item.type.imagePath != null && item.type.imagePath.Length > 14)
            {
                String pom = item.type.imagePath.Substring(14);
                imagePathTextBox.Text = pom;
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if(itemNameTextBox.Text!=null && itemNameTextBox.Text.Length>0)
            {
                item.type.name = itemNameTextBox.Text;
                item.type.category = (ItemCategory)itemCategoryComboBox.SelectedItem;
                if(itemDescriptionTextBox.Text!=null)
                {
                    item.type.description = itemDescriptionTextBox.Text;
                }
                if(imagePathTextBox.Text!=null)
                {
                    item.type.imagePath = "assets\\items\\\\"+imagePathTextBox.Text;
                }
            }
            view.setCurrentItem(item);
            view.updateButtons();
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
