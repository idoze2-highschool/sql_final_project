namespace DAL.Component
{
    public class User
    {
        private int id,userType;
        private string fName,lName;
        public int ID { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public int UserType { get => userType; set => userType = value; }
        public User(int UserID, string FName,string LName,int UserType)
        {
            this.ID = UserID;
            this.FName = FName;
            this.LName = LName;
            this.UserType = UserType;
        }
        public User(User User):this(User.ID,User.FName,User.LName,User.UserType)
        {
        }
        public static string Tablename { get => "Users"; }
        public static string[] Columns { get => new string[] { "UserID", "FName", "LName", "UserType" }; }
    }
}