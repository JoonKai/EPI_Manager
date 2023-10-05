using System.Windows;
using System.Windows.Controls;

namespace HellsysControls.Controls.BaseControls.Tank
{
    public partial class Tank2 : UserControl
    {
        public static readonly DependencyProperty GageValueProperty = DependencyProperty.Register("GageValue", typeof(int), typeof(Tank2), new PropertyMetadata(0));

        public int GageValue
        {
            get { return (int)GetValue(GageValueProperty); }
            set { SetValue(GageValueProperty, value); }
        }
        public Tank2()
        {
            InitializeComponent();
        }
    }
}
