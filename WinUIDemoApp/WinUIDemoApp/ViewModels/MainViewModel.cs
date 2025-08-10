using WinUIDemoApp.Services;

namespace WinUIDemoApp.ViewModels;

/// <summary>
/// ViewModel for the main page of the application.
/// </summary>
internal sealed class MainViewModel(IExampleServices exampleServices)
{
    /// <summary>
    /// Provides access to example services.
    /// </summary>
    private readonly IExampleServices _exampleServices = exampleServices;
}
