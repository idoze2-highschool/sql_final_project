namespace DALOrg.Component
{
    public class User
    {
        public int ID;
        public string FName;
        public string LName;
        public int UserType;
        public User(int UserID, string FName,string LName,int UserType)
        {
            this.ID = UserID;
            this.FName = FName;
            this.LName = LName;
            this.UserType = UserType;
        }
        public User(User user):this(user.ID,user.FName,user.LName,user.UserType)
        {
        }
    }
}