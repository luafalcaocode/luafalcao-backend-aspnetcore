using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace luafalcao.api.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artigo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titulo = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true),
                    aqual_blog_pertence = table.Column<string>(nullable: true),
                    thumbnail = table.Column<string>(nullable: true),
                    data_publicacao = table.Column<DateTime>(nullable: false),
                    tags = table.Column<string[]>(nullable: true),
                    numero_likes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_artigo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_roles",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_name = table.Column<string>(maxLength: 256, nullable: true),
                    concurrency_stamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_users",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    user_name = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(maxLength: 256, nullable: true),
                    email = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_email = table.Column<string>(maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(nullable: false),
                    password_hash = table.Column<string>(nullable: true),
                    security_stamp = table.Column<string>(nullable: true),
                    concurrency_stamp = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    phone_number_confirmed = table.Column<bool>(nullable: false),
                    two_factor_enabled = table.Column<bool>(nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(nullable: true),
                    lockout_enabled = table.Column<bool>(nullable: false),
                    access_failed_count = table.Column<int>(nullable: false),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    autor = table.Column<string>(nullable: true),
                    descricao = table.Column<string>(nullable: true),
                    data_publicacao = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    artigo_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_comentario", x => x.id);
                    table.ForeignKey(
                        name: "fk_comentario_artigo_artigo_id",
                        column: x => x.artigo_id,
                        principalTable: "artigo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_role_claims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<string>(nullable: false),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_role_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_asp_net_role_claims_asp_net_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "asp_net_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_claims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<string>(nullable: false),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_asp_net_user_claims_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_logins",
                columns: table => new
                {
                    login_provider = table.Column<string>(nullable: false),
                    provider_key = table.Column<string>(nullable: false),
                    provider_display_name = table.Column<string>(nullable: true),
                    user_id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_logins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "fk_asp_net_user_logins_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_roles",
                columns: table => new
                {
                    user_id = table.Column<string>(nullable: false),
                    role_id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_asp_net_user_roles_asp_net_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "asp_net_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_asp_net_user_roles_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_tokens",
                columns: table => new
                {
                    user_id = table.Column<string>(nullable: false),
                    login_provider = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_tokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "fk_asp_net_user_tokens_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "artigo",
                columns: new[] { "id", "aqual_blog_pertence", "data_publicacao", "descricao", "numero_likes", "tags", "thumbnail", "titulo" },
                values: new object[,]
                {
                    { 8, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 8, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2370), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 8" },
                    { 15, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 15, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2460), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 15" },
                    { 14, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 14, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2450), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 14" },
                    { 13, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 13, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2390), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 13" },
                    { 12, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 12, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2390), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 12" },
                    { 11, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 11, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2380), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 11" },
                    { 10, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 10, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2380), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 10" },
                    { 9, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 9, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2380), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 9" },
                    { 16, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 16, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2460), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 16" },
                    { 17, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 17, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2460), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 17" },
                    { 6, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 6, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2370), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 6" },
                    { 5, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 5, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2360), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 5" },
                    { 4, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 4, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2360), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 4" },
                    { 3, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 3, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2350), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 3" },
                    { 2, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 2, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2280), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 2" },
                    { 1, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 1, 19, 11, 35, 638, DateTimeKind.Local).AddTicks(9940), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 1" },
                    { 7, "DiarioEngenheiroSoftware", new DateTime(2020, 11, 7, 19, 11, 35, 654, DateTimeKind.Local).AddTicks(2370), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..", 5, new[] { "Engenharia de Software", "Design Patterns", "Programa��o" }, null, "Artigo 7" }
                });

            migrationBuilder.InsertData(
                table: "asp_net_roles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { "2f7acdda-51f1-499c-aeab-f959a4448e73", "59c523aa-2148-42ac-878e-786af35c659d", "Todos", "TODOS" },
                    { "508e98c6-994e-4ace-816c-277ae692de41", "8922367e-e0ab-41b6-b183-72e2dd1d4d95", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "comentario",
                columns: new[] { "id", "artigo_id", "autor", "data_publicacao", "descricao", "email" },
                values: new object[,]
                {
                    { 1, 1, "Lu� Falc�o", new DateTime(2020, 10, 31, 19, 11, 35, 655, DateTimeKind.Local).AddTicks(8150), "Coment�rio.......", "lpjfalcao@gmail.com" },
                    { 2, 2, "Lu� Falc�o", new DateTime(2020, 10, 31, 19, 11, 35, 655, DateTimeKind.Local).AddTicks(9630), "Coment�rio.......", "lpjfalcao@gmail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_role_claims_role_id",
                table: "asp_net_role_claims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "asp_net_roles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_user_claims_user_id",
                table: "asp_net_user_claims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_user_logins_user_id",
                table: "asp_net_user_logins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_user_roles_role_id",
                table: "asp_net_user_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "asp_net_users",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "asp_net_users",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_comentario_artigo_id",
                table: "comentario",
                column: "artigo_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asp_net_role_claims");

            migrationBuilder.DropTable(
                name: "asp_net_user_claims");

            migrationBuilder.DropTable(
                name: "asp_net_user_logins");

            migrationBuilder.DropTable(
                name: "asp_net_user_roles");

            migrationBuilder.DropTable(
                name: "asp_net_user_tokens");

            migrationBuilder.DropTable(
                name: "comentario");

            migrationBuilder.DropTable(
                name: "asp_net_roles");

            migrationBuilder.DropTable(
                name: "asp_net_users");

            migrationBuilder.DropTable(
                name: "artigo");
        }
    }
}
