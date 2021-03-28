using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class VowelSpellchecker
    {
        /// <summary>
        /// When the query exactly matches a word in the wordlist(case-sensitive), you should return the same word back.
        /// When the query matches a word up to capitlization, you should return the first such match in the wordlist. 
        /// When the query matches a word up to vowel errors, you should return the first such match in the wordlist.
        /// If the query has no matches in the wordlist, you should return the empty string.
        /// </summary>
        /// <param name="wordlist"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            var output = new List<string>();

            var lcaseWords = new Dictionary<int, string>();
            var novowelWords = new Dictionary<int, string>();
            var index = 0;

            foreach (var word in wordlist)
            {
                var lowerWord = word.ToLower();
                lcaseWords.Add(index, lowerWord);
                novowelWords.Add(index, lowerWord.Replace("a", ".").Replace("e", ".").Replace("i", ".")
                        .Replace("o", ".").Replace("u", "."));
                index++;
            }

            foreach(var queryWord in queries)
            {
                if (wordlist.Contains(queryWord))
                {
                    output.Add(queryWord);
                    continue;
                }

                var lowerQueryWord = queryWord.ToLower();
                if (lcaseWords.ContainsValue(lowerQueryWord))
                {
                    foreach (var word in lcaseWords)
                    {
                        if (word.Value.Equals(lowerQueryWord))
                        {
                            output.Add(wordlist[word.Key]);
                            break;
                        }
                    }

                    continue;
                }

                var novowelQueryWord = lowerQueryWord.Replace("a", ".").Replace("e", ".").Replace("i", ".")
                        .Replace("o", ".").Replace("u", ".");

                if (novowelWords.ContainsValue(novowelQueryWord))
                {
                    foreach (var word in novowelWords)
                    {
                        if (word.Value.Equals(novowelQueryWord))
                        {
                            output.Add(wordlist[word.Key]);
                            break;
                        }
                    }

                    continue;
                }

                output.Add(string.Empty);
            }

            return output.ToArray();
        }

    }
}
