using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private GameObject player;
    private Vector2 facingPos;
    private GameObject gridMan;
    private Tile[,] grid;
    private GameObject santaBag;
    private SprigganHoldItem sprigganHoldItem; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Spriggan");
        facingPos = SprigMove.currentPos + SprigMove.forwardVec;
        gridMan = GameObject.Find("GridManager");
        grid = gridMan.GetComponent<GridManager>().Grid;
        santaBag = GameObject.Find("Santas ToyBag");
        sprigganHoldItem = player.GetComponent<SprigganHoldItem>();
    }

    // Update is called once per frame
    void Update()
    {
        facingPos = SprigMove.currentPos + SprigMove.forwardVec;
        grid = gridMan.GetComponent<GridManager>().Grid;
        Interact();
    }

    // method for player interaction and what to do
    public void Interact()
    {
        // player interaction
        if (Input.GetKeyDown(KeyCode.E))
        {
            // if the tile they are facing when interacting is an actual tile
            if (grid[(int)facingPos.x, (int)facingPos.y].name == "Workbench")
            {

            }
            else if (grid[(int)facingPos.x, (int)facingPos.y].name == "Cloth")
            {
                if (sprigganHoldItem.holding == false)
                {
                    sprigganHoldItem.holding = true;
                    sprigganHoldItem.item = grid[(int)facingPos.x, (int)facingPos.y].GetComponent<Resources>().GetResource("Cloth");
                }
            }
            else if (grid[(int)facingPos.x, (int)facingPos.y].name == "Coal")
            {
                if (sprigganHoldItem.holding == false)
                {
                    sprigganHoldItem.holding = true;
                    sprigganHoldItem.item = grid[(int)facingPos.x, (int)facingPos.y].GetComponent<Resources>().GetResource("Coal");
                }
            }
            else if (grid[(int)facingPos.x, (int)facingPos.y].name == "Wood")
            {
                if (sprigganHoldItem.holding == false)
                {
                    sprigganHoldItem.holding = true;
                    sprigganHoldItem.item = grid[(int)facingPos.x, (int)facingPos.y].GetComponent<Resources>().GetResource("Wood");
                }
            }
            else if (grid[(int)facingPos.x, (int)facingPos.y].name == "Cloth Weaver")
            {

            }
            else if (grid[(int)facingPos.x, (int)facingPos.y].name == "Wood Shaver")
            {

            }
            else if (grid[(int)facingPos.x, (int)facingPos.y].name == "Santa's Bag")
            {
                // if the player is holding something check if the item is on the list
                if (sprigganHoldItem.holding == true)
                {
                    if(santaBag.GetComponent<SantaLetter>().ListCheck(sprigganHoldItem.item.name) == true)
                    {
                        sprigganHoldItem.holding = false;
                        sprigganHoldItem.item = null;
                    }
                }
            }
        }
    }
}
