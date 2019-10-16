using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprigganHoldItem : MonoBehaviour
{
    public GameObject item; //The item the player is holding
    public bool holding; //Is the player holding an item?
    bool facing; //Is the player facing the table to interact with?

    GameObject spriggan; //The Player
    List <GameObject> materials; //The materials the player can pick up
    Vector2 forwardVec = SprigMove.forwardVec;
    Vector2 currentPos = SprigMove.currentPos;


    // Start is called before the first frame update
    void Start()
    {
        holding = false;

        //Loops through all the material stations to check if player starts facing one
        for(int i = 0; i < materials.Count; i ++)
        {    
            //Checks if the player is facing a station
            if(new Vector3(currentPos.x + forwardVec.x, currentPos.y + forwardVec.y, materials[i].transform.position.z) == materials[i].transform.position)
            {
                facing = true;
            }
            else
            {
                facing = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Loops through all the material stations to check if player starts facing one
        for(int i = 0; i < materials.Count; i ++)
        {    
            //Checks if the player is facing a station
            if(new Vector3(currentPos.x + forwardVec.x, currentPos.y + forwardVec.y, materials[i].transform.position.z) == materials[i].transform.position)
            {
                facing = true;
            }
            else
            {
                facing = false;
            }
        }

        //PUESDO CODE
        //if(facing = true && holding == false && Players INPUT BUTTON)
        //{
        //        Check the station for what object it is
        //        Pick up appropriate upject
        //        holding = true;
        //        item = MATERIAL ITEM
        //}
    }
}
