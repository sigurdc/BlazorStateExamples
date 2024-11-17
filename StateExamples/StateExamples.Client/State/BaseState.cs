using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StateExamples.Client.State;

public abstract class BaseState<T>(T state) : INotifyPropertyChanged
{
    protected T State { get; } = state;

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    
    // Possibly new way of doing the same?
    // protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    // {
    //     if (EqualityComparer<T>.Default.Equals(field, value)) return false;
    //     field = value;
    //     OnPropertyChanged(propertyName);
    //     return true;
    // }
}