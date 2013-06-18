namespace Test
{
    using System;
    using System.Collections.Generic;

    using EFCCFLibrary.Demo1;

    using Model;

    class Program
    {
        static void Main(string[] args)
        {
            var newPatient = new Patient
                                 {
                                     Name = "Andoni",
                                     Type = new PatientType { TyoeName = "VIP" },
                                     Visits =
                                         new List<Visit>
                                             {
                                                 new Visit
                                                     {
                                                         Date = new DateTime(2010, 01, 01),
                                                         Reason = "Resaca"
                                                     },
                                                 new Visit
                                                     {
                                                         Date = new DateTime(2011, 01, 01),
                                                         Reason = "Otra resaca"
                                                     }
                                             }
                                 };

            Demo1.CreateNewPatient(newPatient);
            Console.Write("New patient created...");
            Console.ReadLine();
        }
    }
}
