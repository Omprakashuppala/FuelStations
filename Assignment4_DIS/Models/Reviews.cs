using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_DIS.Models
{
    public class ReviewRecord
    {
        [Key]
        public int Id { get; set; }
        public string FuelStation_Name { get; set; }

        public string FuelSTation_Address { get; set; }
        public string CustomerName { get; set; }
        public string Customer_Email { get; set; }
        public string Review { get; set; }

    }

    public class Reviews
    {
        public List<ReviewRecord> reviewRecords{ get; set; }
    }

}
