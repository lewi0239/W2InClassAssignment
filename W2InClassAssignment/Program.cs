﻿using MyNamespace;

namespace W2InClassAssignment;

class Program
{
    static void Main(string[] args)
    {
        //create a book object
        Book theHobbit = new Book("The Hobbit", "J.R.R.Tolkien", "1937");
        theHobbit.DisplayInfo();
        //create a student object
        Student brodie = new Student("Brodie", 90);
        brodie.studentInfo();
        brodie.IsPassing();
        
        //create a car object
        RaceCar myCar = new RaceCar("BMW", 150);
        myCar.Describe();
        
        //vowelCounter
        VowelCounter vowelCounter = new VowelCounter("Hello World");
        VowelCounter vowelCounter2 = new VowelCounter("Apples ARE awesome");
        vowelCounter.getVowelCount();
        vowelCounter2.getVowelCount();
        
        
    }
    
}
