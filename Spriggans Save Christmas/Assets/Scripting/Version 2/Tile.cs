using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//state of resource, unrefined for raw resources, done for if it a completed object.  If the player has nothing in hand, empty
public enum HoldingState
{
    unrefined,
    state1,
    state2,
    state3,
    finished
}

public class Tile : MonoBehaviour
{
    public string holdingName;  // name of the object the tile is holding
    public HoldingState holdingState;
    public bool isHolding;      // true if holding something, false if not holding something

    // Default Constructor
    public Tile()
    {
        isHolding = false;  // isHolding is false by default;
    }

    // Parameterized Constructor
    // Can specifiy isHolding and holdingName
    public Tile(bool _isHolding, string _holdingName)
    {
        isHolding = _isHolding; // the object is holding something or not
        holdingName = _holdingName; // the name of the object that is held.
    }

    // method to be overridden/overloaded :)
    public virtual bool Interact(Player player)
    {
        return false;
    }
}

