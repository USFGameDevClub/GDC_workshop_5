using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleWholeState : AppleBaseClass
{
    float rottenCountdown = 5f; 

    public override void enterState(AppleStateManager apple) // Overridden from AppleBaseClass
    {
        Debug.Log("Hello From Whole State");
    }

    public override void updateState(AppleStateManager apple) // Overridden from AppleBaseClass
    {
        if (rottenCountdown >= 0)
        {
            rottenCountdown -= Time.deltaTime;
        }
        else
        {
            apple.switchState(apple.RottenState);
        }
    }

    // Slight correction from the workshop. onPlayerEnter should check if the colliding object has a tag 'Player'
    public override void onPlayerEnter(AppleStateManager apple, Collision collision) 
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("Player"))
        {
            Debug.Log("You ate the apple");
        }
        apple.switchState(apple.ChewedState);
    }
}
