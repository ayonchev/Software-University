using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(250)]
        public string Address { get; set; }

        [MaxLength(80)]
        public string Email { get; set; }
        public bool HasInsurance { get; set; }
        public ICollection<Diagnose> Diagnoses { get; set; } = new List<Diagnose>();
        public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();
        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }
}
