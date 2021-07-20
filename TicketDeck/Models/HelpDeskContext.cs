﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TicketDeck.Models
{
    public partial class HelpDeskContext : DbContext
    {
        public HelpDeskContext()
        {
        }

        public HelpDeskContext(DbContextOptions<HelpDeskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookmark> Bookmarks { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=HelpDesk;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bookmark>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Person)
                    .WithMany()
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Bookmarks__Perso__2B3F6F97");

                entity.HasOne(d => d.Ticket)
                    .WithMany()
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK__Bookmarks__Ticke__2C3393D0");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Priotity)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Solution)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
