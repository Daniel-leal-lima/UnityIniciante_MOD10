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

    public void ResetEffect()
    {
        charactersCount = tmPro.text.Length;
        tmPro.maxVisibleCharacters = 0;
        counter = 0;
        timeCounter = Time.time;
    }
    private void Start()
    {
        ResetEffect();
    }
    public bool EfeitoEstaAtivo()
    {
        return counter <= charactersCount;
    }

    public void CompletaTexto()
    {
        if (EfeitoEstaAtivo())
        {
            counter = charactersCount;
        }
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
            return;
        }
    }
}
