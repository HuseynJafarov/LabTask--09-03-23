using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pharmacy
    {
        public Medicine[] Medicinies = new Medicine[0];

        public void AddMedicine(Medicine medicinies)
        {
            Array.Resize(ref Medicinies, Medicinies.Length + 1);
            Medicinies[Medicinies.Length - 1] = medicinies;
        }

    }
}
