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
        Message = "Good Morning, " + User.FirstName +"!";
        User.Address = Address;
    }
    public string Address
    {
        get
        { return User.Address; }
        set
        {
            if (User.Address == value)
                return;

            User.Address = value;
            OnPropertyChanged(nameof(Address));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
