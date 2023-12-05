using System.ComponentModel.DataAnnotations;

namespace App1.Data
{
    public class Budget
    {
        public Budget()
        {
            Title = "";
            Amount = 0;
            Category = "";
            DateAuthored = DateTime.Now;
          
            Description = "";

        }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }
        public DateTime DateAuthored { get; set; }
        public string Description { get; set; }


    }
}
