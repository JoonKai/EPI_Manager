using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HellsysControls.Controls.BaseControls.CustomControls
{
    public partial class EPI_HeaderTextbox : UserControl
    {
        #region 디펜던시프로퍼티
        public static readonly DependencyProperty THeaderTextProperty = DependencyProperty.Register("THeaderText", typeof(string), typeof(EPI_HeaderTextbox), new PropertyMetadata(null));
        public static readonly DependencyProperty THeaderWidthProperty = DependencyProperty.Register("THeaderWidth", typeof(int), typeof(EPI_HeaderTextbox), new PropertyMetadata(50));
        public static readonly DependencyProperty THeaderColorProperty = DependencyProperty.Register("THeaderColor", typeof(Brush), typeof(EPI_HeaderTextbox), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TBTextProperty = DependencyProperty.Register("TBText", typeof(string), typeof(EPI_HeaderTextbox), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty WaterTextProperty = DependencyProperty.Register("WaterText", typeof(string), typeof(EPI_HeaderTextbox), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty TBColorProperty = DependencyProperty.Register("TBColor", typeof(Brush), typeof(EPI_HeaderTextbox), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TSemiColonColorProperty = DependencyProperty.Register("TSemiColonColor", typeof(Brush), typeof(EPI_HeaderTextbox), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TBReadOnlyProperty = DependencyProperty.Register("TBReadOnly", typeof(bool), typeof(EPI_HeaderTextbox), new PropertyMetadata(false));
        public static new readonly DependencyProperty HorizontalContentAlignmentProperty = DependencyProperty.Register("HorizontalContentAlignment", typeof(HorizontalAlignment), typeof(EPI_HeaderTextbox), new UIPropertyMetadata(HorizontalAlignment.Left));
        public static readonly DependencyProperty TBTextWrappingProperty = DependencyProperty.Register("TBTextWrapping", typeof(TextWrapping), typeof(EPI_HeaderTextbox), new UIPropertyMetadata(TextWrapping.NoWrap));
        public static readonly DependencyProperty TBAcceptsReturnProperty = DependencyProperty.Register("TBAcceptsReturn", typeof(bool), typeof(EPI_HeaderTextbox), new UIPropertyMetadata(false));
        public static readonly DependencyProperty TBHeightProperty = DependencyProperty.Register("TBHeight", typeof(int), typeof(EPI_HeaderTextbox), new PropertyMetadata(20));
        public static readonly DependencyProperty TBWidthProperty = DependencyProperty.Register("TBWidth", typeof(int), typeof(EPI_HeaderTextbox), new PropertyMetadata(50));


        public string WaterText
        {
            get { return (string)GetValue(WaterTextProperty); }
            set { SetValue(WaterTextProperty, value); }
        }
        public int TBHeight
        {
            get { return (int)GetValue(TBHeightProperty); }
            set { SetValue(TBHeightProperty, value); }
        }
        public int TBWidth
        {
            get { return (int)GetValue(TBWidthProperty); }
            set { SetValue(TBWidthProperty, value); }
        }
        public bool TBAcceptsReturn
        {
            get { return (bool)GetValue(TBAcceptsReturnProperty); }
            set { SetValue(TBAcceptsReturnProperty, value); }
        }

        public TextWrapping TBTextWrapping
        {
            get { return (TextWrapping)GetValue(TBTextWrappingProperty); }
            set { SetValue(TBTextWrappingProperty, value); }
        }

        public new HorizontalAlignment HorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalContentAlignmentProperty); }
            set { SetValue(HorizontalContentAlignmentProperty, value); }
        }
        public bool TBReadOnly
        {
            get { return (bool)GetValue(TBReadOnlyProperty); }
            set { SetValue(TBReadOnlyProperty, value); }
        }
        public Brush TSemiColonColor
        {
            get { return (Brush)GetValue(TSemiColonColorProperty); }
            set { SetValue(TSemiColonColorProperty, value); }
        }
        public Brush TBColor
        {
            get { return (Brush)GetValue(TBColorProperty); }
            set { SetValue(TBColorProperty, value); }
        }
        public Brush THeaderColor
        {
            get { return (Brush)GetValue(THeaderColorProperty); }
            set { SetValue(THeaderColorProperty, value); }
        }
        public string THeaderText
        {
            get { return (string)GetValue(THeaderTextProperty); }
            set { SetValue(THeaderTextProperty, value); }
        }
        public int THeaderWidth
        {
            get { return (int)GetValue(THeaderWidthProperty); }
            set { SetValue(THeaderWidthProperty, value); }
        }
        public string TBText
        {
            get { return (string)GetValue(TBTextProperty); }
            set { SetValue(TBTextProperty, value); }
        }
        #endregion

        public EPI_HeaderTextbox()
        {
            InitializeComponent();
        }
    }
}
