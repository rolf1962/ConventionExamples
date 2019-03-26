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

namespace ConventionExamples
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Model.Model model = new Model.Model();

            List<Model.Person> filteredPersonsList = model.Personen
                .Where(p => p.Nachname != null && p.Nachname.StartsWith("x", StringComparison.InvariantCultureIgnoreCase))
                .Select(p => new Model.Person()
                {
                    Nachname = p.Nachname,
                    Geburtsdatum = p.Geburtsdatum,
                    Vornamen = p.Vornamen
                })
                .ToList();
        }
    }
}
