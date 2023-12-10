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

    //ctor for recerving options [generic if we are using A multi-tenant application ]
    private readonly UserManager<ApplicationUser> _manager;
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
            UserName = "admin",
        };
        admin.PasswordHash = hasher.HashPassword(admin, "Admin@123");
        modelBuilder.Entity<ApplicationUser>().HasData(admin);
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
