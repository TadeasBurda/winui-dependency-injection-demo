using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using WinUIDemoApp.ViewModels;

namespace WinUIDemoApp.Views;

/// <summary>
/// Represents the main page of the application.
/// </summary>
public sealed partial class MainPage : Page
{
    /// <summary>
    /// Gets the <see cref="MainViewModel"/> instance for this page.
    /// </summary>
    internal MainViewModel ViewModel { get; } =
        App.Current.Services.GetRequiredService<MainViewModel>();

    /// <summary>
    /// Initializes a new instance of the <see cref="MainPage"/> class.
    /// </summary>
    public MainPage()
    {
        InitializeComponent();
    }
}
