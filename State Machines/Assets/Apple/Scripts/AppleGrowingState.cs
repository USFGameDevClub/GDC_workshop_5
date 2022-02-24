using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGrowingState : AppleBaseClass
{
    Vector3 appleStartingSize = new Vector3(0.1f, 0.1f, 0.1f); // Initial size of apple
    Vector3 growAppleAScalar = new Vector3(0.2f, 0.2f, 0.2f); // Growth rate of apple
    Vector3 appleFinalSize = new Vector3(1, 1, 1); // Final size of apple
    public override void enterState(AppleStateManager state) // Overridden from AppleBaseClass
    {
        Debug.Log("Hello from GrowingState");
        state.transform.localScale = appleStartingSize;
    }

    public override void onPlayerEnter(AppleStateManager apple, Collision collision) // Overridden from AppleBaseClass
    {

    }

    public override void updateState(AppleStateManager apple) // Overridden from AppleBaseClass
    {
        if (apple.transform.localScale.x < 1)
        {
            apple.transform.localScale += growAppleAScalar * Time.deltaTime; // increments local scale of apple by growAppleScalar 
        }
        else
        {
            apple.transform.localScale = appleFinalSize;
            apple.switchState(apple.WholeState);
        }

    }
}
