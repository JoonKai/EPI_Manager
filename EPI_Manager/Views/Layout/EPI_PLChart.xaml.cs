using EPI_Manager.ViewModels;
using System.Windows.Controls;

namespace EPI_Manager.Views.Layout
{
    /// <summary>
    /// EPI_PLChart.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPI_PLChart : UserControl
    {
        public EPI_PLChart()
        {
            InitializeComponent();
            this.DataContext = new PLChartViewModel();
        }
    }
}
