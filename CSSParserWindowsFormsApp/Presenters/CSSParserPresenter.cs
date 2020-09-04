using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSParserWindowsFormsApp.Views;
using CSSParserWindowsFormsApp.Models;
using CSSParserWindowsFormsApp.Service;
using System.Resources;
using System.Reflection;

namespace CSSParserWindowsFormsApp.Presenters
{
    class CSSParserPresenter
    {
        ICSSParserForm cssParserView;

        public CSSParserPresenter(ICSSParserForm view)
        {
            cssParserView = view;
        }

        public List<SelectorProperty> Parser()
        {
            FileIO io = new FileIO();
            SelectorProperty selectorProperty = new SelectorProperty();
            CSSParser cSSParser = new CSSParser();
            /*ResourceManager reader = new ResourceManager(typeof(CSSParserWindowsFormsApp.Properties.Resources));
            Console.Out.WriteLine(reader.GetString("inputFilePath"));*/
            io.InputFilePath = cssParserView.InputFilePathText;
            io.OutputFilePath = cssParserView.OutputFilePathText;
            return cSSParser.Parser(io);
        }

    }
}
