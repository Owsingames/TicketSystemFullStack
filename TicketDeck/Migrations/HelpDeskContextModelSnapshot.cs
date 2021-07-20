﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketDeck.Models;

namespace TicketDeck.Migrations
{
    [DbContext(typeof(HelpDeskContext))]
    partial class HelpDeskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketDeck.Models.Bookmark", b =>
                {
                    b.Property<int?>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("PersonID");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int")
                        .HasColumnName("TicketID");

                    b.HasIndex("PersonId");

                    b.HasIndex("TicketId");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("TicketDeck.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TicketID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Priotity")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<bool?>("Resolved")
                        .HasColumnType("bit");

                    b.Property<string>("Solution")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketDeck.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketDeck.Models.Bookmark", b =>
                {
                    b.HasOne("TicketDeck.Models.User", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .HasConstraintName("FK__Bookmarks__Perso__2B3F6F97");

                    b.HasOne("TicketDeck.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .HasConstraintName("FK__Bookmarks__Ticke__2C3393D0");


                });
#pragma warning restore 612, 618
        }
    }
}
