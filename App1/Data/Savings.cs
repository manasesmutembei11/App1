using System.ComponentModel.DataAnnotations;

namespace App1.Data
{
    public class Savings
    {
        public Savings()
        {
            GoalName = "";
            TargetAmount = 0;
            CurrentAmount = 0;
            TargetDate = DateTime.Now;
            SavingDescription = "";
        }

        [Key]
        public int Id { get; set; }
        public string GoalName { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }

        public string SavingDescription { get; set; }
    }
}
