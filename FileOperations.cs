using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIoApplication
{
    public class FileOperations
    {
        //string path = @"E:\kansa\visual studio projects\FileIoApplication\FIOFiles";
        public void CreateFile()
        {
            Console.WriteLine("Enter File name to Create new one");
            string Fname = Console.ReadLine();

            string path = @"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + Fname + ".txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Enter text into file:");
                string Text = Console.ReadLine();
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.Write(Text);
                    Console.WriteLine("Your file name " + Fname + " Created Succesfully");
                }

            }
            else
            {
                Console.WriteLine("!!File exist create different name file!!");
            }
        }

        public void DeleteFile()
        {
            string[] files = Directory.GetFiles(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\");
            foreach (string f in files)
            {
                Console.WriteLine(f.ToString());
            }
            Console.WriteLine("Enter Name of the file from above list to delete:");
            string DeleteName = Console.ReadLine();

            foreach (string d in files)
            {
                if (d.Equals(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + DeleteName + ".txt"))
                {
                    File.Delete(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + DeleteName + ".txt");
                    Console.WriteLine("Your file Deleted Succesfully");
                }
            }
        }

        public void ReadFile()
        {
            string[] Rfiles = Directory.GetFiles(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\");
            foreach (string r in Rfiles)
            {
                Console.WriteLine(r.ToString());
            }
            Console.WriteLine("Enter File name from above List to read it:");
            string selectF = Console.ReadLine();
            foreach (string g in Rfiles)
            {
                if (g.Equals(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + selectF + ".txt"))
                {
                    Console.WriteLine("Your text are:");
                    string readText = File.ReadAllText(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + selectF + ".txt");
                    Console.WriteLine(readText);
                }
            }
        }

        public void RenameFile()
        {
            string[] Rnfiles = Directory.GetFiles(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\");
            foreach (string rn in Rnfiles)
            {
                Console.WriteLine(rn.ToString());
            }

            Console.WriteLine("Enter File name from above given list to Rename the file name:");
            string oldFile = Console.ReadLine();

            foreach (string x in Rnfiles)
            {
                if (x.Equals(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + oldFile + ".txt"))
                {
                    //Console.WriteLine(x);
                    Console.WriteLine("Enter new name for the file of oldName is: " + oldFile + ".txt");
                    string newFile = Console.ReadLine();
                    try
                    {
                        File.Move(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + oldFile + ".txt", @"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + newFile + ".txt");
                        Console.WriteLine("File Renamed succesfully");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }

        public void CopyFile()
        {
            string[] cfiles = Directory.GetFiles(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\");
            foreach (string c in cfiles)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("Enter file from above list to copy:");
            string copy = Console.ReadLine();
            Console.WriteLine("Your selected file is " + copy + ".txt");



            try
            {
                Console.WriteLine("Enter new file name:");
                string newf = Console.ReadLine();
                File.Copy(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + copy + ".txt", @"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + newf + ".txt");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void AppendFile()
        {
            Console.WriteLine("Enter File name to Create new one");
            string Fname = Console.ReadLine();
            string path = @"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + Fname + ".txt";
            try
            {




                if (!File.Exists(path))
                {

                    using (StreamWriter streamWriter = File.CreateText(path))
                    {

                        Console.WriteLine("Your file name " + Fname + " Created Succesfully");
                    }

                }
                else
                {
                    Console.WriteLine("!!File exist create different name file!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            string[] afiles = Directory.GetFiles(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\");
            foreach (string a in afiles)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine("Select two files from above list:");
            string as1 = Console.ReadLine();
            string as2 = Console.ReadLine();
            string temp1 = File.ReadAllText(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + as1 + ".txt");
            string temp2 = File.ReadAllText(@"E:\kansa\visual studio projects\FileIoApplication\FIOFiles\" + as2 + ".txt");
            File.AppendAllText(path, temp1);
            File.AppendAllText(path, "");
            File.AppendAllText(path, temp2);




        }
    }
}
