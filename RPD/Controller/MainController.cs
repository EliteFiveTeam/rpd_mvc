using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPD.Data;
using RPD.Data.Model;
using RPD.View;

namespace RPD.Controller
{
    public class MainController
    {
        IMainForm _view;
        private List<ProfileEducational> _profiles;

    public MainController(IMainForm view)
    {
       _view = view;
       _profiles = DataRepository.getInstance().GetProfileNameAndYear();
       view.SetController(this);
    }

    public void getProfiles(){
        _view.ShowProfiles(_profiles);
    }

    public void getDiscipline(int position)
    {
        _view.ShowDisciplines(DataRepository.getInstance().GetDiscipline(_profiles[position]));
    }

    }
}
