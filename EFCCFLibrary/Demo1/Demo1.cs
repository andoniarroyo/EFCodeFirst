namespace EFCCFLibrary.Demo1
{
    using Model;

    /// <summary>
    /// The demo 1.
    /// </summary>
    public class Demo1
    {
        #region Public Methods and Operators

        /// <summary>
        /// The create new patient.
        /// </summary>
        public static void CreateNewPatient(Patient newPatient)
        {
            using (var context = new ClinicContext())
            {
                context.Patients.Add(newPatient);
                context.SaveChanges();
            }
        }

        #endregion
    }
}