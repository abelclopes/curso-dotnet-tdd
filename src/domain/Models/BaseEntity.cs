using System;
using System.ComponentModel.DataAnnotations;

namespace domain.Models
{
    public class BaseEntity
    {
       [Key]
        public Guid Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCriation { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateUpdate { get; set; }
        public bool Excluded { get; set; }

        public BaseEntity()
        {
            DateCriation = DateTime.UtcNow;
        }

        public void Delete()
        {
            Excluded = true;
        }
    }
}