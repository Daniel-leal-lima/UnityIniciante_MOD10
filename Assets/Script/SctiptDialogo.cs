using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SctiptDialogo : MonoBehaviour
{   
    [System.Serializable]
    struct Dialogo
    {
        public Sprite personagem;
        public string dialogo;
    }

    [SerializeField] Dialogo[] dialogos;
    [SerializeField] TMP_Text tmPro;
    [SerializeField] Image spritePersonagem;
    [SerializeField] TypewritterEffect scriptTypeWritterEffect;
    [SerializeField] int indexConversa;

    private void Start()
    {
        Reset();
    }
    private void Reset()
    {
        indexConversa = 0;
        tmPro.text = dialogos[indexConversa].dialogo;
        spritePersonagem.sprite = dialogos[indexConversa].personagem;
        scriptTypeWritterEffect.ResetEffect();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (scriptTypeWritterEffect.EfeitoEstaAtivo())
            {
                SkipDialogo();
            }
            else
            {
                MudaDialogo();
            }
        }
    }


    void SkipDialogo()
    {
        scriptTypeWritterEffect.CompletaTexto();
    }

    void MudaDialogo()
    {
        if (indexConversa < dialogos.Length - 1)
        {
            indexConversa++;
        }
        else
        {
            return;
        }
        tmPro.text = dialogos[indexConversa].dialogo;
        spritePersonagem.sprite = dialogos[indexConversa].personagem;
        scriptTypeWritterEffect.ResetEffect();
    }


    public void OnButtonClick()
    {
        Reset();
    }
}
