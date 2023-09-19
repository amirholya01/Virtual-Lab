﻿// <auto-generated />
using System;
using CourseCreator.Datalayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CourseCreator.Datalayer.Migrations
{
    [DbContext(typeof(CourseCreatorContext))]
    [Migration("20230919082042_mig_make_level_status_DB")]
    partial class mig_make_level_status_DB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseImageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("CourseLevelLevelId")
                        .HasColumnType("integer");

                    b.Property<int>("CourseStatusStatusId")
                        .HasColumnType("integer");

                    b.Property<string>("CourseTitle")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DemoFileName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("LevelId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int?>("SubGroup")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CourseId");

                    b.HasIndex("CourseLevelLevelId");

                    b.HasIndex("CourseStatusStatusId");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubGroup");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseEpisode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("EpisodeFileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("EpisodeTime")
                        .HasColumnType("interval");

                    b.Property<string>("EpisodeTitle")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseEpisodes");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId");

                    b.HasIndex("ParentId");

                    b.ToTable("CourseGroups");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseLevel", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LevelId"));

                    b.Property<string>("LevelTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("LevelId");

                    b.ToTable("CourseLevels");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseStatus", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatusId"));

                    b.Property<string>("StatusTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("StatusId");

                    b.ToTable("CourseStatus");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.User.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("ActiveCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.User.UserRole", b =>
                {
                    b.Property<int>("UR_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UR_Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UR_Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("userRoles");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.Course", b =>
                {
                    b.HasOne("CourseCreator.Datalayer.Entities.Course.CourseLevel", "CourseLevel")
                        .WithMany("Courses")
                        .HasForeignKey("CourseLevelLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseCreator.Datalayer.Entities.Course.CourseStatus", "CourseStatus")
                        .WithMany("Courses")
                        .HasForeignKey("CourseStatusStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseCreator.Datalayer.Entities.Course.CourseGroup", "CourseGroup")
                        .WithMany("Courses")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseCreator.Datalayer.Entities.Course.CourseGroup", "Group")
                        .WithMany("SubGroup")
                        .HasForeignKey("SubGroup");

                    b.HasOne("CourseCreator.Datalayer.Entities.User.User", "User")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseGroup");

                    b.Navigation("CourseLevel");

                    b.Navigation("CourseStatus");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseEpisode", b =>
                {
                    b.HasOne("CourseCreator.Datalayer.Entities.Course.Course", "Course")
                        .WithMany("CourseEpisodes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseGroup", b =>
                {
                    b.HasOne("CourseCreator.Datalayer.Entities.Course.CourseGroup", null)
                        .WithMany("CourseGroups")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.User.UserRole", b =>
                {
                    b.HasOne("CourseCreator.Datalayer.Entities.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseCreator.Datalayer.Entities.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.Course", b =>
                {
                    b.Navigation("CourseEpisodes");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseGroup", b =>
                {
                    b.Navigation("CourseGroups");

                    b.Navigation("Courses");

                    b.Navigation("SubGroup");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseLevel", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.Course.CourseStatus", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.User.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CourseCreator.Datalayer.Entities.User.User", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}