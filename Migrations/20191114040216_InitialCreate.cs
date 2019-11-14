using Microsoft.EntityFrameworkCore.Migrations;

namespace repositorio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calificador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Identificación = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: true),
                    SegundoApellido = table.Column<string>(nullable: true),
                    CorreoElectrónico = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Identificación = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: true),
                    SegundoApellido = table.Column<string>(nullable: true),
                    CorreoElectrónico = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Identificación = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: true),
                    SegundoApellido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rúbrica",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdministradorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rúbrica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rúbrica_Administrador_AdministradorId",
                        column: x => x.AdministradorId,
                        principalTable: "Administrador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asignatura",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Código = table.Column<string>(maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    CalificadorId = table.Column<long>(nullable: true),
                    DirectorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asignatura_Calificador_CalificadorId",
                        column: x => x.CalificadorId,
                        principalTable: "Calificador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asignatura_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Criterio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripción = table.Column<string>(nullable: true),
                    RúbricaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criterio_Rúbrica_RúbricaId",
                        column: x => x.RúbricaId,
                        principalTable: "Rúbrica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Código = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    IdAsignatura = table.Column<long>(nullable: false),
                    AsignaturaId = table.Column<long>(nullable: true),
                    DirectorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proyecto_Asignatura_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignatura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proyecto_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteProyecto",
                columns: table => new
                {
                    IdEstudiante = table.Column<long>(nullable: false),
                    IdProyecto = table.Column<long>(nullable: false),
                    EstudianteId = table.Column<long>(nullable: true),
                    ProyectoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteProyecto", x => new { x.IdEstudiante, x.IdProyecto });
                    table.ForeignKey(
                        name: "FK_EstudianteProyecto_Estudiante_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstudianteProyecto_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoCalificador",
                columns: table => new
                {
                    IdProyecto = table.Column<long>(nullable: false),
                    IdCalificador = table.Column<long>(nullable: false),
                    ProyectoId = table.Column<long>(nullable: true),
                    CalificadorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoCalificador", x => new { x.IdCalificador, x.IdProyecto });
                    table.ForeignKey(
                        name: "FK_ProyectoCalificador_Calificador_CalificadorId",
                        column: x => x.CalificadorId,
                        principalTable: "Calificador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProyectoCalificador_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asignatura_CalificadorId",
                table: "Asignatura",
                column: "CalificadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignatura_DirectorId",
                table: "Asignatura",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterio_RúbricaId",
                table: "Criterio",
                column: "RúbricaId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteProyecto_EstudianteId",
                table: "EstudianteProyecto",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteProyecto_ProyectoId",
                table: "EstudianteProyecto",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_AsignaturaId",
                table: "Proyecto",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_DirectorId",
                table: "Proyecto",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoCalificador_CalificadorId",
                table: "ProyectoCalificador",
                column: "CalificadorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoCalificador_ProyectoId",
                table: "ProyectoCalificador",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rúbrica_AdministradorId",
                table: "Rúbrica",
                column: "AdministradorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Criterio");

            migrationBuilder.DropTable(
                name: "EstudianteProyecto");

            migrationBuilder.DropTable(
                name: "ProyectoCalificador");

            migrationBuilder.DropTable(
                name: "Rúbrica");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Asignatura");

            migrationBuilder.DropTable(
                name: "Calificador");

            migrationBuilder.DropTable(
                name: "Director");
        }
    }
}
