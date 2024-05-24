namespace SpendeeClient.Models
{
    public class UserState
    {
        public User CurrentUser { get; private set; }

        public void SetUser(User user)
        {
            CurrentUser = user;
        }

        public void ClearUser()
        {
            CurrentUser = null;
        }

        public bool IsAuthenticated => CurrentUser != null;
    }
}
