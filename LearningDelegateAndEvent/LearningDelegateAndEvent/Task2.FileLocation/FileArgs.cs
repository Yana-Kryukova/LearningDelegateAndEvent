using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDelegateAndEvent.Task2.FileLocation
{
    internal class FileArgs(string fileName) : EventArgs
    {
        public string FileName { get; } = fileName;
    }
}
