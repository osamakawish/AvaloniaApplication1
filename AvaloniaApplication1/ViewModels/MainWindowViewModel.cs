using System.ComponentModel;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private string _counter = "0";
        public static string Greeting => "Welcome to Avalonia!";

        public string ButtonText { get; } = "This is a Button";

        public string Counter
        {
            get => _counter;
            internal set => this.RaiseAndSetIfChanged(ref _counter, value);
        }
    }
}