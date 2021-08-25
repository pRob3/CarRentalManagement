using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string TaxId { get; set; }
        public string Adress { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAdress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}