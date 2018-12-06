using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_PersonenDB.ViewModel
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public int AnzahlPerson { get { return Model.Person.PersonenListe.Count; } }

        public UserCommand LadeDBCmd { get; set; }
        public UserCommand ÖffneDBCmd { get; set; }

        public StartViewModel()
        {
            this.LadeDBCmd = new UserCommand
                (
                    parameter => this.AnzahlPerson == 0,
                    parameter =>
                    {
                        Model.Person.LadePersonenAusDB();
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AnzahlPerson"));
                    }
                );
            this.ÖffneDBCmd = new UserCommand
                (
                    parameter => this.AnzahlPerson > 0,
                    parameter =>
                    {
                        View.ListView datenbankFenster = new View.ListView();
                        datenbankFenster.DataContext = new ListViewModel();

                        datenbankFenster.Show();
                        (parameter as View.StartView).Close();
                    }
                );
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
