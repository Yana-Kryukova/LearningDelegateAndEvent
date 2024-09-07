namespace LearningDelegateAndEvent.Task1.GenericMethod
{
    internal class Person(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public override string ToString()
        {
            return $"Name: {Name}, age = {Age}";
        }
    }
}
