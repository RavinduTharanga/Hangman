// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    
     string wordToGuess="hangman";
     char guessedLetter;
     int maxGuesses;
     int incorrectGuesses;
    

    public void play(){
        while(true){
         DisplayWord();
         Console.Write("\n Please guess a Letter: ");
         guessedLetter=Console.ReadKey().KeyChar;

         GuessWord(guessedLetter);
        }
    }
    

    public bool GuessWord(char guessedLetter){
        
           for(int i=0; i<wordToGuess.Length;i++){
             
             
             if(wordToGuess[i]==guessedLetter){
                 
                return true;
             }
         }
         return false;
        
    }
      
    public void DisplayWord() {
        
        for(int i=0; i<wordToGuess.Length;i++){
        Console.Write("_ ");
    } 
}
    public static void Main(string[] args)
    {
    
         HelloWorld game =new HelloWorld();
         game.play();
    
    }
    
    
}
