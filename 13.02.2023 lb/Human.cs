using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClass
{
    abstract public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        abstract public void Work();
        abstract public void StopWork();
    }

    public class Builder : Human
    {
        public Builder()
        {
            CurrentProjectsNumber = 0;
        }
        public int CurrentProjectsNumber { get; set; }
        public override void Work()
        {
            Console.WriteLine("Builder works");
            CurrentProjectsNumber++;
        }

        public override void StopWork()
        {
            Console.WriteLine("Builder does not work");
            CurrentProjectsNumber--;
        }
    }

    public class Pilot : Human
    {
        public Pilot()
        {
            isAloft = false;
        }

        public bool isAloft { get; set; }
        public override void Work()
        {
            Console.WriteLine("Pilot works");
            isAloft = true;
        }

        public override void StopWork()
        {
            Console.WriteLine("Pilot does not work");
            isAloft = false;
        }
    }

    public class Sailor : Human
    {
        private static Random r = new Random();
        public int ContractTimeDays { get; set; }
        public override void StopWork()
        {
            Console.WriteLine("Sailor does not work");
            ContractTimeDays = 0;
        }

        public override void Work()
        {

            Console.WriteLine("Sailor works");
            ContractTimeDays = r.Next(90, 180);
        }
    }
}
