namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wh_Management
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Wh_Name { get; set; }
    }
}
