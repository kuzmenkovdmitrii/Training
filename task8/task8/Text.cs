using System;
using System.Collections.Generic;
using System.Linq;

namespace task8
{
    class Text
    {
        private readonly char[] vowel = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        private readonly char[] soundless = { 'ь', 'ъ' };
        private string text;
        private List<string> words;

        public Text(string text)
        {
            this.text = text;
            words = text.Split(' ').ToList();
        }

        public string SplitSyllables()
        {
            string splitedText = "";
            for (int i = 0; i < words.Count; i++)
            {
                string[] splitedSyllables = SplitSyllables(words[i]);
                for (int j = 0; j < splitedSyllables.Length; j++)
                {
                    if (j < splitedSyllables.Length - 1)
                    {
                        splitedText += splitedSyllables[j] + "-";
                    }
                    else
                    {
                        splitedText += splitedSyllables[j] + " ";
                    }
                }
            }

            return splitedText;
        }

        public string[] SplitSyllables(string word)
        {
            string[] rawSyllables = SplitByVowels(word);
            if (NumberOfVowels(word) != 1)
            { 
                for (int i = 0; i < rawSyllables.Length; i++)
                {
                    if (i < rawSyllables.Length - 2)
                    {
                        string currentSyllables = rawSyllables[i];
                        string nextSyllables = rawSyllables[i + 1];
                        if (!IsVowel(nextSyllables[0]) && !IsVowel(nextSyllables[1]))
                        {
                            currentSyllables += nextSyllables[0];
                            nextSyllables = Array.MoveLeft(nextSyllables);
                            if (CheckSoundless(nextSyllables))
                            {
                                currentSyllables += nextSyllables[0];
                                nextSyllables = Array.MoveLeft(nextSyllables);
                            }

                            rawSyllables[i] = currentSyllables;
                            rawSyllables[i + 1] = nextSyllables;
                        }
                    }

                    if (i == rawSyllables.Length - 1 && i > 1)
                    {
                        if (rawSyllables[rawSyllables.Length - 1].Length >= 2)
                        {
                            string currentSyllables = rawSyllables[i];
                            string previousSyllables = rawSyllables[i - 1];
                            if (IsVowel(previousSyllables[previousSyllables.Length - 1]) &&
                                !IsVowel(currentSyllables[0]) && !IsVowel(currentSyllables[1]))
                            {
                                previousSyllables += currentSyllables[0];
                                currentSyllables = Array.MoveLeft(currentSyllables);
                                if (CheckSoundless(currentSyllables))
                                {
                                    previousSyllables += currentSyllables[0];
                                    currentSyllables = Array.MoveLeft(currentSyllables);
                                }

                                rawSyllables[i] = currentSyllables;
                                rawSyllables[i - 1] = previousSyllables;
                            }
                        }

                        if (!CheckVowel(rawSyllables[i]))
                        {
                            rawSyllables[i - 1] += rawSyllables[i];
                            rawSyllables[i] = "";
                        }
                    }
                }
            }
            else
            {
                System.Array.Resize(ref rawSyllables,1);
                rawSyllables[0] = word;
            }

            return Array.DeleteNull(rawSyllables);
        }

        private int NumberOfVowels(string word)
        {
            int numberOfVowels = 0;
            foreach (var w in word)
            {
                if (IsVowel(w))
                {
                    numberOfVowels++;
                }
            }

            return numberOfVowels;
        }

        private bool CheckVowel(string word)
        {
            foreach (var w in word)
            {
                if (IsVowel(w))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckSoundless(string word)
        {
            foreach (var w in word)
            {
                if (IsSoundless(w))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsSoundless(char symbol)
        {

            if (soundless.Contains(symbol))
            {
                return true;
            }

            return false;
        }

        private bool IsVowel(char symbol)
        {
            if (vowel.Contains(Char.ToLower(symbol)))
            {
                return true;
            }

            return false;
        }

        private int[] VowelPosition(string word)
        {
            int[] vowelPosition = new int[0];
            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(word[i]))
                {
                    System.Array.Resize(ref vowelPosition, vowelPosition.Length + 1);
                    vowelPosition[vowelPosition.Length - 1] = i;
                }
            }

            return vowelPosition;
        }

        private string[] SplitByVowels(string word)
        {
            string[] splitedWord = word.Split(vowel);
            string[] syllables = new string[NumberOfVowels(word) + 1];
            int[] vowelPosition = VowelPosition(word);

            for (int i = 0; i < vowelPosition.Length; i++)
            {
                syllables[i] += splitedWord[i];
                syllables[i] += word[vowelPosition[i]];
            }
            syllables[syllables.Length - 1] += splitedWord[splitedWord.Length - 1];
            return Array.DeleteNull(syllables);
        }

        public string GetText()
        {
            return text;
        }
    }
}