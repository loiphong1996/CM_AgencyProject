namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTask")]
    public partial class UserTask
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsFollow { get; set; }

        public virtual Task Task { get; set; }

        public virtual User User { get; set; }
    }
}
