using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1_Wizard
{
    public class WizardWindowViewModel
    {
        BackgroundWorker worker = new BackgroundWorker();
        public List<sub> myList = new List<sub>();
        public StringBuilder sb = new StringBuilder();
        public virtual bool finClicked { get; set; }
        public virtual int multiple { get; set; }
        public virtual string replace { get; set; }
        public virtual string listDisp { get; set; }
        public virtual int minCheck { get; set; } = 1;
        public virtual int maxCheck { get; set; } = 100;
        public virtual string finalDisp { get; set; }
        public virtual bool allowNext { get; set; }
        public virtual bool addClicked { get; set; }
        public virtual string theString { get; set; } = string.Empty;
        public virtual string outputString { get; set; } = string.Empty;




        public WizardWindowViewModel()
        {
            addClicked = false;
            finClicked = false;
        }

        public virtual void ListBoxPopulate()
        {
            listDisp += multiple.ToString() + "    " + replace + "\n";
            myList.Add(new sub() { multiple = multiple, replace = replace });
            addClicked = true;

           
        }

        public virtual void finBtnClicked()
        {
            finClicked = true;
            FinalBoxPopulate();
        }
        public void FinalBoxPopulate()
        {

            worker.DoWork += delegate (object s, DoWorkEventArgs args)
            {
                for (int a = minCheck; a <= maxCheck; a++)
                {
                    var processed = false;
                    foreach (var something in myList)
                    {
                        if (a % something.multiple == 0)
                        {
                            processed = true;
                            sb.Append( something.replace + " ");
                        }

                    }
                    if (processed)
                        sb.Append( "\n");
                    else
                        sb.Append( a.ToString() + "\n");

                    theString = sb.ToString();
                }
            };


        worker.RunWorkerAsync();

           
        }
        
    }
}
