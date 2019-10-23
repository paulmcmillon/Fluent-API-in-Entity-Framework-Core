using System;
using System.Collections.Generic;
using System.Text;

namespace GroundzKeeper.Data
{
    public class SelectedJobActivity
    {
        public bool Selected { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ModelEnums.UnitOfMeasure Uom { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }


        public static implicit operator SelectedJobActivity(Activity activity)
        {
            return new SelectedJobActivity
            {
                Selected = false,
                Id = activity.Id,
                Name = activity.Name,
                Description = activity.Description,
                Uom = activity.DefaultUom,
                Price = activity.DefualtPrice,
                Cost = activity.DefaultCost
            };
        }

        public static implicit operator Activity(SelectedJobActivity activity)
        {
            return new Activity
            {
                Id = activity.Id,
                Name = activity.Name,
                Description = activity.Description,
                DefaultUom = activity.Uom,
                DefualtPrice = activity.Price,
                DefaultCost = activity.Cost
            };
        }
    }
}
