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
    class TextReplacer:ITextReplacer
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
        private string[] _Words;

        /// <summary>
        /// Конструктор, принимающий заданный пользователем текст в текстовое поле
        /// </summary>
        /// <param name="text">строка текста</param>
        public TextReplacer(string text)
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
            get { return _Words; }
            set { _Words = value; }
        }

        /// <summary>
        /// Печать количества повторений каждого глагола в строке текста
        /// </summary>
        public void ShowVerbsDups()
        {
            string[] verbs = new string[Words.Length];
            int k = 0;
            int count = 0;
            for (int i = 0; i < Words.Length; i++)
            {
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i].EndsWith(_endings[j]))
                    {
                        verbs[k++] = Words[i];
                        break;
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
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
        /// Метод, предлагающий пользователю самостоятельно ввести слово-замену и минимально допустимую длину слова и печатающий обработанный текст
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
        /// Метод предлагает ввести пользователю слово, которым будут заменены глаголы в тексте и печатает обработанный текст
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
        /// Метод печатает число глаголов в тексте
        /// </summary>
        public void ShowVerbsCount()
        {

            int k = 0;
            for (int i = 0; i < Words.Length; i++)
            {
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i].EndsWith(_endings[j]))
                    {
                        k++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Text contains {k} verbs");
        }

        /// <summary>
        /// Метод печатает все глаголы, содержащиеся в тексте
        /// </summary>
        public void ShowVerbs()
        {
            Console.Write("Verbs:  ");
            for (int i = 0; i < Words.Length; i++)
            {
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i] == _endings[j])
                    {
                        Console.Write($"{Words[i]}, ");
                        break;
                    }
                }
            }
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
            for (int i = 0; i < Text.Length; i++)
            {
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
            for (int i = 0; i < Words.Length; i++)
            {
                for (int j = 0; j < _endings.Length; j++)
                {
                    if (Words[i].EndsWith(_endings[j]))
                    {
                        verbs[k++] = Words[i];
                        break;
                    }
                }
            }
            for (int i = 0; i < Text.Length;)
            {
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
