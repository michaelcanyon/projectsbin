using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    interface ITextReplacer
    {
        string Text { get; set; }

        string[] Words { get; set; }
 
        void ShowShortWordReplacedText();
    }
}
