using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    interface IVerbsEditor : ITextEditor
    {
        /// <summary>
        /// Печать количества повторений каждого глагола
        /// </summary>
        void ShowVerbsDups();

        /// <summary>
        /// Подсчёт числа глаголов в тексте
        /// </summary>
        /// <returns>Число глаголов</returns>
        int VerbsCount();

        /// <summary>
        /// Поиск глаголов
        /// </summary>
        /// <returns>Массив глаголов</returns>
        string[] FindVerbs();

        /// <summary>
        /// Печать текста с замененными глаголами
        /// </summary>
        void ShowVerbsReplacedText();
    }
}
