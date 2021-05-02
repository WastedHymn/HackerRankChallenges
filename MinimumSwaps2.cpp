// hackerRankSwapQuestion.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;

int main()
{
    int counter = 0;

    for (int i = 0; i < arr.size(); i++) {
        //check for if the element "i+1" is in the right place
        int K = i + 1;
        //if arr[i] is different then k search for element "K"s index
        if (arr[i] != K) {

            for (int j = i + 1; j < arr.size(); j++) {

                if (arr[j] == K) {
                    //Swap j. element and i. element    
                    swap(arr[i], arr[j]);
                    ++counter;
                    //Don't go any further in the array to save time. 
                    break;
                }
            }

        }
    }
    return counter;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
