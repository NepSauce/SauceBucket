using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SauceBucket;

public partial class MainWindow : Window
{
    int count = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object? sender, RoutedEventArgs e)
    {
        count++;

        if (CounterButton != null)
        {
            if (count == 1)
                CounterButton.Content = $"Clicked {count} time";
            else
                CounterButton.Content = $"Clicked {count} times";
        }
    }
}
