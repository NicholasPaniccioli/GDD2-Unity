using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : Tile
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Combine resources together to make a toy
    public override bool Interact(Player player)
    {
        return false;
    }
}
