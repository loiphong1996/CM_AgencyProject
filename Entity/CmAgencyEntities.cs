namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CmAgencyEntities : DbContext
    {
        public CmAgencyEntities()
            : base("name=CmAgencyEntities")
        {
        }

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskDependency> TaskDependencies { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }
        public virtual DbSet<UserTask> UserTasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Label>()
                .Property(e => e.Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Label>()
                .HasMany(e => e.Tasks)
                .WithMany(e => e.Labels)
                .Map(m => m.ToTable("LabelTask").MapLeftKey("LabelD").MapRightKey("TaskID"));

            modelBuilder.Entity<Project>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Labels)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Stages)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.UserProjects)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserProjects)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stage>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Stage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Attachments)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Task1)
                .WithOptional(e => e.Task2)
                .HasForeignKey(e => e.parentTaskId);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.TaskDependencies)
                .WithRequired(e => e.Task)
                .HasForeignKey(e => e.Source)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.TaskDependencies1)
                .WithRequired(e => e.Task1)
                .HasForeignKey(e => e.Destination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.UserTasks)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Projects)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Teams)
                .Map(m => m.ToTable("UserTeam").MapLeftKey("TeamID").MapRightKey("UserID"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserProjects)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserTasks)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
