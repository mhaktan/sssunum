using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace sssunum.Personnels.Dto
{
    [AutoMapTo(typeof(Entities.Personnel))]
    public class CreatePersonnelDto
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string BadgeNumber { get; set; }

        public int Role { get; set; }

        [MaxLength(100)]
        public string LicenseNumber { get; set; }

    }
}