namespace DAL.Component
{
    public class User : Component
    { 
        public string Name;
        public User(int UserID,string Name) : base(UserID)
        {
            this.Name = Name;
        }
    }
}