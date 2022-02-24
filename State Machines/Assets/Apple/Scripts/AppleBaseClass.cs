using UnityEngine;

public abstract class AppleBaseClass // Base class from which all states inherit from
{
    public abstract void enterState(AppleStateManager apple); // defines behaviour of object when state is entered
    public abstract void updateState(AppleStateManager apple); // defines behaviour of object while in a certain state
    public abstract void onPlayerEnter(AppleStateManager apple, Collision collision); // defines behaviour of object when a player character comes in contact with it
}
