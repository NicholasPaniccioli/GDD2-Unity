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
    public GameObject sword; //Hold the sword in the toy list


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
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to Holding-Text or the Sword-Text
        if (player.GetComponent<Player>().holdingName == "Coal" && diaInd == 1 ||
            Input.GetKeyDown(KeyCode.Space) && diaInd == 7)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to ToyList-Text
        if(player.transform.position.x < 12 && diaInd == 2 || 
            Input.GetKeyDown(KeyCode.Space) && diaInd == 8)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to Santa-Text
        if(player.transform.position.y > 3 && diaInd == 3)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        //Goes to Continue-Text
        if (coal.activeSelf == false && diaInd == 4)
        {
            dialogue[diaInd].SetActive(false);
            diaInd++;
            dialogue[diaInd].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && diaInd == 5)
        {
           diaInd++;
            SceneManager.LoadScene("SecondLevel");
        }

        if(Input.GetKeyDown(KeyCode.Space) && diaInd == 11)
        {
            SceneManager.LoadScene("TheCOolOurScene");
        }
    }
}
