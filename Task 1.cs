using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Declare variables
    public int input; // Input value



    // Start is called before the first frame update
    void Start()
    {
        GetDigits();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDigits()
    {
        // Output the values all at once
        Debug.Log($"I owe you {GetHundreds(input)} $100 bills, {GetFifites(input)} $50 bills, {GetTwenties(input)} $20 bills, {GetTens(input)} $10 bills, {GetFives(input)} $5 bills, and {GetOnes(input)} $1 bills.");
    }

    // Get the number of $100 bills
    int GetHundreds(int input) {
        return input / 100;     // Dividing integers truncates the decimal at the end
    }

    // Get the number of $50 bills
    int GetFifites(int input) {
        return (input % 100) / 50;  // Modulous removes the hundreds digit
    }

    int GetTwenties(int input) {
        return ((input % 100) % 50) / 20;
    }

    int GetTens(int input) {
        return (((input % 100) % 50) % 20) / 10;
    }

    int GetFives(int input) {
        return ((((input % 100) % 50) % 20) % 10) / 5;
    }

    int GetOnes(int input) {
        return (((((input % 100) % 50) % 20) % 10) % 5) / 1;
    }
}
