using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    /// <summary>
    /// Класс, описывающий методы и поля для работы с текстом
    /// </summary>
    class TextEditor : IVerbsEditor
    {
        /// <summary>
        /// Возможные окончания глаголов
        /// </summary>
        private string[] _endings = { "сь", "ыли", "ось", "ло", "тся", "ться", "ают", "ает", "ит", "яет", "яют", "еет", "еют", "ивать" };

        /// <summary>
        /// Возвращаемое полю текста значение
        /// </summary>
        private string _text;

        /// <summary>
        /// Возвращаемое значение массиву строк
        /// </summary>
        private string[] _words;

        /// <summary>
        /// Конструктор, принимающий заданный пользователем текст в текстовое поле
        /// </summary>
        /// <param name="text">строка текста</param>
        public TextEditor(string text)
        {
            Text = text;
            Words = SplitText();
        }

        /// <summary>
        /// Текст
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value ?? throw new ArgumentNullException("Text field isn't filled in");
            }
        }

        /// <summary>
        /// Массив слов
        /// </summary>
        public string[] Words
        {
            get { return _words; }
            set { _words = value; }
        }

        // TODO: заменить на словарь 
        /// <summary>
        /// Печать количества повторений каждого глагола в исходном тексте
        /// </summary>
        public void ShowVerbsDups()
        {
            string[] verbs = new string[Words.Length];
            int k = 0;
            int count = 0;
            // Пройти по всем словам текста
            for (int i = 0; i < Words.Length; i++)
            {
                // Пройти по всем окончаниям глаголов
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i].EndsWith(_endings[j]))
                    {
                        verbs[k++] = Words[i];
                        break;
                    }
                }
            }
            // Пройти по массиву глаголов
            for (int i = 0; i < k; i++)
            {
                // Пройти по этому же массиву для выявления совпадений
                for (int j = i; j < k; j++)
                {
                    if (Words[i] == Words[j])
                        count++;
                }
                Console.WriteLine($"Verb {verbs[i]} have {count} duplications.");
                count = 0;
            }
        }

        /// <summary>
        /// Заменить в тексте слова меньше заданной длины и вывести измененный текст
        /// </summary>
        public void ShowShortWordReplacedText()
        {
            int l;
            string w;
            Console.Write("Enter the word you want to replace the short ones with: ");
            w = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter minimal acceptable word length: ");
            l = Convert.ToInt16(Console.ReadLine());
            string rext = ReplaceShortWordsInText(w, l);
            Console.WriteLine(rext);
        }

        /// <summary>
        /// Заменить в тексте глаголы и вывести измененный текст
        /// </summary>
        public void ShowVerbsReplacedText()
        {
            string w;
            Console.Write("Enter the word you want to replace verbs with: ");
            w = Console.ReadLine();
            Console.WriteLine();
            string rext = ReplaceVerbsInText(w);
            Console.WriteLine(rext);
        }

        /// <summary>
        /// Подсчёт глаголов
        /// </summary>
        /// <returns>число глаголов</returns>
        public int VerbsCount()
        {

            int k = 0;
            // Пройти по всем словам в тексте
            for (int i = 0; i < Words.Length; i++)
            {
                // Пройти по всем окончаниям глаголов
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i].EndsWith(_endings[j]))
                    {
                        k++;
                        break;
                    }
                }
            }
            return k;
        }

        /// <summary>
        /// Поиск глаголов
        /// </summary>
        /// <returns>Массив глаголов</returns>
        public string[] FindVerbs()
        {
            int k = 0;
            string[] verbs = new string[Words.Length];
            // Пройти по всем словам
            for (int i = 0; i < Words.Length; i++)
            {
                // Пройти по всем окочаниям глаголов
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i] == _endings[j])
                    {
                        verbs[k++] = Words[i];
                        break;
                    }
                }
            }
            return verbs;
        }

        /// <summary>
        /// Метод, разделяющий текст на слова и удаляющим знаки препинания и другие посторонние символы
        /// </summary>
        /// <returns>Массив слов</returns>
        private string[] SplitText()
        {
            Words = Text.Split(new char[] { '.', '!', '?', '-', ':', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Words;
        }

        /// <summary>
        /// замена слов длиной меньше той, которую задал пользователь заданным словом
        /// </summary>
        /// <param name="wordToReplaceWith">Слово, которым будут заменяться слова меньше заданной длины</param>
        /// <param name="shortWordMaxLength">Минимально допустимая длина слова</param>
        /// <returns>Строка текста с замененными словами</returns>
        private string ReplaceShortWordsInText(string wordToReplaceWith, int shortWordMaxLength)
        {
            int wordStartIndex = 0;
            StringBuilder sb = new StringBuilder(Text.Length);
            bool cycleExit = false;
            for (int i = 0; i < Text.Length;)
            {
                // Пройти по всем небуквенным значениям до первого буквенного
                while (!(char.IsLetter(Text[i])))
                {
                    i++;
                    // Проверить, не закончился ли текст
                    if (i == Text.Length)
                    {
                        cycleExit = true;
                        break;
                    }
                }
                if (cycleExit)
                    break;
                wordStartIndex = i;
                // Пройти до конца слова
                while (char.IsLetter(Text[i]))
                {
                    i++;
                    // Проверить, не закончился ли текст
                    if (i == Text.Length)
                    {
                        cycleExit = true;
                        break;
                    }
                }
                if (cycleExit)
                    break;
                var length = i - wordStartIndex;
                var word = Text.Substring(wordStartIndex, length);
                if (word.Length < shortWordMaxLength)
                    word = wordToReplaceWith;
                sb.Append(word);
                sb.Append(Text[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Метод заменяет глаголы в тексте лругим словом
        /// </summary>
        /// <param name="wordToReplaceWith">Слово, задаваемое пользователем, которым будут заменены глаголы</param>
        /// <returns>Обработанный текст</returns>
        private string ReplaceVerbsInText(string wordToReplaceWith)
        {
            StringBuilder text = new StringBuilder(Text.Length);
            string[] verbs = new string[Words.Length];
            int k = 0;
            int wordStartIndex = 0;
            bool cycleExit = false;
            // Пройти по массиву слов
            for (int i = 0; i < Words.Length; i++)
            {
                // Пройти по окончаниям глаголов 
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i].EndsWith(_endings[j]))
                    {
                        verbs[k++] = Words[i];
                        break;
                    }
                }
            }
            // Пройти по массиву символов текста
            for (int i = 0; i < Text.Length;)
            {
                // Пройти по всем небуквенным значениям до первого буквенного
                while (!(char.IsLetter(Text[i])))
                {
                    i++;
                    if (i == Text.Length)
                    {
                        cycleExit = true;
                        break;
                    }
                }
                if (cycleExit)
                    break;
                wordStartIndex = i;
                // Пройти по символам до конца слова
                while (char.IsLetter(Text[i]))
                {
                    i++;
                    if (i == Text.Length)
                    {
                        cycleExit = true;
                        break;
                    }
                }
                if (cycleExit)
                    break;
                var length = i - wordStartIndex;
                var word = Text.Substring(wordStartIndex, length);
                // Пройти по массиву глаголов на наличие совпадений
                for (int j = 0; j < k; j++)
                {
                    if (word == verbs[j])
                    {
                        word = wordToReplaceWith;
                        break;
                    }
                }
                text.Append(word);
                text.Append(Text[i]);
            }
            return text.ToString();
        }
    }
}
