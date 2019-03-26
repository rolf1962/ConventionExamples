using System;

namespace ConventionExamples.Model
{
    /// <summary>
    /// Die Klasse Person repräsentiert die Eigenschaften, mit denen eine natürliche 
    /// Person beschrieben, gesucht und wiedererkannt werden kann.
    /// </summary>
    public class Person : ModelBase
    {
        public readonly string Hinweis =
            $"Erzeugen Sie eine neue {nameof(Person)} mit new {nameof(Person)}() und weisen Sie den Eigenschaften" +
            $"{nameof(Nachname)}, {nameof(Vornamen)} und {nameof(Geburtsdatum)} gültige Werte zu";

        private string _nachname;
        private string _vornamen;
        private DateTime? _geburtsdatum;

        /// <summary>
        /// Gibt den Nachnamen einer <see cref="Person"/> zurück oder legt ihn fest.
        /// </summary>
        public string Nachname
        {
            get
            {
                return _nachname;
            }
            set
            {
                if (_nachname != value)
                {
                    _nachname = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gibt die Vornamen einer <see cref="Person"/> zurück oder legt sie fest.
        /// </summary>
        public string Vornamen
        {
            get
            {
                return _vornamen;
            }
            set
            {
                if (_vornamen != value)
                {
                    _vornamen = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gibt das Geburtsdatum einer <see cref="Person"/> zurück oder legt es fest.
        /// </summary>
        public DateTime? Geburtsdatum
        {
            get
            {
                return _geburtsdatum;
            }
            set
            {
                if (_geburtsdatum != value)
                {
                    _geburtsdatum = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// <paramref name="testString"/>
        /// </summary>
        /// <param name="testString"></param>
        public void Test(string testString)
        {

            if (string.IsNullOrWhiteSpace(testString)) { throw new ArgumentNullException(nameof(testString)); }

            Console.WriteLine(testString);
        }
    }
}
