using System;
using System.Collections.Generic;
using FinalProject.EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject.DataLayer.ContextDb
{
    public partial class MoviesInfoContext : DbContext
    {
        public MoviesInfoContext()
        {
        }

        public MoviesInfoContext(DbContextOptions<MoviesInfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mytable> Mytables { get; set; } = null!;
        public virtual DbSet<LoginEntity> Logins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-LOIGVJB;Database=MoviesInfo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mytable>(entity =>
            {
                entity.ToTable("mytable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Adult)
                    .HasMaxLength(126)
                    .IsUnicode(false)
                    .HasColumnName("adult");

                entity.Property(e => e.BelongsToCollection)
                    .HasMaxLength(184)
                    .IsUnicode(false)
                    .HasColumnName("belongs_to_collection");

                entity.Property(e => e.Budget)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("budget");

                entity.Property(e => e.Genres)
                    .HasMaxLength(264)
                    .IsUnicode(false)
                    .HasColumnName("genres");

                entity.Property(e => e.Homepage)
                    .HasMaxLength(242)
                    .IsUnicode(false)
                    .HasColumnName("homepage");

                entity.Property(e => e.ImdbId)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("imdb_id");

                entity.Property(e => e.OriginalLanguage)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("original_language");

                entity.Property(e => e.OriginalTitle)
                    .HasMaxLength(109)
                    .IsUnicode(false)
                    .HasColumnName("original_title");

                entity.Property(e => e.Overview)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("overview");

                entity.Property(e => e.Popularity)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("popularity");

                entity.Property(e => e.PosterPath)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("poster_path");

                entity.Property(e => e.ProductionCompanies)
                    .HasMaxLength(1252)
                    .IsUnicode(false)
                    .HasColumnName("production_companies");

                entity.Property(e => e.ProductionCountries)
                    .HasMaxLength(1039)
                    .IsUnicode(false)
                    .HasColumnName("production_countries");

                entity.Property(e => e.ReleaseDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("release_date");

                entity.Property(e => e.Revenue).HasColumnName("revenue");

                entity.Property(e => e.Runtime)
                    .HasColumnType("numeric(6, 1)")
                    .HasColumnName("runtime");

                entity.Property(e => e.SpokenLanguages)
                    .HasMaxLength(765)
                    .IsUnicode(false)
                    .HasColumnName("spoken_languages");

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Tagline)
                    .HasMaxLength(297)
                    .IsUnicode(false)
                    .HasColumnName("tagline");

                entity.Property(e => e.Title)
                    .HasMaxLength(105)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Video)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("video");

                entity.Property(e => e.VoteAverage)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("vote_average");

                entity.Property(e => e.VoteCount).HasColumnName("vote_count");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
