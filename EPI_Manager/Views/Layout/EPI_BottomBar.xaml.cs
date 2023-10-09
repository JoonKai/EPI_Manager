using System;
using System.Windows;
using System.Windows.Controls;

namespace EPI_Manager.Views.Layout
{

    public partial class EPI_BottomBar : UserControl
    {
        #region 디펜던시프로퍼티
        public static readonly DependencyProperty DigitalTimeProperty = DependencyProperty.Register("DigitalTime", typeof(DateTime), typeof(EPI_BottomBar), new FrameworkPropertyMetadata(DateTime.Now));
        public DateTime DigitalTime
        {
            get { return (DateTime)GetValue(DigitalTimeProperty); }
            set { SetValue(DigitalTimeProperty, value); }
        }
        #endregion
        public EPI_BottomBar()
        {
            InitializeComponent();
        }
    }
}
