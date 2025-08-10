using WinUISharedLibrary.Services;

namespace WinUISharedLibrary.ViewModels;

/// <summary>
/// ViewModel for the main page of the application.
/// </summary>
internal sealed class MainLibViewModel(IExampleServices exampleServices)
{
    /// <summary>
    /// Provides access to example services.
    /// </summary>
    private readonly IExampleServices _exampleServices = exampleServices;
}
