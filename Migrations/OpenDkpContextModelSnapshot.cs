﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenDKPShared.DBModels;

#nullable disable

namespace OpenDKP.Migrations
{
    [DbContext(typeof(OpenDkpContext))]
    partial class OpenDkpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("OpenDKPShared.DBModels.Adjustments", b =>
                {
                    b.Property<int>("IdAdjustment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_adjustment");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdAdjustment"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("description");

                    b.Property<int>("IdCharacter")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_character");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("timestamp");

                    b.Property<double>("Value")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("double")
                        .HasColumnName("value")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("IdAdjustment", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_adjust_clientid_idx");

                    b.HasIndex("IdAdjustment")
                        .IsUnique()
                        .HasDatabaseName("id_adjustment_UNIQUE");

                    b.HasIndex("IdCharacter")
                        .HasDatabaseName("fk_adjust_char_id_idx");

                    b.ToTable("adjustments", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.AdminSettings", b =>
                {
                    b.Property<string>("SettingName")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("setting_name");

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("setting_value");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("updated_by");

                    b.Property<DateTime>("UpdatedTimestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_timestamp");

                    b.HasKey("SettingName", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_admin_clientId_idx");

                    b.HasIndex("SettingName")
                        .IsUnique()
                        .HasDatabaseName("setting_name_UNIQUE");

                    b.ToTable("admin_settings", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("CognitoUser")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("NewValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OldValue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime");

                    b.HasKey("Id", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_audit_clientid_idx");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("id_UNIQUE");

                    b.ToTable("audit", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Cache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CacheExpires")
                        .HasColumnType("datetime")
                        .HasColumnName("cache_expires");

                    b.Property<string>("CacheName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cache_name");

                    b.Property<DateTime>("CacheUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("cache_updated");

                    b.Property<string>("CacheValue")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cache_value");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("id_UNIQUE");

                    b.ToTable("cache", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Characters", b =>
                {
                    b.Property<int>("IdCharacter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_character");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdCharacter"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("clientId");

                    b.Property<sbyte>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(4)")
                        .HasColumnName("active")
                        .HasDefaultValueSql("'1'");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("class");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("gender");

                    b.Property<string>("Guild")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("guild");

                    b.Property<int>("IdAssociated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_associated")
                        .HasDefaultValueSql("'-1'");

                    b.Property<int?>("Level")
                        .HasColumnType("int(11)")
                        .HasColumnName("level");

                    b.Property<DateTime?>("MainChange")
                        .HasColumnType("datetime")
                        .HasColumnName("main_change");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("race");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("rank");

                    b.HasKey("IdCharacter", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_clientid_idx");

                    b.HasIndex("IdCharacter")
                        .IsUnique()
                        .HasDatabaseName("id_UNIQUE");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("name_UNIQUE");

                    b.ToTable("characters", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Clients", b =>
                {
                    b.Property<string>("ClientId")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("clientId");

                    b.Property<string>("AssumedRole")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("assumedRole");

                    b.Property<string>("Forums")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("forums");

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("identity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("name");

                    b.Property<string>("Subdomain")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("subdomain");

                    b.Property<string>("UserPool")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("userPool");

                    b.Property<string>("WebClientId")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("webClientId");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("website");

                    b.HasKey("ClientId");

                    b.HasIndex("ClientId")
                        .IsUnique()
                        .HasDatabaseName("clientId_UNIQUE");

                    b.ToTable("clients", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Items", b =>
                {
                    b.Property<int>("IdItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_item");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdItem"));

                    b.Property<string>("Lucylink")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("lucylink");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.HasKey("IdItem");

                    b.ToTable("items", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.ItemsXCharacters", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("transaction_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<string>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("character_id");

                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("item_id");

                    b.Property<int>("RaidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("raid_id")
                        .HasDefaultValueSql("'-1'");

                    b.Property<double>("Dkp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("double")
                        .HasColumnName("dkp")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("TransactionId", "ClientId", "CharacterId", "ItemId", "RaidId");

                    b.HasIndex("CharacterId")
                        .HasDatabaseName("fkey_items_character_idx");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_items_clientId_idx");

                    b.HasIndex("ItemId")
                        .HasDatabaseName("fkey_items_item_idx");

                    b.HasIndex("RaidId")
                        .HasDatabaseName("fkey_items_raid_id_idx");

                    b.HasIndex("TransactionId")
                        .IsUnique()
                        .HasDatabaseName("transaction_id_UNIQUE");

                    b.ToTable("items_x_characters", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Pools", b =>
                {
                    b.Property<int>("IdPool")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_pool");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdPool"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.Property<int>("Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("order")
                        .HasDefaultValueSql("'99'");

                    b.HasKey("IdPool");

                    b.HasIndex("IdPool")
                        .IsUnique()
                        .HasDatabaseName("id_UNIQUE");

                    b.ToTable("pools", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Raids", b =>
                {
                    b.Property<int>("IdRaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id_raid");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdRaid"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<int>("IdPool")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_pool");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("timestamp");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("updated_by")
                        .HasDefaultValueSql("'system'");

                    b.Property<DateTime?>("UpdatedTimestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_timestamp");

                    b.HasKey("IdRaid", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_raids_clientid_idx");

                    b.HasIndex("IdPool")
                        .HasDatabaseName("fkey_raids_pool_id_idx");

                    b.HasIndex("IdRaid")
                        .IsUnique()
                        .HasDatabaseName("id_raid_UNIQUE");

                    b.ToTable("raids", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Ticks", b =>
                {
                    b.Property<int>("TickId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("tick_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TickId"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("description");

                    b.Property<int>("RaidId")
                        .HasColumnType("int(11)")
                        .HasColumnName("raid_id");

                    b.Property<double>("Value")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("double")
                        .HasColumnName("value")
                        .HasDefaultValueSql("'0'");

                    b.HasKey("TickId", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_entries_clientId_idx");

                    b.HasIndex("RaidId")
                        .HasDatabaseName("fkey_entries_raids_id_idx");

                    b.HasIndex("TickId")
                        .IsUnique()
                        .HasDatabaseName("tick_id_UNIQUE");

                    b.ToTable("ticks", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.TicksXCharacters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<int>("IdCharacter")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_character");

                    b.Property<int>("IdTick")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_tick");

                    b.HasKey("Id", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_tick_clientId_idx");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("id_UNIQUE");

                    b.HasIndex("IdCharacter")
                        .HasDatabaseName("fkey_tick_charId_idx");

                    b.HasIndex("IdTick")
                        .HasDatabaseName("fkey_tick_tickId_idx");

                    b.ToTable("ticks_x_characters", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.UserRequests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<string>("RequestApprover")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("request_approver");

                    b.Property<string>("RequestDetails")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("request_details");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int(11)")
                        .HasColumnName("request_status");

                    b.Property<DateTime>("RequestTimestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("request_timestamp");

                    b.Property<int>("RequestType")
                        .HasColumnType("int(11)")
                        .HasColumnName("request_type");

                    b.Property<string>("Requestor")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("requestor");

                    b.Property<DateTime>("ReviewedTimestamp")
                        .HasColumnType("datetime")
                        .HasColumnName("reviewed_timestamp");

                    b.HasKey("Id", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_userrequests_clientId_idx");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("id_UNIQUE");

                    b.ToTable("user_requests", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.UserXCharacter", b =>
                {
                    b.Property<string>("User")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("user");

                    b.Property<int>("IdCharacter")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_character");

                    b.Property<string>("ClientId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("clientId");

                    b.Property<string>("ApprovedBy")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("approved_by");

                    b.HasKey("User", "IdCharacter", "ClientId");

                    b.HasIndex("ClientId")
                        .HasDatabaseName("fkey_clientId_idx");

                    b.HasIndex("IdCharacter")
                        .HasDatabaseName("userCharFkey_idx");

                    b.ToTable("user_x_character", (string)null);
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Adjustments", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("Adjustments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_adjust_clientid");

                    b.HasOne("OpenDKPShared.DBModels.Characters", "IdCharacterNavigation")
                        .WithMany("Adjustments")
                        .HasForeignKey("IdCharacter")
                        .HasPrincipalKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_adjust_char_id");

                    b.Navigation("Client");

                    b.Navigation("IdCharacterNavigation");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.AdminSettings", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("AdminSettings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_admin_clientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Audit", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("Audit")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_audit_clientid");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Characters", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("Characters")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_clientid");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.ItemsXCharacters", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Characters", "Character")
                        .WithMany("ItemsXCharacters")
                        .HasForeignKey("CharacterId")
                        .HasPrincipalKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_items_character");

                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("ItemsXCharacters")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_items_clientId");

                    b.HasOne("OpenDKPShared.DBModels.Items", "Item")
                        .WithMany("ItemsXCharacters")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_items_item");

                    b.HasOne("OpenDKPShared.DBModels.Raids", "Raid")
                        .WithMany("ItemsXCharacters")
                        .HasForeignKey("RaidId")
                        .HasPrincipalKey("IdRaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_items_raid_id");

                    b.Navigation("Character");

                    b.Navigation("Client");

                    b.Navigation("Item");

                    b.Navigation("Raid");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Raids", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("Raids")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_raids_clientid");

                    b.HasOne("OpenDKPShared.DBModels.Pools", "IdPoolNavigation")
                        .WithMany("Raids")
                        .HasForeignKey("IdPool")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_raids_pool_id");

                    b.Navigation("Client");

                    b.Navigation("IdPoolNavigation");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Ticks", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("Ticks")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_entries_clientId");

                    b.HasOne("OpenDKPShared.DBModels.Raids", "Raid")
                        .WithMany("Ticks")
                        .HasForeignKey("RaidId")
                        .HasPrincipalKey("IdRaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_entries_raids_id");

                    b.Navigation("Client");

                    b.Navigation("Raid");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.TicksXCharacters", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("TicksXCharacters")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_tick_clientId");

                    b.HasOne("OpenDKPShared.DBModels.Characters", "IdCharacterNavigation")
                        .WithMany("TicksXCharacters")
                        .HasForeignKey("IdCharacter")
                        .HasPrincipalKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_tick_charId");

                    b.HasOne("OpenDKPShared.DBModels.Ticks", "IdTickNavigation")
                        .WithMany("TicksXCharacters")
                        .HasForeignKey("IdTick")
                        .HasPrincipalKey("TickId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_tick_tickId");

                    b.Navigation("Client");

                    b.Navigation("IdCharacterNavigation");

                    b.Navigation("IdTickNavigation");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.UserRequests", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("UserRequests")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_userrequests_clientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.UserXCharacter", b =>
                {
                    b.HasOne("OpenDKPShared.DBModels.Clients", "Client")
                        .WithMany("UserXCharacter")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fkey_userxchar_clientId");

                    b.HasOne("OpenDKPShared.DBModels.Characters", "IdCharacterNavigation")
                        .WithMany("UserXCharacter")
                        .HasForeignKey("IdCharacter")
                        .HasPrincipalKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("userCharFkey");

                    b.Navigation("Client");

                    b.Navigation("IdCharacterNavigation");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Characters", b =>
                {
                    b.Navigation("Adjustments");

                    b.Navigation("ItemsXCharacters");

                    b.Navigation("TicksXCharacters");

                    b.Navigation("UserXCharacter");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Clients", b =>
                {
                    b.Navigation("Adjustments");

                    b.Navigation("AdminSettings");

                    b.Navigation("Audit");

                    b.Navigation("Characters");

                    b.Navigation("ItemsXCharacters");

                    b.Navigation("Raids");

                    b.Navigation("Ticks");

                    b.Navigation("TicksXCharacters");

                    b.Navigation("UserRequests");

                    b.Navigation("UserXCharacter");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Items", b =>
                {
                    b.Navigation("ItemsXCharacters");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Pools", b =>
                {
                    b.Navigation("Raids");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Raids", b =>
                {
                    b.Navigation("ItemsXCharacters");

                    b.Navigation("Ticks");
                });

            modelBuilder.Entity("OpenDKPShared.DBModels.Ticks", b =>
                {
                    b.Navigation("TicksXCharacters");
                });
#pragma warning restore 612, 618
        }
    }
}
