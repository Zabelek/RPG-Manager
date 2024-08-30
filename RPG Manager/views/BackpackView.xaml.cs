using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPG_Manager.views
{
    /// <summary>
    /// Logika interakcji dla klasy BackpackView.xaml
    /// </summary>
    public partial class BackpackView : Window
    {
        private Hero displayedHero;
        private HeroesView view;
        private List<ItemBackpackButton> backpackButtons;
        private Item currentItem;

        public BackpackView(HeroesView view, Hero hero)
        {
            InitializeComponent();
            this.displayedHero = hero;
            this.view = view;
            backpackButtons = new List<ItemBackpackButton>();
            updateViewWithHero();
        }

        private void updateViewWithHero()
        {
            titleLabel.Content = displayedHero.name+" Plecak:";
            goldTextBox.Text = displayedHero.gold.ToString();
            goldTextBox.TextChanged += goldTextBox_TextChanged;
            updateButtons();
        }

        public void updateButtons()
        {
            itemsGrid.Children.Clear();
            backpackButtons.Clear();
            foreach (Item item in displayedHero.backpack)
            {
                bool duplicate = false;
                foreach (ItemBackpackButton button in backpackButtons)
                {                   
                    if(String.Compare(button.getItem().type.name, item.type.name) == 0)
                    {
                        duplicate = true;
                        button.addOne();
                    }
                }
                if(!duplicate)
                {
                    ItemBackpackButton newButton = new ItemBackpackButton(this, item);
                    newButton.addToView(itemsGrid, backpackButtons.Count%4, backpackButtons.Count/4);
                    Debug.WriteLine(backpackButtons.Count / 4);
                    backpackButtons.Add(newButton);
                }
            }
            ItemBackpackButton newEmpyuButton = new ItemBackpackButton(this);
            newEmpyuButton.addToView(itemsGrid, backpackButtons.Count % 4, backpackButtons.Count / 4);
            Debug.WriteLine(backpackButtons.Count / 4);
            backpackButtons.Add(newEmpyuButton);
        }
        public void setCurrentItem(Item item)
        {
            this.currentItem = item;
            try
            {
                previewImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), item.type.imagePath)));
            }
            catch(Exception e) 
            {
                previewImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), item.type.category.imagePath)));
            }
            itemtitleLabel.Content = item.type.name;
            descriptionTextBlock.Text = item.type.description;
        }
        public void removeItemFromHero(Item item)
        {
            displayedHero.backpack.Remove(item);
            updateButtons();
        }
        public void addItemToHero(Item item)
        {
            displayedHero.backpack.Add(item);
            updateButtons();
        }
        public void openAddItemMenu()
        {
            AddItemMenu menu = new AddItemMenu(this);
            menu.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            view.enableView();
            this.Close();
        }

        private void goldTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                this.displayedHero.gold = Int32.Parse(goldTextBox.Text);
            }
            catch (Exception ex) { }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if(currentItem!=null) 
            { 
                ItemEditingView view = new ItemEditingView(this, currentItem);
                view.Show();
            }
        }

        private void equipButton_Click(object sender, RoutedEventArgs e)
        {
            if(currentItem != null && !currentItem.isDamaged)
            {
                currentItem.isEquipped = !currentItem.isEquipped;
                updateButtons();
            }
        }

        private void damageButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentItem != null)
            {
                currentItem.isDamaged = !currentItem.isDamaged;
                if(currentItem.isDamaged) { currentItem.isEquipped = false; }
                updateButtons();
            }
        }

        private void AddGold_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                goldTextBox.Text = (Int32.Parse(goldTextBox.Text) + Int32.Parse(goldModTextBox.Text)).ToString();
                goldModTextBox.Text = "0";

            }
            catch (Exception ex) { }
        }
    }
}
