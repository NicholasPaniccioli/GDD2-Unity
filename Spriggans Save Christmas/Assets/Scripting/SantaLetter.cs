using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaLetter : MonoBehaviour
{
    // list for the letters
    List<string> letterRequest = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        letterRequest.Add("Boat");
        letterRequest.Add("Sword");
        letterRequest.Add("Wand");
        letterRequest.Add("Dragon");
        letterRequest.Add("Coal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // check if the toy entered the bag is on the list
    public bool ListCheck()
    {
        return false;
    }
}
