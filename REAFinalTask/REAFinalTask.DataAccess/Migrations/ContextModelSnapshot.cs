// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REAFinalTask.DataAccess.EF;

namespace REAFinalTask.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("REAFinalTask.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CommentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToDoId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ToDoId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("REAFinalTask.Entities.ToDo", b =>
                {
                    b.Property<int>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ToDoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToDoOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToDoStatusEnum")
                        .HasColumnType("int");

                    b.Property<string>("ToDoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToDoId");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("REAFinalTask.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("REAFinalTask.Entities.Comment", b =>
                {
                    b.HasOne("REAFinalTask.Entities.ToDo", "ToDo")
                        .WithMany("Comments")
                        .HasForeignKey("ToDoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToDo");
                });

            modelBuilder.Entity("REAFinalTask.Entities.ToDo", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
