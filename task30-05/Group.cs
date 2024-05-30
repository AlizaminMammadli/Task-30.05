

namespace task30_05
{
    public class Group
    {

        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }

        private Student[] students { get; set; }


        public Group (string groupNo, int studentLimit)
        {
            if (CheckGroupNo(groupNo))
            {
                GroupNo = groupNo;
            }
            if (studentLimit < 5 || studentLimit > 18)
            {
                StudentLimit = studentLimit;
                students = new Student[studentLimit];
            }
        }


        public bool CheckGroupNo (string groupNo)
        {
            if (!string.IsNullOrEmpty(groupNo) && !string.IsNullOrWhiteSpace(groupNo))
                if (groupNo.Length == 5)
                    if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
                        if (groupNo.Substring(2).All(char.IsDigit))
                            return true;
            return false;
        }

        public void AddStudent ( Student student) 
        {
            if (students.Length >= StudentLimit)
            {
                Console.WriteLine();
            }
        }


    }
}
