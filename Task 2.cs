using UnityEngine;

public class Task2 : MonoBehaviour
{
    
    public float bookPrice;   
    public int copiesSold; 
    float discountrate = .40f; // Discount rate for when buying the book.
    

    float CalculateShipping(float sold) // function that calculates shipping cost.
    {
        return ((sold - 1) * .75f) + 3f ; // $3 are left alone as that never changes, so we calculate what the cost of each additional copy is.
        
    }

    float CalculateDiscount(float price, float discount) // function that calculates discount on book.
    {
        return price - (price * discount);  // normal price - the discounted amount.
    }

    float TotalCost() // function that calculates total cost
    {
        return ( (CalculateDiscount(bookPrice, discountrate)) + CalculateShipping(copiesSold)); // The price with the discount + shipping costs.
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Total Cost is: {TotalCost()}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
