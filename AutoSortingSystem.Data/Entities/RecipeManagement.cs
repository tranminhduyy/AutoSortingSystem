namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecipeManagement")]
    public partial class RecipeManagement
    {
        public int ID { get; set; }

        public int? Wh_ID { get; set; }

        [StringLength(50)]
        public string Recipe { get; set; }

        public DateTime? ImportDate { get; set; }
    }
}
