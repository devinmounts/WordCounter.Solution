# Word Counter

#### Epicodus C#: Wk. 1 Independent Project, 06/29/2018

#### By Devin Mounts

## A console application that will allow the user to input a word and check how frequently that word appears in a given string.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program allows user to enter a word, and stores that word**| Input: "The" | Output: "The" |
| **Program converts stored word to lower case letters.**| Input: "The" | Output: "the" |
| **Program allows user to enter in a string, and saves that string** | Input: "The cat" | Output: "The cat" |
| **Program converts stored string to lower case letters.**| Input: "The cat" | Output: "the cat" |
| **Program splits lowercase string into array of lowercase words at each space, i.e (" ").**| Input: "the cat" | Output: {"the", "cat"} |
| **Program loops through arary of words checking to see if lowercase test word is present.**| Input: "Test Word: The; Test string: "The cat" | Output: "Compare: "the" to Array {"the", "cat"}." |
| **Program uses loop to return an integer value for the number of times the test word appears in the array.**| Input: "Test Word: "The"; Test String: "The cat" | Output: "1" |
| **Program evaluates splitting string for special characters and returns occurances of word.**| Input: "Test Word: "The"; Test String: "The,!! #cat@()cat (the),.the?CAT!" | Output: "3" |

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at https://github.com/devinmounts/WordCounter.Solution
1. Run `dotnet restore` from within the project directory
1. Make a new branch
1. Open WordSearch.Solution.sln in text editor
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .NET Core 1.1 SDK
* .NET runtime
* MS Test 1.1.11
* Mono
* Visual Studio

## Links

*  This program was previously named as WordSearch.Solutions, to view commit history for majority of project build visit: https://github.com/devinmounts/WordSearch.Solution.git

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Devin Mounts**