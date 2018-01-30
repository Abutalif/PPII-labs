using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Far_Manager
{
    class Program
    {
        
        public static void OpenFolder (DirectoryInfo current, int cursor)
        {
            FileSystemInfo[] folders = current.GetDirectories();
            FileSystemInfo[] files = current.GetFiles();

            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i<folders.Length; i++)
            {
                if(cursor==i)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(folders[i].Name);

            }
            for(int i = 0; i<files.Length; i++)
            {
                if(cursor == i + folders.Length)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(files[i].Name);

            }
            
        }

        /*public static void Controls(int pos)
        {

            ConsoleKeyInfo pressed = Console.ReadKey();
            
            switch(pressed.Key)
            {
                case ConsoleKey.UpArrow:
                    pos--;
                    break;
                case ConsoleKey.DownArrow:
                    pos++;
                    break;
                case ConsoleKey.Enter:

                    break;
                case ConsoleKey.Escape:

                    break;
                case ConsoleKey.Q:

                    break;

            }
        }*/

        public static void Main(String[] args)
        {

            Console.CursorVisible = false;
            int cursor = 0;
            bool is_on = true;

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop\user files\КБТУ");

            while (is_on)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                OpenFolder(dir, cursor);
                // Controls(cursor);

                ConsoleKeyInfo pressed = Console.ReadKey();

                switch (pressed.Key)
                {
                    case ConsoleKey.UpArrow:
                        cursor--;
                        if (cursor < 0)
                        {
                            cursor = dir.GetFileSystemInfos().Length - 1;
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (cursor == dir.GetFileSystemInfos().Length - 2)
                            Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.DownArrow:
                        cursor++;
                        if (cursor > dir.GetFileSystemInfos().Length - 1)
                        {
                            cursor = 0;
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo newdir = dir.GetFileSystemInfos()[cursor];
                        if (newdir.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(newdir.FullName);
                        }
                        else if(Path.GetExtension(newdir.Name) == ".txt")    
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            FileStream fs = new FileStream(newdir.FullName, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);
                            string text = sr.ReadToEnd();
                            Console.Clear();
                            Console.WriteLine(text);
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                    case ConsoleKey.Q:
                        is_on = false;
                        break;

                }
            }

        }
    }
}
