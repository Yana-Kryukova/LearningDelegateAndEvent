namespace LearningDelegateAndEvent.Task2.FileLocation;

#region Задача 2
// Написать класс, обходящий каталог файлов и выдающий событие при нахождении каждого файла;
// Оформить событие и его аргументы с использованием.NET соглашений:
// public event EventHandler FileFound; FileArgs – будет содержать имя файла и наследоваться от EventArgs
// Добавить возможность отмены дальнейшего поиска из обработчика;
#endregion
internal class FileLocator
{
    public FileLocator(EventHandler<FileArgs> fileFound)
    {
        FileFound += fileFound;
    }
    

    // Declare the event.
    public event EventHandler<FileArgs> FileFound;

    // Wrap the event in a protected virtual method
    // to enable derived classes to raise the event.
    protected virtual void OnFileFound(FileArgs e)
    {
        // Raise the event in a thread-safe manner using the ?. operator.
        FileFound?.Invoke(this, e);
    }
    public void BrowseFileDirectory(string path)
    {
        if (!Directory.Exists(path))
            throw new ArgumentException($"Каталог по указанному пути {path} не существует");
        string[] files = Directory.GetFiles(path);
        foreach (string s in files)
        {
            OnFileFound(new FileArgs(s));
        }
    }
}
