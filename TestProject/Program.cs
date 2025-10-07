// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("Hai fatto una doppia! hai un bonus di 2 punti!! ");
//     total += 2;
// }
// if ((roll1 == roll2) && (roll2 == roll3)) 
// {
//     Console.WriteLine("Hai fatto triplette, hai un bonus di 6 punti!!");
//     total += 6;
// }


// if (total >= 15)
// {
//     Console.WriteLine("You win");
//     Console.WriteLine(total);

// }
// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
//     Console.WriteLine(total);
// }
// // Espressione booleana possone essere : 
// // 1 : un codice che ritorna true o false
// // 2 : un metodo che restituisce valore true o false

// string message = "La volpe saltela sopra il cane lento";
// bool result = message.Contains("cane");
// Console.WriteLine(result);
// if (message.Contains("volpe"))// qua uso l'accesso ai membri(proprieta, metodo,campo,evento)
// {
//     Console.WriteLine("Cosa dice la volpe?");
// }




// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
// }else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine($@"Your subscription expires within a day!\nRenew now and save 20%!");
// }else if (daysUntilExpiration == 0)
// {
//     Console.WriteLine($@"Your subscription has expired.");
// }