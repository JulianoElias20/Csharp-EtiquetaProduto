using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) :
            base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return "Name: " + Name+ " (used) "+ " " +
                " Price: $" + Price+ " "+
                "(Manufacture date: "+ManufactureDate.ToString("dd/MM/yyyy")+")";
        }
    }
}
