﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiengInClassWebApp.Data;

namespace TiengInClassWebApp.Migrations
{
    [DbContext(typeof(JobApplicationContext))]
    [Migration("20200917151618_ApplicationNotes")]
    partial class ApplicationNotes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TiengInClassWebApp.Models.JobApplication", b =>
                {
                    b.Property<int>("jobRequisitionNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("applicationNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("applicationSubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("hiringCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("jobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jobRequisitionNumber");

                    b.ToTable("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
