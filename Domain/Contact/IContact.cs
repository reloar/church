namespace Domain
{
    public interface IContact
    {
         int Id { get; set; }
         string FromEmail { get; set; }
         string Body { get; set; }
         string FullName { get; set; }
         string PhoneNumber { get; set; }
         string To { get; set; }
         string Subject { get; set; }
    }
}