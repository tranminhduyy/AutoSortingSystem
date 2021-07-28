namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceManagement")]
    public partial class DeviceManagement
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string DeviceName { get; set; }

        [StringLength(20)]
        public string Category { get; set; }

        [StringLength(20)]
        public string Wh_Name { get; set; }

        public int? Wh_Id { get; set; }
    }
}
