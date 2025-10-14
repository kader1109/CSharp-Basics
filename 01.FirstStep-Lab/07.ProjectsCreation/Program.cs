namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int hourForProjects = projectsCount * 3;

            Console.WriteLine($"The architect {architectName} will need {hourForProjects} hours to complete {projectsCount} project/s.");

        }
    }
}
