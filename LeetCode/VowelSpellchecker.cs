﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            string[] output = (string[])queries.Clone();
            var matches = new Dictionary<string, string>();
            var lcaseWords = new Dictionary<string, string>();
            var novowelWords = new Dictionary<string, string>();
            var lcases = new HashSet<string>();
            var novowels = new HashSet<string>();
            var wordList = new HashSet<string>();

            foreach (var word in wordlist)
            {
                if (!wordList.Contains(word))
                {
                    wordList.Add(word);
                }

                if (!lcaseWords.ContainsKey(word))
                {
                    var lowerWord = word.ToLower();

                    if (!lcases.Contains(lowerWord))
                    {
                        lcases.Add(lowerWord);
                    }

                    lcaseWords.Add(word, lowerWord);

                    var novowelWord = System.Text.RegularExpressions.Regex.Replace(lowerWord, "[aeiou]", ".");

                    if (!novowels.Contains(novowelWord))
                    {
                        novowels.Add(novowelWord);
                    }

                    novowelWords.Add(word, novowelWord);
                }
            }

            for (var i = 0; i < output.Length; i++)
            {
                if (matches.ContainsKey(output[i]))
                {
                    output[i] = matches[output[i]];
                    continue;
                }

                if (wordList.Contains(output[i]))
                {
                    matches.Add(output[i], output[i]);
                    continue;
                }

                var lowerQueryWord = output[i].ToLower();
                if (lcases.Contains(lowerQueryWord))
                {
                    foreach (var word in lcaseWords)
                    {
                        if (word.Value.Equals(lowerQueryWord))
                        {
                            matches.Add(output[i], word.Key);
                            output[i] = word.Key;
                            break;
                        }
                    }

                    continue;
                }

                var novowelQueryWord = System.Text.RegularExpressions.Regex.Replace(lowerQueryWord, "[aeiou]", ".");

                if (novowels.Contains(novowelQueryWord))
                {
                    foreach (var word in novowelWords)
                    {
                        if (word.Value.Equals(novowelQueryWord))
                        {
                            matches.Add(output[i], word.Key);
                            output[i] = word.Key;
                            break;
                        }
                    }

                    continue;
                }

                matches.Add(output[i], "");
                output[i] = "";
            }

            return output;
        }
    }
}
