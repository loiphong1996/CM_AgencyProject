namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            Attachments = new HashSet<Attachment>();
            Comments = new HashSet<Comment>();
            Task1 = new HashSet<Task>();
            TaskDependencies = new HashSet<TaskDependency>();
            TaskDependencies1 = new HashSet<TaskDependency>();
            UserTasks = new HashSet<UserTask>();
            Labels = new HashSet<Label>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int? parentTaskId { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }

        public int? ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangedDate { get; set; }

        public int Status { get; set; }

        public DateTime? Deadline { get; set; }

        public int ProjectID { get; set; }

        public int StageID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Project Project { get; set; }

        public virtual Stage Stage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Task1 { get; set; }

        public virtual Task Task2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskDependency> TaskDependencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskDependency> TaskDependencies1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTask> UserTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Label> Labels { get; set; }
    }
}
