using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ARK
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
		
        private void btnopciones_Click(object sender, System.EventArgs e)
        {
        	int hola=0;
            NavigationService.Navigate(new Uri("/MenuArk.xaml?Welcome=" + hola, UriKind.Relative));
            
        }

        private void btneditar_Click(object sender, System.EventArgs e)
        {
        	int editar=0;
            NavigationService.Navigate(new Uri("/Herramientas.xaml?Welcome=" + editar, UriKind.Relative));
            
        }
    }
}