﻿// <auto-generated />
using Alii.CodeChallenge.BlogApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alii.CodeChallenge.BlogApi.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Blog", b =>
                {
                    b.HasOne("Alii.CodeChallenge.BlogApi.Data.Models.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Comment", b =>
                {
                    b.HasOne("Alii.CodeChallenge.BlogApi.Data.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Post", b =>
                {
                    b.HasOne("Alii.CodeChallenge.BlogApi.Data.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Blog", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Alii.CodeChallenge.BlogApi.Data.Models.User", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
