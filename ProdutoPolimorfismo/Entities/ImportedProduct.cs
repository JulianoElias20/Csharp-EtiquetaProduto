using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProdutoPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price,double customFee) :
            base (name,price)
        {
            CustomFee = customFee;
        }
        public override string PriceTag()
        {
            return "Name: " + Name + " " +
                " Price: $" + Price +" "+
                "(Customs fee: $ "+ TotalPrice().ToString()+")";
                   

        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        
    }
}
