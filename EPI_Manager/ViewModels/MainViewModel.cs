using EPI_Manager.Commands;
using EPI_Manager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EPI_Manager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IViewService _viewService;
        public MainViewModel(IViewService viewService)
        {
            _viewService = viewService;
        }
        public ICommand ShowSettingViewCommand => new RelayCommand<object>(ShowSettingView);

        private void ShowSettingView(object obj)
        {
            _viewService.ShowSettingView();
        }
    }
}
