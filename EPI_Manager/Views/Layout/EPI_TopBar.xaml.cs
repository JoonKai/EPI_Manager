using System.Windows;
using System.Windows.Controls;
using HellsysLibrary.Extensions;

namespace EPI_Manager.Views.Layout
{
    /// <summary>
    /// EPI_TopBar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPI_TopBar : UserControl
    {
        private Window _parentWindow;


        public Window ParentWindow
        {
            get
            {
                if (_parentWindow == null)
                {
                    _parentWindow = this.FindParent<Window>();
                }
                return _parentWindow;
            }
            set { _parentWindow = value; }
        }
        public EPI_TopBar()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            btnMinimize.Click += BtnMinimize_Click;
            btnMaximize.Click += BtnMaximize_Click;
        }
        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {

            ParentWindow.WindowState = ParentWindow.WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {

            ParentWindow.WindowState = WindowState.Minimized;
            ParentWindow.ResizeMode = ResizeMode.CanResizeWithGrip;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();

        }
    }
}
