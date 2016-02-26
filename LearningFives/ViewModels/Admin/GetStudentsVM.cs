namespace ViewModels.Admin
{
    public class GetStudentsVM
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int StudentStatus { get; set; }
        public string Server { get; set; }
        public string RankTier { get; set; }
    }
}