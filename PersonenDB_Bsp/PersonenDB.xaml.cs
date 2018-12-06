using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PersonenDB_Bsp
{
    /// <summary>
    /// Interaction logic for PersonenDB.xaml
    /// </summary>
    public partial class PersonenDB : Window
    {
        public PersonenDB()
        {
            InitializeComponent();

            this.DataContext = this;
            dgdPersonen.ItemsSource = this.PersonenListe;

            this.PersonenListe.Add(new Person() { Vorname = "Hanna", Nachname = "Maier", Geburtsdatum = new DateTime(1992, 3, 12), Geschlecht = Gender.Weiblich, Lieblingsfarbe = Farben.Rot, Verheiratet = true });
        }

        public ObservableCollection<Person> PersonenListe { get; set; } = new ObservableCollection<Person>();

        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            NeuePerson_Dialog personenDialog = new NeuePerson_Dialog();
            personenDialog.DataContext = new Person();
            if (personenDialog.ShowDialog() == true)
                PersonenListe.Add(personenDialog.DataContext as Person);
        }

        private void btnÄndern_Click(object sender, RoutedEventArgs e)
        {
            if (dgdPersonen.SelectedValue is Person)
            {
                NeuePerson_Dialog personenDialog = new NeuePerson_Dialog();
                personenDialog.DataContext = new Person(dgdPersonen.SelectedValue as Person);
                if (personenDialog.ShowDialog() == true)
                    PersonenListe[PersonenListe.IndexOf(dgdPersonen.SelectedValue as Person)] = personenDialog.DataContext as Person;
            }
        }

        private void btnLöschen_Click(object sender, RoutedEventArgs e)
        {
            if (dgdPersonen.SelectedValue is Person)
            {
                if (MessageBox.Show("Soll diese Person wirklich gelöscht werden?", "Person löschen", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    PersonenListe.Remove(dgdPersonen.SelectedValue as Person);
            }
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
