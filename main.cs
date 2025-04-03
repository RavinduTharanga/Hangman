using System;


	
public class HangmanGame
{
	private string wordToGuess;
	private char[] guessedLetters;
	private int maxGuesses;
	private int incorrectGuesses;
	
	public HangmanGame(string word){
	
	wordToGuess=word.ToUpper();
	guessedLetters=new char[wordToGuess.Length];
	maxGuesses=5;
	incorrectGuesses=0;
		
	}
	
	public void Play(){
	
	Console.WriteLine("Welcome to Hangman!");
	while(true){
		Console.WriteLine();
		DisplayGuessedLetters();
		Console.Write("Enter a letter: ");
		char letter=char.ToUpper(Console.ReadKey().KeyChar);
		Console.WriteLine();
		
	
		
	}
	}
	
	public bool IsLetterGuessed(char letter){
		
		for(int i=0; i<wordToGuess.Length; i++){
			if(guessedLetters[i]==letter){
				return true;
			}
		}
		return false;
	}
	public void DisplayGuessedLetters(){
	
	}
	
	
	
}
