using System.Windows.Input;

namespace ai_math_models;

public class RelayCommand(Action<object> execute, Predicate<object>? canExecute = null)
    : ICommand
{
    public bool CanExecute(object? parameter) => parameter != null && (canExecute == null || canExecute(parameter));
    public void Execute(object? parameter)
    {
        if (parameter != null) execute(parameter);
    }

    public event EventHandler? CanExecuteChanged;
    public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
}