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
    /// Logika interakcji dla klasy AbilityView.xaml
    /// </summary>
    public partial class AbilityView : Window
    {
        public AbilityView(Ability ab)
        {
            InitializeComponent();
            this.abilityDescLabel.Text = ab.description;
            this.abilityTitleLabel.Content = ab.name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
