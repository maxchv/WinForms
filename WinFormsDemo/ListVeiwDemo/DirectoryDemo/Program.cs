using System;
using System.IO;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\");
            Console.WriteLine("Directories");
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                Console.WriteLine($"{d.Name} {d.CreationTime} {d.Extension}");
            }
            Console.WriteLine();
            Console.WriteLine("Files");
            foreach (FileInfo f in di.GetFiles())
            {
                Console.WriteLine($"{f.Name} {f.CreationTime} {f.Extension}");
            }
            Console.WriteLine();
            Console.WriteLine("All file sistem entities");
            foreach (FileSystemInfo fsi in di.GetFileSystemInfos())
            {
                var type = Directory.Exists(fsi.FullName) ? "DIR" : "File";
                Console.WriteLine($"{fsi.Name} [{type}] {fsi.CreationTime} {fsi.Extension}");
            }
        }
    }
}
