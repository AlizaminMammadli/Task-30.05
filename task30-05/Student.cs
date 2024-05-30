
namespace task30_05
{
    public class Student
    {
        private static int _counter;
        public int Id { get; set; } 
        public string FullName { get; set; }
        public double Point { get; set; }


        static Student()

        {
            _counter = 0;
        }

        public Student()
        {
            _counter++;
            Id = _counter;
        }


        public void StudentInfo ()
        {
            Console.WriteLine($"User Id : {Id} \nFullname : {FullName} \nPoint : {Point}");
        }
       
    }
}
