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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.PersonenListe = new ObservableCollection<Person>();

            this.PersonenListe.Add(new Person() { Vorname = "Jürgen", Name = "Maier", Alter = 25 });
            this.PersonenListe.Add(new Person() { Vorname = "Bettina", Name = "Fischer", Alter = 67 });
            this.PersonenListe.Add(new Person() { Vorname = "Hannes", Name = "Schmidt", Alter = 35 });

            this.BspPerson = new Person() { Vorname = "Hannes", Name = "Schmidt", Alter = 35 };
            //Setzen des DataContext  auf das Windows (d.h. der DataContext der Xaml-Elemente sind die Properties der Window-Klasse im CodeBehind)
            this.splBspListBox.DataContext = this;

        }

        public ObservableCollection<Person> PersonenListe { get; set; }
        public Person BspPerson { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hallo");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(lbxAnzeige.SelectedItem is Person)
            {
                (lbxAnzeige.SelectedItem as Person).Alter++;
            }
            else
                (splMain.DataContext as Person).Alter++;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PersonenListe.Add(new Person() { Vorname = "Susi", Name = "Müller", Alter = 78 });
        }
    }
}
