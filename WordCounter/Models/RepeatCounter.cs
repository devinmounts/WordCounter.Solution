﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private int _result;
        private string _targetWord;
        private static List<string> _wordList = new List<string> { };
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

        public void SaveWordToList(string listWord)
        {
            _wordList.Add(listWord);
        }

        public List<string> GetList()
        {
            return _wordList;
        }

        public static void ClearList()
        {
            _wordList.Clear();
        }

        public void SetSplitCompareString(string newComparePhrase)
        {
            char[] splitChars = { ' ', '.', ',', '!', '?', '-', '_', '#', '@', ':', ';', '(', ')', '*', '<', '>'};
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

