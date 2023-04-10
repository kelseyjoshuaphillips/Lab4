using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Subscription
    {
        [Display(Name = "Subscription ID")]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ICollection<Client> Client { get; set; }
        public string NewsBoardId { get; set; }
        public ICollection<NewsBoard> NewsBoard { get; set; }
    


    }
}
