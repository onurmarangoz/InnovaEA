using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.Entities
{
   public abstract class EntityBase : IEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string UpdatedBy { get; set; }

        public int Id { get; set; }
        public enum EntityState
        {
            New, Update, Delete, Ignore
        }
        [NotMapped]
        public int State { get; set; }

        public EntityBase()
        {
            CreatedOn = DateTime.Now;
            UpdateOn = DateTime.Now;
            State = (int)EntityState.New;
        }


    }
}
