﻿using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Repositories
{
    public interface IDoctorRepository
    {
        Task<Guid> GetCurrentPatientID();
        
        Task<List<string>> GetSpecialties();

        Task<List<Doctor>> GetDoctorsBySpecialty(string specialty);

        Task<Guid> GetDoctorGuidByName(string doctorName);
        Task<string> GetDoctorNameByID(Guid doctorId);
        Task<string> GetPatientFullName();
    }
}
