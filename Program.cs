/*
Carlos Felipe Sales
9-19-22
Mini Challenge #8 - Guess It
My code creates a guessing game where the user guesses a number given the difficulty they chose. Each difficulty has a respective range in which to guess. There is replayability and data validation for ALL user inputs.
Peer review: Brian Mallory - Works great and flow chart looks good.  Nice job finding bug in original version and fixing it.
DONE
*/

static void End()
{   
    Console.WriteLine("Okay maybe next time!");
    Environment.Exit(0);
}

static void Play()

{   
    Console.Clear();
    Random rndNum = new Random();
    string difficulty;
    string userInput;
    int correctGuess = 0;
    bool run = true;
    string playLoop;

    int numOne = 0;
    int numTwo = 0;
    int userGuess;
    bool isNumber;
    int i = 1; 

    bool oneRun = true;
    bool twoRun = true;
    bool validRange = true;
    
    Console.WriteLine("There is a jelly bean jar with many jellies inside.");
    Console.WriteLine("Guess the number of jellies and win a prize!");
    Console.WriteLine("One condition however, you can't see the jar.");
    Console.WriteLine("\nThere are three difficulties.");
    Console.WriteLine("Easy ranges 1 - 10");
    Console.WriteLine("Medium ranges 1 - 50");
    Console.WriteLine("Hard ranges 1 - 100");
    Console.WriteLine("Custom has a custom range!");
    Console.Write("\nChoose your difficulty: ");
    difficulty = Console.ReadLine().ToLower();

    while(difficulty != "easy" && difficulty != "medium" && difficulty != "hard" && difficulty != "custom")
    {
        Console.Write("That is not a difficulty. Try again: ");
        difficulty = Console.ReadLine().ToLower();
    }

    switch (difficulty)
    {
        case "easy":
            correctGuess = rndNum.Next(0, 11);

            Console.WriteLine("\nYou chose " + difficulty);
            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine();

            while (run)
            {
                isNumber = Int32.TryParse(userInput, out userGuess);
                if (isNumber == true && userGuess >= 0 && userGuess <= 10)
                {
                    Console.WriteLine("\nYour guess is " + userGuess);

                    if (userGuess < correctGuess)
                    {   
                        i++;
                        Console.Write("You are too low. Try again: ");
                        userInput = Console.ReadLine();
                       
                    }
                    else if (userGuess > correctGuess)
                    {
                        Console.Write("You are too high. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess == correctGuess)
                    {

                        Console.WriteLine("Congratulations you guessed correctly! The number was " + correctGuess);
                        Console.WriteLine("It took you " + i + " guesses");
                        Console.WriteLine("\nPlay again? 'yes' or 'no' ");
                        playLoop = Console.ReadLine().ToLower();

                        while(playLoop != "yes" && playLoop != "no")
                        {
                            Console.Write("I said 'yes' or 'no' Try Again: ");
                            playLoop = Console.ReadLine().ToLower();
                        }if(playLoop == "yes")
                        {
                            Play();
                        }
                        if(playLoop == "no")
                        {
                            End();
                        }
                    }
                }
                else
                {
                    Console.Write("Incorrect input or input is out of scope. Try again: ");
                    userInput = Console.ReadLine();
                }
            }

            break;

        case "medium":
            correctGuess = rndNum.Next(0, 51);

            Console.WriteLine("\nYou chose " + difficulty);
            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine();

            while (run)
            {
                isNumber = Int32.TryParse(userInput, out userGuess);
                if (isNumber == true && userGuess >= 0 && userGuess <= 50)
                {
                    Console.WriteLine("\nYour guess is " + userGuess);

                    if (userGuess < correctGuess)
                    {
                        Console.Write("You are too low. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess > correctGuess)
                    {
                        Console.Write("You are too high. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess == correctGuess)
                    {

                        Console.WriteLine("Congratulations you guessed correctly! The number was " + correctGuess);
                        Console.WriteLine("It took you " + i + " guesses");
                        Console.WriteLine("Play again? 'yes' or 'no' ");
                        playLoop = Console.ReadLine().ToLower();

                        while(playLoop != "yes" && playLoop != "no")
                        {
                            Console.Write("I said 'yes' or 'no' Try Again: ");
                            playLoop = Console.ReadLine().ToLower();
                        }if(playLoop == "yes")
                        {
                            Play();
                        }
                        if(playLoop == "no")
                        {
                            End();
                        }
                    }
                }
                else
                {
                    Console.Write("Incorrect input or input is out of scope. Try again: ");
                    userInput = Console.ReadLine();
                }
            }

            break;

        case "hard":
            correctGuess = rndNum.Next(0, 101);

            Console.WriteLine("\nYou chose " + difficulty);
            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine();

            while (run)
            {
                isNumber = Int32.TryParse(userInput, out userGuess);
                if (isNumber == true && userGuess >= 0 && userGuess <= 100)
                {
                    Console.WriteLine("\nYour guess is " + userGuess);

                    if (userGuess < correctGuess)
                    {
                        Console.Write("You are too low. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess > correctGuess)
                    {
                        Console.Write("You are too high. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess == correctGuess)
                    {

                        Console.WriteLine("Congratulations you guessed correctly! The number was " + correctGuess);
                        Console.WriteLine("It took you " + i + " guesses");
                        Console.WriteLine("Play again? 'yes' or 'no' ");
                        playLoop = Console.ReadLine().ToLower();
                        
                        while(playLoop != "yes" && playLoop != "no")
                        {
                            Console.Write("I said 'yes' or 'no' Try Again: ");
                            playLoop = Console.ReadLine().ToLower();
                        }if(playLoop == "yes")
                        {
                            Play();
                        }
                        if(playLoop == "no")
                        {
                            End();
                        }
                    }
                }
                else
                {
                    Console.Write("Incorrect input or input is out of scope. Try again: ");
                    userInput = Console.ReadLine();
                }
            }

            break;

        case "custom":
            
            Console.WriteLine("\nYou chose custom");
            while(validRange){
            Console.Write("Enter your minimum value: ");
            userInput = Console.ReadLine();
            while(oneRun){
            isNumber = Int32.TryParse(userInput, out numOne);
            if(isNumber == false){
                Console.Write("Invalid input. Enter you minimum value: ");
                userInput = Console.ReadLine();
            }else{
                oneRun = false;
            }
            }
        
            Console.Write("Enter your maximum value: ");
            userInput = Console.ReadLine();
            while(twoRun){
            isNumber = Int32.TryParse(userInput, out numTwo);
            if(isNumber == false){
                Console.Write("Invalid input. Enter your maximum value: ");
                userInput = Console.ReadLine();
            }else{
                twoRun = false;
            }
            }
           
            if(numOne >= numTwo){
                Console.WriteLine("Minimum and maximum values create an invalid range. Try Again.");
                oneRun = true;
                twoRun = true;
            }
            else if(numOne < numTwo)
            {
                break;
            }
            }
            
            correctGuess = rndNum.Next(numOne, numTwo);
            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine();
            

            while (run)
            {

                isNumber = Int32.TryParse(userInput, out userGuess);
                if (isNumber == true && userGuess >= numOne && userGuess <= numTwo)
                {
                    Console.WriteLine("\nYour guess is " + userGuess);

                    if (userGuess < correctGuess)
                    {
                        Console.Write("You are too low. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess > correctGuess)
                    {
                        Console.Write("You are too high. Try again: ");
                        userInput = Console.ReadLine();
                        i++;
                    }
                    else if (userGuess == correctGuess)
                    {

                        Console.WriteLine("Congratulations you guessed correctly! The number was " + correctGuess);
                        Console.WriteLine("It took you " + i + " guesses");
                        Console.WriteLine("Play again? 'yes' or 'no' ");
                        playLoop = Console.ReadLine().ToLower();
                        
                        while(playLoop != "yes" && playLoop != "no")
                        {
                            Console.Write("I said 'yes' or 'no' Try Again: ");
                            playLoop = Console.ReadLine().ToLower();
                        }if(playLoop == "yes")
                        {
                            Play();
                        }
                        if(playLoop == "no")
                        {
                            End();
                           
                        }
                    }
                }
                else
                {
                    Console.Write("Incorrect input or input is out of scope. Try again: ");
                    userInput = Console.ReadLine();
                }
            }

            break;
    }


}

Play();







