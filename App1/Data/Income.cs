using System.ComponentModel.DataAnnotations;

namespace App1.Data
{
    public class Income
    {
        public Income()
        {
            Source = "";
            Amount = 0;
            IncomeCategory = "";
            IncomeDate = DateTime.Now;
            IncomeDescription = "";
        }

        [Key]
        public int Id { get; set; }
        public string Source { get; set; }
        public int Amount { get; set; }
        public string IncomeCategory { get; set; }
        public DateTime IncomeDate { get; set; }
        public string IncomeDescription { get; set; }

    }
}
