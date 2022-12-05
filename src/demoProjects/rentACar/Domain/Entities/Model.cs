using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Model : Entity
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public virtual Brand? Brand { get; set; }

        public Model()
        {
            // if you will use Model.Brand from other instance you have to create new instance
            // Brand brand = new Brand(); 
        }

        // this() = if you need to run base constructor 
        public Model(int id, int brandId, string name, decimal dailyPrice, string imageUrl) : this()
        {
            Id = id;
            BrandId = brandId;
            Name = name;
            DailyPrice = dailyPrice;
            ImageUrl = imageUrl;
        }
    }
}
