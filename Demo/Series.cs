using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Series : IEquatable<Series>
    {

        public int Id { get; set; }
        public string title { get; set; }
        public double price { get; set; }

        public Series(int id, string title, double price)
        {
            Id = id;
            this.title = title;
            this.price = price;
        }

        public override string ToString()
        {
            return $"id : {Id} | Title : {title} |price : {price} ";
        }

        public bool Equals(Series? other)
        {
            return this.Id.Equals(other.Id) &&
            this.title.Equals(other.title) &&
             this.price.Equals(other.price);
        }
    }

}
