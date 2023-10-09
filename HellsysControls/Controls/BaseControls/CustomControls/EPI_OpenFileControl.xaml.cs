using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HellsysControls.Controls.BaseControls.CustomControls
{
    /// <summary>
    /// EPI_OpenFileControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPI_OpenFileControl : UserControl
    {
        #region 디펜던시프로퍼티
        public static readonly DependencyProperty TBWidthProperty = DependencyProperty.Register("TBWidth", typeof(int), typeof(EPI_OpenFileControl), new PropertyMetadata(100));
        public static readonly DependencyProperty THeaderTextProperty = DependencyProperty.Register("THeaderText", typeof(string), typeof(EPI_OpenFileControl), new PropertyMetadata(null));
        public static readonly DependencyProperty THeaderWidthProperty = DependencyProperty.Register("THeaderWidth", typeof(int), typeof(EPI_OpenFileControl), new PropertyMetadata(50));
        public static readonly DependencyProperty THeaderColorProperty = DependencyProperty.Register("THeaderColor", typeof(Brush), typeof(EPI_OpenFileControl), new PropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty ItemTextProperty = DependencyProperty.Register("ItemText", typeof(string), typeof(EPI_OpenFileControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty TBColorProperty = DependencyProperty.Register("TBColor", typeof(Brush), typeof(EPI_OpenFileControl), new UIPropertyMetadata(Brushes.Black));
        public static readonly DependencyProperty TSemiColonColorProperty = DependencyProperty.Register("TSemiColonColor", typeof(Brush), typeof(EPI_OpenFileControl), new UIPropertyMetadata(Brushes.Black));
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

        public int TBWidth
        {
            get { return (int)GetValue(TBWidthProperty); }
            set { SetValue(TBWidthProperty, value); }
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
        public string ItemText
        {
            get { return (string)GetValue(ItemTextProperty); }
            set { SetValue(ItemTextProperty, value); }
        }
        #endregion
        public EPI_OpenFileControl()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                tbPath.Text = openFileDialog.FileName;
            }
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
