using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private string model;
        private int capacity;
        private List<CPU> multiprocessor;


        public Computer(string model, int capacity)
        {
            this.Model = model;
            this.Capacity = capacity;
            this.Multiprocessor = new List<CPU>();
        }


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }
        public List<CPU> Multiprocessor
        {
            get { return this.multiprocessor; }
            set { this.multiprocessor = value; }
        }
        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Count == Capacity)
            {
                return;
            }

            Multiprocessor.Add(cpu);

        }
        public bool Remove(string brand)
           => Multiprocessor.Remove(Multiprocessor.FirstOrDefault(x => x.Brand == brand));

        public CPU MostPowerful()
        {
            var maxFreqCPU = Multiprocessor.Max(x => x.Frequency);
            return Multiprocessor.FirstOrDefault(x => x.Frequency == maxFreqCPU);
        }

        public CPU GetCPU(string brand)
            => Multiprocessor.FirstOrDefault(x => x.Brand == brand);

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {model}:");
            foreach (var CPU in Multiprocessor)
            {
                sb.AppendLine(CPU.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
