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

namespace UnitConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Unit> units = new List<Unit>();
        public MainWindow()
        {
            InitializeComponent();
            units.AddRange(Methods.AddUnits());

            SourceUnitList.ItemsSource = units;
            OutputUnitList.ItemsSource= units;
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            var From = units[SourceUnitList.SelectedIndex];
            From.Ammount = double.Parse(Input.Text);
            var To = units[OutputUnitList.SelectedIndex];
            Methods.Calculate(From,To);
            Output.Text=""+To.Ammount;
        }
    }



    
}
