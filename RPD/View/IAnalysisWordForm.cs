using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using RPD.Controller;
using RPD.Data.Model;

namespace RPD.View
{
    public interface IAnalysisWordForm
    {
        void SetController(AnalisysWordController controller);
        void pasteLiteraBasic();
        void pasteLiteraAdd();
        void ShowLogs(String text, Color color);
        void pasteUMO();
        void pasteForExam();
        void ClearWordForm();
    }
}
