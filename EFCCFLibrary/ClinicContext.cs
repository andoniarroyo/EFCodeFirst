namespace EFCCFLibrary.Demo1
{
    using System.Data.Entity;

    using Model;

    class ClinicContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Visit> Visits { get; set; }
    }
}
