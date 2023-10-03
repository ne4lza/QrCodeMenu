using QrCodeMenu.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeMenu.Core.Concrate
{
    public class EntityBase:IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime RemovedDate { get; set; }
        public string? RemovedBy { get; set; }
        public bool IsActive { get; set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
}
