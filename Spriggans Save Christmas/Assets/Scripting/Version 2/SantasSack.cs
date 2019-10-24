using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantasSack : Tile
{
    // Started by Kyle

    public List<string> toyList;   // list of strings representing the toys to be made

    GameObject listBoat;
    GameObject listDragon;
    GameObject listSword;
    GameObject listWand;
    GameObject listCoal;
    


    // default constructor for SantasSack
    public SantasSack()
    {
        toyList = new List<string>();   // make a new list
        toyList.Add("Dragon");
        toyList.Add("Sword");
        toyList.Add("Wand");
        toyList.Add("Boat");
        toyList.Add("Coal");
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
        listBoat = GameObject.Find("List Boat");
        listDragon = GameObject.Find("List Dragon");
        listSword = GameObject.Find("List Sword");
        listWand = GameObject.Find("List Wand");
        listCoal = GameObject.Find("List Coal");
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
    public bool CheckGift(string toyName)
    {
        for(int i = 0; i < toyList.Count; i++ ) // loop through all of the toys in toyList
        {
            if(toyName.ToLower() == toyList[i])   // if the name of the toy is in the list
            {
                if(toyName == "Boat")
                {
                    listBoat.SetActive(false);  // remove Boat sprite from Toy List UI
                }
                if (toyName == "Dragon")
                {
                    listDragon.SetActive(false);    // remove Dragon sprite from Toy List UI
                }
                if (toyName == "Sword")
                {
                    listSword.SetActive(false);     // remove Sword sprite from Toy List UI
                }
                if (toyName == "Wand")
                {
                    listWand.SetActive(false);      // remove Wand sprite from Toy List UI
                }
                if (toyName == "Coal")
                {
                    listCoal.SetActive(false);      // remove Coal sprite from Toy List UI
                }
                Debug.Log("Successfully removed " + toyList[i] + " from Toy List.");    // output success message to console, specifying what was removed
                toyList.RemoveAt(i);    // remove toy from toyList
                return true;            // return true
            }
        }
        Debug.Log("Did not remove " + toyName + " from Toy List."); // output failure message to console, specifying what was not removed
        return false;   // if toy is not in toyList, do nothing to toyList and return false
    }
}
