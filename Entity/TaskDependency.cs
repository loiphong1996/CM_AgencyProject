namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskDependency")]
    public partial class TaskDependency
    {
        public int ID { get; set; }

        public int Source { get; set; }

        public int Destination { get; set; }

        public int Type { get; set; }

        public virtual Task Task { get; set; }

        public virtual Task Task1 { get; set; }
    }
}
