using RPG_Manager.data_model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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
using System.Xml.Linq;

namespace RPG_Manager.views
{
    public partial class HeroesView : Window
    {
        public List<FrameworkElement> sharedComponents { get; set; }
        private MainWindow mainWindow;
        private bool needsToRelocate;
        private Hero displayedHero;
        public HeroesView(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            sharedComponents = new List<FrameworkElement>();
            sharedComponents.Add(heroImage);
            sharedComponents.Add(heroImageShadow);
            sharedComponents.Add(raceLabel);
            sharedComponents.Add(raceLabelContent);
            sharedComponents.Add(ageLabel);
            sharedComponents.Add(ageLabelContent);
            sharedComponents.Add(weightLabel);
            sharedComponents.Add(weightLabelContent);
            sharedComponents.Add(healthBarZero);
            sharedComponents.Add(healthBarFull);
            sharedComponents.Add(healthBarShadow);
            sharedComponents.Add(heroBorder);
            sharedComponents.Add(heroComboBox);
            sharedComponents.Add(healthLabel);
            sharedComponents.Add(strengthIcon);
            sharedComponents.Add(dextrityIcon);
            sharedComponents.Add(enduranceIcon);
            sharedComponents.Add(charismaIcon);
            sharedComponents.Add(intelligenceIcon);
            sharedComponents.Add(magicIcon);
            sharedComponents.Add(perceptionIcon);
            sharedComponents.Add(strengthLabel);
            sharedComponents.Add(dextrityLabel);
            sharedComponents.Add(endurancehLabel);
            sharedComponents.Add(charismaLabel);
            sharedComponents.Add(intelligenceLabel);
            sharedComponents.Add(magicLabel);
            sharedComponents.Add(perceptionLabel);
            sharedComponents.Add(statsdivider);
            sharedComponents.Add(professionsDivider); 
            sharedComponents.Add(professionScroll);
            sharedComponents.Add(abilitiesScroll);
            sharedComponents.Add(notesPanel);
            sharedComponents.Add(backpackButton);
            sharedComponents.Add(heteronomiconButton);
            sharedComponents.Add(perksButton);
            shadow.IsHitTestVisible = false;
            needsToRelocate = true;
            heroComboBox.ItemsSource = Session.registeredHeroes;
            heroComboBox.DisplayMemberPath = "name";
            assignRandomImage();
        }

        public Image getShadow()
        {
            var parent = VisualTreeHelper.GetParent(shadow);
            var parentAsPanel = parent as Panel;
            if (parentAsPanel != null)
            {
                parentAsPanel.Children.Remove(shadow);
            }
            return shadow;
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

        internal void setLocation(int v1, int v2)
        {
            if(needsToRelocate) {
                foreach(FrameworkElement elem in sharedComponents)
                {
                    elem.Margin = new Thickness(elem.Margin.Left + v1, elem.Margin.Top + v2, 0, 0);
                }
                needsToRelocate = false;
            }            
        }
        private void assignRandomImage()
        {
            String dir = "assets\\Random Placeholders\\Hero\\";
            int fCount = Directory.GetFiles(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\Random Placeholders\\Hero"), "*", SearchOption.AllDirectories).Length;
            var rand = new Random();
            dir += rand.Next(fCount)+1;
            dir += ".png";
            Uri uri = new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), dir));
            heroImage.Source = new BitmapImage(uri);
        }
        public void updateViewWithNewHero()
        {
            Uri uri = new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), displayedHero.imagePath));
            heroImage.Source = new BitmapImage(uri);
            raceLabelContent.Content = displayedHero.race;
            ageLabelContent.Content = displayedHero.age;
            weightLabelContent.Content = displayedHero.weight;
            healthLabel.Content = displayedHero.currentHP + "/" + displayedHero.maxHP;
            strengthLabel.Content = displayedHero.strength;
            dextrityLabel.Content = displayedHero.dextrity;
            endurancehLabel.Content = displayedHero.endurance;
            charismaLabel.Content = displayedHero.charisma;
            intelligenceLabel.Content = displayedHero.intelligence;
            magicLabel.Content = displayedHero.magic;
            perceptionLabel.Content = displayedHero.perception;
            //sharedComponents.Add(abilitiesScroll);
            notesPanel.Text = displayedHero.notes;
            professionsStackPanel.Children.Clear();
            foreach (LearnedProfession prof in displayedHero.professions)
            {
                Grid grid = new Grid();
                grid.Height = 30;
                Image image = new Image();
                image.Width = 25; image.Height = 25; image.HorizontalAlignment = HorizontalAlignment.Left; image.VerticalAlignment = VerticalAlignment.Top;
                image.Margin = new Thickness(0,3,0,0); image.OpacityMask = new SolidColorBrush(Color.FromArgb(204, 255, 255, 255));
                if (String.Compare(prof.profession.statsType ,"Siła")==0)
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\strength.png")));
                else if (String.Compare(prof.profession.statsType, "Zręczność") == 0)
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\dextrity.png")));
                else if (String.Compare(prof.profession.statsType, "Wytrzymałość") == 0)
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\health.png")));
                else if (String.Compare(prof.profession.statsType, "Perswazja") == 0)
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\charisma.png")));
                else if (String.Compare(prof.profession.statsType, "Inteligencja") == 0)
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\intelligence.png")));
                else if (String.Compare(prof.profession.statsType, "Magia") == 0)
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\magic.png")));
                else
                    image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets\\menu\\icons\\perception.png")));
                grid.Children.Add(image);
                Label label = new Label();
                label.Margin = new Thickness(35,0,0,0); label.Width = 421; label.HorizontalAlignment = HorizontalAlignment.Left;
                label.Foreground = new SolidColorBrush(Color.FromArgb(255, 216, 216, 216));
                label.Content = prof.profession.name+"........................................................................................";
                grid.Children.Add(label);
                TextBox textBox = new TextBox();
                textBox.Margin = new Thickness(0, 0, 5, 0); textBox.Height = 25; textBox.Width = 40; textBox.VerticalAlignment = VerticalAlignment.Top;
                textBox.HorizontalContentAlignment = HorizontalAlignment.Center; textBox.FontWeight = FontWeights.Bold;
                textBox.Text = prof.getLevel().ToString(); textBox.HorizontalAlignment = HorizontalAlignment.Right;
                textBox.Background = new SolidColorBrush(Color.FromArgb(204, 255, 255, 255));
                textBox.TextChanged += new TextChangedEventHandler((sendItem, args) =>
                {
                    if (String.Compare(textBox.Text, "0") == 0 || String.Compare(textBox.Text, "1") == 0 || String.Compare(textBox.Text, "2") == 0 || String.Compare(textBox.Text, "3") == 0
                        || String.Compare(textBox.Text, "4") == 0 || String.Compare(textBox.Text, "5") == 0 || String.Compare(textBox.Text, "6") == 0 || String.Compare(textBox.Text, "7") == 0
                        || String.Compare(textBox.Text, "8") == 0 || String.Compare(textBox.Text, "9") == 0 || String.Compare(textBox.Text, "10") == 0)
                        prof.setLevel (Int32.Parse(textBox.Text));
                });
                grid.Children.Add(textBox);
                professionsStackPanel.Children.Add(grid);
            }
            abilitiesStackPanel.Children.Clear();
            foreach (Ability ability in displayedHero.abilities)
            {
                Button button = new Button();
                button.Style = Application.Current.Resources["abilityButtonStyle"] as Style;
                button.HorizontalAlignment = HorizontalAlignment.Left;
                button.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                button.Content = ability.name;
                button.Click += (s, e) => 
                {
                    AbilityView view = new AbilityView(ability);
                    view.Left = heroBorder.Margin.Left+70;
                    view.Show();           
                };
                abilitiesStackPanel.Children.Add(button);
            }
            updateHpDisplay();
            //sharedComponents.Add(backpackButton);
            //sharedComponents.Add(heteronomiconButton);
        }
        private void heroComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Hero hero = (Hero)e.AddedItems[0];
            displayedHero = hero;
            updateViewWithNewHero();
        }

        internal void updateHpDisplay()
        {
            this.healthLabel.Content = displayedHero.currentHP + "/" + displayedHero.maxHP;
            this.healthBarFull.Width = (double)((double)displayedHero.currentHP/(double)displayedHero.maxHP)*486;
        }

        private void healthLabel_Click(object sender, RoutedEventArgs e)
        {
            if(displayedHero!=null)
            {
                ChangeHpWidget widget = new ChangeHpWidget(displayedHero, this);
                widget.Left = healthLabel.Margin.Left + 140;
                widget.Top = healthLabel.Margin.Top-10;
                widget.Show();
            }
        }

        private void heteronomiconButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayedHero != null)
            {
                HeteronomiconView hetview = new HeteronomiconView(this, displayedHero.name, displayedHero.heteronomicon);
                hetview.Show();
                mainWindow.disableView();
            }
        }

        private void backpackButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayedHero != null)
            {
                BackpackView backpackview = new BackpackView(this, displayedHero);
                backpackview.Show();
                mainWindow.disableView();
            }
        }

        private void perksButton_Click(object sender, RoutedEventArgs e)
        {
            if (displayedHero != null)
            {
                PerkAddingView perkAddingView = new PerkAddingView(this, displayedHero);
                perkAddingView.Show();
                mainWindow.disableView();
            }
        }
        public void disableView()
        {
            mainWindow.disableView();
        }
        public void enableView()
        {
            mainWindow.enableView();
        }

        private void notesPanel_LostFocus(object sender, RoutedEventArgs e)
        {
            if(displayedHero != null)
            {
                displayedHero.notes = notesPanel.Text;
            }
        }
    }
}
