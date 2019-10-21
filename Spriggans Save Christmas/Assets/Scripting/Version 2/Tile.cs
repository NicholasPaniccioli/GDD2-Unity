using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public string holdingName;  // name of the object the tile is holding
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
    public bool Interact()
    {
        return false;
    }
}

