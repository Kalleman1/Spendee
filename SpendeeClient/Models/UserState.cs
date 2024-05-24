namespace SpendeeClient.Models
{
    public class UserState
    {
        public User CurrentUser { get; private set; }

        public void SetUser(User user)
        {
            CurrentUser = user;
        }

        public void ClearUser(User user)
        {
            CurrentUser = null;
        }

        public bool IsAuthenticated()
        {
            return CurrentUser != null;
        }
    }
}
