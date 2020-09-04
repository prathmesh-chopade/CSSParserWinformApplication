using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSParserWindowsFormsApp.Views
{
    public interface ICSSParserForm
    {
        string InputFilePathText { get; set; }
        string OutputFilePathText { get; set; }
    }
}
