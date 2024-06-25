namespace SOLID.Example.SRP.EducationSystem
{
    /// <summary>
    /// In a university’s digital system, students are enrolled in courses, and at the end of a semester, 
    /// they receive grades for each course. The university wants to calculate each student’s GPA (Grade Point Average) 
    /// based on their grades. Additionally, the system should generate a transcript showing all courses, grades, and the calculated GPA.

    /// Refactor
    /// The student manages course enrollments and grade assignments.
    /// GPACalculator calculates the GPA for a student.
    /// TranscriptGenerator creates and prints the student’s transcript.

    /// </summary>
    public class StudentRefactor
    {
        public string Name { get; set; }
        public Dictionary<string, double> CoursesAndGrades = new Dictionary<string, double>();
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
    }
    public class GPACalculator
    {
        public double CalculateGPA(StudentRefactor student)
        {
            // Basic GPA calculation logic
            return student.CoursesAndGrades.Values.Average();
        }
    }
    public class TranscriptGenerator
    {
        private GPACalculator _gpaCalculator;
        public TranscriptGenerator(GPACalculator gpaCalculator)
        {
            _gpaCalculator = gpaCalculator;
        }
        public void PrintTranscript(StudentRefactor student)
        {
            Console.WriteLine($"Transcript for {student.Name}");
            foreach (var course in student.CoursesAndGrades)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
            }
            Console.WriteLine($"GPA: {_gpaCalculator.CalculateGPA(student)}");
        }
    }
}
