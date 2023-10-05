using System.Windows;
using System.Windows.Controls;

namespace HellsysControls.Controls.BaseControls.Tank
{
    public partial class Tank1 : UserControl
    {
        public int GageValue
        {
            get { return (int)GetValue(GageValueProperty); }
            set { SetValue(GageValueProperty, value); }
        }
        public static readonly DependencyProperty GageValueProperty = DependencyProperty.Register("GageValue", typeof(int), typeof(Tank1), new PropertyMetadata(0));

        public Tank1()
        {
            InitializeComponent();
        }
    }
}
