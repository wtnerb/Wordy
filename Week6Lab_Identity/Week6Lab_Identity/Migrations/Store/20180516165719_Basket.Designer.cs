﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Week6Lab_Identity.Data;
using Week6Lab_Identity.Models;

namespace Week6Lab_Identity.Migrations.Store
{
    [DbContext(typeof(StoreContext))]
    [Migration("20180516165719_Basket")]
    partial class Basket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Week6Lab_Identity.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemId");

                    b.Property<int>("ItemQuantity");

                    b.Property<int>("UserBasketNum");

                    b.Property<int>("UserKey");

                    b.HasKey("Id");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("Week6Lab_Identity.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Definition");

                    b.Property<decimal>("Price");

                    b.Property<string>("Text");

                    b.Property<int>("Usage");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
