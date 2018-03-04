using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P04Files
{
    class File
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string FullFileName { get; set; }
        public BigInteger FileSize { get; set; }

        public File(string fileName, string extension, string fullFileName, BigInteger fileSize)
        {
            FileName = fileName;
            Extension = extension;
            FullFileName = fullFileName;
            FileSize = fileSize;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<File>> rootFile = new Dictionary<string, List<File>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] fileInfo = input.Split(new char[] { '\\', ';', '.' }, StringSplitOptions.RemoveEmptyEntries); //potencialno tuk e problemut
                string root = fileInfo[0];
                string fileName = fileInfo[fileInfo.Length - 3];
                string fileExtension = fileInfo[fileInfo.Length - 2];
                BigInteger fileSize = BigInteger.Parse(fileInfo[fileInfo.Length - 1]);
                string fullFileName = fileName + '.' + fileExtension;
                File currentFile = new File(fileName, fileExtension, fullFileName, fileSize);

                if (!rootFile.ContainsKey(root)) // ako nqma takava direktoriq
                {
                    List<File> fileList = new List<File>();
                    fileList.Add(currentFile);
                    rootFile.Add(root, fileList);
                }
                else //ako veche sushtesvuva taka direktoriq
                {
                    if (FileNameIndex(fullFileName, rootFile[root]) == -1) // ako ne sushtesvuva takuv fail v direktoriqta
                    {
                        rootFile[root].Add(currentFile);
                    }
                    else
                    {
                        int index = FileNameIndex(fullFileName, rootFile[root]); 
                        rootFile[root][index] = currentFile; // prezapisvane
                    }
                }

            }

            string[] printInformation = Console.ReadLine().Split();

            string extension = printInformation[0];
            string directory = printInformation[2];

            if (!rootFile.ContainsKey(directory))
            {
                Console.WriteLine("No");
                return;
            }

            List<File> specificExtensionList = new List<File>();
            for (int i = 0; i < rootFile[directory].Count; i++)
            {
                if (rootFile[directory][i].Extension == extension)
                {
                    specificExtensionList.Add(rootFile[directory][i]);
                }
            }

            if (specificExtensionList.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (File file in specificExtensionList.OrderByDescending(size => size.FileSize).ThenBy(name => name.FileName))
            {
                Console.WriteLine($"{file.FullFileName} - {file.FileSize} KB ");
            }
            //main ends here
        }

        static int FileNameIndex(string fullFileName, List<File> listOfFiles)
        {
            for (int i = 0; i < listOfFiles.Count; i++)
            {
                if (listOfFiles[i].FullFileName == fullFileName)
                {
                    return i;
                }
            }
            return -1;
        }

        //class ends here
    }
}
