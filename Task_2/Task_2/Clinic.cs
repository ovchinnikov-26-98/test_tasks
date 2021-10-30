using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Clinic
    {
        public List<Patient> Data;
        //Patient p1 = new Patient("Alex", "Mitchel", 21, "critical");
        //Patient p2 = new Patient("Kate", "Pupsvel", 18, "critical");
        //Patient p3 = new Patient("Georgy", "Robbinson", 42, "normal");
        //Patient p4 = new Patient("LG", "Company", 120, "normal");
        //Patient p5 = new Patient("Mikky", "Mouse", 30, "critical");
        
        public Clinic()
        {
            Data = new List<Patient>();
        }

        public void Create_New_Patient(Patient patient)
        {
            Data.Add(patient);
        }


    }
}
