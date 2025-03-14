using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenDKP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cache",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cache_name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cache_value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cache_expires = table.Column<DateTime>(type: "datetime", nullable: false),
                    cache_updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cache", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    subdomain = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identity = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userPool = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    webClientId = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    assumedRole = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    forums = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.clientId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lucylink = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.id_item);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pools",
                columns: table => new
                {
                    id_pool = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    order = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "'99'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pools", x => x.id_pool);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "admin_settings",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    setting_name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    setting_value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_settings", x => new { x.setting_name, x.clientId });
                    table.ForeignKey(
                        name: "fkey_admin_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "audit",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CognitoUser = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    Action = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OldValue = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NewValue = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audit", x => new { x.id, x.clientId });
                    table.ForeignKey(
                        name: "fkey_audit_clientid",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_character = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_associated = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "'-1'"),
                    active = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValueSql: "'1'"),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rank = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    @class = table.Column<string>(name: "class", type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    level = table.Column<int>(type: "int(11)", nullable: true),
                    race = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guild = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    main_change = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => new { x.id_character, x.clientId });
                    table.UniqueConstraint("AK_characters_id_character", x => x.id_character);
                    table.ForeignKey(
                        name: "fkey_clientid",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_requests",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    requestor = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    request_type = table.Column<int>(type: "int(11)", nullable: false),
                    request_status = table.Column<int>(type: "int(11)", nullable: false),
                    request_details = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    request_timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    request_approver = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reviewed_timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_requests", x => new { x.id, x.clientId });
                    table.ForeignKey(
                        name: "fkey_userrequests_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "raids",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_raid = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_pool = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, defaultValueSql: "'system'")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_timestamp = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raids", x => new { x.id_raid, x.clientId });
                    table.UniqueConstraint("AK_raids_id_raid", x => x.id_raid);
                    table.ForeignKey(
                        name: "fkey_raids_clientid",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_raids_pool_id",
                        column: x => x.id_pool,
                        principalTable: "pools",
                        principalColumn: "id_pool",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "adjustments",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_adjustment = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_character = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value = table.Column<double>(type: "double", nullable: false, defaultValueSql: "'0'"),
                    timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adjustments", x => new { x.id_adjustment, x.clientId });
                    table.ForeignKey(
                        name: "fkey_adjust_char_id",
                        column: x => x.id_character,
                        principalTable: "characters",
                        principalColumn: "id_character",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_adjust_clientid",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user_x_character",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_character = table.Column<int>(type: "int(11)", nullable: false),
                    approved_by = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_x_character", x => new { x.user, x.id_character, x.clientId });
                    table.ForeignKey(
                        name: "fkey_userxchar_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "userCharFkey",
                        column: x => x.id_character,
                        principalTable: "characters",
                        principalColumn: "id_character",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "items_x_characters",
                columns: table => new
                {
                    transaction_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    character_id = table.Column<int>(type: "int(11)", nullable: false),
                    item_id = table.Column<int>(type: "int(11)", nullable: false),
                    raid_id = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "'-1'"),
                    dkp = table.Column<double>(type: "double", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items_x_characters", x => new { x.transaction_id, x.clientId, x.character_id, x.item_id, x.raid_id });
                    table.ForeignKey(
                        name: "fkey_items_character",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id_character",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_items_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_items_item",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "id_item",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_items_raid_id",
                        column: x => x.raid_id,
                        principalTable: "raids",
                        principalColumn: "id_raid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ticks",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tick_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    raid_id = table.Column<int>(type: "int(11)", nullable: false),
                    value = table.Column<double>(type: "double", nullable: false, defaultValueSql: "'0'"),
                    description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticks", x => new { x.tick_id, x.clientId });
                    table.UniqueConstraint("AK_ticks_tick_id", x => x.tick_id);
                    table.ForeignKey(
                        name: "fkey_entries_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_entries_raids_id",
                        column: x => x.raid_id,
                        principalTable: "raids",
                        principalColumn: "id_raid",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ticks_x_characters",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_character = table.Column<int>(type: "int(11)", nullable: false),
                    id_tick = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticks_x_characters", x => new { x.id, x.clientId });
                    table.ForeignKey(
                        name: "fkey_tick_charId",
                        column: x => x.id_character,
                        principalTable: "characters",
                        principalColumn: "id_character",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_tick_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fkey_tick_tickId",
                        column: x => x.id_tick,
                        principalTable: "ticks",
                        principalColumn: "tick_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_adjust_char_id_idx",
                table: "adjustments",
                column: "id_character");

            migrationBuilder.CreateIndex(
                name: "fkey_adjust_clientid_idx",
                table: "adjustments",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "id_adjustment_UNIQUE",
                table: "adjustments",
                column: "id_adjustment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_admin_clientId_idx",
                table: "admin_settings",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "setting_name_UNIQUE",
                table: "admin_settings",
                column: "setting_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_audit_clientid_idx",
                table: "audit",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "audit",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "cache",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_clientid_idx",
                table: "characters",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "characters",
                column: "id_character",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE",
                table: "characters",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "clientId_UNIQUE",
                table: "clients",
                column: "clientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_items_character_idx",
                table: "items_x_characters",
                column: "character_id");

            migrationBuilder.CreateIndex(
                name: "fkey_items_clientId_idx",
                table: "items_x_characters",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "fkey_items_item_idx",
                table: "items_x_characters",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "fkey_items_raid_id_idx",
                table: "items_x_characters",
                column: "raid_id");

            migrationBuilder.CreateIndex(
                name: "transaction_id_UNIQUE",
                table: "items_x_characters",
                column: "transaction_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "pools",
                column: "id_pool",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_raids_clientid_idx",
                table: "raids",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "fkey_raids_pool_id_idx",
                table: "raids",
                column: "id_pool");

            migrationBuilder.CreateIndex(
                name: "id_raid_UNIQUE",
                table: "raids",
                column: "id_raid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_entries_clientId_idx",
                table: "ticks",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "fkey_entries_raids_id_idx",
                table: "ticks",
                column: "raid_id");

            migrationBuilder.CreateIndex(
                name: "tick_id_UNIQUE",
                table: "ticks",
                column: "tick_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_tick_charId_idx",
                table: "ticks_x_characters",
                column: "id_character");

            migrationBuilder.CreateIndex(
                name: "fkey_tick_clientId_idx",
                table: "ticks_x_characters",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "fkey_tick_tickId_idx",
                table: "ticks_x_characters",
                column: "id_tick");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "ticks_x_characters",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_userrequests_clientId_idx",
                table: "user_requests",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "user_requests",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fkey_clientId_idx",
                table: "user_x_character",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "userCharFkey_idx",
                table: "user_x_character",
                column: "id_character");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adjustments");

            migrationBuilder.DropTable(
                name: "admin_settings");

            migrationBuilder.DropTable(
                name: "audit");

            migrationBuilder.DropTable(
                name: "cache");

            migrationBuilder.DropTable(
                name: "items_x_characters");

            migrationBuilder.DropTable(
                name: "ticks_x_characters");

            migrationBuilder.DropTable(
                name: "user_requests");

            migrationBuilder.DropTable(
                name: "user_x_character");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "ticks");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "raids");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "pools");
        }
    }
}
