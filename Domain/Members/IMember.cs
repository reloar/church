using System;

namespace Domain
{
    public interface IMember
    {
        int Id { get; set; }
        string MemberName { get; set; }

        string Address { get; set; }
        string PhoneNumber { get; set; }
        DateTime DateOfBirth { get; set; }

        string MemberImageUrl { get; set; }

        string MemeberImageThumbnailUrl { get; set; }
        string Profession { get; set; }
        string Married { get; set; }
        string SpouseName { get; set; }
        DateTime WeddingAnniversary { get; set; }
    }
}
