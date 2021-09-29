using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor 
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var flie = new StringBuilder();

            do {
                flie.Append(Console.ReadLine());
                flie.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja salvar o arquivo?");
            Viewer.Show(flie.ToString());
        }
    }
}