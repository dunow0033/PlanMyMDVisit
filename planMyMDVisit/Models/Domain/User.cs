namespace planMyMDVisit.Models.Domain
{
    public class User
    {
        public string FullName()
        {
            return this.FirstName() + " " + this.LastName();
        }
    }
}
