using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewritterEffect : MonoBehaviour
{
    [SerializeField] TMP_Text tmPro;
    [SerializeField] float timeDelay = 0.05f;
    int charactersCount;
    int counter;
    float timeCounter;
    private void Start()
    {
        charactersCount = tmPro.text.Length;
        Debug.Log(charactersCount);
        tmPro.maxVisibleCharacters = 0;
        counter = 0;
        timeCounter = Time.time;
    }
    private void Update()
    {
        if(counter<= charactersCount)
        {
            tmPro.maxVisibleCharacters = counter;

            if( Time.time > timeCounter + timeDelay)
            {
                timeCounter = Time.time;
                counter++;
            }
        }
        else
        {
            this.enabled = false;
        }
    }
}
