using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class matedbContext : DbContext
    {
        public matedbContext()
        {
        }

        public matedbContext(DbContextOptions<matedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<TableList> Lists { get; set; }
        public virtual DbSet<ListsTask> ListsTasks { get; set; }
        public virtual DbSet<ListsUpd> ListsUpds { get; set; }
        public virtual DbSet<SecretUser> SecretUsers { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Subtask> Subtasks { get; set; }
        public virtual DbSet<TableTask> Tasks { get; set; }
        public virtual DbSet<TableUser> Users { get; set; }
        public virtual DbSet<UsersCommunication> UsersCommunications { get; set; }
        public virtual DbSet<UsersInfo> UsersInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=matedb;Username=postgres;Password=postgre");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.ToTable("attributes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Deadline)
                    .HasColumnType("timestamp(0) with time zone")
                    .HasColumnName("deadline");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Attribute)
                    .HasForeignKey<Attribute>(d => d.Id)
                    .HasConstraintName("attributes_fk");
            });

            modelBuilder.Entity<TableList>(entity =>
            {
                entity.ToTable("lists");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DefaultList)
                    .HasColumnName("default_list")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Hobby)
                    .HasColumnName("hobby")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Listname)
                    .HasColumnType("character varying")
                    .HasColumnName("listname");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Lists)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("lists_fk");
            });

            modelBuilder.Entity<ListsTask>(entity =>
            {
                entity.HasKey(e => new { e.IdLists, e.IdTasks })
                    .HasName("lists_tasks_pk");

                entity.ToTable("lists_tasks");

                entity.Property(e => e.IdLists).HasColumnName("id_lists");

                entity.Property(e => e.IdTasks).HasColumnName("id_tasks");

                entity.HasOne(d => d.IdListsNavigation)
                    .WithMany(p => p.ListsTasks)
                    .HasForeignKey(d => d.IdLists)
                    .HasConstraintName("lists_tasks_fk");

                entity.HasOne(d => d.IdTasksNavigation)
                    .WithMany(p => p.ListsTasks)
                    .HasForeignKey(d => d.IdTasks)
                    .HasConstraintName("lists_tasks_fk_1");
            });

            modelBuilder.Entity<ListsUpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lists_upd");

                entity.HasIndex(e => e.Id, "lists_upd_id_idx");

                entity.Property(e => e.DefaultList)
                    .HasColumnName("default_list")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Hobby)
                    .HasColumnName("hobby")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Listname)
                    .HasColumnType("character varying")
                    .HasColumnName("listname");

                entity.Property(e => e.UsersId).HasColumnName("users_id");
            });

            modelBuilder.Entity<SecretUser>(entity =>
            {
                entity.ToTable("secret_users", "fYhjb45I");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("login");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Statusname)
                    .HasColumnType("character varying")
                    .HasColumnName("statusname");
            });

            modelBuilder.Entity<Subtask>(entity =>
            {
                entity.ToTable("subtasks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdTask).HasColumnName("id_task");

                entity.Property(e => e.SubtaskName).HasColumnName("subtask_name");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Subtasks)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subtasks_st");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.Subtasks)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("subtasks_fk");
            });

            modelBuilder.Entity<TableTask>(entity =>
            {
                entity.ToTable("tasks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdStatus).HasColumnName("id_status")
                .HasDefaultValueSql("1");

                entity.Property(e => e.Taskname)
                    .HasColumnType("character varying")
                    .HasColumnName("taskname");
                    

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tasks_fk");
            });

            modelBuilder.Entity<TableUser>(entity =>
            {
                entity.ToTable("users", "fYhjb45I");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.LastDate)
                    .HasColumnType("timestamp(0) with time zone")
                    .HasColumnName("last_date");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("password");

                entity.Property(e => e.RegDate)
                    .HasColumnType("timestamp(0) with time zone")
                    .HasColumnName("reg_date");

                entity.Property(e => e.SchemaName)
                    .HasColumnType("character varying")
                    .HasColumnName("schema_name");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("user_login");
            });

            modelBuilder.Entity<UsersCommunication>(entity =>
            {
                entity.HasKey(e => new { e.IdExternTask, e.IdExternUser })
                    .HasName("users_communication_pk");

                entity.ToTable("users_communication");

                entity.Property(e => e.IdExternTask).HasColumnName("id_extern_task");

                entity.Property(e => e.IdExternUser).HasColumnName("id_extern_user");

                entity.HasOne(d => d.IdExternTaskNavigation)
                    .WithMany(p => p.UsersCommunications)
                    .HasForeignKey(d => d.IdExternTask)
                    .HasConstraintName("users_communication_fk");

                entity.HasOne(d => d.IdExternUserNavigation)
                    .WithMany(p => p.UsersCommunications)
                    .HasForeignKey(d => d.IdExternUser)
                    .HasConstraintName("users_communication_fk_1");
            });

            modelBuilder.Entity<UsersInfo>(entity =>
            {
                entity.ToTable("users_info");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateLast)
                    .HasColumnType("time with time zone")
                    .HasColumnName("date_last");

                entity.Property(e => e.DateReg)
                    .HasColumnType("time with time zone")
                    .HasColumnName("date_reg");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasColumnName("user_login");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
