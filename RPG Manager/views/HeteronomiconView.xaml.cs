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
    /// Logika interakcji dla klasy HeteronomiconView.xaml
    /// </summary>
    public partial class HeteronomiconView : Window
    {
        HeroesView view;
        public HeteronomiconView(HeroesView view, String heroName, List<String> content)
        {
            InitializeComponent();
            loadLovers(content);
            this.view = view;
            heroNameLabel.Content = heroName;
        }
        private void loadLovers(List<String> content)
        {
            mainGrid.Children.Clear();
            for (int i = 0; i < content.Count(); i++)
            {
                Label label = new Label();
                label.FontWeight = FontWeights.Bold;
                label.Width = 280;
                label.Height = 34;
                label.HorizontalAlignment = HorizontalAlignment.Left;
                label.VerticalAlignment = VerticalAlignment.Top;
                label.Margin = new Thickness(161, 110 + 20 * i, 0, 0);
                if (label.Margin.Top > 430)
                {
                    double pomy = label.Margin.Top - 400;
                    double pomx = 480;
                    label.Margin = new Thickness(pomx, pomy, 0, 0);
                }
                label.FontSize = 18;
                label.Content = content[i];
                mainGrid.Children.Add(label);
            }

            TextBox textBox = new TextBox();
            textBox.FontWeight = FontWeights.Bold;
            textBox.Width = 280;
            textBox.Height = 30;
            textBox.HorizontalAlignment = HorizontalAlignment.Left;
            textBox.VerticalAlignment = VerticalAlignment.Top;
            textBox.Margin = new Thickness(163, 120 + 20 * content.Count(), 0, 0);
            if (textBox.Margin.Top > 430)
            {
                double pomy = textBox.Margin.Top - 400;
                double pomx = 480;
                textBox.Margin = new Thickness(pomx, pomy, 0, 0);
            }
            textBox.FontSize = 18;
            textBox.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
            textBox.BorderBrush = new SolidColorBrush(Color.FromArgb(0, 255, 255, 255));
            textBox.KeyDown += new KeyEventHandler((x, args) =>
            {
                if (args.Key == Key.Return)
                {
                    if (textBox.Text != null && textBox.Text.Length > 0)
                    {
                        content.Add(textBox.Text);
                        textBox.Text = "";
                        loadLovers(content);
                    }
                }
            });
            mainGrid.Children.Add(textBox);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            view.enableView();
            this.Close();
        }
    }
}
