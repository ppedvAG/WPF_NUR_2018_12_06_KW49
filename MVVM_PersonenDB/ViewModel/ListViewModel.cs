using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_PersonenDB.ViewModel
{
    public class ListViewModel
    {
        public UserCommand NeuCmd { get; set; }
        public UserCommand ÄndernCmd { get; set; }
        public UserCommand LöschenCmd { get; set; }
        public UserCommand SchließenCmd { get; set; }

        public ObservableCollection<Model.Person> PersonenListe { get { return Model.Person.PersonenListe; } }

        public ListViewModel()
        {
            this.SchließenCmd = new UserCommand
                (
                    p => true,
                    p => Application.Current.Shutdown()
                );
            this.LöschenCmd = new UserCommand
                (
                    p => p is Model.Person,
                    p => Model.Person.PersonenListe.Remove(p as Model.Person)
                );
            this.ÄndernCmd = new UserCommand
                (
                    p => p is Model.Person,
                    p =>
                    {
                        View.DetailView neuePersonDialog = new View.DetailView();
                        neuePersonDialog.DataContext = new DetailViewModel();
                        (neuePersonDialog.DataContext as DetailViewModel).AktuellePerson = new Model.Person(p as Model.Person);

                        //Aufruf des Dialogfensters und Überprüfung des DialogResults (Hat der Benutzer auf OK geklickt?)
                        if (neuePersonDialog.ShowDialog() == true)
                            Model.Person.PersonenListe[Model.Person.PersonenListe.IndexOf(p as Model.Person)] = (neuePersonDialog.DataContext as DetailViewModel).AktuellePerson;

                    }
                );
            this.NeuCmd = new UserCommand
                (
                    p => true,
                    p =>
                    {
                        View.DetailView neuePersonDialog = new View.DetailView();
                        neuePersonDialog.DataContext = new DetailViewModel();

                        if (neuePersonDialog.ShowDialog() == true)
                            Model.Person.PersonenListe.Add((neuePersonDialog.DataContext as DetailViewModel).AktuellePerson);
                    }
                );
        }
    }
}
