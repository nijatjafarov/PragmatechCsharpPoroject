using System;
using System.IO;
using System.Text;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CSharpGroup3";
            Directory.CreateDirectory(path);
            using (File.Create(path + @"\CSharpGroup3.txt")) { }

            if (Directory.Exists(path + @"\SubFolderCSharpGroup3"))
            {
                Console.WriteLine("There is such a directory");
            }
            else
            {
                Directory.CreateDirectory(path + @"\SubFolderCSharpGroup3");
            }

            string subPath = path + @"\SubFolderCSharpGroup3";

            using (File.Create(subPath + @"\testExcelFile.xlsx")) { }
            using (File.Create(subPath + @"\testWordFile.docx")) { }

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                if (file.Split('.')[1] == "txt")
                {
                    FileStream strm = File.Open(file, FileMode.Create);
                    string text = "This is test string for txt file";
                    byte[] bytesOfText = Encoding.Default.GetBytes(text);
                    strm.Write(bytesOfText, 0, bytesOfText.Length);
                    strm.Position = 0;
                    strm.Close();

                    StreamReader sr = File.OpenText(file);
                    Console.Write(sr.ReadToEnd());
                    sr.Close();
                }
                else if (file.Split('.')[1] == "docx")
                {
                    StreamWriter sw = File.CreateText(file);
                    sw.WriteLine("This is test string for docx file");
                    sw.Close();

                    StreamReader sr = File.OpenText(file);
                    Console.Write(" " + sr.ReadToEnd());
                    sr.Close();
                }
            }
        }
    }
}
