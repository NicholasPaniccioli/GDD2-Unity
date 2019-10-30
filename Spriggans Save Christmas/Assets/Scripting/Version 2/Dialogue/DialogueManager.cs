using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject player; // Hold the player/spriggan
    public int diaInd; //Number for indication and management of what text to be shown
    public List <GameObject> dialogue; //Holds the text to be used
    public GameObject coal; //Holds the coal in the toy list


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Goes to Coal-Text
        if(player.transform.position.x > 3 && diaInd == 0)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to Holding-Text
        if(player.GetComponent<Player>().holdingName == "Coal" && diaInd == 1)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to ToyList-Text
        if(player.transform.position.x < 17 && diaInd == 2)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to Santa-Text
        if(player.transform.position.x < 12 && diaInd == 3)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to Continue-Text
        if (coal.active == false && diaInd == 4)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }
    }
}
