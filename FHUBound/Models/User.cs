using FHUBound.ViewModels;

namespace FHUBound.Models
{
    public class User : BaseViewModel
    {
        private int currentPoints = 0;
        private int streak = 0;
        private int streakPointsAdded = 0;
        public int CurrentPoints
        {
            get { return currentPoints; }
            set { SetProperty(ref currentPoints, value); }
        }
        public int Streak
        {
            get { return streak; }
            set { SetProperty(ref streak, value); }
        }
        public int StreakPointsAdded
        {
            get { return streakPointsAdded; }
            set { SetProperty(ref streakPointsAdded, value); }
        }
        public string Id { get; set; }
        public string Username { get; set; }

        public string Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public User()
        {
        }
    }
}
