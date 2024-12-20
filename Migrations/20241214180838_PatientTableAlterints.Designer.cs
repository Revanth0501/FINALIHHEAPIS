﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Apis.Data;

#nullable disable

namespace Project_Apis.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20241214180838_PatientTableAlterints")]
    partial class PatientTableAlterints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_Apis.Models.AppointmentData", b =>
                {
                    b.Property<Guid>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("blood_pressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diagonsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("heart_rate")
                        .HasColumnType("int");

                    b.Property<int>("height")
                        .HasColumnType("int");

                    b.Property<string>("labtest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medication")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.ToTable("AppointmentDatas");
                });

            modelBuilder.Entity("Project_Apis.Models.Appointments", b =>
                {
                    b.Property<Guid>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("AppointmentDate")
                        .HasColumnType("date");

                    b.Property<string>("AppointmentNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("AppointmentTime")
                        .HasColumnType("time");

                    b.Property<string>("Doctor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Project_Apis.Models.Doctor_Registration", b =>
                {
                    b.Property<Guid>("Doctor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Account_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Field_Study")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Hospital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Doctor_Id");

                    b.ToTable("doctor_Registrations");
                });

            modelBuilder.Entity("Project_Apis.Models.Hospital_Registration_Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Account_Staus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Account_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Account__Confirm_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Avilable_Facilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Hospital_Established_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hospital_Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Ownership_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hospital_User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hospital_registrations");
                });

            modelBuilder.Entity("Project_Apis.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Account_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FathersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Physician")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
