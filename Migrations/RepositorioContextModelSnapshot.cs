﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorio.Models;

namespace repositorio.Migrations
{
    [DbContext(typeof(RepositorioContext))]
    partial class RepositorioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Repositorio.Models.Administrador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Administrador");
                });

            modelBuilder.Entity("Repositorio.Models.Asignatura", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CalificadorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Código")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<long?>("DirectorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CalificadorId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Asignatura");
                });

            modelBuilder.Entity("Repositorio.Models.Calificador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorreoElectrónico")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identificación")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sexo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Calificador");
                });

            modelBuilder.Entity("Repositorio.Models.Criterio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .HasColumnType("TEXT");

                    b.Property<long?>("RúbricaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RúbricaId");

                    b.ToTable("Criterio");
                });

            modelBuilder.Entity("Repositorio.Models.Director", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorreoElectrónico")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identificación")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sexo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("Repositorio.Models.Estudiante", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identificación")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sexo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("Repositorio.Models.EstudianteProyecto", b =>
                {
                    b.Property<long>("IdEstudiante")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IdProyecto")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdEstudiante", "IdProyecto");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("EstudianteProyecto");
                });

            modelBuilder.Entity("Repositorio.Models.Proyecto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AsignaturaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Código")
                        .HasColumnType("TEXT");

                    b.Property<long?>("DirectorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("Repositorio.Models.ProyectoCalificador", b =>
                {
                    b.Property<long>("IdCalificador")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IdProyecto")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CalificadorId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdCalificador", "IdProyecto");

                    b.HasIndex("CalificadorId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("ProyectoCalificador");
                });

            modelBuilder.Entity("Repositorio.Models.Rúbrica", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AdministradorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorId");

                    b.ToTable("Rúbrica");
                });

            modelBuilder.Entity("Repositorio.Models.Asignatura", b =>
                {
                    b.HasOne("Repositorio.Models.Calificador", null)
                        .WithMany("Asignaturas")
                        .HasForeignKey("CalificadorId");

                    b.HasOne("Repositorio.Models.Director", null)
                        .WithMany("Asignaturas")
                        .HasForeignKey("DirectorId");
                });

            modelBuilder.Entity("Repositorio.Models.Criterio", b =>
                {
                    b.HasOne("Repositorio.Models.Rúbrica", null)
                        .WithMany("Criterios")
                        .HasForeignKey("RúbricaId");
                });

            modelBuilder.Entity("Repositorio.Models.EstudianteProyecto", b =>
                {
                    b.HasOne("Repositorio.Models.Estudiante", "Estudiante")
                        .WithMany("EstudianteProyectos")
                        .HasForeignKey("EstudianteId");

                    b.HasOne("Repositorio.Models.Proyecto", "Proyecto")
                        .WithMany("ProyectoEstudiantes")
                        .HasForeignKey("ProyectoId");
                });

            modelBuilder.Entity("Repositorio.Models.Proyecto", b =>
                {
                    b.HasOne("Repositorio.Models.Asignatura", "Asignatura")
                        .WithMany("Proyectos")
                        .HasForeignKey("AsignaturaId");

                    b.HasOne("Repositorio.Models.Director", "Director")
                        .WithMany("Proyectos")
                        .HasForeignKey("DirectorId");
                });

            modelBuilder.Entity("Repositorio.Models.ProyectoCalificador", b =>
                {
                    b.HasOne("Repositorio.Models.Calificador", "Calificador")
                        .WithMany("CalificadorProyectos")
                        .HasForeignKey("CalificadorId");

                    b.HasOne("Repositorio.Models.Proyecto", "Proyecto")
                        .WithMany("ProyectoCalificadores")
                        .HasForeignKey("ProyectoId");
                });

            modelBuilder.Entity("Repositorio.Models.Rúbrica", b =>
                {
                    b.HasOne("Repositorio.Models.Administrador", null)
                        .WithMany("Rúbricas")
                        .HasForeignKey("AdministradorId");
                });
#pragma warning restore 612, 618
        }
    }
}
