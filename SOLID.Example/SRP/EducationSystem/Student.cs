namespace SOLID.Example.SRP.EducationSystem
{
    /// <summary>
    /// In a university’s digital system, students are enrolled in courses, and at the end of a semester, 
    /// they receive grades for each course. The university wants to calculate each student’s GPA (Grade Point Average) 
    /// based on their grades. Additionally, the system should generate a transcript showing all courses, grades, and the calculated GPA.
    /// </summary>


    public class Student
    {
        public string Name { get; set; }
        private Dictionary<string, double> CoursesAndGrades = new Dictionary<string, double>();
        public void EnrollCourse(string courseName)
        {
            CoursesAndGrades[courseName] = 0; // default grade
        }
        public void AssignGrade(string courseName, double grade)
        {
            if (CoursesAndGrades.ContainsKey(courseName))
            {
                CoursesAndGrades[courseName] = grade;
            }
        }
        public double CalculateGPA()
        {
            // Basic GPA calculation logic
            return CoursesAndGrades.Values.Average();
        }
        public void PrintTranscript()
        {
            Console.WriteLine($"Transcript for {Name}");
            foreach (var course in CoursesAndGrades)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
            }
            Console.WriteLine($"GPA: {CalculateGPA()}");
        }
    }
}
