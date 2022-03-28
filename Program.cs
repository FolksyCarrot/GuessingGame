using System;

Main();

void Main() {
    Guesses();
};

void GuessTheNumber() {
    int secretNumber = 42;
    Console.WriteLine("Guess a number: ");
    int answer = Convert.ToInt32(Console.ReadLine()); 
    if(answer == secretNumber ) {
        Console.WriteLine("Success");
    } else {
        Console.WriteLine("Keep Guessing");
    }
};


void Guesses() {
    int guess = 0;
    while ( guess < 4) {
        guess ++;
        GuessTheNumber();
    }
    if (guess == 4) {
        Console.WriteLine("All out of guesses");
    }
};
