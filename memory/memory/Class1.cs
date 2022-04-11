using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory
{
    internal class Class1
    {
        public void write_to_file (String text, int level)
        {
            File.WriteAllText(@"C:\Users\Justyna\source\repos\memory\memory\Rang_hard.txt", string.Empty);
            switch (level){
                case 0:
                    File.WriteAllText("Range_easy.txt", text); break;
                case 1:
                    File.WriteAllText("Range_normal.txt", text); break;
                case 2:
                    File.WriteAllText(@"C:\Users\Justyna\source\repos\memory\memory\Rang_hard.txt", text); ; break;
                    
            }
            
        }

        public string read_from_file(int level)
        {
            int counter = 0;
            string text = null;

            switch (level)
            {
                case 0:
                    foreach (string line in File.ReadLines(@"Rang_easy.txt"))
                    {
                        text = text + (line + '\n');
                        counter++;
                    }
                    return text;
                case 1:
                    foreach (string line in File.ReadLines(@"Rang_normal.txt"))
                    {
                        text = text + (line + '\n');
                        counter++;
                    }
                    return text;
                case 2:
                    foreach (string line in File.ReadLines(@"C:\Users\Justyna\source\repos\memory\memory\Rang_hard.txt"))
                    {
                        text = text + (line + '\n');
                        counter++;
                    }
                    return text;
            }

            return null;

            
        }
    }
}
