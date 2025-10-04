namespace Core;

public class UserState
{
    private string? _username;
    public string? Username
    {
        get => _username;
        set
        {
            if (_username != value)
            {
                _username = value;
                NotifyStateChanged();
            }
        }
    }

    public event Action? OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();
}