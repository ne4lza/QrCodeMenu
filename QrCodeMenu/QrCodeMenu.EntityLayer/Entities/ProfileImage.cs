using QrCodeMenu.Core.Abstract;
using QrCodeMenu.Core.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeMenu.EntityLayer.Entities
{
    public class ProfileImage : EntityBase
    {
        public string? FileName { get; set; }
        public string? RealFileName { get; set; }
        public string? FileType { get; set; }
        public Guid UserId { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
