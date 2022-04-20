using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string sex { get; set; }

        [DataType(DataType.Date)]
        public DateTime BrithDate { get; set; }

        public int age{ get; set; }
        
        public string phonex { get; set; }

        public int t { get; set; }

        [DataType(DataType.Date)]
        public DateTime writeDate { get; set; }
    }
}
