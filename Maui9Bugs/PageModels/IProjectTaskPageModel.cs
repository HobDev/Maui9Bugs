using CommunityToolkit.Mvvm.Input;
using Maui9Bugs.Models;

namespace Maui9Bugs.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}