namespace Domain.Requests
{
    public class FindAllProducts
    {
        public bool OrderByName { get; set; }
        public bool NameAscending { get; set; }
        public bool OrderByDescription { get; set; }
        public bool DescriptionAscending { get; set; }
    }
}
