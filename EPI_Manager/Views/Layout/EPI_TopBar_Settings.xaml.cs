using System.Windows;
using System.Windows.Controls;
using HellsysLibrary.Extensions;

namespace EPI_Manager.Views.Layout
{
    /// <summary>
    /// EPI_TopBar_Settings.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPI_TopBar_Settings : UserControl
    {
        public EPI_TopBar_Settings()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
        }
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
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();
        }
    }
}
