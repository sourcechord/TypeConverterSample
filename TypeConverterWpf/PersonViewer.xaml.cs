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

namespace TypeConverterWpf
{
    /// <summary>
    /// PersonViewer.xaml の相互作用ロジック
    /// </summary>
    public partial class PersonViewer : UserControl
    {
        public PersonViewer()
        {
            InitializeComponent();
            root.DataContext = this;
        }

        public Person Person
        {
            get { return (Person)GetValue(PersonProperty); }
            set { SetValue(PersonProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Person.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonProperty =
            DependencyProperty.Register("Person", typeof(Person), typeof(PersonViewer), new PropertyMetadata(null));

    }
}
