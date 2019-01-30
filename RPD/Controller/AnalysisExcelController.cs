using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPD.Data;
using RPD.Data.Model;
using RPD.View;

namespace RPD.Controller
{
    public class AnalysisExcelController
    {
        private IAnalysisExcelForm _view;
        public AnalysisExcelController(AnalysisExcelForm view)
        {
            _view = view;
            _view.SetController(this);
        }
    }
}
