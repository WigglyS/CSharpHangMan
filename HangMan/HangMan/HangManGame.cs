using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class HangManGame
    {
        List<String> PossibleWords;
        public List<Char> GuessedCharacters;

        public String CurrentWord { get; private set; }
        public int MaxLives = 5;

        public int Lives { get; private set; }

        char[] guessed;

        public HangManGame()
        {
            PossibleWords = new List<string>() {
                "potato",
                "television",
                "Computer",
                "internet",
                "keyboard",
                "purple",
                "pretzel",
                "index",
                "water",
                //aparently it takes japanes input just fine
                //zoo
                "動物園",
                //aquarium
                "水族館",
                //vampire
                "吸血鬼"
                
            };
            GuessedCharacters = new List<char>();


            Reset();
        }

        public void SelectNewWord()
        {
            GuessedCharacters.Clear();
            Random random = new Random();
            CurrentWord = PossibleWords[random.Next(0, PossibleWords.Count - 1)];

            guessed = new char[CurrentWord.Length];
            for (int i = 0; i < guessed.Length; i++)
            {
                guessed[i] = '.';
            }
        }

        public List<int> CheckLetter(Char letter, out string message)
        {

            List<int> matchedIndexs = new List<int>();


            foreach (var c in GuessedCharacters)
            {
                if(letter == c)
                {
                    message = "You have already guessed that letter";
                    return matchedIndexs;
                }
            }

            
            for (int i = 0; i < CurrentWord.Length; i++)
            {
                
                if (Char.ToUpper(letter) == CurrentWord.ToUpper()[i])
                {
                    guessed [i] = Char.ToUpper(letter);
                    matchedIndexs.Add(i);
                }
              
            }

            if(matchedIndexs.Count ==0)
            {
                message = "That letter wasnt in the word";
                Lives--;

            }
            else
            {
                message = "You guessed correctly";
            }

            
            GuessedCharacters.Add(letter);
            return matchedIndexs;

        }

        public void Reset()
        {
            
            Lives = MaxLives;
            SelectNewWord();
        }

        public bool CheckWord(string word)
        {

            if(word.Length != guessed.Length)
            {
                return false;

            }

            for (int i = 0; i < guessed.Length; i++)
            {
                if (!(guessed[i] == word[i]))
                {
                    return false;
                }
            }
           
            return true;
        }
    }
}
