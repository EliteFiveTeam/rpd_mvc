using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPD.Data;
using RPD.Data.Model;
using RPD.View;
using excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word; 

namespace RPD.Controller
{
    public class AnalisysWordController
    {
        private IAnalysisWordForm _view;
        private word.Application WordApp;
        public AnalisysWordController(IAnalysisWordForm view)
        {
            _view = view;
            WordApp = new word.Application();
        }

    }
}
