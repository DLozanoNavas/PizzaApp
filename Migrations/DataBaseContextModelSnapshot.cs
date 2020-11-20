﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMvcApp.Data;

namespace MyMvcApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MyMvcApp.Models.Adicional", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<float>("CostoEnPesos")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("Restantes")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Adicionales");
                });

            modelBuilder.Entity("MyMvcApp.Models.Bebida", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Carbonatada")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("CostoEnPesos")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("GradosAlcohol")
                        .HasColumnType("float");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("MenuID")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("MiliLitros")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.ToTable("Bebidas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Bebida");
                });

            modelBuilder.Entity("MyMvcApp.Models.Ingrediente", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<float>("RestanteEnKG")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("MyMvcApp.Models.IngredientePizza", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IngredienteID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PizzaID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("IngredienteID");

                    b.HasIndex("PizzaID");

                    b.ToTable("IngredientePizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Menu", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("PizzeriaID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("PizzeriaID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MyMvcApp.Models.OpcionMenu", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("MenuID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PizzaID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("PizzaID");

                    b.ToTable("OpcionesMenu");
                });

            modelBuilder.Entity("MyMvcApp.Models.Orden", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Despachada")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PagoID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PizzeriaID")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("PuestoEnLaCola")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UsuarioID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("PagoID");

                    b.HasIndex("PizzeriaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("MyMvcApp.Models.OrdenAdicional", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AdicionalID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("OrdenID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("AdicionalID");

                    b.HasIndex("OrdenID");

                    b.ToTable("OrdenesAdicionales");
                });

            modelBuilder.Entity("MyMvcApp.Models.OrdenBebida", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BebidaID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("OrdenID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("BebidaID");

                    b.HasIndex("OrdenID");

                    b.ToTable("OrdenesBebidas");
                });

            modelBuilder.Entity("MyMvcApp.Models.OrdenPizza", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("OrdenID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PizzaID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("OrdenID");

                    b.HasIndex("PizzaID");

                    b.ToTable("OrdenesPizzas");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pago", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("MontoPagadoEnPesos")
                        .HasColumnType("float");

                    b.Property<string>("PizzeriaID")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UsuarioID")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("PizzeriaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pizza", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("CostoEnPesos")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("PizzeriaID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("PizzeriaID");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pizzeria", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlLogo")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Pizzerias");
                });

            modelBuilder.Entity("MyMvcApp.Models.Usuario", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext");

                    b.Property<string>("Cuidad")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Pais")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MyMvcApp.Models.Cerveza", b =>
                {
                    b.HasBaseType("MyMvcApp.Models.Bebida");

                    b.HasDiscriminator().HasValue("Cerveza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Gaseosa", b =>
                {
                    b.HasBaseType("MyMvcApp.Models.Bebida");

                    b.HasDiscriminator().HasValue("Gaseosa");
                });

            modelBuilder.Entity("MyMvcApp.Models.Jugo", b =>
                {
                    b.HasBaseType("MyMvcApp.Models.Bebida");

                    b.HasDiscriminator().HasValue("Jugo");
                });

            modelBuilder.Entity("MyMvcApp.Models.Vino", b =>
                {
                    b.HasBaseType("MyMvcApp.Models.Bebida");

                    b.HasDiscriminator().HasValue("Vino");
                });

            modelBuilder.Entity("MyMvcApp.Models.Bebida", b =>
                {
                    b.HasOne("MyMvcApp.Models.Menu", "Menu")
                        .WithMany("Bebidas")
                        .HasForeignKey("MenuID");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("MyMvcApp.Models.IngredientePizza", b =>
                {
                    b.HasOne("MyMvcApp.Models.Ingrediente", "Ingrediente")
                        .WithMany("IngredientePizza")
                        .HasForeignKey("IngredienteID");

                    b.HasOne("MyMvcApp.Models.Pizza", "Pizza")
                        .WithMany("IngredientesPizza")
                        .HasForeignKey("PizzaID");

                    b.Navigation("Ingrediente");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Menu", b =>
                {
                    b.HasOne("MyMvcApp.Models.Pizzeria", "Pizzeria")
                        .WithMany("Menus")
                        .HasForeignKey("PizzeriaID");

                    b.Navigation("Pizzeria");
                });

            modelBuilder.Entity("MyMvcApp.Models.OpcionMenu", b =>
                {
                    b.HasOne("MyMvcApp.Models.Menu", "Menu")
                        .WithMany("OpcionesMenu")
                        .HasForeignKey("MenuID");

                    b.HasOne("MyMvcApp.Models.Pizza", "Pizza")
                        .WithMany("OpcionesMenu")
                        .HasForeignKey("PizzaID");

                    b.Navigation("Menu");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Orden", b =>
                {
                    b.HasOne("MyMvcApp.Models.Pago", null)
                        .WithMany("Orden")
                        .HasForeignKey("PagoID");

                    b.HasOne("MyMvcApp.Models.Pizzeria", null)
                        .WithMany("Ordenes")
                        .HasForeignKey("PizzeriaID");

                    b.HasOne("MyMvcApp.Models.Usuario", "Usuario")
                        .WithMany("Orden")
                        .HasForeignKey("UsuarioID");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MyMvcApp.Models.OrdenAdicional", b =>
                {
                    b.HasOne("MyMvcApp.Models.Adicional", "Adicional")
                        .WithMany("OrdenesAdicional")
                        .HasForeignKey("AdicionalID");

                    b.HasOne("MyMvcApp.Models.Orden", "Orden")
                        .WithMany("OrdenesAdicionales")
                        .HasForeignKey("OrdenID");

                    b.Navigation("Adicional");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("MyMvcApp.Models.OrdenBebida", b =>
                {
                    b.HasOne("MyMvcApp.Models.Bebida", "Bebida")
                        .WithMany("OrdenesBebida")
                        .HasForeignKey("BebidaID");

                    b.HasOne("MyMvcApp.Models.Orden", "Orden")
                        .WithMany("OrdenesBebidas")
                        .HasForeignKey("OrdenID");

                    b.Navigation("Bebida");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("MyMvcApp.Models.OrdenPizza", b =>
                {
                    b.HasOne("MyMvcApp.Models.Orden", "Orden")
                        .WithMany("OrdenesPizza")
                        .HasForeignKey("OrdenID");

                    b.HasOne("MyMvcApp.Models.Pizza", "Pizza")
                        .WithMany("OrdenesPizza")
                        .HasForeignKey("PizzaID");

                    b.Navigation("Orden");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pago", b =>
                {
                    b.HasOne("MyMvcApp.Models.Pizzeria", null)
                        .WithMany("Pagos")
                        .HasForeignKey("PizzeriaID");

                    b.HasOne("MyMvcApp.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pizza", b =>
                {
                    b.HasOne("MyMvcApp.Models.Pizzeria", "Pizzeria")
                        .WithMany("Pizzas")
                        .HasForeignKey("PizzeriaID");

                    b.Navigation("Pizzeria");
                });

            modelBuilder.Entity("MyMvcApp.Models.Adicional", b =>
                {
                    b.Navigation("OrdenesAdicional");
                });

            modelBuilder.Entity("MyMvcApp.Models.Bebida", b =>
                {
                    b.Navigation("OrdenesBebida");
                });

            modelBuilder.Entity("MyMvcApp.Models.Ingrediente", b =>
                {
                    b.Navigation("IngredientePizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Menu", b =>
                {
                    b.Navigation("Bebidas");

                    b.Navigation("OpcionesMenu");
                });

            modelBuilder.Entity("MyMvcApp.Models.Orden", b =>
                {
                    b.Navigation("OrdenesAdicionales");

                    b.Navigation("OrdenesBebidas");

                    b.Navigation("OrdenesPizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pago", b =>
                {
                    b.Navigation("Orden");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pizza", b =>
                {
                    b.Navigation("IngredientesPizza");

                    b.Navigation("OpcionesMenu");

                    b.Navigation("OrdenesPizza");
                });

            modelBuilder.Entity("MyMvcApp.Models.Pizzeria", b =>
                {
                    b.Navigation("Menus");

                    b.Navigation("Ordenes");

                    b.Navigation("Pagos");

                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("MyMvcApp.Models.Usuario", b =>
                {
                    b.Navigation("Orden");
                });
#pragma warning restore 612, 618
        }
    }
}
