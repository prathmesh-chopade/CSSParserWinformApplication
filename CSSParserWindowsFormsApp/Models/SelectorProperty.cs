using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSParserWindowsFormsApp.Models
{
    public class SelectorProperty
    {
        public SelectorProperty() { }

        public SelectorProperty(string aSelector, string aKey, string aValuePair)
        {
            selector = aSelector;
            key = aKey;
            valuePair = aValuePair;
        }

        private string selector;

        public string Selector
        {
            get { return selector; }
            set { selector = value; }
        }

        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        private string valuePair;

        public string ValuePair
        {
            get { return valuePair; }
            set { valuePair = value; }
        }

        private List<SelectorProperty> list;

        public List<SelectorProperty> List
        {
            get { return list; }
            set { list = value; }
        }

    }
}
