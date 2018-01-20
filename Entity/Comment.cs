namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int ID { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangedDate { get; set; }

        public int TaskID { get; set; }

        public virtual Task Task { get; set; }
    }
}
