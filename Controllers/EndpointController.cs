//Marcel Rodriguez
//10-25-22
//MiniChallengesAllInOneEndpoints
//This contolller will return strings or ints from our mini challenges to the bowser
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMMiniChallenge1AllChallengesWithEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("miniCh1")]
    public string SayHello()
    {
        Console.Clear();

        string end = "yes";
        string myName = "Hello Marcel, have an awesome day!";

        while (end == "yes")
        {

        bool isContainer = false;
        bool isNumber;
        int validNumber = 0;


        while (isContainer == false)
        {
        Console.WriteLine("Good morning, what is your name?\n");
        isNumber = Int32.TryParse(myName, out validNumber);

        if(isNumber == false)
        {
            isContainer = true;

            Console.WriteLine("\nHello " + myName + ", have an awesome day!");
        }

        else
        {
            Console.WriteLine("\nPlease enter a name and not a number\n");
        }


        }


        Console.WriteLine("\n\nWould you like to try again? Yes / No");
        end = "no";
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        }
        return myName;
    }

    [HttpGet]
    [Route("miniCh2")]

    public int Add2Numbers()
    {
        Console.Clear();

        string end = "yes";
        int sum = 0;

        while (end == "yes")
        {
            bool isContainer = false;
            bool isNumber;
            int validNum = 0;
            
            while(isContainer == false)
            {

                Console.WriteLine("Please enter a number: ");
                string numberOne = "5";

                isNumber = Int32.TryParse(numberOne, out validNum);

                if(isNumber == true)
                {
                    isContainer = true;
                    Console.WriteLine($"\nThe number you entered was {numberOne}");
                }
                else
                {
                    Console.WriteLine("\nPlease enter an actual number.\n");
                }

            }

            bool isContainer2 = false;
            bool isNumber2;
            int validNum2 = 0;

            while(isContainer2 == false)
            {
                Console.WriteLine("\nPlease enter another number: ");
                string numberTwo = "3";
                isNumber2 = Int32.TryParse(numberTwo, out validNum2);

                if(isNumber2 == true)
                {
                    isContainer2 = true;
                    Console.WriteLine($"\nThe number you entered was {numberTwo}\n");
                }
                else
                {
                    Console.WriteLine("\nPlease enter an actual number.\n");
                }
            }

            sum = validNum + validNum2;

            Console.WriteLine($"The sum of {validNum} and {validNum2} is {sum}!\n");



            Console.WriteLine("Do you want to try again? Yes/No");
            end = "no";
            Console.WriteLine("\n\n");
        }
        return sum;
    }

    [HttpGet]
    [Route("miniCh3")]

    public string AskingQuestions()
    {
        Console.Clear();

        string end = "yes";
        string name = "";
        string timeAwake = "";
        while(end == "yes")
        {
            bool isContainer = false;
            bool isNumber;
            int validNum = 0;

            bool isContainer2 = false;
            bool isNumber2;
            int validNum2 = 0;

            while(isContainer == false)
            {
                Console.WriteLine("What is your name??");
                name = "Marcel";
                isNumber = Int32.TryParse(name, out validNum);

                if (isNumber == false)
                {
                    isContainer = true;

                    Console.WriteLine("\nWhat time did you wake up?");
                    timeAwake = "7 O'clock";
                    Console.WriteLine($"\nHello {name}, you woke up at {timeAwake}! I hope you got a good amount of rest :)");

                    Console.WriteLine("\nDo you want to try again? Yes/No");
                    end = "no";
                }
                else
                {
                    Console.WriteLine("\nPlease enter a name not a number");
                }
            }
        }
        return $"Hello {name}, you woke up at {timeAwake}! I hope you got a good amount of rest :)";
    }

    [HttpGet]
    [Route("miniCh4")]

    public string GreaterThanOrLessThan()
    {
        Console.Clear();

        string end = "yes";
        double validNum = 0;
        double validNum2 = 0;
        while(end == "yes")
        {
            bool isContainer = false;
            bool isNumber;
            string numberOne = "4";

            while(isContainer == false)
            {
                Console.WriteLine("Please enter a number: ");

                isNumber = double.TryParse(numberOne, out validNum);

                if (isNumber == true)
                {
                    isContainer = true;
                    Console.WriteLine($"\nThe number you entered was {numberOne}");
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number, not string: \n");
                }
            }

            bool isContainer2 = false;
            bool isNumber2;
            string numberTwo = "3";

            while(isContainer2 == false)
            {
                Console.WriteLine("\nPlease enter another number: ");

                isNumber2 = double.TryParse(numberTwo, out validNum2);

                if (isNumber2 == true)
                {
                    isContainer2 = true;
                    Console.WriteLine($"\nThe number you entered was {numberTwo}");
                }
                else
                {
                    Console.WriteLine("\nPlease enter a number, not string: \n");
                }
            }

            if(validNum > validNum2)
            {
                Console.WriteLine($"\n{validNum} is greater than {validNum2}");
                Console.WriteLine($"\n{validNum2} is less than {validNum}");
            }
            else if (validNum < validNum2)
            {
                Console.WriteLine($"\n{validNum} is less than {validNum2}");
                Console.WriteLine($"\n{validNum2} is greater than {validNum}");
            }
            else
            {
                Console.WriteLine($"\n{validNum} is equal to {validNum2}");
            }

            Console.WriteLine("\nDo you want to play again? Yes/No");
            end = "no";
        }
        return $"{validNum} is greater than {validNum2}";
    }

    [HttpGet]
    [Route("miniCh5")]

    public string MadLib()
    {
        Console.Clear();

        string end = "yes";
        string story = "";
        while(end == "yes")
        {
            string stringValue = "";

            Console.WriteLine("Please enter a name: ");
            string nameOne = "Marcel";
            Validate(nameOne, out stringValue);
            nameOne = stringValue;

            Console.WriteLine("Please enter a noun: ");
            string nounOne = "toaster";
            Validate(nounOne, out stringValue);
            nounOne = stringValue;

            Console.WriteLine("Please enter a verb: ");
            string verbOne = "jump";
            Validate(verbOne, out stringValue);
            verbOne = stringValue; 

            Console.WriteLine("Please enter an adjective: ");
            string adjectiveOne = "red";
            Validate(adjectiveOne, out stringValue);
            adjectiveOne = stringValue; 

            Console.WriteLine("Please enter another noun: ");
            string nounTwo = "laptop";
            Validate(nounTwo, out stringValue);
            nounTwo = stringValue;

            Console.WriteLine("Please enter another verb: ");
            string verbTwo = "skip";
            Validate(verbTwo, out stringValue);
            verbTwo = stringValue;

            
            Console.WriteLine("Please enter another adjective: ");
            string adjectiveTwo = "shiny";
            Validate(adjectiveTwo, out stringValue);
            adjectiveTwo = stringValue; 

            Console.WriteLine("Please enter a third adjective: ");
            string adjectiveThree = "colorful";
            Validate(adjectiveThree, out stringValue);
            adjectiveThree = stringValue;

            Console.WriteLine("Please enter a third verb: ");
            string verbThree = "ski";
            Validate(verbThree, out stringValue);
            verbThree = stringValue;

            Console.WriteLine("Please enter a forth verb: ");
            string verbFour = "fly";   
            Validate(verbFour, out stringValue);
            verbFour = stringValue;

            Console.WriteLine("Please enter a fifth verb: ");
            string verbFive = "eat";
            Validate(verbFive, out stringValue);
            verbFive = stringValue;

            Console.WriteLine();
            Console.WriteLine();
            story +="There once was a person named " +nameOne+ " who loved " +nounOne+ " a lot.";
            story +=" They loved " +nounOne+ " so much that they always had to " +verbOne+ " with it.";
            story +=" It had a " +adjectiveOne+ " look to it, and that made " +nameOne+ " want to " +verbTwo+ " when they were apart.";
            story +=" There was another thing that they had, which was a " +nounTwo;
            story +=" The " +nounTwo+ " was " +adjectiveTwo+ " and " +adjectiveThree+ ".";
            story +=$" {nameOne} dropped the {nounTwo} off a cliff, which caused {nameOne} to ";
            story +=$"{verbThree}, {verbFour}, and {verbFive} off the cliff as well.";
            story +=$" {nounOne} watched from the top and laughed. The End :D";
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("\nDo you want to try again? Yes/No");
            end = "no";
            Console.WriteLine();
        }
        return story;
        

        static string Validate(string validateString, out string validatedString)
        {
            bool isContainer = false;
            int validNum = 0;
            Console.WriteLine();

            while(isContainer == false)
            {   
                if (!Int32.TryParse(validateString, out validNum))
                {
                    isContainer = true;
                    validatedString = validateString;
                    return validateString;
                }
                else
                {
                    Console.WriteLine("Please enter a word, not a number");
                    validateString = Console.ReadLine();
                    Console.WriteLine();

                }
            }
            validatedString = validateString;
            return validateString;
        }
    }    

    [HttpGet]
    [Route("miniCh6")]

    public string OddOrEven()
    {
        Console.Clear();

        string end = "yes";
        string numberOne;
        int validNumber = 0;

        while(end == "yes")
        {
            bool isContained = false;
            bool isNumber;

            while(isContained == false)
            {
                Console.WriteLine("Please enter a number");
                numberOne = "42";
                isNumber = Int32.TryParse(numberOne, out validNumber);

                if(isNumber == true)
                {
                    isContained = true;
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(numberOne+ " is valid for real");
                }
                else
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Lowkey not valid");
                }
            }

            if(validNumber%2 == 0)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"{validNumber} is even");
            }
            else
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"{validNumber} is odd");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Would you like to play again? yes/no");
            end = "no";
            Console.WriteLine("--------------------------");
        }
        return $"{validNumber} is even";
    }

    [HttpGet]
    [Route("miniCh7")]

    public string ReverseIt()
    {
        Console.Clear();

        string end = "yes";
        string inputOne = "";
        string inputReverse = "";
        string numberChoice = "";
        string wordInput = "";
        string wordReverse = "";
        string inputReverseCheck = "";
        long validForReal = 0;

        while(end == "yes" || end == "YES" || end == "Yes")
        {

            bool isContainer = true;
            bool issaNumber;
            
            
            while(isContainer == true)
            {
                Console.WriteLine("Please enter a number and i will reverse it");
                inputOne = "347";
                issaNumber = Int64.TryParse(inputOne, out validForReal);

                inputReverse = string.Empty;

                if(issaNumber == true)
                {
                    for(int i = inputOne.Length - 1; i>=0; i--)
                    {
                        inputReverse += inputOne[i];
                    }
                    Console.WriteLine(inputReverse);
                    inputReverseCheck = inputReverse;
                    isContainer = false;
                    
                    long daNumber = 0;
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("Aw you don't beleive it's an int? give me another number: ");


                    bool containerAdd = false;
                    bool isNumberCheck;
                    while(containerAdd == false)
                    {
                        numberChoice = "42";
                        isNumberCheck = Int64.TryParse(numberChoice, out daNumber);

                        if (isNumberCheck == true)
                        {
                            containerAdd = true;
                        }
                        else
                        {
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("That is not a number >_>");
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("Please give me another number: ");
                        }
                    }
                    long sum = validForReal + daNumber;
                    Console.WriteLine("The sum of " +validForReal+ " and " +daNumber+ " equals " +sum);
                    Console.WriteLine("BOOM, m a t h");
                    Console.WriteLine("_________________________________");

                }
                else
                {
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("That is not a number >_>");
                    Console.WriteLine("_________________________________");
                }
            }

            
            bool isContainer2 = true;
            bool issaNumber2;
            long validForReal2 = 0;

            while(isContainer2 == true)
            {
                Console.WriteLine("Please enter a string and i will reverse it");
                wordInput = "racecar lol";
                issaNumber2 = Int64.TryParse(wordInput, out validForReal2);

                wordReverse = string.Empty;

                if(issaNumber2 == false)
                {
                    for(int j = wordInput.Length - 1; j>=0; j--)
                    {
                        wordReverse += wordInput[j];
                    }
                    Console.WriteLine(wordReverse);
                    isContainer2 = false;
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("yeah that's pretty much a string lol");

                }
                else
                {
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("That is not a string >_>");
                    Console.WriteLine("_________________________________");
                }
            }

            Console.WriteLine("Do you want to play again? yes/no");
            end = "no";
            Console.WriteLine("_________________________________");

        }
        return $"The reverse of {inputOne} is {inputReverse}. The reverse of {wordInput} is {wordReverse}.";
    }

    [HttpGet]
    [Route("miniCh8")]

    public string Magic8Ball()
    {
        string wordOutput = "";
        Random rndNum = new Random();
        long num = rndNum.Next(1,9);

        switch(num)
        {
            case 1:
            
            wordOutput = "Yes";

            break;

            case 2:

            wordOutput = "No";

            break;

            case 3:

            wordOutput = "Maybe";

            break;

            case 4:

            wordOutput = "Bro are you for real?";

            break;

            case 5:

            wordOutput = "Most Likely";

            break;

            case 6:

            wordOutput = "Never";

            break;

            case 7:

            wordOutput = "Mehoy Minoy";

            break;

            case 8:

            wordOutput = "Ask Again";

            break;
        }

        return wordOutput;
    }

    [HttpGet]
    [Route("miniChRestaurant")]

    public string RestaurantPicker()
    {
        Console.Clear();

        string end = "yes";
        string foodDecision = "";

        while(end == "yes")
        {

        bool isContainer = false;
        bool isNumberCheck;
        int validNum = 0;
        string foodChoice = "";


        while(isContainer == false)
        {
                Random rndNum2 = new Random();
                long num2 = rndNum2.Next(1,4);
            
            Console.WriteLine("What type of food do you want?\nMexican, American, or Chinese?");
            foodChoice = "american";

            switch(num2)
            {
                case 1:
                foodChoice = "mexican";
                break;

                case 2:
                foodChoice = "american";
                break;

                case 3:
                foodChoice = "chinese";
                break;

                default:

                break;
            }

            isNumberCheck = Int32.TryParse(foodChoice, out validNum);

            if(isNumberCheck == false)
            {
                isContainer = true;

                Random rndNum = new Random();
                long num = rndNum.Next(1,11);

                switch(foodChoice)
                {
                    case "mexican":

                    switch(num)
                    {
                        case 1:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Xochimico's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 2:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco Bell";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 3:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Alberto's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 4:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Las Palmas";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 5:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco truck beind Target";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 6:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco truck in front of Target";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 7:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Taco truck inside Target";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 8:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Nena's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 9:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Tio Pepe's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 10:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Flacko's Tacos";
                        Console.WriteLine("---------------------------------");
                        break;

                        default:

                        break;
                    }

                    break;

                    case "american":

                    switch(num)
                    {
                        case 1:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Dominos";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 2:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "McDonalds";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 3:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Burger King";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 4:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Chipotle";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 5:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Wendys";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 6:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "KFC";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 7:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Sonic";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 8:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Moo Moo's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 9:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Carl's Jr";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 10:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Chick-fil-a";
                        Console.WriteLine("---------------------------------");
                        break;

                        default:

                        break;
                    }

                    break;

                    case "chinese":

                    switch(num)
                    {
                        case 1:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Panda Express";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 2:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Dave Wong's";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 3:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Yen Du Restaurant";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 4:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Freddy's Wok and Talk";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 5:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "China Express";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 6:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "The Chopstick";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 7:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Golden Bowl Restaurant";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 8:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Dim Sum";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 9:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Ramen 101";
                        Console.WriteLine("---------------------------------");
                        break;

                        case 10:
                        Console.WriteLine("---------------------------------");
                        foodDecision = "Sun Won Kee";
                        Console.WriteLine("---------------------------------");
                        break;

                        default:

                        break;
                    }

                    break;

                    default:
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Please Choose one of the categories above: ");
                    Console.WriteLine("---------------------------------");

                    isContainer = false;
                    break;
                }
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Please enter a name and not a number XD");
                Console.WriteLine("---------------------------------");
            }
        }

        Console.WriteLine("Do you want to choose again? Yes/No");
        end = "no";

        }
        return foodDecision;
    }
}
