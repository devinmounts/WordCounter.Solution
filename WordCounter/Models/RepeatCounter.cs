using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private int _result;
        private string _targetWord;
        private string[] _comparePhrase;

        public RepeatCounter()
        {

        }

        public RepeatCounter(string targetWord = "")
        {
            _targetWord = targetWord;
        }

        public RepeatCounter(string targetWord = "", string phrase = "")
        {
            _targetWord = targetWord;
            _comparePhrase = phrase.ToLower().Split(' ');
        }



        public void SetTargetWord(string newTargetWord)
        {
            _targetWord = newTargetWord.ToLower();
        }
        public string GetTargetWord()
        {
            return _targetWord;
        }

        public void SetSplitCompareString(string newComparePhrase)
        {
            char[] splitChars = { ' ', '.', ',', '!', '?', '-', '_', '#', '@', ':', ';', '(', ')', '*', '<', '>' };
            _comparePhrase = newComparePhrase.ToLower().Split(splitChars);
        }

        public string[] GetComparePhrase()
        {
            return _comparePhrase;
        }

        public int CheckSplitPhrase(string targetWord, string targetPhrase)
        {
            SetTargetWord(targetWord);
            string inputWord = GetTargetWord();
            SetSplitCompareString(targetPhrase);
            string[] inputPhrase = GetComparePhrase();
            if (!inputPhrase.Contains(inputWord))
            {
                return _result = 0;
            }
            else
            {
                int i = 0;
                foreach (string word in inputPhrase)
                {
                    if (inputWord == inputPhrase[i])
                    {
                        _result += 1;
                    }
                    i++;
                }
                return _result;
            }
        }
        public int GetResult()
        {
            return _result;
        }

        public int RunCounter(string word,string phrase)
        {
            CheckSplitPhrase(word, phrase);
           return GetResult();
        }

    }
}

