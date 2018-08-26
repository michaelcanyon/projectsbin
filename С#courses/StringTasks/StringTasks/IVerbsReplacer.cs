using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    interface IVerbsReplacer:ITextReplacer
    {
        void ShowVerbsDups();

        int VerbsCount();

        string[] FindVerbs();

        void ShowVerbsReplacedText();
    }
}
