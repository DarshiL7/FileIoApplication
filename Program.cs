using System;
using FileIoApplication;
namespace FileIoApplication
{
    class Program 
    {
        static void Main(string[] args)
        {
            FileOperations fileOperations = new FileOperations();
            //fileOperations.CreateFile();
            //fileOperations.DeleteFile();
            //fileOperations.ReadFile();
            //fileOperations.RenameFile();
            //fileOperations.CopyFile();
            //fileOperations.AppendFile();
            //Console.WriteLine("Hello World!");
            repeate:
            Console.WriteLine("--->>Welcome to File Operations<<---");
            Console.WriteLine("Select option from below:");
            Console.WriteLine("1.Create file:");
            Console.WriteLine("2.Delete file:");
            Console.WriteLine("3.Read file data:");
            Console.WriteLine("4.Rename file name:");
            Console.WriteLine("5.Copy file:");
            Console.WriteLine("6.Append two files:");
            Console.WriteLine("Enter any numeric key to exit:");

            int c =Int32.Parse(Console.ReadLine()) ;

            switch (c)
            {
                case 1:
                    fileOperations.CreateFile();
                    goto repeate;

                case 2:
                    fileOperations.DeleteFile();
                    goto repeate;

                case 3:
                    fileOperations.ReadFile();
                    goto repeate;

                case 4:
                    fileOperations.RenameFile();
                    goto repeate;

                case 5:
                    fileOperations.CopyFile();
                    goto repeate;

                case 6:
                    fileOperations.AppendFile();
                    goto repeate;

                default:
                    break;



            }
        
        }

         
    }
}
