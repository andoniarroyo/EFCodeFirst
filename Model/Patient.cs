namespace Model
{
    using System.Collections.Generic;

    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public PatientType Type { get; set; }

        public List<Visit> Visits { get; set; }
    }
}
