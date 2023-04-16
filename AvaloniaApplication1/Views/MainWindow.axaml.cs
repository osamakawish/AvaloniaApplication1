using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object? sender, RoutedEventArgs e)
        {
            var dataContext = (MainWindowViewModel)DataContext!;
            dataContext.Counter = $"{int.Parse(dataContext.Counter) + 1}";
        }
    }
}