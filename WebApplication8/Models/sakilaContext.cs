using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication8.Models;

namespace WebApplication8.Models

{
    public partial class sakilaContext : DbContext
    {
        public sakilaContext()
        {
        }

        public sakilaContext(DbContextOptions<sakilaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Addressdb> Addressdb { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CityName> CityName { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmActor> FilmActor { get; set; }
        public virtual DbSet<FilmCategory> FilmCategory { get; set; }
        public virtual DbSet<FilmText> FilmText { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Rental> Rental { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Store> Store { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.HasKey(e => e.ActorId)
                    .HasName("PK__actor__8B2447B5D2C9E04F")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("actor");

                entity.HasIndex(e => e.LastName)
                    .HasName("idx_actor_last_name");

                entity.Property(e => e.ActorId).HasColumnName("actor_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__address__CAA247C9FD235546")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("address");

                entity.HasIndex(e => e.CityId)
                    .HasName("idx_fk_city_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_address_city");
            });

            modelBuilder.Entity<Addressdb>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__addressd__CAA247C98CCE4F40")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("addressdb");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__category__D54EE9B58C34E6D0")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__city__031491A9F8E832B7")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("city");

                entity.HasIndex(e => e.CountryId)
                    .HasName("idx_fk_country_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.City1)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_city_country");
            });

            modelBuilder.Entity<CityName>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CityName1).HasColumnName("City_name");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.LastUpdate).HasColumnName("Last_update");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__country__7E8CD0549C402D55")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Country1)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__customer__CD65CB84850AB0DA")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("customer");

                entity.HasIndex(e => e.AddressId)
                    .HasName("idx_fk_address_id");

                entity.HasIndex(e => e.LastName)
                    .HasName("idx_last_name");

                entity.HasIndex(e => e.StoreId)
                    .HasName("idx_fk_store_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customer_address");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customer_store");
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PK__film__349764A88349E4E3")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("film");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("idx_fk_language_id");

                entity.HasIndex(e => e.OriginalLanguageId)
                    .HasName("idx_fk_original_language_id");

                entity.Property(e => e.FilmId).HasColumnName("film_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.OriginalLanguageId).HasColumnName("original_language_id");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('G')");

                entity.Property(e => e.ReleaseYear)
                    .HasColumnName("release_year")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RentalDuration)
                    .HasColumnName("rental_duration")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.RentalRate)
                    .HasColumnName("rental_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReplacementCost)
                    .HasColumnName("replacement_cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpecialFeatures)
                    .HasColumnName("special_features")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FilmLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_language");

                entity.HasOne(d => d.OriginalLanguage)
                    .WithMany(p => p.FilmOriginalLanguage)
                    .HasForeignKey(d => d.OriginalLanguageId)
                    .HasConstraintName("fk_film_language_original");
            });

            modelBuilder.Entity<FilmActor>(entity =>
            {
                entity.HasKey(e => new { e.ActorId, e.FilmId })
                    .HasName("PK__film_act__086D31FFFDED42D0")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("film_actor");

                entity.HasIndex(e => e.ActorId)
                    .HasName("idx_fk_film_actor_actor");

                entity.HasIndex(e => e.FilmId)
                    .HasName("idx_fk_film_actor_film");

                entity.Property(e => e.ActorId).HasColumnName("actor_id");

                entity.Property(e => e.FilmId).HasColumnName("film_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.FilmActor)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_actor_actor");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmActor)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_actor_film");
            });

            modelBuilder.Entity<FilmCategory>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.CategoryId })
                    .HasName("PK__film_cat__69C38A33CCF97640")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("film_category");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("idx_fk_film_category_category");

                entity.HasIndex(e => e.FilmId)
                    .HasName("idx_fk_film_category_film");

                entity.Property(e => e.FilmId).HasColumnName("film_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FilmCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_category_category");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmCategory)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_category_film");
            });

            modelBuilder.Entity<FilmText>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PK__film_tex__349764A8DEFC31C6")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("film_text");

                entity.Property(e => e.FilmId)
                    .HasColumnName("film_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK__inventor__B59ACC48ADFA7D0A")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("inventory");

                entity.HasIndex(e => e.FilmId)
                    .HasName("idx_fk_film_id");

                entity.HasIndex(e => new { e.StoreId, e.FilmId })
                    .HasName("idx_fk_film_id_store_id");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.FilmId).HasColumnName("film_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inventory_film");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inventory_store");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK__language__804CF6B2383E6C6D")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("language");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__payment__ED1FC9EB2511C64B")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("payment");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("idx_fk_customer_id");

                entity.HasIndex(e => e.StaffId)
                    .HasName("idx_fk_staff_id");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RentalId).HasColumnName("rental_id");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payment_customer");

                entity.HasOne(d => d.Rental)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.RentalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_payment_rental");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payment_staff");
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.HasKey(e => e.RentalId)
                    .HasName("PK__rental__67DB611A303B6220")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("rental");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("idx_fk_customer_id");

                entity.HasIndex(e => e.InventoryId)
                    .HasName("idx_fk_inventory_id");

                entity.HasIndex(e => e.StaffId)
                    .HasName("idx_fk_staff_id");

                entity.HasIndex(e => new { e.RentalDate, e.InventoryId, e.CustomerId })
                    .HasName("idx_uq")
                    .IsUnique();

                entity.Property(e => e.RentalId).HasColumnName("rental_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RentalDate)
                    .HasColumnName("rental_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rental)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rental_customer");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.Rental)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rental_inventory");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Rental)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rental_staff");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("PK__staff__1963DD9DF09F9DA1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("staff");

                entity.HasIndex(e => e.AddressId)
                    .HasName("idx_fk_address_id");

                entity.HasIndex(e => e.StoreId)
                    .HasName("idx_fk_store_id");

                entity.Property(e => e.StaffId)
                    .HasColumnName("staff_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("image");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_staff_address");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_staff_store");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__store__A2F2A30DA71E8C39")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("store");

                entity.HasIndex(e => e.AddressId)
                    .HasName("idx_fk_store_address");

                entity.HasIndex(e => e.ManagerStaffId)
                    .HasName("idx_fk_address_id")
                    .IsUnique();

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManagerStaffId).HasColumnName("manager_staff_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_store_address");

                entity.HasOne(d => d.ManagerStaff)
                    .WithOne(p => p.StoreNavigation)
                    .HasForeignKey<Store>(d => d.ManagerStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_store_staff");
            });
        }
    }
}
