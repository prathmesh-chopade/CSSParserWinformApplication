using System;
using System.Collections.Generic;
using CSSParserWindowsFormsApp.Views;
using CSSParserWindowsFormsApp.Models;
using CSSParserWindowsFormsApp.Service;

namespace CSSParserWindowsFormsApp.Presenters
{
    class ShowAndUpdatePresenter
    {
        readonly IShowAndUpdateForm showAndUpdateForm;
        
        public ShowAndUpdatePresenter(IShowAndUpdateForm view)
        {
            showAndUpdateForm = view;
        }

        public ShowAndUpdatePresenter() { }

        CSSParser cSSParser = new CSSParser();

        public string[] ChooseSelectorSet(SelectorProperty obj)
        {
            string[] array = CSSParser.ChooseSelectorSet(obj.List);
            return array;
        }

        public bool CreateAndWriteFile(List<SelectorProperty> list, FileIO io)
        {
            bool flag = false;
            FileHelper fileHelper = new FileHelper(io);
            if (fileHelper.CreateAndWriteFile(list))
                flag = true;
            return flag;
        }

        public bool UpdateSelector(string oldInput, string newInput, List<SelectorProperty> list)
        {
            bool flag = false;
            flag = cSSParser.UpdateSelector(oldInput, newInput, list);
            return flag;
        }

        public bool UpdateKeyAndValue(string selector, List<SelectorProperty> list, string oldProperty, string newProperty, string newValue)
        {
            bool flag = false;
            flag = (cSSParser.UpdateProperty(selector,oldProperty,newProperty,list) && cSSParser.UpdateValue(selector,newProperty,list,newValue));
            return flag;
        }
    }
}
