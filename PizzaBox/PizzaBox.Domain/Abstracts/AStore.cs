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
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }

    }
}
