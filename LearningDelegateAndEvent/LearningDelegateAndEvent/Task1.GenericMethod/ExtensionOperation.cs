namespace LearningDelegateAndEvent.Task1.GenericMethod
{
    #region Задача 1
    // Написать обобщённую функцию расширения,
    // находящую и возвращающую максимальный элемент коллекции.

    //Функция должна принимать на вход делегат,
    //преобразующий входной тип в число для возможности поиска максимального значения.
    #endregion
    public static class ExtensionOperation
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection), "Коллекция равна null");
            if (!collection.Any())
                throw new ArgumentException("Коллекция не содержит ни одного элемента", nameof(collection));


            T max = collection.First();
            float maxConvertToNumber = convertToNumber(max);
            foreach (T elem in collection)
            {
                float elemConvertToNumber = convertToNumber(elem);
                if (elemConvertToNumber > maxConvertToNumber)
                {
                    max = elem;
                    maxConvertToNumber = elemConvertToNumber;
                }
            }
            return max;

        }

    }
}
