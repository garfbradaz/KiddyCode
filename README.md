# Welcome to KiddyCode! 🚀

Hey there, future programmer! This is your guide to KiddyCode, a fun programming language made just for you. If you've been using Scratch and want to try something new, you're in the right place!

## How to Write Your First Program 📝

Every program starts like this:
```
program MyProgramName {
    start {
        // Your cool code goes here!
    }
}
```

## Types of Things You Can Use 🎨

### Numbers
```
number score is 0        // Whole numbers
number height is 1.75    // Numbers with decimals
```

### Text
```
text name is "Alex"
text message is "Hello, friend!"
```

### Yes or No Choices
```
choice isPlaying is yes
choice gameOver is no
```

### Lists (Collections of Things)
```
list numbers is [1, 2, 3, 4]
list names is ["Alex", "Sam", "Pat"]
```

### Things That Never Change
When you want a value that shouldn't change, use `fixed`:
```
fixed number MAX_SCORE is 1000
fixed text GAME_NAME is "Adventure Time"
```

## Math Operations (Working with Numbers) ➗

You can do all sorts of math in KiddyCode:

### Basic Math
```
number sum is 5 + 3        // Adding (sum is 8)
number diff is 10 - 4      // Subtracting (diff is 6)
number product is 6 * 2    // Multiplying (product is 12)
number quotient is 8 / 2   // Dividing (quotient is 4)
```

### Finding Remainders
```
number remainder is 7 % 3   // The remainder when dividing 7 by 3 (remainder is 1)
```

### Multiple Operations
```
number result is (4 + 2) * 3   // Do the math in parentheses first (result is 18)
number mixed is 10 + 5 * 2     // Multiplication happens before addition (mixed is 20)
```

### Changing Numbers
```
number score is 10
score is score + 1     // Add 1 to score (now score is 11)
score is score - 5     // Subtract 5 from score (now score is 6)
score is score * 2     // Double the score (now score is 12)
score is score / 3     // Divide score by 3 (now score is 4)
```

## Making Decisions (If Statements) 🤔

```
if score is greater than 100 then {
    print "Wow! Great score!"
} else {
    print "Keep trying!"
}
```

You can use these comparisons:
- `is equal to`
- `is not equal to`
- `is greater than`
- `is less than`
- `is at least`
- `is at most`

## Making Multiple Choices 🎯

```
choose {
    when score is greater than 100 then {
        print "You won!"
    }
    when score is greater than 50 then {
        print "Almost there!"
    }
    otherwise {
        print "Keep playing!"
    }
}
```

## Repeating Things (Loops) 🔄

### Repeat a specific number of times
```
repeat 5 times {
    print "Hello!"
}
```

### Repeat while something is true
```
repeat while score is less than 100 {
    print "Still playing..."
}
```

### Repeat for each item in a list
```
list pets = ["dog", "cat", "fish"]
repeat for pet in pets {
    print "I have a " + pet
}
```

## Creating Commands (Your Own Instructions) ⚙️

```
command addPoints(number points) {
    reply points + 10
}

command sayHello(text friendName) {
    print "Hello, " + friendName + "!"
}
```

## Combining Things Together

You can use `and` and `or` to combine choices:
```
choice canPlay = age is greater than 8 and score is less than 100
```

## Printing Things to the Screen 📺
```
print "Hello!"
print "Your score is: " + score
```

## Cool Tips 💡

1. Use comments to leave notes in your code:
```
// This is a comment - it helps explain what your code does!
```

2. Give your variables nice, clear names that explain what they do:
```
number playerScore = 0     // Good! Clear what this is for
number x = 0              // Not so good - what is x?
```

3. Keep your code neat and organized with proper spacing!

## Examples 📚

Check out the examples folder to see some cool programs you can try!

Remember: Programming is like building with LEGO® - you start with simple pieces and build amazing things! Have fun coding! 🎮