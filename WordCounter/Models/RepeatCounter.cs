using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

    public class RepeatCounter
    {
        private string _sentenceInput;
        private string _wordInput;

        public RepeatCounter(string sentence, string word)
        {
            _sentenceInput = sentence.ToLower();
            _wordInput = word.ToLower();
        }

        public string GetSentence()
        {
            return _sentenceInput;
        }

        public string GetWord()
        {
            return _wordInput;
        }

        public void SetSentence(string sentence)
        {
            _sentenceInput = sentence;
        }

        public void SetWord(string word)
        {
            _wordInput = word;
        }

        public int GetPairs()
        {
            int pairs = 0;
            string[] splitSentence = _sentenceInput.Split();
            foreach (string word in splitSentence)
            {
                if (word == _wordInput)
                {
                    pairs += 1;
                }
            }
            return pairs;
        }

    }

}
