using Microsoft.UI.Xaml.Controls;
using WinUISharedLibrary.ViewModels;

namespace WinUISharedLibrary.Views;

/// <summary>
/// Represents the main library page of the application.
/// </summary>
public sealed partial class MainLibPage : Page
{
    /// <summary>
    /// Gets the <see cref="MainLibViewModel"/> instance for this page.
    /// </summary>
    internal MainLibViewModel ViewModel { get; } =
        DependencyConfiguration.GetService<MainLibViewModel>();

    /// <summary>
    /// Initializes a new instance of the <see cref="MainLibPage"/> class.
    /// </summary>
    public MainLibPage()
    {
        InitializeComponent();
    }
}
