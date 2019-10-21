using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantasSack : Tile
{
    // Started by Kyle

    public List<string> toyList;   // list of strings representing the toys to be made

    // default constructor for SantasSack
    public SantasSack()
    {
        toyList = new List<string>();   // make a new list
        toyList.Add("dragon");
        toyList.Add("sword");
        toyList.Add("wand");
        toyList.Add("boat");
        toyList.Add("coal");
    }

    // parameterized constructor for SantasSack
    // can specify a list of toys
    public SantasSack(List<string> _toyList)
    {
        toyList = _toyList;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool Interact(Player player)
    {
        if (player.isHolding) //makes sure the player is holding an object...
        {
            if (CheckGift(player.holdingName)) //...and that the object is one that the player needed to make...
            {
                //...then delete the object from the players inventory
                player.isHolding = false;
                player.holdingName = "";
                return true;
            }
            return false;
        }
        return false;
    }

    // Check to see if the gift is correct.
    // Loop through the list of toys.
    // If the toy is in the list, remove toy from toyList and return true.
    // Else, return false.
    bool CheckGift(string toyName)
    {
        for(int i = 0; i < toyList.Count; i++ ) // loop through all of the toys in toyList
        {
            if(toyName == toyList[i])   // if the name of the toy is in the list
            {
                toyList.RemoveAt(i);    // remove toy from toyList
                return true;            // return true
            }
        }
        return false;   // if toy is not in toyList, do nothing to toyList and return false
    }
}
