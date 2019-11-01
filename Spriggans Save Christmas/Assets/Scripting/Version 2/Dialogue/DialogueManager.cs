using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{

    public GameObject player; // Hold the player/spriggan
    public int diaInd; //Number for indication and management of what text to be shown
    public List <GameObject> dialogue; //Holds the text to be used
    public GameObject coal; //Holds the coal in the toy list
    public GameObject wood; //Holds the wood pile for reference
    public GameObject sword; //Hold the sword in the toy list
    public GameObject refiner; //Holds the refiner for reference


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Goes to Coal-Text or the Station-Text
        if(player.transform.position.x > 3 && diaInd == 0 || 
            player.transform.position.x > 9 && player.transform.position.y > 3 && diaInd == 6)
        {
            if(diaInd == 0)
            {
                dialogue[diaInd].SetActive(false);
                diaInd++;
                dialogue[diaInd].SetActive(true);
            }
            else if (diaInd == 6)
            {
                dialogue[diaInd - 6].SetActive(false);
                diaInd++;
                dialogue[diaInd - 6].SetActive(true);
            }
        }

        //Goes to Holding-Text or the Sword-Text
        if (player.GetComponent<Player>().holdingName == "Coal" && diaInd == 1 ||
            Input.GetKeyDown(KeyCode.Space) && diaInd == 7)
        {
            if (diaInd == 1)
            {
                dialogue[diaInd].SetActive(false);
                diaInd++;
                dialogue[diaInd].SetActive(true);
            }
            else if (diaInd == 7)
            {
                dialogue[diaInd - 6].SetActive(false);
                diaInd++;
                dialogue[diaInd - 5].SetActive(true);
            }
        }

        //Goes to ToyList-Text
        if(player.transform.position.x < 12 && diaInd == 2 || 
             diaInd == 8 && player.GetComponent<Player>().holdingName == "Wood")
        {
            if (diaInd == 2)
            {
                dialogue[diaInd].SetActive(false);
                diaInd++;
                dialogue[diaInd].SetActive(true);
            }
            else if (diaInd == 8)
            {
                dialogue[diaInd - 7].SetActive(false);
                diaInd++;
                dialogue[diaInd - 6].SetActive(true);
                
            }
        }

        //Goes to Santa-Text or Refiner Text
        if(player.transform.position.y > 3 && diaInd == 3
            || refiner.GetComponent<Refiner>().holdingName == "Wood" && diaInd == 9)
        {
            if (diaInd == 3)
            {
                dialogue[diaInd].SetActive(false);
                diaInd++;
                dialogue[diaInd].SetActive(true);
            }
            else if (diaInd == 9)
            {
                dialogue[diaInd - 6].SetActive(false);
                diaInd++;
                dialogue[diaInd - 6].SetActive(true);
            }
        }

        //Goes to Bench-Text
        if (coal.active == false && diaInd == 4
            || Input.GetKeyDown(KeyCode.Space) && diaInd == 10)
        {
            if (diaInd == 4)
            {
                dialogue[diaInd].SetActive(false);
                diaInd++;
                dialogue[diaInd].SetActive(true);
            }
            else if (diaInd == 10)
            {
                dialogue[diaInd - 6].SetActive(false);
                diaInd++;
                dialogue[diaInd - 6].SetActive(true);
            }
        }

        //Goes to Craft-Text
        if(Input.GetKeyDown(KeyCode.Space) && diaInd == 11 && (player.GetComponent<Player>().holdingName == "Wood"))
        {
            dialogue[diaInd - 6].SetActive(false);
            diaInd++;
            dialogue[diaInd - 6].SetActive(true);
        }

        //Goes to Finish Text
        if (Input.GetKeyDown(KeyCode.Space) && diaInd == 12 && player.GetComponent<Player>().holdingName == "Sword")
        {            
            dialogue[diaInd - 6].SetActive(false);
            diaInd++;
            dialogue[diaInd - 6].SetActive(true);
            
        }

        //Goes to Santa text
        if(diaInd == 13 && player.transform.position.x < 12)
        {         
            dialogue[diaInd - 6].SetActive(false);
            diaInd++;
            dialogue[diaInd - 6].SetActive(true);           
        }
        //Goes to Continue text
        if(sword.active == false && diaInd == 14)
        {            
            dialogue[diaInd - 6].SetActive(false);
            diaInd++;
            dialogue[diaInd - 6].SetActive(true);          
        }


        if (Input.GetKeyDown(KeyCode.Space) && diaInd == 5)
        {
           diaInd++;
            SceneManager.LoadScene("SecondLevel");
        }

        if(Input.GetKeyDown(KeyCode.N) && diaInd == 15)
        {
            SceneManager.LoadScene("TheCOolOurScene");
        }
    }
}
