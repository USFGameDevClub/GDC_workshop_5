using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleStateManager : MonoBehaviour
{
    public AppleBaseClass currentState;
    public AppleChewedState ChewedState = new AppleChewedState();
    public AppleGrowingState GrowingState = new AppleGrowingState();
    public AppleWholeState WholeState = new AppleWholeState();
    public AppleRottenState RottenState = new AppleRottenState();


    public void switchState(AppleBaseClass state) // Allows us to switch from one state to another
    {
        currentState = state;
        state.enterState(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        currentState = GrowingState; // sets the inital state of the object
        currentState.enterState(this); 
    }

    // Update is called once per frame
    void Update()
    {
        currentState.updateState(this); // runs defined behaviour of the object for a set state
           
    }

    private void OnCollisionEnter(Collision collision) // Pre-defined Unity method for dealing with collisions in game
    {
        currentState.onPlayerEnter(this, collision);
    }
}
