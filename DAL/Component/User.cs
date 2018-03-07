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
        }
        public User(User user):this(user.ID,user.FName,user.LName,user.UserType)
        {
        }
    }
    public class Student : User
    {
        public Student(User user):base(user)
        {
            this.UserType = 2;
        }

    }
    public class Teacher:User
    {
        public Teacher(User user) : base(user)
        {
            this.UserType = 1;
        }
    }
}