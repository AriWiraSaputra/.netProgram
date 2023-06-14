namespace project_wira.Models
{
    public class Agen
    {
        public long ID { get; set; }
        public DateTime RegDate { get; set; }
        public string? RegStatus { get; set; }

        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? IdCard { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }
    }

}
