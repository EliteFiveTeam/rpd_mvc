using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPD.Controller;
using RPD.Data.Model;

namespace RPD.View
{
    public interface IAnalysisExcelForm
    {
        void SetController(AnalysisExcelController controller);
        void ShowError(String message);
        void ShowLogs(String text, Color color);
        void ShowProgressBar(int Max, int Value);
    }
}
