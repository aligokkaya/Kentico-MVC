using org.pdfclown.documents.contents.entities;

namespace Kentico.Models.Home
{
    public class DoctorlarViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Degree { get; set; }
        public string Speciality { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }
        public int EmergencyShift { get; set; }

    }
}