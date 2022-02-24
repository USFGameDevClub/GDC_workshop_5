using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRottenState : AppleBaseClass
{
    public override void enterState(AppleStateManager apple) // Overridden from AppleBaseClass
    {
        Debug.Log("Hello from Rotten State!");
    }

    // Slight correction from the workshop. onPlayerEnter should check if the colliding object has a tag 'Player'
    public override void onPlayerEnter(AppleStateManager apple, Collision collision) // Overridden from AppleBaseClass
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("Player"))
        {
            Debug.Log("You ate the apple");
        }
        apple.switchState(apple.ChewedState);

    }

    public override void updateState(AppleStateManager apple)
    {
    }
}
