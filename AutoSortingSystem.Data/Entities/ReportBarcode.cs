namespace AutoSortingSystem.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportBarcode")]
    public partial class ReportBarcode
    {
        public int ID { get; set; }

        public int? Wh_ID { get; set; }

        [StringLength(50)]
        public string Recipe { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? StopTime { get; set; }

        public int? Total { get; set; }

        public int? Gate1Total { get; set; }

        public int? Gate2Total { get; set; }

        public int? Gate3Total { get; set; }

        public int? Gate4Total { get; set; }

        public int? Gate5Total { get; set; }

        public int? Reject { get; set; }
    }
}
