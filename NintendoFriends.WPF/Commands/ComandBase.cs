using System;
using System.Windows.Input;

namespace NintendoFriends.WPF.Commands
{
    public abstract class ComandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            return true; 
        }

        public abstract void Execute(object? parameter);

        protected virtual void OnCanExecuteChanged(object? parameter) 
        { 
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
