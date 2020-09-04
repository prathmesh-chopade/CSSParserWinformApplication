using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSParserWindowsFormsApp.Models;
using System.Text.RegularExpressions;

namespace CSSParserWindowsFormsApp.Service
{
    class CSSParser
    {
        List<SelectorProperty> list = new List<SelectorProperty>();

        // remove comments from css file
        public static string RemoveComments(string text)
        {
            string cleanText = text.Replace(" ", "");
            Regex regex = new Regex(@"\/\*(.|\n)*?\*\/");
            cleanText = regex.Replace(cleanText, "");
            return cleanText;
        }

        //parse css file and return list of objects
        public List<SelectorProperty> Parser(FileIO io)
        {
            string selector = "";
            string key = "";
            string value = "";
            string temp = "";
            int count = 0;
            FileHelper file = new FileHelper(io);
            string text = file.ReadFileAsString();
            string cleanText = RemoveComments(text);
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < cleanText.Length; i++)
            {
                if (cleanText[i] != '{' && cleanText[i] != '}' && cleanText[i] != ':' && cleanText[i] != ';')
                    temp += cleanText[i];
                if (cleanText[i] == '{')
                {
                    count++;
                    if (count > 1)
                    {
                        selector += " " + temp;
                    }
                    else
                    {
                        selector = temp;
                    }
                    st.Push(cleanText[i]);
                    temp = "";
                }
                if (cleanText[i] == ':')
                {
                    key = temp;
                    temp = "";
                }
                if (cleanText[i] == ';')
                {
                    value = temp;
                    temp = "";
                }
                if (selector != "" && key != "" && value != "")
                {
                    SelectorProperty obj = new SelectorProperty(selector, key, value);
                    list.Add(obj);
                    key = value = "";
                }
                if (cleanText[i] == '}')
                {
                    if (st.Pop() == '{' && cleanText[i] == '}')
                    {
                        count--;
                        if (count > 0)
                        {
                            int index = selector.LastIndexOf(' ');
                            selector = selector.Substring(0, index + 1).Trim();
                        }
                        else
                        {
                            selector = "";
                        }
                    }
                }
            }

            return list;
        }

        //to update selector value
        public bool UpdateSelector(string oldInput, string newInput, List<SelectorProperty> list)
        {
            bool flag = false;
            foreach (SelectorProperty obj in list)
            {
                if (obj.Selector.Contains(oldInput))
                {
                    obj.Selector = obj.Selector.Replace(oldInput, newInput);
                    flag = true;
                }
            }
            return flag;
        }

        //to update property name
        public bool UpdateProperty(string selector, string oldInput, string newInput, List<SelectorProperty> list)
        {
            bool flag = false;
            foreach (SelectorProperty obj in list)
            {
                if (obj.Selector.Equals(selector) && obj.Key.Equals(oldInput))
                {
                    obj.Key = newInput;
                    flag = true;
                }
            }
            return flag;
        }

        //to update property value
        internal bool UpdateValue(string selector, string newProperty, List<SelectorProperty> list, string newValue)
        {
            bool flag = false;
            foreach (SelectorProperty obj in list)
            {
                if (obj.Selector.Equals(selector) && obj.Key.Equals(newProperty))
                {
                    obj.ValuePair = newValue;
                    flag = true;
                }
            }
            return flag;
        }

        //to get set-> array from objects list
        public static string[] ChooseSelectorSet(List<SelectorProperty> list)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (SelectorProperty obj in list)
            {
                if(!obj.Selector.Contains(" "))
                    set.Add(obj.Selector);
            }
            string[] array = new string[set.Count];
            set.CopyTo(array);
            return array;
        }
    }
}
