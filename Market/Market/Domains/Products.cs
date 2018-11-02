using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Market.Domains
{
    public class Products
    {
     
        public void ProductWithChar()
        {            
            var prod1 = new PC(name: "Aerocool ZL-15", price: 2000, gpu: "GTX 1080 TI", cpu: "AMD Ryzen 5 2600", memory: 8);
            var prod2 = new Earphones(name: "JBL T110BT", price: 40, frequencies: 20000, battery: 6, bluetooth: "Yes");

            prod1.Watch();
            prod2.Watch();
        }
    }
}
