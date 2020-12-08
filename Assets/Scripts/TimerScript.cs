using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private int waitTime = 10;

    [SerializeField] private GameObject speechBubble;

    private int currentTick;



    private void Start()

    {

        currentTick = waitTime;

        StartCoroutine("Tick");

    }



    private IEnumerator Tick()

    {

        while (waitTime > 0)
        {

            print(waitTime);

            waitTime -= 1;

            yield return new WaitForSeconds(1f);

        }

        speechBubble.SetActive(true);

    }
}
