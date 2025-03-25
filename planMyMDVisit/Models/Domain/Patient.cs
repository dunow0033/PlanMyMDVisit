namespace planMyMDVisit.Models.Domain
{
    public class Patient
    {
        public String FullName()
        {
            return this.User ? this.User.FullName : null;
        }
    }
}
