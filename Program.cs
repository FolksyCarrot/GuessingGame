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
    Console.WriteLine("Choose a difficulty: 1 = easy, 2 = medium, 3 = hard");
    int difficulty = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Guess a number: ");
    int answer = Convert.ToInt32(Console.ReadLine()); 

    if(difficulty == 1){
        while (guess < 8) {
        guess ++;
            if(answer == secretNumber){
                Console.WriteLine("Success");
                break;
            }else if (answer>secretNumber){
                Console.WriteLine("Your guess was too high!");
                Console.WriteLine("Guess a number: ");
                answer = Convert.ToInt32(Console.ReadLine());
                remaindingNum= 8-guess;
                Console.WriteLine($"You have {remaindingNum} guesses left!");
                
            }else {
                Console.WriteLine("Your guess was too low!");
                Console.WriteLine("Guess a number: ");
                answer = Convert.ToInt32(Console.ReadLine());
                remaindingNum= 8-guess;
                Console.WriteLine($"You have {remaindingNum} guesses left!");
            }
        }
    } else if(difficulty == 2) {
        while (guess < 6) {
        guess ++;
            if(answer == secretNumber){
                Console.WriteLine("Success");
                break;
            }else if (answer>secretNumber){
                Console.WriteLine("Your guess was too high!");
                Console.WriteLine("Guess a number: ");
                answer = Convert.ToInt32(Console.ReadLine());
                remaindingNum= 6-guess;
                Console.WriteLine($"You have {remaindingNum} guesses left!");
                
            }else {
                Console.WriteLine("Your guess was too low!");
                Console.WriteLine("Guess a number: ");
                answer = Convert.ToInt32(Console.ReadLine());
                remaindingNum= 6-guess;
                Console.WriteLine($"You have {remaindingNum} guesses left!");
            }
        }
    } else if(difficulty == 3) {
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
    } else {
        Console.WriteLine("Not a valid difficulty");
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