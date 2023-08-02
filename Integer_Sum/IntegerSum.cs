using System.ComponentModel.DataAnnotations;

namespace Integer_Sum
{
    public class IntegerSum
    {
        [Key]
        public int Id { get; set; }
        public int IntegersSum { get; set; }
    }
}   
