using System.Collections.Generic;
using System.Linq;
using ManseBuilder.Core.Model;

namespace ManseBuilder.UI.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(List<Manse> manses)
        {
            Manses = manses;
            SelectedManse = manses.First();
        }

        public List<Manse> Manses { get; set; }
        public Manse SelectedManse { get; set; }
    }
}