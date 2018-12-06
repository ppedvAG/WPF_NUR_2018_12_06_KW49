﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_PersonenDB.Model
{
    public enum Gender { Männlich, Weiblich, Divers }
    public enum Farben
    {
        Blau,
        Grün,
        Gelb,
        Rot
    }

    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        #region StatischeMember

        public static ObservableCollection<Person> PersonenListe { get; set; }

        static Person()
        {
            Person.PersonenListe = new ObservableCollection<Person>();
        }

        public static void LadePersonenAusDB()
        {
            Person.PersonenListe.Add(new Person() { Vorname = "Hugo", Nachname = "Meier", Geburtsdatum = new DateTime(1991, 3, 15), Verheiratet = false, Geschlecht = Gender.Männlich, Lieblingsfarbe = Farben.Grün });
            Person.PersonenListe.Add(new Person() { Vorname = "Anna", Nachname = "Schmidt", Geburtsdatum = new DateTime(1985, 12, 2), Verheiratet = true, Geschlecht = Gender.Weiblich, Lieblingsfarbe = Farben.Blau });
            Person.PersonenListe.Add(new Person() { Vorname = "Susi", Nachname = "Mülle", Geburtsdatum = new DateTime(1974, 4, 23), Verheiratet = false, Geschlecht = Gender.Divers, Lieblingsfarbe = Farben.Rot });
        }

        #endregion

        #region Properties
        private string vorname;
        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vorname")); }
        }

        private string nachname;
        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nachname")); }
        }

        private DateTime geburtsdatum;
        public DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Geburtsdatum")); }
        }

        private bool verheiratet;
        public bool Verheiratet
        {
            get { return verheiratet; }
            set { verheiratet = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Verheiratet")); }
        }

        private Farben lieblingsfarbe;
        public Farben Lieblingsfarbe
        {
            get { return lieblingsfarbe; }
            set { lieblingsfarbe = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lieblingsfarbe")); }
        }

        private Gender geschlecht;
        public Gender Geschlecht
        {
            get { return geschlecht; }
            set { geschlecht = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Geschlecht")); }
        }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Vorname):
                        if (Vorname.Length <= 0 || Vorname.Length > 50) return "Bitte geben Sie den Vornamen ein";
                        if (!Vorname.All(char.IsLetter)) return "Der Vorname darf nur Buchstaben enthalten";
                        break;
                    case nameof(Nachname):
                        if (Nachname.Length <= 0 || Nachname.Length > 50) return "Bitte geben Sie den Nachnamen ein";
                        if (!Nachname.All(char.IsLetter)) return "Der Nachname darf nur Buchstaben enthalten";
                        break;
                    case nameof(Geburtsdatum):
                        if (Geburtsdatum > DateTime.Now) return "Das Geburtsdatum darf nicht in der Zukunft liegen";
                        if (DateTime.Now.Year - Geburtsdatum.Year > 150) return "Das Geburtsdatum darf nicht mehr als 150 Jahre in der Vergangenheit liegen";
                        break;
                    default:
                        break;
                }
                return "";
            }
        }
        #endregion

        public Person()
        {
            this.Geburtsdatum = DateTime.Now;
            this.Vorname = "";
            this.Nachname = "";
        }

        public Person(Person altePerson)
        {
            this.Vorname = altePerson.Vorname;
            this.Nachname = altePerson.Nachname;
            this.Geburtsdatum = new DateTime(altePerson.Geburtsdatum.Year, altePerson.Geburtsdatum.Month, altePerson.Geburtsdatum.Day);
            this.Verheiratet = altePerson.Verheiratet;
            this.Lieblingsfarbe = altePerson.Lieblingsfarbe;
            this.Geschlecht = altePerson.Geschlecht;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
