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
    /// Logika interakcji dla klasy CreationView.xaml
    /// </summary>
    public partial class CreationView : Window
    {
        public List<FrameworkElement> sharedComponents { get; set; }
        private MainWindow mainWindow;
        public CreationView(MainWindow mainWindow)
        {
            InitializeComponent();
            sharedComponents = new List<FrameworkElement>();
            sharedComponents.Add(background);
            sharedComponents.Add(titleBackground);
            sharedComponents.Add(titleLabel);
            sharedComponents.Add(buttonsStackPanel);
            this.mainWindow = mainWindow;
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
    }
}
