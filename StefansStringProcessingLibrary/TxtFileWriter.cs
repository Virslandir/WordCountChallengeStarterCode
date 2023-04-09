using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefansStringProcessingLibrary
{
    public class TxtFileWriter
    {
        public void WriteResultsToTxt(string text, string path)
        {
            File.WriteAllText(path, text);           
        }
    }
}
