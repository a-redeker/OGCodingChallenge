using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1_Wizard
{
    public class MainWindowViewModel
    {
        public virtual void buttonPress()
        {
            var x = new WizardWindow();           
            x.Show();
            
        }
    }
}
