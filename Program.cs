using System;

Main();

void Main() {
    GuessTheNumber();
};

void GuessTheNumber() {
    int guess = 0;
    int remaindingNum;
    int secretNumber = RandomNumberGenerator();
    Console.WriteLine(secretNumber);
    Console.WriteLine("Guess a number: ");
    int answer = Convert.ToInt32(Console.ReadLine()); 

    while (guess < 4) {
        guess ++;
        if(answer == secretNumber){
            Console.WriteLine("Success");
            break;
        }else if (answer>secretNumber){
            Console.WriteLine("Your guess was too high!");
            Console.WriteLine("Guess a number: ");
            answer = Convert.ToInt32(Console.ReadLine());
            remaindingNum= 4-guess;
            Console.WriteLine($"You have {remaindingNum} guesses left!");
            
        }else {
            Console.WriteLine("Your guess was too low!");
            Console.WriteLine("Guess a number: ");
            answer = Convert.ToInt32(Console.ReadLine());
            remaindingNum= 4-guess;
            Console.WriteLine($"You have {remaindingNum} guesses left!");
        }
    }

   
};


 /* void Guesses() {
    int guess = 0;
    
    while ( guess < 4) {
        guess ++;
        GuessTheNumber();
    }
    if (guess == 4) {
        Console.WriteLine("All out of guesses");
    }
};
*/
static int RandomNumberGenerator() {
    Random r = new Random();
    int genRand= r.Next(0,100);
    return genRand;
}