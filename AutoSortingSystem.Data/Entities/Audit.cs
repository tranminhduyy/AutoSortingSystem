namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Audit")]
    public partial class Audit
    {
        public int ID { get; set; }

        public DateTime? EvTime { get; set; }

        [StringLength(20)]
        public string EvUser { get; set; }

        [StringLength(255)]
        public string EvMessage { get; set; }
    }
}
