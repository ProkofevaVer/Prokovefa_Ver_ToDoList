﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prokovefa_Ver_ToDoList.Date;

#nullable disable

namespace Prokovefa_Ver_ToDoList.Migrations
{
    [DbContext(typeof(TaskDbContact))]
    partial class TaskDbContactModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prokovefa_Ver_ToDoList.Model.DeleteTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("dateTimev")
                        .HasColumnType("datetime2");

                    b.Property<int>("taskID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("taskID");

                    b.ToTable("Deletetask");
                });

            modelBuilder.Entity("Prokovefa_Ver_ToDoList.Model.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("task");
                });

            modelBuilder.Entity("Prokovefa_Ver_ToDoList.Model.DeleteTask", b =>
                {
                    b.HasOne("Prokovefa_Ver_ToDoList.Model.Task", "task")
                        .WithMany()
                        .HasForeignKey("taskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("task");
                });
#pragma warning restore 612, 618
        }
    }
}
