using FHUBound;
using FHUBound.Models;
using FHUBound.ViewModels;

public class ProfileViewModel : BaseViewModel
{
    public User User { get; set; }
    public string Message { get; set; }

    public ProfileViewModel()
    {
        User = App.CurrentUser;
        Message = "Good Morning, " + User.FirstName +"!";
    }

}
