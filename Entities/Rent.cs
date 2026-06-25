namespace CrystalPalace.Entities
{
    public class Rent
    {
        public Guid Id { get; private set; }
        public Guid TenantId { get; private set; }
        public Guid ApartmentId { get; private set; }
        public decimal Payment { get; private set; }
        public DateTime DateRented { get; private set; }
        public DateTime DueDate { get; private set; }

        public Rent(Guid tenantId, Guid apartmentId, decimal payment, DateTime dateRented, DateTime dueDate)
        {
            Id = Guid.NewGuid();
            TenantId = tenantId;
            ApartmentId = apartmentId;
            Payment = payment;
            DateRented = dateRented;
            DueDate = dueDate;
        }
    }
}