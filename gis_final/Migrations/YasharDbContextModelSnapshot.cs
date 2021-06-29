﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gis_final.Models;

namespace gis_final.Migrations
{
    [DbContext(typeof(YasharDbContext))]
    partial class YasharDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gis_final.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasMaxLength(12);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("gis_final.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("gis_final.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("gis_final.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("gis_final.Models.FieldCourses", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.HasKey("Id", "CourseId", "FieldId");

                    b.HasIndex("CourseId");

                    b.HasIndex("FieldId");

                    b.ToTable("FieldCourses");
                });

            modelBuilder.Entity("gis_final.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Confirm")
                        .HasColumnType("bit");

                    b.Property<bool>("Create")
                        .HasColumnType("bit");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Update")
                        .HasColumnType("bit");

                    b.Property<bool>("View")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Title = "Admin",
                            Update = true,
                            View = true
                        },
                        new
                        {
                            Id = 2,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Title = "Teacher",
                            Update = true,
                            View = true
                        },
                        new
                        {
                            Id = 3,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Title = "Assistant",
                            Update = true,
                            View = true
                        },
                        new
                        {
                            Id = 4,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Title = "Student",
                            Update = true,
                            View = true
                        });
                });

            modelBuilder.Entity("gis_final.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnumScoreStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherFieldCourseId")
                        .HasColumnType("int");

                    b.Property<int>("YearTermId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherFieldCourseId");

                    b.HasIndex("YearTermId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("gis_final.Models.StudentConselor", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("StudentConselors");
                });

            modelBuilder.Entity("gis_final.Models.StudentDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("StudentDegrees");
                });

            modelBuilder.Entity("gis_final.Models.StudentField", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("StudentFields");
                });

            modelBuilder.Entity("gis_final.Models.StudentGraduationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GraduationStatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("StudentGraduationStatuses");
                });

            modelBuilder.Entity("gis_final.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Profesör"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Döçent"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Dr. Öğr. Üyesi"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Araştırma Görevlisi"
                        });
                });

            modelBuilder.Entity("gis_final.Models.TeacherCourseResearchAssistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ResearchAssistantId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherFieldCourseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherFieldCourseId");

                    b.ToTable("TeacherCourseResearchAssistants");
                });

            modelBuilder.Entity("gis_final.Models.TeacherField", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FieldId");

                    b.HasIndex("FieldId");

                    b.ToTable("TeacherFields");
                });

            modelBuilder.Entity("gis_final.Models.TeacherFieldCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("FieldCoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("FieldCoursesFieldId")
                        .HasColumnType("int");

                    b.Property<int>("FieldCoursesId")
                        .HasColumnType("int");

                    b.Property<int>("FieldCoursesId1")
                        .HasColumnType("int");

                    b.Property<int?>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("UserId");

                    b.HasIndex("FieldCoursesId1", "FieldCoursesCourseId", "FieldCoursesFieldId");

                    b.ToTable("TeacherFieldCourses");
                });

            modelBuilder.Entity("gis_final.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "yashar",
                            Password = "123",
                            UserStatus = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "safak",
                            Password = "123",
                            UserStatus = 0
                        },
                        new
                        {
                            Id = 3,
                            Email = "nese",
                            Password = "123",
                            UserStatus = 0
                        },
                        new
                        {
                            Id = 4,
                            Email = "defne",
                            Password = "123",
                            UserStatus = 0
                        });
                });

            modelBuilder.Entity("gis_final.Models.UserRoles", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Confirm")
                        .HasColumnType("bit");

                    b.Property<bool>("Create")
                        .HasColumnType("bit");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<bool>("Update")
                        .HasColumnType("bit");

                    b.Property<bool>("View")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Update = true,
                            View = true
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Update = true,
                            View = true
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Update = true,
                            View = true
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 4,
                            Confirm = true,
                            Create = true,
                            Delete = true,
                            Update = true,
                            View = true
                        });
                });

            modelBuilder.Entity("gis_final.Models.UserTags", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("UserTags");
                });

            modelBuilder.Entity("gis_final.Models.YearTerm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TermId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("YearTerms");
                });

            modelBuilder.Entity("gis_final.Models.Address", b =>
                {
                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.Field", b =>
                {
                    b.HasOne("gis_final.Models.Faculty", "Faculty")
                        .WithMany("Fields")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.FieldCourses", b =>
                {
                    b.HasOne("gis_final.Models.Course", "Course")
                        .WithMany("FieldCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.Field", "Field")
                        .WithMany("FieldCourses")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.Schedule", b =>
                {
                    b.HasOne("gis_final.Models.TeacherFieldCourse", "TeacherFieldCourse")
                        .WithMany("Schedules")
                        .HasForeignKey("TeacherFieldCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.YearTerm", "YearTerm")
                        .WithMany()
                        .HasForeignKey("YearTermId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.StudentConselor", b =>
                {
                    b.HasOne("gis_final.Models.User", "User")
                        .WithOne("StudentConselor")
                        .HasForeignKey("gis_final.Models.StudentConselor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.StudentDegree", b =>
                {
                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany("StudentDegrees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.StudentField", b =>
                {
                    b.HasOne("gis_final.Models.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany("StudentFields")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.StudentGraduationStatus", b =>
                {
                    b.HasOne("gis_final.Models.User", "User")
                        .WithOne("StudentGraduationStatus")
                        .HasForeignKey("gis_final.Models.StudentGraduationStatus", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.TeacherCourseResearchAssistant", b =>
                {
                    b.HasOne("gis_final.Models.TeacherFieldCourse", "TeacherFieldCourse")
                        .WithMany("TeacherCourseResearchAssistants")
                        .HasForeignKey("TeacherFieldCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.TeacherField", b =>
                {
                    b.HasOne("gis_final.Models.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany("TeacherFields")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.TeacherFieldCourse", b =>
                {
                    b.HasOne("gis_final.Models.Field", null)
                        .WithMany("TeacherFieldCourses")
                        .HasForeignKey("FieldId");

                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.FieldCourses", "FieldCourses")
                        .WithMany("TeacherFieldCourses")
                        .HasForeignKey("FieldCoursesId1", "FieldCoursesCourseId", "FieldCoursesFieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.UserRoles", b =>
                {
                    b.HasOne("gis_final.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gis_final.Models.UserTags", b =>
                {
                    b.HasOne("gis_final.Models.Tag", "Tag")
                        .WithMany("UserTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gis_final.Models.User", "User")
                        .WithMany("UserTags")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
