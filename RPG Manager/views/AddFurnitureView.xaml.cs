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
    /// Logika interakcji dla klasy AddFurnitureView.xaml
    /// </summary>
    public partial class AddFurnitureView : Window
    {
        GuildView guildView;
        public AddFurnitureView(GuildView guildView)
        {
            InitializeComponent();
            this.guildView = guildView;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if(nameTextBox.Text.Length>0 && descTextBox.Text.Length>0)
            {
                if(imageTextBox.Text.Length>0)
                {
                    String dir = "assets\\guild\\furniture\\\\" + imageTextBox.Text;
                    Session.guildFurnitures.Add(new data_model.GuildFurniture(nameTextBox.Text, descTextBox.Text, dir));
                }
                else
                {
                    Session.guildFurnitures.Add(new data_model.GuildFurniture(nameTextBox.Text, descTextBox.Text, "Brak"));
                }

                guildView.reloadGui();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
