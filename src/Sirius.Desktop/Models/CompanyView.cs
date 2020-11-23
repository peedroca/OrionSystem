namespace Sirius.Desktop.Models
{
    public class CompanyView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool Inactive { get; set; }
        public bool Blocked { get; set; }
    }
}
