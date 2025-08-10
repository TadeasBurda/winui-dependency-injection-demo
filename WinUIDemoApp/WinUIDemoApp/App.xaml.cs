﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinUIDemoApp.Views;

namespace WinUIDemoApp;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// The main window of the application.
    /// </summary>
    private Window? _mainWindow;

    /// <summary>
    /// The content frame used for navigation.
    /// </summary>
    private Frame? _contentFrame;

    /// <summary>
    /// Gets the current instance of the <see cref="App"/> class.
    /// </summary>
    internal static new App Current => (App)Application.Current;

    /// <summary>
    /// Gets the application's service provider for dependency injection.
    /// </summary>
    internal ServiceProvider Services { get; } = ConfigureServices();

    /// <summary>
    /// Initializes a new instance of the <see cref="App"/> class.
    /// </summary>
    public App()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        AssignServiceProvider();
        InitializeMainWindow();
    }

    /// <summary>
    /// Configures and builds the application's service provider.
    /// </summary>
    /// <returns>The configured <see cref="ServiceProvider"/>.</returns>
    private static ServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();
        services.Configure();

        ConfigureDependencyModules(services);

        return services.BuildServiceProvider();
    }

    /// <summary>
    /// Assigns the application's service provider to the shared dependency configuration.
    /// </summary>
    private void AssignServiceProvider()
    {
        WinUISharedLibrary.DependencyConfiguration.Services = Services;
    }

    /// <summary>
    /// Initializes and activates the main window of the application.
    /// </summary>
    private void InitializeMainWindow()
    {
        _contentFrame = new Frame();
        _contentFrame.Navigate(typeof(MainPage));

        _mainWindow = new MainWindow { Content = _contentFrame };
        _mainWindow.Activate();

        SetupMainWindow(_mainWindow);
    }

    /// <summary>
    /// Sets up the main window in the shared dependency configuration.
    /// </summary>
    /// <param name="mainWindow">The main window to set up.</param>
    private static void SetupMainWindow(Window mainWindow)
    {
        WinUISharedLibrary.DependencyConfiguration.MainWindow = mainWindow;
    }

    /// <summary>
    /// Configures dependency modules for the application.
    /// </summary>
    /// <param name="services">The service collection to configure.</param>
    private static void ConfigureDependencyModules(ServiceCollection services)
    {
        WinUISharedLibrary.DependencyConfiguration.Configure(services);
    }
}
