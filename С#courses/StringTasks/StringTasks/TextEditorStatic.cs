using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    // TODO: написать статический класс, который выполняет то же, что и не статический

    static class TextEditorStatic
    {
        /// <summary>
        /// Возможные окончания глаголов
        /// </summary>
        private static string[] endings = { "сь", "ыли", "ось", "ло", "тся", "ться", "ают", "ает", "ит", "яет", "яют", "еет", "еют", "ивать" };

        public static void ShowVerbsDups(string Text)
        {
            string[] words = SplitText(Text);
            string[] verbs = new string[words.Length];
            int k = 0;
            int count = 0;
            // Пройти по всем словам текста
            for (int i = 0; i < words.Length; i++)
            {
                // Пройти по всем окончаниям глаголов
                for (int j = 0; j < endings.Length; j++)
                {
                    if (words[i].EndsWith(endings[j]))
                    {
                        verbs[k++] = words[i];
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
                    if (words[i] == words[j])
                        count++;
                }
                Console.WriteLine($"Verb {verbs[i]} have {count} duplications.");
                count = 0;
            }
        }

        /// <summary>
        /// Подсчёт глаголов
        /// </summary>
        /// <returns>число глаголов</returns>
        public static int VerbsCount(string Text)
        {
            string[] words = SplitText(Text);
            int k = 0;
            // Пройти по всем словам в тексте
            for (int i = 0; i < words.Length; i++)
            {
                // Пройти по всем окончаниям глаголов
                for (int j = 0; j < endings.Length; j++)
                {
                    if (words[i].EndsWith(endings[j]))
                    {
                        k++;
                        break;
                    }
                }
            }
            return k;
        }

        // TODO : метод должен возвращать словарь глаголов
        /// <summary>
        /// Поиск глаголов
        /// </summary>
        /// <returns>Массив глаголов</returns>
        public static string[] FindVerbs(string Text)
        {
            string[] words = SplitText(Text);
            int k = 0;
            // Пройти по всем словам
            string[] verbs = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                // Пройти по всем окочаниям глаголов
                for (int j = 0; j < endings.Length; j++)
                {
                    if (words[i] == endings[j])
                    {
                        verbs[k++] = words[i];
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
        private static string[] SplitText(string Text)
        {
            return Text.Split(new char[] { '.', '!', '?', '-', ':', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// замена слов длиной меньше той, которую задал пользователь заданным словом
        /// </summary>
        /// <param name="wordToReplaceWith">Слово, которым будут заменяться слова меньше заданной длины</param>
        /// <param name="shortWordMaxLength">Минимально допустимая длина слова</param>
        /// <returns>Строка текста с замененными словами</returns>
        private static string ReplaceShortwordsInText(string wordToReplaceWith, int shortWordMaxLength, string Text)
        {
            int wordStartIndex = 0;
            StringBuilder sb = new StringBuilder(Text.Length);
            bool cycleExit = false;
            for (int i = 0; i < Text.Length; i++)
            {
                // Пройти по всем небуквенным значениям до первого буквенного
                while (!char.IsLetter(Text[i]))
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
        private static string ReplaceVerbsInText(string wordToReplaceWith, string Text)
        {
            string[] words = SplitText(Text);
            StringBuilder text = new StringBuilder(Text.Length);
            string[] verbs = new string[words.Length];
            int k = 0;
            int wordStartIndex = 0;
            bool cycleExit = false;
            // Пройти по массиву слов
            for (int i = 0; i < words.Length; i++)
            {
                // Пройти по окончаниям глаголов 
                for (int j = 0; j < endings.Length; j++)
                {
                    if (words[i].EndsWith(endings[j]))
                    {
                        verbs[k++] = words[i];
                        break;
                    }
                }
            }
            // Пройти по массиву символов текста
            for (int i = 0; i < Text.Length;)
            {
                // Пройти по всем небуквенным значениям до первого буквенного
                while (!char.IsLetter(Text[i]))
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

        /// <summary>
        /// Заменить в тексте глаголы и вывести измененный текст
        /// </summary>
        public static void ShowVerbsReplacedText(string Text)
        {
            string w;
            Console.Write("Enter the word you want to replace verbs with: ");
            w = Console.ReadLine();
            Console.WriteLine();
            string rext = ReplaceVerbsInText(w, Text);
            Console.WriteLine(rext);
        }

        public static void ShowShortWordReplacedText(string Text)
        {
            int l;
            string w;
            Console.Write("Enter the word you want to replace the short ones with: ");
            w = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter minimal acceptable word length: ");
            l = Convert.ToInt16(Console.ReadLine());
            string rext = ReplaceShortwordsInText(w, l, Text);
            Console.WriteLine(rext);
        }
    }
}
