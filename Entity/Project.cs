namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            Labels = new HashSet<Label>();
            Stages = new HashSet<Stage>();
            Tasks = new HashSet<Task>();
            UserProjects = new HashSet<UserProject>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        public int ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime ChangedDate { get; set; }

        public int TeamID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Label> Labels { get; set; }

        public virtual Team Team { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stage> Stages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}
