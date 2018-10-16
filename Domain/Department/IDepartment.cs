namespace Domain
{
    public interface IDepartment
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        //string MeetingDay { get; set; }
        string ImageUrl { get; set; }
        string DepartmentLeaderName { get; set; }
        string LeaderImageUrl { get; set; }
        string LeaderImageThumbnailUrl { get; set; }
        string ImageThumbnailUrl { get; set; }
    }
}
