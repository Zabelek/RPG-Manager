using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace RPG_Manager.views
{
    class ItemBackpackButton
    {
        private BackpackView backpackView;
        private Item item;
        private Label nameLabel, numberLabel;
        private Image itemImage, itemShadow;
        private Button plusButton, minusButton, mainButton;
        public ItemBackpackButton(BackpackView backpackView, Item item)
        {
            this.backpackView = backpackView;
            setUpVisuals();
            setToItem(item);
        }
        public ItemBackpackButton(BackpackView backpackView)
        {
            this.backpackView = backpackView;
            setUpVisuals();
            setToEmpty();
        }
        public void assignItem(Item item)
        {
            setToItem(item);
        }
        public void removeItem()
        {
            setToEmpty();
        }
        private void setUpVisuals()
        {
            mainButton = new Button();
            plusButton = new Button();
            itemImage = new Image();
            itemShadow = new Image();
            minusButton = new Button();
            nameLabel = new Label();
            numberLabel = new Label();
            mainButton.Content = itemImage;
            mainButton.Style = Application.Current.Resources["itemButtonStyle"] as Style;
            mainButton.Width = 210; mainButton.Height = 100; mainButton.HorizontalAlignment = HorizontalAlignment.Left;
            mainButton.VerticalAlignment = VerticalAlignment.Top; mainButton.Margin = new Thickness(20, 15, 0, 0);
            itemShadow.Width = 210; itemShadow.Height = 100; itemShadow.HorizontalAlignment = HorizontalAlignment.Left;
            itemShadow.VerticalAlignment = VerticalAlignment.Top; itemShadow.Margin = new Thickness(20, 15, 0, 0);
            itemShadow.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\item_button_shadow.png")));
            itemShadow.Stretch = Stretch.Fill;
            itemImage.Margin = new Thickness(0, 0, 0, 8);
            plusButton.Style = Application.Current.Resources["boxButtonStyle"] as Style;
            plusButton.Width = 20; plusButton.Height = 20; plusButton.HorizontalAlignment = HorizontalAlignment.Left;
            plusButton.VerticalAlignment = VerticalAlignment.Top; plusButton.Margin = new Thickness(25, 18, 0, 0);
            plusButton.FontSize = 16;
            plusButton.Content = "+";
            plusButton.Click += plusButton_Click;
            minusButton.Style = Application.Current.Resources["boxButtonStyle"] as Style;
            minusButton.Width = 20; minusButton.Height = 20; minusButton.HorizontalAlignment = HorizontalAlignment.Left;
            minusButton.VerticalAlignment = VerticalAlignment.Top; minusButton.Margin = new Thickness(25, 40, 0, 0);
            minusButton.FontSize = 16;
            minusButton.Content = "-";
            minusButton.Click += minusButton_Click;
            nameLabel.Width = 200; nameLabel.Height = 30; nameLabel.HorizontalAlignment = HorizontalAlignment.Left;
            nameLabel.VerticalAlignment = VerticalAlignment.Top; nameLabel.Margin = new Thickness(20, 90, 0, 0);
            nameLabel.FontSize = 14;
            nameLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 210, 210, 210));
            nameLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
            numberLabel.Width = 50; nameLabel.Height = 30; numberLabel.HorizontalAlignment = HorizontalAlignment.Left;
            numberLabel.VerticalAlignment = VerticalAlignment.Top; numberLabel.Margin = new Thickness(180, 20, 0, 0);
            numberLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 210, 210, 210));
            numberLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
        }

        private void setToItem(Item item)
        {
            if(item.isEquipped) 
            {
                itemShadow.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\item_button_shadow_eq.png")));
            }
            else if(item.isDamaged)
            {
                itemShadow.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\item_button_shadow_br.png")));
            }
            this.item = item;
            itemImage.Source = new BitmapImage(new Uri(item.type.category.imagePath));
            nameLabel.Content = item.type.name;
            numberLabel.Content = "1";
            plusButton.Visibility = Visibility.Visible;
            minusButton.Visibility = Visibility.Visible;
            nameLabel.Visibility = Visibility.Visible;
            numberLabel.Visibility = Visibility.Visible;
            removeClickEvents(mainButton);
            mainButton.Click += mainButtonWithItem_Click;
        }
        public void setToEmpty()
        {
            itemShadow.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\item_button_shadow.png")));
            plusButton.Visibility = Visibility.Hidden;
            minusButton.Visibility = Visibility.Hidden;
            nameLabel.Visibility = Visibility.Hidden;
            numberLabel.Visibility = Visibility.Hidden;
            itemImage.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Item Categories\\plus.png")));
            this.item = null;
            removeClickEvents(mainButton);
            mainButton.Click += mainButtonEmpty_Click;
        }

        public Item getItem() { return this.item; }

        public void addToView(Grid itemsGrid, int x, int y)
        {
            if(itemsGrid.RowDefinitions.Count-1 < y)
            {
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(120);
                itemsGrid.RowDefinitions.Add(row);
            }
            Grid.SetRow(nameLabel, y);
            Grid.SetRow(numberLabel, y);
            Grid.SetRow(itemShadow, y);
            Grid.SetRow(mainButton, y);
            Grid.SetRow(plusButton, y);
            Grid.SetRow(minusButton, y);
            Grid.SetColumn(nameLabel, x);
            Grid.SetColumn(numberLabel, x);
            Grid.SetColumn(itemShadow, x);
            Grid.SetColumn(mainButton, x);
            Grid.SetColumn(plusButton, x);
            Grid.SetColumn(minusButton, x);
            itemsGrid.Children.Add(nameLabel);
            itemsGrid.Children.Add(numberLabel);
            itemsGrid.Children.Add(itemShadow);
            itemsGrid.Children.Add(mainButton);
            itemsGrid.Children.Add(plusButton);
            itemsGrid.Children.Add(minusButton);
        }
        internal void addOne()
        {
            int wartosc = Int32.Parse(numberLabel.Content.ToString());
            this.numberLabel.Content = (wartosc + 1).ToString();
        }
        internal void plusButton_Click(object sender, RoutedEventArgs e)
        {
            backpackView.addItemToHero(item);
        }
        internal void minusButton_Click(object sender, RoutedEventArgs e) 
        {
            backpackView.removeItemFromHero(item);
        }
        private void removeClickEvents(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            if (f1 != null)
            {
                object obj = f1.GetValue(b);
                PropertyInfo pi = b.GetType().GetProperty("Events",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
                list.RemoveHandler(obj, list[obj]);
            }
        }
        private void mainButtonWithItem_Click(object sender, RoutedEventArgs e)
        {
            backpackView.setCurrentItem(item);
        }
        private void mainButtonEmpty_Click(object sender, RoutedEventArgs e)
        {
            backpackView.openAddItemMenu();
        }
    }
}
