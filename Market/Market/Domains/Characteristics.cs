using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domains
{
   public class Characteristics
    {
        
        public int Price { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
    }

    public class PC : Characteristics
    {
        

        private string GPU { get; set; }
        private string CPU { get; set; }
        private int Memory { get; set; }
        



        public PC(string name, int price, string gpu, string cpu, int memory, string tag = "--PC--" )
        {
            this.Name = name;
            this.Price = price;
            this.GPU = gpu;
            this.CPU = cpu;
            this.Memory = memory;
            Tag = tag;
            
        }
        public  void Watch()
        {
            Console.WriteLine($"{Tag} Name: {Name} ||  Price: {Price} BR\nGpu: {GPU} ||  CPU: {CPU} ||  Memory: {Memory} Gb\n{new string('+',30)}");
        }
        

    }

   public class Earphones : Characteristics
    {
        
        private int Frequencies { get; set; }
        private int Battery { get; set; }
        private string Bluetooth { get; set; }
        

        public Earphones(string name, int price, int frequencies, int battery, string bluetooth, string tag = "--Earphones--")
        {
            

            this.Name = name;
            this.Price = price;
            this.Frequencies = frequencies;
            this.Battery = battery;
            this.Bluetooth = bluetooth;
            Tag = tag;
        }

        public  void Watch()
        {
            Console.WriteLine($"{Tag} Name: {Name} || Price: {Price} BR\nFrequencies: {Frequencies} Hz||  Battery: {Battery} Hours||  Bluetooth: {Bluetooth}\n{new string('+', 30)}");
        }
        
    }
}
