namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GateRecipe")]
    public partial class GateRecipe
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Recipe_ID { get; set; }

        [StringLength(20)]
        public string GateNo { get; set; }

        [StringLength(50)]
        public string ReferenceCode { get; set; }
    }
}
