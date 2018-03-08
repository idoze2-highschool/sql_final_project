namespace DAL.Component
{
    public class User : Component
    {
        public string FName;
        public string LName;
        public int UserType;
        public User(int UserID, string FName,string LName,int UserType) : base(UserID)
        {
            this.FName = FName;
            this.LName = LName;
            this.UserType = UserType;
        }
        public User(User user):this(user.ID,user.FName,user.LName,user.UserType)
        {
        }
    }
}