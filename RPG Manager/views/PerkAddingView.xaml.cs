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
    /// Logika interakcji dla klasy PerkAddingView.xaml
    /// </summary>
    public partial class PerkAddingView : Window
    {
        private Hero hero;
        private HeroesView view;
        public PerkAddingView(HeroesView view, Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
            this.view = view;
            professionsStatsComboBox.ItemsSource = new String[] { "Siła", "Zręczność", "Wytrzymałość", "Perswazja", "Inteligencja", "Magia", "Percepcja"};
            professionsStatsComboBox.SelectedItem = "Percepcja";
            foreach (Profession prof in Session.registeredProfessions)
            {
                Button button = new Button();
                button.Height = 30;
                button.Margin = new Thickness(10, 0, 10, 5);
                button.Content = prof.name;
                button.Click += new RoutedEventHandler((x, args) =>
                {
                    professionsNameTextBox.Text = prof.name;
                    professionsStatsComboBox.SelectedItem = prof.statsType;
                });
                professionsGrid.Children.Add(button);
            }
            foreach(Ability abi in Session.registeredAbilities)
            {
                Button button = new Button();
                button.Height = 30;
                button.Margin = new Thickness(10, 0, 10, 5);
                button.Content = abi.name;
                button.Click += new RoutedEventHandler((x, args) =>
                {
                    abilitiesNameTextBox.Text = abi.name;
                    abilitiesDescriptionBox.Text = abi.description;
                });
                abilitiesGrid.Children.Add(button);
            }

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            view.enableView();
            this.Close();
        }
        private void addAbilitiesButton_Click(object sender, RoutedEventArgs e)
        {
            if(abilitiesNameTextBox.Text!=null && abilitiesNameTextBox.Text.Length>0)
            {
                Ability abi = Session.registeredAbilities.Find(x => String.Compare(x.name, abilitiesNameTextBox.Text) == 0);
                if (abi == null)
                {
                    abi = new Ability(abilitiesNameTextBox.Text, abilitiesDescriptionBox.Text);
                    Session.registeredAbilities.Add(abi);
                    hero.abilities.Add(abi);
                    view.updateViewWithNewHero();
                    view.enableView();
                    this.Close();
                }
                else if (hero.abilities.Find(x => String.Compare(abi.name, x.name) == 0) == null)
                {
                    hero.abilities.Add(abi);
                    view.updateViewWithNewHero();
                    view.enableView();
                    this.Close();
                }
            }
        }
        private void removeAbilitiesButton_Click(object sender, RoutedEventArgs e)
        {
            Ability abi = hero.abilities.Find(x => String.Compare(x.name, abilitiesNameTextBox.Text) == 0);
            if (abi != null)
            {
                hero.abilities.Remove(abi);
                view.updateViewWithNewHero();
                view.enableView();
                this.Close();
            }
        }
        private void addProfessionsButton_Click(object sender, RoutedEventArgs e)
        {
            if (professionsNameTextBox.Text != null && professionsNameTextBox.Text.Length > 0)
            {
                Profession prof = Session.registeredProfessions.Find(x => String.Compare(x.name, professionsNameTextBox.Text) == 0);
                if (prof == null)
                {
                    prof = new Profession(professionsNameTextBox.Text, professionsStatsComboBox.Text);
                    Session.registeredProfessions.Add(prof);
                    hero.professions.Add(new LearnedProfession(prof, 1));
                    view.updateViewWithNewHero();
                    view.enableView();
                    this.Close();
                }
                else if (hero.professions.Find(x => String.Compare(prof.name, x.profession.name) == 0) == null)
                {
                    hero.professions.Add(new LearnedProfession(prof, 1));
                    view.updateViewWithNewHero();
                    view.enableView();
                    this.Close();
                }
            }
        }
        private void removeProfessionsButton_Click(object sender, RoutedEventArgs e)
        {
            LearnedProfession prof = hero.professions.Find(x => String.Compare(x.profession.name, professionsNameTextBox.Text) == 0);
            if (prof != null)
            {
                hero.professions.Remove(prof);
                view.updateViewWithNewHero();
                view.enableView();
                this.Close();
            }
        }
        private void professionsFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                professionsGrid.Children.Clear();
                foreach (Profession prof in Session.registeredProfessions)
                {
                    if (prof.name.ToLower().Contains(professionsFilter.Text.ToLower()))
                    {
                        Button button = new Button();
                        button.Height = 30;
                        button.Margin = new Thickness(10, 0, 10, 5);
                        button.Content = prof.name;
                        button.Click += new RoutedEventHandler((sendItem, args) =>
                        {
                            professionsNameTextBox.Text = prof.name;
                            professionsStatsComboBox.SelectedItem = prof.statsType;
                        });
                        professionsGrid.Children.Add(button);
                    }
                }
            }
        }
        private void abilityFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                abilitiesGrid.Children.Clear();
                foreach (Ability abi in Session.registeredAbilities)
                {
                    if (abi.name.ToLower().Contains(abilitiesFilter.Text.ToLower()))
                    {
                        Button button = new Button();
                        button.Height = 30;
                        button.Margin = new Thickness(10, 0, 10, 5);
                        button.Content = abi.name;
                        button.Click += new RoutedEventHandler((sendItem, args) =>
                        {
                            abilitiesNameTextBox.Text = abi.name;
                            abilitiesDescriptionBox.Text = abi.description;
                        });
                        abilitiesGrid.Children.Add(button);
                    }
                }
            }
        }
    }
}
