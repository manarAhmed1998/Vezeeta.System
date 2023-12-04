using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class VezeetaContext:IdentityDbContext<ApplicationUser>
{
    public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Specialization> Specializations =>Set<Specialization>();
    public DbSet<Appointment> Appointments =>Set<Appointment>();
    public DbSet<Time>Times =>Set<Time>();
    public DbSet<Booking> Bookings =>Set<Booking>();

    //ctor for recerving options [generic if we are using A multi-tenant application ]
    public VezeetaContext(DbContextOptions<VezeetaContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //adding to the orginal code
        base.OnModelCreating(modelBuilder);

        //configuring keys
        modelBuilder.Entity<Appointment>().HasKey(a => new { a.DoctorId, a.Day });

        //modelBuilder.Entity<ApplicationUser>().
        //    HasOne(a => a.Doctor)
        //    .WithOne(d => d.ApplicationUser)
        //    .HasForeignKey<Doctor>(d => d.ApplicationUserId);

        //modelBuilder.Entity<ApplicationUser>().
        // HasOne(a => a.Patient)
        // .WithOne(p => p.ApplicationUser)
        // .HasForeignKey<Patient>(p => p.ApplicationUserId);


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

        modelBuilder.Entity<Doctor>().HasData(specializations);
        #endregion
    }
}
