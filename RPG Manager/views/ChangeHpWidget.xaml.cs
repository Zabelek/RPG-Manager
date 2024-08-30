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
    /// Logika interakcji dla klasy ChangeHpWidget.xaml
    /// </summary>
    public partial class ChangeHpWidget : Window
    {
        private Hero currentHero;
        private HeroesView heroesView;

        public ChangeHpWidget(Hero hero, HeroesView view)
        {
            InitializeComponent();
            currentHero = hero;
            heroesView = view;
        }

        private void HpModTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                String helpString = HpModTextBox.Text;
                if (helpString.Length > 0)
                {
                    try
                    {
                        if (helpString[0] == '+' || helpString[0] == '-')
                        {
                            currentHero.setCurrentHp(currentHero.currentHP + Int32.Parse(helpString));
                        }
                        else if (helpString[0] == 'M' || helpString[0] == 'm')
                        {
                            String t1 = helpString.Substring(1);
                            if (t1[0] == '+' || t1[0] == '-')
                            {
                                currentHero.maxHP += Int32.Parse(t1);
                            }
                        }
                        else if (helpString[0] == 'U' || helpString[0] == 'u')
                        {
                            String t1 = helpString.Substring(1);
                            currentHero.setCurrentHp(Int32.Parse(t1));
                        }
                        else if (String.Compare(helpString.ToLower(), "full") == 0)
                        {
                            currentHero.setCurrentHp(currentHero.maxHP);
                        }
                        heroesView.updateHpDisplay();
                    }
                    catch(Exception ex){}
                }
                this.Close();
            }
        }
        private void HpModButton_Click(object sender, RoutedEventArgs e)
        {
            String helpString = HpModTextBox.Text;
            if (helpString.Length > 0)
            {
                try
                {
                    if (helpString[0] == '+' || helpString[0] == '-')
                    {
                        currentHero.setCurrentHp(currentHero.currentHP + Int32.Parse(helpString));
                    }
                    else if (helpString[0] == 'M' || helpString[0] == 'm')
                    {
                        String t1 = helpString.Substring(1);
                        if (t1[0] == '+' || t1[0] == '-')
                        {
                            currentHero.maxHP += Int32.Parse(t1);
                        }
                    }
                    else if (helpString[0] == 'U' || helpString[0] == 'u')
                    {
                        String t1 = helpString.Substring(1);
                        currentHero.setCurrentHp(Int32.Parse(t1));
                    }
                    else if (String.Compare(helpString.ToLower(), "full") == 0)
                    {
                        currentHero.setCurrentHp(currentHero.maxHP);
                    }
                    heroesView.updateHpDisplay();
                }
                catch (Exception ex) { }
            }
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            HpModTextBox.Focus();
        }

    }
}
