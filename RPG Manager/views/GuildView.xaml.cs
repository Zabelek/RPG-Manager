using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPG_Manager.views
{
    /// <summary>
    /// Logika interakcji dla klasy GuildView.xaml
    /// </summary>
    public partial class GuildView : Window
    {
        public List<FrameworkElement> sharedComponents { get; set; }
        private MainWindow mainWindow;
        private bool init;

        public GuildView(MainWindow mainWindow)
        {
            InitializeComponent();
            init = true;
            this.mainWindow = mainWindow;
            sharedComponents = new List<FrameworkElement>();
            sharedComponents.Add(background);
            sharedComponents.Add(titleBackground);
            sharedComponents.Add(titleLabel);
            sharedComponents.Add(goldImage);
            sharedComponents.Add(goldTextBox);
            sharedComponents.Add(upgradesTitleLabel);
            sharedComponents.Add(upgradesScrollBar);
            sharedComponents.Add(descTitleLabel);
            sharedComponents.Add(furnitureDescriptionBox);
            sharedComponents.Add(furnitureDescriptionTitleBox);
            sharedComponents.Add(furnitureImageGrid);
            reloadGui();
            init = false;

        }
        internal void clearParentFormComponents()
        {
            foreach (UIElement element in sharedComponents)
            {
                var parent = VisualTreeHelper.GetParent(element);
                var parentAsPanel = parent as Panel;
                if (parentAsPanel != null)
                {
                    parentAsPanel.Children.Remove(element);
                }
            }
        }

        private void goldTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!init)
            {
                try
                {
                    Session.guildMoney = Int32.Parse(goldTextBox.Text);
                }
                catch (Exception ex) { }
            }
        }

        internal void reloadGui()
        {
            upgradesStackPanel.Children.Clear();
            foreach (GuildFurniture furniture in Session.guildFurnitures)
            {
                Button button = new Button();
                button.Margin = new Thickness(15, 15, 15, 0);
                button.Height = 30;
                button.Content = furniture.name;
                button.FontWeight = FontWeights.Bold;
                button.Click += new RoutedEventHandler((x, args) =>
                {
                    furnitureDescriptionTitleBox.Text = furniture.name;
                    furnitureDescriptionBox.Text = furniture.description;
                    Image image = new Image();
                    try
                    {
                        image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), furniture.imagePath)));
                    }
                    catch(Exception ex) 
                    {
                        String dir = "assets\\Random Placeholders\\Furniture\\";
                        int fCount = Directory.GetFiles(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Random Placeholders\\Furniture"), "*", SearchOption.AllDirectories).Length;
                        var rand = new Random();
                        dir += rand.Next(fCount) + 1;
                        dir += ".png";
                        image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), dir)));
                    }
                    furnitureImageGrid.Children.Clear();
                    furnitureImageGrid.Children.Add(image);
                });
                button.Background = new SolidColorBrush(Color.FromArgb(170, 255, 255, 255));
                upgradesStackPanel.Children.Add(button);
            }
            Button button2 = new Button();
            button2.Margin = new Thickness(15, 15, 15, 0);
            button2.Height = 40;
            button2.Content = "DODAJ NOWE...";
            button2.FontWeight = FontWeights.Bold;
            button2.Click += new RoutedEventHandler((x, args) =>
            {
                AddFurnitureView furnitureView = new AddFurnitureView(this);
                furnitureView.ShowDialog();
            });
            upgradesStackPanel.Children.Add(button2);
            button2.Background = new SolidColorBrush(Color.FromArgb(170, 255, 255, 255));
            goldTextBox.Text = Session.guildMoney.ToString();
        }
    }
}
