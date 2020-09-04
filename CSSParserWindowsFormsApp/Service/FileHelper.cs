using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSSParserWindowsFormsApp.Models;

namespace CSSParserWindowsFormsApp.Service
{
    class FileHelper
    {
        FileIO io;

        public FileHelper(FileIO value)
        {
            io = value; 
        }

        // to read file and return one string string
        public string ReadFileAsString()
        {
            string text = "";
            try
            {
                string ln = "";
                using (StreamReader file = new StreamReader(io.InputFilePath))
                {
                    while ((ln = file.ReadLine()) != null)
                    {
                        text += ln;
                    }
                    file.Close();
                }
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while reading file. " + e.Message);
                return "";
            }
        }

        // to write css file using list of objects
        public bool CreateAndWriteFile(List<SelectorProperty> list)
        {
            bool flag = true;
            try
            {
                if(File.Exists(io.OutputFilePath))
                    File.Delete(io.OutputFilePath);
                FileStream fs1 = new FileStream(io.OutputFilePath+"\\output.css", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs1);
                List<SelectorProperty> printlist = list;
                HashSet<string> set = new HashSet<string>();
                foreach (SelectorProperty obj in list)
                {
                    set.Add(obj.Selector);
                }
                foreach (string selector in set)
                {
                    writer.Write(selector + " {\n");
                    for (int j = 0; j < printlist.Count; j++)
                    {
                        if (selector == printlist[j].Selector)
                        {
                            writer.Write("  " + printlist[j].Key + " : " + printlist[j].ValuePair + ";\n");
                        }
                    }
                    writer.Write(" }\n\n");
                }
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return flag;
        }
    }
}
