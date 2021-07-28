namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alarm")]
    public partial class Alarm
    {
        public int ID { get; set; }

        public DateTime? AlrmTime { get; set; }

        [StringLength(255)]
        public string AlrmMessage { get; set; }

        public bool AlrmAck { get; set; }
    }
}
