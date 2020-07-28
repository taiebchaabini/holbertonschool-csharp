using System;

public enum Rating{
    Good,
    Great,
    Excellent
}

public struct Dog{
    public Dog(string dogName, float dogAge, string dogOwner, Rating dogRating){
        name = dogName;
        age = dogAge;
        owner = dogOwner;
        rating = dogRating;
    }
    public string name { get; }
    public float age { get; }
    public string owner { get; }
    public Rating rating { get; }
}