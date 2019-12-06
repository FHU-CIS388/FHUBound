using FHUBound;
using FHUBound.Models;
using FHUBound.ViewModels;
using System.ComponentModel;

public class ProfileViewModel : BaseViewModel, INotifyPropertyChanged
{
    public User User { get; set; }
    public string Message { get; set; }

    public ProfileViewModel()
    {
        User = App.CurrentUser;
        Message = "Good Morning, " + User.Username;
    }

    private string address = string.Empty;
    public string Address
    {
        get
        { return address; }
        set
        {
            if (address == value)
                return;

            address = value;
            OnPropertyChanged(nameof(Address));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
