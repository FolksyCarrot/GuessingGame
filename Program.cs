using System;

Main();

void Main() {
    Guesses();
};

void GuessTheNumber() {
    int secretNumber = RandomNumberGenerator();
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

static int RandomNumberGenerator() {
    Random r = new Random();
    int genRand= r.Next(0,100);
    return genRand;
}