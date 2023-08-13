namespace StudentDetails.Global_Exception
{
    public class StudentDetailsExceptions:Exception
    {

        public static List<string> ExceptionMessages { get;}=
            new List<string>
            {
                "Student Not Found"
            };
    }
}
