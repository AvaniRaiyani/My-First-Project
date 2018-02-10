using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvanisHerbalSalon.Data;


namespace AvanisHerbalSalon.Models
{
    public class EFRepository : IDisposable, IRepository
    {
        private ApplicationDbContext _db;
        public EFRepository(ApplicationDbContext db)
        { this._db = db;
        }
        public IList<Appointment> ListAppointments()
        {
            return _db.Appointments.ToList();
        }
        public Appointment FindAppointment(int id)
        {
            return _db.Appointments.FirstOrDefault(a => a.Id == id);
        }
        public void CreateAppointment(Appointment appointmentToCreate)
        {
            _db.Appointments.Add(appointmentToCreate);
            _db.SaveChanges();
        }

        public void UpdateAppointment(Appointment appointmentToUpdate)
        {
            var originalAppointment = this.FindAppointment(appointmentToUpdate.Id);
            originalAppointment.Email = appointmentToUpdate.Email;
            originalAppointment.ConfirmEmail = appointmentToUpdate.ConfirmEmail;
            originalAppointment.Password = appointmentToUpdate.Password;
            originalAppointment.ConfirmPassword = appointmentToUpdate.ConfirmPassword;
            originalAppointment.BirthDate = appointmentToUpdate.BirthDate;
            originalAppointment.FirstName = appointmentToUpdate.FirstName;
            originalAppointment.LastName = appointmentToUpdate.LastName;
            originalAppointment.Address1 = appointmentToUpdate.Address1;
            originalAppointment.Address2 = appointmentToUpdate.Address2;
            originalAppointment.City = appointmentToUpdate.City;
            originalAppointment.State = appointmentToUpdate.State;
            originalAppointment.ZipCode = appointmentToUpdate.ZipCode;
            originalAppointment.PhoneNumber = appointmentToUpdate.PhoneNumber;
            _db.SaveChanges();
        }

        public void DeleteAppointment(int id)
        {
            var originalAppointment = this.FindAppointment(id);
            _db.Appointments.Remove(originalAppointment);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void UpdatetoAppointment(Appointment appointmentToUpdate)
        {
            throw new NotImplementedException();
        }
    }
    }

