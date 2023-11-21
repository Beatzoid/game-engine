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

namespace PrimalEditor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == openProjectButton)
            {
                // Open project button was clicked

                // Create button project was previously clicked
                if (createProjectButton.IsChecked == true)
                {
                    // Deselect create project button
                    createProjectButton.IsChecked = false;
                    // Show open project content
                    browserContent.Margin = new Thickness(0);
                }

                // Select open project button
                openProjectButton.IsChecked = true;
            }
            else
            {
                // Create project button was clicked

                // Open button project was previously clicked
                if (openProjectButton.IsChecked == true)
                {
                    // Deselect open project button
                    openProjectButton.IsChecked = false;
                    // Show create project content
                    browserContent.Margin = new Thickness(-800, 0, 0, 0);
                }

                // Select open project button
                createProjectButton.IsChecked = true;
            }
        }
    }
}
