using System;

namespace Domain
{
    public class Member : Entity, IAggregateRoot, IMember
    {
      
        public string MemberName { get; set ; }
        public DateTime DateOfBirth { get; set; }
        public string MemberImageUrl { get; set; }
        public string MemeberImageThumbnailUrl { get; set; }
        public string Profession { get; set; }
        public string Married { get; set; }
        public string SpouseName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime WeddingAnniversary { get; set; }
    }
}
