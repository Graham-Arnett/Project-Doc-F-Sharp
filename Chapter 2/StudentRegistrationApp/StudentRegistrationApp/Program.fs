// For more information see https://aka.ms/fsharp-console-apps
printfn "What is your first name? "
let firstName = System.Console.ReadLine()

printfn "What is your last name? "
let lastName = System.Console.ReadLine()

printfn "What is your year of birth? "
let birthYear = System.Console.ReadLine()

printfn $"Welcome {firstName} {lastName}!"

printfn "Your registration is complete."

printfn $"Your temporary password is: {lastName}{birthYear}"