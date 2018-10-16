using System;

namespace Domain
{
    public class Worker : Entity, IAggregateRoot, IWorker
    {

        public string WorkerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public string BaptismDate { get; set; }
        public string JoinDate { get; set; }

        public string HolyGhostBaptism { get; set; }

        public string WaterBaptism { get; set; }
        public string Experience { get; set; }
        public string IsMarried { get; set; }
        public string FileUrl { get; set; }
        public string FilethunmbnailUrl { get; set; }

        public string IsExperienced {get;set;}

        public string SpouseName { get; set; }
        public string NumberOfChildren { get; set; }
        public DateTime MarriageAnniversary { get; set; }
        public string Profession { get; set; }
        public string ChurchBaptised { get; set; }
        public string BornAgain { get; set; }
        public string YearBornAgain { get; set; }
    }
}
