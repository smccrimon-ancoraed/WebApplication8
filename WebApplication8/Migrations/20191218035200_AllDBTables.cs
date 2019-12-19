using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class AllDBTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            return;
            /*
            migrationBuilder.CreateTable(
                name: "actor",
                columns: table => new
                {
                    actor_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__actor__8B2447B5D2C9E04F", x => x.actor_id)
                        .Annotation("SqlServer:Clustered", false);
                });
           

            migrationBuilder.CreateTable(
                name: "addressdb",
                columns: table => new
                {
                    address_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    address2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    district = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    city_id = table.Column<int>(nullable: false),
                    postal_code = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__addressd__CAA247C98CCE4F40", x => x.address_id)
                        .Annotation("SqlServer:Clustered", false);
                });
 
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

      


            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__category__D54EE9B58C34E6D0", x => x.category_id)
                        .Annotation("SqlServer:Clustered", false);
                });
            */


            migrationBuilder.CreateTable(
                name: "CityName",
                columns: table => new
                {
                    City_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country_id = table.Column<short>(nullable: false),
                    Last_update = table.Column<DateTime>(nullable: false),
                    City_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityName", x => x.City_id);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    country_id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    country = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__country__7E8CD0549C402D55", x => x.country_id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "film_text",
                columns: table => new
                {
                    film_id = table.Column<short>(nullable: false),
                    title = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__film_tex__349764A8DEFC31C6", x => x.film_id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    language_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__language__804CF6B2383E6C6D", x => x.language_id)
                        .Annotation("SqlServer:Clustered", false);
                });

            /*
             * 
             * 
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            */


            /*
             * These databases were accessed
             * 
            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    city_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    country_id = table.Column<short>(nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__city__031491A9F8E832B7", x => x.city_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_city_country",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "country_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "film",
                columns: table => new
                {
                    film_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    release_year = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    language_id = table.Column<byte>(nullable: false),
                    original_language_id = table.Column<byte>(nullable: true),
                    rental_duration = table.Column<byte>(nullable: false, defaultValueSql: "((3))"),
                    rental_rate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    length = table.Column<short>(nullable: true),
                    replacement_cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    rating = table.Column<string>(unicode: false, maxLength: 10, nullable: true, defaultValueSql: "('G')"),
                    special_features = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__film__349764A88349E4E3", x => x.film_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_film_language",
                        column: x => x.language_id,
                        principalTable: "language",
                        principalColumn: "language_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_film_language_original",
                        column: x => x.original_language_id,
                        principalTable: "language",
                        principalColumn: "language_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    address_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address1 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    address2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    district = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    city_id = table.Column<int>(nullable: false),
                    postal_code = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__address__CAA247C9FD235546", x => x.address_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_address_city",
                        column: x => x.city_id,
                        principalTable: "city",
                        principalColumn: "city_id",
                        onDelete: ReferentialAction.Restrict);
                });

            */

            migrationBuilder.CreateTable(
                name: "film_actor",
                columns: table => new
                {
                    actor_id = table.Column<int>(nullable: false),
                    film_id = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__film_act__086D31FFFDED42D0", x => new { x.actor_id, x.film_id })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_film_actor_actor",
                        column: x => x.actor_id,
                        principalTable: "actor",
                        principalColumn: "actor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_film_actor_film",
                        column: x => x.film_id,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "film_category",
                columns: table => new
                {
                    film_id = table.Column<int>(nullable: false),
                    category_id = table.Column<byte>(nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__film_cat__69C38A33CCF97640", x => new { x.film_id, x.category_id })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_film_category_category",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_film_category_film",
                        column: x => x.film_id,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Restrict);
                });

            /*
             * 
             *  Previously used
             *  
            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    store_id = table.Column<int>(nullable: false),
                    first_name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    address_id = table.Column<int>(nullable: false),
                    active = table.Column<string>(unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('Y')"),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__CD65CB84850AB0DA", x => x.customer_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_customer_address",
                        column: x => x.address_id,
                        principalTable: "address",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                });

            */


            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    staff_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    address_id = table.Column<int>(nullable: false),
                    picture = table.Column<byte[]>(type: "image", nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    store_id = table.Column<int>(nullable: false),
                    active = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    username = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    password = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__staff__1963DD9DF09F9DA1", x => x.staff_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_staff_address",
                        column: x => x.address_id,
                        principalTable: "address",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "store",
                columns: table => new
                {
                    store_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    manager_staff_id = table.Column<byte>(nullable: false),
                    address_id = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__store__A2F2A30DA71E8C39", x => x.store_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_store_address",
                        column: x => x.address_id,
                        principalTable: "address",
                        principalColumn: "address_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_store_staff",
                        column: x => x.manager_staff_id,
                        principalTable: "staff",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inventory",
                columns: table => new
                {
                    inventory_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    film_id = table.Column<int>(nullable: false),
                    store_id = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__inventor__B59ACC48ADFA7D0A", x => x.inventory_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_inventory_film",
                        column: x => x.film_id,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_inventory_store",
                        column: x => x.store_id,
                        principalTable: "store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rental",
                columns: table => new
                {
                    rental_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rental_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    inventory_id = table.Column<int>(nullable: false),
                    customer_id = table.Column<int>(nullable: false),
                    return_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    staff_id = table.Column<byte>(nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__rental__67DB611A303B6220", x => x.rental_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_rental_customer",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rental_inventory",
                        column: x => x.inventory_id,
                        principalTable: "inventory",
                        principalColumn: "inventory_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rental_staff",
                        column: x => x.staff_id,
                        principalTable: "staff",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    payment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(nullable: false),
                    staff_id = table.Column<byte>(nullable: false),
                    rental_id = table.Column<int>(nullable: true),
                    amount = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    payment_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__payment__ED1FC9EB2511C64B", x => x.payment_id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_payment_customer",
                        column: x => x.customer_id,
                        principalTable: "customer",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_payment_rental",
                        column: x => x.rental_id,
                        principalTable: "rental",
                        principalColumn: "rental_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_payment_staff",
                        column: x => x.staff_id,
                        principalTable: "staff",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "idx_actor_last_name",
                table: "actor",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "idx_fk_city_id",
                table: "address",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "idx_fk_country_id",
                table: "city",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_address_id",
                table: "customer",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "idx_last_name",
                table: "customer",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "idx_fk_store_id",
                table: "customer",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_language_id",
                table: "film",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_original_language_id",
                table: "film",
                column: "original_language_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_film_actor_actor",
                table: "film_actor",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_film_actor_film",
                table: "film_actor",
                column: "film_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_film_category_category",
                table: "film_category",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_film_category_film",
                table: "film_category",
                column: "film_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_film_id",
                table: "inventory",
                column: "film_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_film_id_store_id",
                table: "inventory",
                columns: new[] { "store_id", "film_id" });

            migrationBuilder.CreateIndex(
                name: "idx_fk_customer_id",
                table: "payment",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_payment_rental_id",
                table: "payment",
                column: "rental_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_staff_id",
                table: "payment",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_customer_id",
                table: "rental",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_inventory_id",
                table: "rental",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_staff_id",
                table: "rental",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "idx_uq",
                table: "rental",
                columns: new[] { "rental_date", "inventory_id", "customer_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_fk_address_id",
                table: "staff",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_store_id",
                table: "staff",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_store_address",
                table: "store",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "idx_fk_address_id",
                table: "store",
                column: "manager_staff_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_customer_store",
                table: "customer",
                column: "store_id",
                principalTable: "store",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_staff_store",
                table: "staff",
                column: "store_id",
                principalTable: "store",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_address_city",
                table: "address");

            migrationBuilder.DropForeignKey(
                name: "fk_staff_address",
                table: "staff");

            migrationBuilder.DropForeignKey(
                name: "fk_store_address",
                table: "store");

            migrationBuilder.DropForeignKey(
                name: "fk_staff_store",
                table: "staff");

            migrationBuilder.DropTable(
                name: "addressdb");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CityName");

            migrationBuilder.DropTable(
                name: "film_actor");

            migrationBuilder.DropTable(
                name: "film_category");

            migrationBuilder.DropTable(
                name: "film_text");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "actor");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "rental");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "inventory");

            migrationBuilder.DropTable(
                name: "film");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "store");

            migrationBuilder.DropTable(
                name: "staff");
        }
    }
}
