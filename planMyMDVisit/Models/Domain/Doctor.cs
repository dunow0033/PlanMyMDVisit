namespace planMyMDVisit.Models.Domain
{
    public class Doctor
    {
        public void Specialties()
        { 
            select(:specialty).distinct.order(specialty: :asc)
        }
    }
}
