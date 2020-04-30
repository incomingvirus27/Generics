namespace IntergenicLibrary
{
    public class Student
    {
        public string Name{get; set;}
        public int YrOfStudy{get; set;}
        public string StuID{get; set;}

        public Student(string name, int yr, string stuID)
        {
            Name = name;
            YrOfStudy = yr;
            StuID = stuID;
        }
    }
}