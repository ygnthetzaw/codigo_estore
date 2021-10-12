﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eVoucher.Data;

namespace eVoucher.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20211012131915_vouchertable")]
    partial class vouchertable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("eVoucher.Entities.BuyType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("lastupdatedby");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.Property<string>("typename")
                        .HasColumnType("longtext")
                        .HasColumnName("typename");

                    b.HasKey("id")
                        .HasName("pk_buytypes");

                    b.ToTable("buytypes");
                });

            modelBuilder.Entity("eVoucher.Entities.DiscountType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("lastupdatedby");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("id")
                        .HasName("pk_discounttypes");

                    b.ToTable("discounttypes");
                });

            modelBuilder.Entity("eVoucher.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("lastupdatedby");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.Property<string>("name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("id")
                        .HasName("pk_paymentmethods");

                    b.ToTable("paymentmethods");
                });

            modelBuilder.Entity("eVoucher.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext")
                        .HasColumnName("fullname");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("lastupdatedby");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.Property<string>("Username")
                        .HasColumnType("longtext")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users");
                });

            modelBuilder.Entity("eVoucher.Entities.Voucher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createddate");

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int")
                        .HasColumnName("discounttypeid");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("longtext")
                        .HasColumnName("lastupdatedby");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("paymentmethodid");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updateddate");

                    b.Property<bool>("active")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active");

                    b.Property<int>("amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<string>("description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<DateTime>("expirydate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("expirydate");

                    b.Property<string>("imageurl")
                        .HasColumnType("longtext")
                        .HasColumnName("imageurl");

                    b.Property<int>("paymentmethoddiscount")
                        .HasColumnType("int")
                        .HasColumnName("paymentmethoddiscount");

                    b.Property<int>("quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<string>("title")
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.HasKey("id")
                        .HasName("pk_vouchers");

                    b.HasIndex("DiscountTypeId")
                        .HasDatabaseName("ix_vouchers_discounttypeid");

                    b.HasIndex("PaymentMethodId")
                        .HasDatabaseName("ix_vouchers_paymentmethodid");

                    b.ToTable("vouchers");
                });

            modelBuilder.Entity("eVoucher.Entities.User", b =>
                {
                    b.OwnsMany("eVoucher.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasColumnName("id");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime(6)")
                                .HasColumnName("created");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("longtext")
                                .HasColumnName("createdbyip");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime(6)")
                                .HasColumnName("expires");

                            b1.Property<string>("ReasonRevoked")
                                .HasColumnType("longtext")
                                .HasColumnName("reasonrevoked");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("longtext")
                                .HasColumnName("replacedbytoken");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime(6)")
                                .HasColumnName("revoked");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("longtext")
                                .HasColumnName("revokedbyip");

                            b1.Property<string>("Token")
                                .HasColumnType("longtext")
                                .HasColumnName("token");

                            b1.Property<int>("UserId")
                                .HasColumnType("int")
                                .HasColumnName("userid");

                            b1.HasKey("Id")
                                .HasName("pk_refreshtoken");

                            b1.HasIndex("UserId")
                                .HasDatabaseName("ix_refreshtoken_userid");

                            b1.ToTable("refreshtoken");

                            b1.WithOwner()
                                .HasForeignKey("UserId")
                                .HasConstraintName("fk_refreshtoken_users_userid");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("eVoucher.Entities.Voucher", b =>
                {
                    b.HasOne("eVoucher.Entities.DiscountType", "DiscountType")
                        .WithMany()
                        .HasForeignKey("DiscountTypeId")
                        .HasConstraintName("fk_vouchers_discounttypes_discounttypeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eVoucher.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .HasConstraintName("fk_vouchers_paymentmethods_paymentmethodid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscountType");

                    b.Navigation("PaymentMethod");
                });
#pragma warning restore 612, 618
        }
    }
}
