namespace Tekconf.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Conferences")]
    public class Conference
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Slug { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(8000)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

    }

    //[Table("Users")]
    //public class User
    //{
    //    public int Id { get; set; }
    //    public 
    //}
}
