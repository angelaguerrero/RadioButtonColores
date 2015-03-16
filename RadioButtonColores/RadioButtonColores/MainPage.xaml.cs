using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RadioButtonColores.Resources;
using System.Windows.Media;

namespace RadioButtonColores
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void radioCkeck(object sender, RoutedEventArgs e)
        {
            if (amarillo.IsChecked.Value)
            {
                rectangulo.Fill = new SolidColorBrush(Color.FromArgb(255,255,255,0));
            }
            if (azul.IsChecked.Value)
            {
                rectangulo.Fill = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
            }
            if (rojo.IsChecked.Value)
            {
                rectangulo.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
            if (!amarillo.IsChecked.Value && !azul.IsChecked.Value && !rojo.IsChecked.Value)
            {
                rectangulo.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            }
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}