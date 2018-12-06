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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonenDB_Bsp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NeuePerson_Dialog : Window
    {
        public NeuePerson_Dialog()
        {
            InitializeComponent();

            this.aktuellePerson = new Person();
            this.DataContext = aktuellePerson;
        }

        public Person aktuellePerson { get; set; }

        #region ButtonEventHandler
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            String ausgabe = aktuellePerson.Vorname + " " + aktuellePerson.Nachname + " (" + aktuellePerson.Geschlecht + ")\nGeboren am " + aktuellePerson.Geburtsdatum.ToLongDateString() + "\n";
            if (aktuellePerson.Verheiratet) ausgabe += "Verheiratet";
            else ausgabe += "Nicht Verheiratet";
            ausgabe += "\nLieblingsfarbe: " + aktuellePerson.Lieblingsfarbe;
            ausgabe += "\n\nEingaben übernehmen?";

            if (MessageBox.Show(ausgabe, aktuellePerson.Vorname + " " + aktuellePerson.Nachname, MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
