using LiveCharts.Defaults;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI_Manager.ViewModels
{

    public class PLChartViewModel : ViewModelBase
    {

        public ChartValues<ObservablePoint> ValuesA { get; set; }
        public ChartValues<ObservablePoint> ValuesB { get; set; }
        public ChartValues<ObservablePoint> ValuesC { get; set; }

        public PLChartViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            var r = new Random();
            ValuesA = new ChartValues<ObservablePoint>();
            ValuesB = new ChartValues<ObservablePoint>();
            ValuesC = new ChartValues<ObservablePoint>();

            for (var i = 0; i < 20; i++)
            {
                ValuesA.Add(new ObservablePoint(r.NextDouble() * 300, r.NextDouble() * 300));
                ValuesB.Add(new ObservablePoint(r.NextDouble() * 300, r.NextDouble() * 300));
                ValuesC.Add(new ObservablePoint(r.NextDouble() * 300, r.NextDouble() * 300));
            }
        }
    }
}
