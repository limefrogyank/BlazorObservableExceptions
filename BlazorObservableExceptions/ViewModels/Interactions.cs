using ReactiveUI;
using System;

namespace BlazorObservableExceptions.ViewModels
{
    public static class Interactions
    {
        public static Interaction<Exception, bool> ErrorMessage = new Interaction<Exception, bool>();
    }
}
