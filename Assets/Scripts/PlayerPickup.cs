using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public FoodType heldFood;

    private FoodItem currentFood;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentFood != null)
        {
            heldFood = currentFood.foodType;

            Debug.Log("Picked up: " + heldFood);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FoodItem food = collision.GetComponent<FoodItem>();

        if (food != null)
        {
            currentFood = food;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FoodItem food = collision.GetComponent<FoodItem>();

        if (food != null)
        {
            currentFood = null;
        }
    }
}