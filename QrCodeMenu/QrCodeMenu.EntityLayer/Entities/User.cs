using QrCodeMenu.Core.Abstract;
using QrCodeMenu.Core.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeMenu.EntityLayer.Entities
{
    public class User : EntityBase
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public Guid ImageId { get; set; }
        public ProfileImage Image { get; set; }
        public User()
        {
            FullName = Name + " " + SurName;
        }
    }
}
