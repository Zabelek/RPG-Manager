using RPG_Manager.views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPG_Manager
{
    public partial class MainWindow : Window
    {
        private HeroesView heroesView1, heroesView2, heroesView3;
        private GuildView guildView;
        private CreationView creationView;
        private List<UIElement> forgeinElements;
        public MainWindow()
        {
            InitializeComponent();
            Session.initiate();
            heroesView1 = new HeroesView(this);
            heroesView2 = new HeroesView(this);
            heroesView3 = new HeroesView(this);
            guildView = new GuildView(this);
            creationView = new CreationView(this);
            forgeinElements = new List<UIElement>();
            mainGrid.Children.Remove(dialogShadow);
            assignRandomBackground();
        }

        private void assignRandomBackground()
        {
            String dir = "assets\\Background\\Adventure\\";
            int fCount = Directory.GetFiles(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Background\\Adventure"), "*", SearchOption.AllDirectories).Length;
            var rand = new Random();
            dir += rand.Next(fCount) + 1;
            dir += ".png";
            Uri uri = new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), dir));
            backgroundImage.Source = new BitmapImage(uri);
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void heroesViewButton_Click(object sender, RoutedEventArgs e)
        {
            changeToHeroesView();
        }
        private void guildViewButton_Click(object sender, RoutedEventArgs e)
        {
            changeToGuildView();
        }

        private void changeToGuildView()
        {
            clearFromForgeinElements();
            if(heroesView1.getShadow()!=null)
            {
                mainGrid.Children.Remove(heroesView1.getShadow());
            }
            guildView.clearParentFormComponents();
            foreach (UIElement element in guildView.sharedComponents)
            {
                this.forgeinElements.Add(element);
                mainGrid.Children.Add(element);
            }
            moveMenuControlsToTheTop();
        }

        private void changeToHeroesView()
        {
            clearFromForgeinElements();
            mainGrid.Children.Add(heroesView1.getShadow());
            heroesView1.clearParentFormComponents();
            heroesView1.setLocation(80, 0);
            foreach (UIElement element in heroesView1.sharedComponents)
            {
                this.forgeinElements.Add(element);
                mainGrid.Children.Add(element);
            }
            heroesView2.clearParentFormComponents();
            heroesView2.setLocation(680, 0);
            foreach (UIElement element in heroesView2.sharedComponents)
            {
                this.forgeinElements.Add(element);
                mainGrid.Children.Add(element);
            }
            heroesView3.clearParentFormComponents();
            heroesView3.setLocation(1280, 0);
            foreach (UIElement element in heroesView3.sharedComponents)
            {
                this.forgeinElements.Add(element);
                mainGrid.Children.Add(element);
            }
            moveMenuControlsToTheTop();
        }
        private void clearFromForgeinElements()
        {
            foreach (UIElement element in forgeinElements)
            {
                var parent = VisualTreeHelper.GetParent(element);
                var parentAsPanel = parent as Panel;
                if (parentAsPanel != null)
                {
                    parentAsPanel.Children.Remove(element);
                }
            }
            forgeinElements.Clear();
        }
        private void moveMenuControlsToTheTop()
        {
            mainGrid.Children.Remove(mainButtonsShadow);
            mainGrid.Children.Remove(creatorsViewButton);
            mainGrid.Children.Remove(saveButton);
            mainGrid.Children.Remove(heroesViewButton);
            mainGrid.Children.Remove(guildViewButton);
            mainGrid.Children.Remove(exitButton);
            mainGrid.Children.Add(mainButtonsShadow);
            mainGrid.Children.Add(heroesViewButton);
            mainGrid.Children.Add(guildViewButton);
            mainGrid.Children.Add(creatorsViewButton);
            mainGrid.Children.Add(saveButton);
            mainGrid.Children.Add(exitButton);
        }

        private void creatorsViewButton_Click(object sender, RoutedEventArgs e)
        {
            changeToCreationView();

        }

        private void changeToCreationView()
        {
            clearFromForgeinElements();
            if (heroesView1.getShadow() != null)
            {
                mainGrid.Children.Remove(heroesView1.getShadow());
            }
            creationView.clearParentFormComponents();
            foreach (UIElement element in creationView.sharedComponents)
            {
                this.forgeinElements.Add(element);
                mainGrid.Children.Add(element);
            }
            moveMenuControlsToTheTop();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.saveProfessions();
            FileHandler.saveAbilities();
            FileHandler.saveItems();
            FileHandler.saveHeroes();
            FileHandler.saveGuild();
        }

        public void disableView()
        {
            mainGrid.Children.Add(dialogShadow);
        }
        public void enableView()
        {
            mainGrid.Children.Remove(dialogShadow);
        }
    }
}
