using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise
{

    public class FileUtility : IFileUtility
    {
        // Make sure the class impliments IFileUtility

        // Add a private string field called _filePath
        private string _filePath;

        // Add a constructor that takes a string parameter called path
        public FileUtility(string path)
        {
            // Set your private field to the path passed in
            _filePath = path;

        }
        public string ReadFromFile()
        {
            // Add a string variable called fileContents
            string fileContents;
            // Add a using statement

            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                fileContents = streamReader.ReadToEnd();
            }
            return fileContents;
            // Inside of the using statment, create a StreamReader.  The stream read constructor will take the path property

            // Set the fileContents variable to the file using stream readers 'ReadToEnd' method

            // Return the fileContents
        }

        public void WriteToFile(string value)
        {
            // Add a using statement
            // Inside of the using, create a new StreamWriter.  The stream writer's constructor take the private file path field
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.Write(value);
            }
            // Write the value parameter to the file using the writer's 'Write' method
        }
    }
}