using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    interface ITextEditor
    {
        /// <summary>
        /// Текст
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Текст в формате массива подстрок
        /// </summary>
        string[] Words { get; set; }

        /// <summary>
        /// Печать текста с замененными короткими словами
        /// </summary>
        void ShowShortWordReplacedText();
    }
}
