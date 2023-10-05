using System.ComponentModel;
using System.Windows;

namespace EPI_Manager.Services
{
    public interface IViewService
    {
        void ShowView<TView, TViewModel>(object parameter = null)
            where TView : Window
            where TViewModel : INotifyPropertyChanged;
        void ShowMainView();
        void ShowSettingView();
    }
}
