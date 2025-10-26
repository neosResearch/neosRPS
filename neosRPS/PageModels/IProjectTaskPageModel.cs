using CommunityToolkit.Mvvm.Input;
using neosRPS.Models;

namespace neosRPS.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}