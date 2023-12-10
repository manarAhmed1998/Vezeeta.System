using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Vezeeta.System.DAL;
public class VezeetaContext:IdentityDbContext<ApplicationUser>
{
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Specialization> Specializations =>Set<Specialization>();
    public DbSet<Appointment> Appointments =>Set<Appointment>();
    public DbSet<Time>Times =>Set<Time>();
    public DbSet<Booking> Bookings =>Set<Booking>();
    public DbSet<Coupon> Coupons =>Set<Coupon>();
    public DbSet<PatientCoupon>PatientCoupons =>Set<PatientCoupon>();

    //ctor for recerving options [generic if we are using A multi-tenant application ]
    public VezeetaContext(DbContextOptions<VezeetaContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        //adding to the orginal code
        base.OnModelCreating(modelBuilder);
        var admin = new ApplicationUser
        {
            AccountType = AccountType.Admin,
            Email = "admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            PasswordHash = hasher.HashPassword(null, "Admin@123"),
            SecurityStamp = string.Empty,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };
        modelBuilder.Entity<ApplicationUser>().HasData(admin);
        modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
        new IdentityUserClaim<string> { Id = 1, UserId = admin.Id, ClaimType = ClaimTypes.NameIdentifier, ClaimValue = admin.UserName },
        new IdentityUserClaim<string> { Id = 2, UserId = admin.Id, ClaimType = ClaimTypes.Role, ClaimValue = admin.AccountType.ToString()},
        new IdentityUserClaim<string> { Id = 3, UserId = admin.Id, ClaimType = ClaimTypes.Email, ClaimValue = admin.Email }
    );
        //configuring keys
        //modelBuilder.Entity<Appointment>().HasKey(a => new { a.DoctorId, a.Day });
        modelBuilder.Entity<Time>().
            HasMany(x => x.Bookings).
            WithOne(x => x.Time).
            HasForeignKey(x => x.BookingId);
        modelBuilder.Entity<Doctor>().Property(x=>x.Img).IsRequired();
        modelBuilder.Entity<Booking>()
            .HasOne(x => x.Patient).
            WithMany(x => x.Bookings).
            HasForeignKey(x => x.PatientId).
            OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Appointment>().
            HasIndex(a => new { a.DoctorId, a.Day }).
            IsUnique();

        // Configure many-to-many relationship
        modelBuilder.Entity<PatientCoupon>()
            .HasKey(pc => new { pc.PatientId, pc.CouponId });

        //modelBuilder.Entity<PatientCoupon>()
        //    .HasOne(pc => pc.Patient)
        //    .WithMany(p => p.PatientCoupons)
        //    .HasForeignKey(pc => pc.PatientId);

        modelBuilder.Entity<PatientCoupon>()
            .HasOne(pc => pc.Coupon)
            .WithMany(c => c.PatientCoupons)
            .HasForeignKey(pc => pc.CouponId);

        #region Seeding


        #region Specialization

        var specializations = new List<Specialization>
        {
            new Specialization
            {
                Id= Guid.NewGuid(),
                NameAr ="طب الباطنة",
                NameEn="Internal Medicine"
            },
            new Specialization
            {
                Id= Guid.NewGuid(),
                NameAr="القلب والاوعية الدموية",
                NameEn="Cardiology"
            },
            new Specialization {
                Id= Guid.NewGuid(),
                NameAr="نساء وتوليد",
                NameEn="Obstetrics and Gynecology"
            },
            new Specialization {
                Id= Guid.NewGuid(),
                NameAr="طب العيون",
                NameEn="Ophthalmology"
            },
            new Specialization
            {
                Id = Guid.NewGuid(),
                NameAr="طب اطفال",
                NameEn="Pediatrics"
            },
            new Specialization
            {
                Id= Guid.NewGuid(),
                NameAr="طب الاعصاب",
                NameEn="Neurology"
            },
            new Specialization
            {
                Id= Guid.NewGuid(),
                NameAr="طب الاورام",
                NameEn="Oncology"
            },
            new Specialization
            {
                Id=Guid.NewGuid(),
                NameAr="المسالك البولية",
                NameEn="Urology"
            },
            new Specialization
            {
                Id=Guid.NewGuid(),
                NameAr="جلدية",
                NameEn="Dermatology"
            }
        };
        #endregion
        modelBuilder.Entity<Specialization>().HasData(specializations);
        
        #endregion
    }
}
