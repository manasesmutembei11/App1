using System.ComponentModel.DataAnnotations;

namespace App1.Data
{
    public class Expense
    {
        public Expense()
        {
            Source = "";
            Amount = 0;
            ExpenseCategory = "";
            ExpenseDate = DateTime.Now;
            ExpenseDescription = "";
        }

        [Key]
        public int Id { get; set; }
        public string Source { get; set; }
        public int Amount { get; set; }
        public string ExpenseCategory { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string ExpenseDescription { get; set; }
    }
}
