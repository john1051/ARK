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
    public partial class Herramientas : PhoneApplicationPage
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void btnguardarfrasereceta_Click(object sender, System.EventArgs e)
        {
        	/*Frases objFrase = new Frases();

            objFrase.Amistad = txtagregarfrase.Text;  
            
        	
            using (BaseDatosARkDataContext contexto = new BaseDatosARkDataContext(""))
            {
                contexto.Frases.InsertOnSubmit(objFrase);
                contexto.SubmitChanges();
            }*/
			int menu=0;
            NavigationService.Navigate(new Uri("/MainPage.xaml?Welcome=" + menu, UriKind.Relative));
            MessageBox.Show("Configuracion Guardada");
		}
		

			
    }
}