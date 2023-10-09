namespace CountryClubAPI.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Telephone { get; set; }
        public int? RecommendedBy { get; set; }
        public DateTime JoinDate { get; set; }
        //public string Status { get; set; }
    }
}
