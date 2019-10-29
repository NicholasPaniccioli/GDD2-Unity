using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int timeLeft = 120;
    public Text countDown;
    public bool winGame;

    // Start is called before the first frame update
    void Start()
    {
        //Start thread for Timer
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        winGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        countDown.text = ("" + timeLeft);
    }
    /// <summary>
    ///Method to adjust the timer
    /// </summary>
    /// <returns></returns>
    IEnumerator LoseTime()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            if (winGame)
            {
                //transition to win screen
            }
            timeLeft--;
        }
        //Transition to loss screen
    }
}
