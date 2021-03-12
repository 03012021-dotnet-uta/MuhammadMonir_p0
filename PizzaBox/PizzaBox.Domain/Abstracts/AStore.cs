using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Abstracts
{
    [XmlInclude(typeof(Store1))]
    [XmlInclude(typeof(Store2))]
    public abstract class AStore
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
    }
}
