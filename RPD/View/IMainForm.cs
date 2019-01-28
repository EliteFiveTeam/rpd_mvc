using System.Collections.Generic;
using RPD.Controller;
using RPD.Data.Model;

namespace RPD.View
{
    public interface IMainForm
    {
        void ShowProfiles(List<EducationalProfile> profiles);
        void ShowDisciplines(List<Discipline> disciplines);
        void SetController(MainController controller);
    }
}
