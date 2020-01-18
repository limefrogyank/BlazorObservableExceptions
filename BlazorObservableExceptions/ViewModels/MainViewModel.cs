using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;

namespace BlazorObservableExceptions.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public ReactiveCommand<Unit,Unit> TestCommand { get; set; }

        public MainViewModel()
        {
            TestCommand = ReactiveCommand.Create(() => 
            {
                throw new Exception("Testing to see if the Interaction will catch the exception.");
            });

            TestCommand.ThrownExceptions.Subscribe(error =>
            {                
                Debug.WriteLine($"The error was caught! ({error.Message})");
            });
        }
    }
}
