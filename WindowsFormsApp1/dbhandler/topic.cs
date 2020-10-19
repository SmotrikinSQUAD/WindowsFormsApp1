namespace WindowsFormsApp1.dbhandler
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class topic
    {
        public int Id { get; set; }

        [Column("topic")]
        [Required]
        [StringLength(50)]
        public string topic1 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string words { get; set; }
    }
}
