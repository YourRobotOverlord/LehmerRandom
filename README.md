# Lehmer Random Number Generator
This project was created with the intention of building an alternative to `System.Random` for games, procedural generation etc. As the name suggests, it uses a [Lehmer random number generator](https://en.wikipedia.org/wiki/Lehmer_random_number_generator).  
It uses .NET Standard.
  
`Lehmer.Random` is a pseudo-random number generator and is **not** cryptographically secure.  

This the algorithm used in `Lehmer.Random` is [Javidx9](https://www.onelonecoder.com/index.html)'s implementation of the Lehmer random number generator converted from C++ to C#. Javidx9 has an excellent [video](https://www.youtube.com/watch?v=ZZY9YE7rZJw) explaining some of the shortcomings of other RNGs for use in procedural generation, and also demonstrates the use of the Lehmer RNG to generate a universe.  
  
`Lehmer.Random` is intended to be easy to use and mirrors the functionality of `System.Random`.  
Some additional method signatures have been added to improve the usability of the RNG. For example, `NextDouble()` has two additional signatures that allow a range to be passed.
  
### Public Member Functions
This list contains all of the non-static methods of `Lehmer.Random`:  

    • Random ()
      Initializes a new instance of the Random class, using a time-dependent default seed value.

    • Random (int seed)
      Initializes a new instance of the Random class, using the specified seed value.

    • Random (uint seed)
      Initializes a new instance of the Random class, using the specified seed value.
  
    • int Next ()
      Returns a non-negative random integer.
  
    • int Next (int maxValue)
      Returns a non-negative random integer that is less than the specified maximum.

    • int Next (int minValue, int maxValue)
      Returns a random integer that is within a specified range.

    • double NextDouble ()
      Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.

    • double NextDouble (double maxValue)
      Returns a non-negative random floating-point number that is less than the specified maximum.
  
    • double NextDouble (double minValue, double maxValue)
      Returns a random floating-point number that is within a specified range.
      
    • void NextBytes (byte[] buffer)
      Fills the elements of a specified array of bytes with random numbers.

### Static Public Member Functions
`Lehmer.Random` also contains several static methods that can be used without instantiating the class. These can be used to generate "one-off" random numbers that are independent of the number generated previously.  

    • static int RndInt (uint seed, int minValue, int maxValue)
      Returns a random integer that is within a specified range, using the specified seed value.

    • static int RndInt (int minValue, int maxValue)
      Returns a random integer that is within a specified range, using a time-dependent default seed value.

    • static double RndDouble (uint seed, double minValue, double maxValue)
      Returns a random double that is within a specified range, using the specified seed value.

    • static double RndDouble (double minValue, double maxValue)
      Returns a random double that is within a specified range, using a time-dependent default seed value.
