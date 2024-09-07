using LearningDelegateAndEvent.Task1.GenericMethod;
using LearningDelegateAndEvent.Task2.FileLocation;

namespace LearningDelegateAndEvent
{
    internal class Program
    {
        public static void HandleCustomEvent(object sender, FileArgs a)
        {
            Console.WriteLine(a.FileName);
        }
        static void Main(string[] args)
        {
            #region Testing Task 1
            Person[] people = { new Person("asxd", 19), new Person("dfg", 34), new Person("bdf", 10) };
            try
            {
                Console.WriteLine("Max person is " +
                    ExtensionOperation.GetMax(people, (p) => p.Name.Length));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Проблема с объектом {e.ParamName}: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Проблема: {e.Message}");
            }
            #endregion //Testing Task 1

            #region Teating Task 2
            FileLocator locator = new FileLocator(HandleCustomEvent);
            locator.BrowseFileDirectory("C:\\Users\\Sony\\Desktop\\Технологии программирования\\Лекции");
            #endregion // Teating Task 2
        }
    }
}
