namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Label")]
    public partial class Label
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Label()
        {
            Tasks = new HashSet<Task>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(7)]
        public string Color { get; set; }

        public int ProjectID { get; set; }

        public virtual Project Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
