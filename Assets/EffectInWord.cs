using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EffectInWord : MonoBehaviour
{
    [SerializeField] TMP_Text tmPro;
    [SerializeField] string specialWord;
    [SerializeField] Color32 color;

    void Update()
    {
        // SPECIAL WORD
        int startIndex = tmPro.text.IndexOf(specialWord);
        int lastIndex = startIndex + specialWord.Length;

        TMP_TextInfo textInfo = tmPro.textInfo;
        if (textInfo.characterCount > 0)
        {
            for (int i = startIndex; i < lastIndex; i++)
            {
                TMP_CharacterInfo charInfo = textInfo.characterInfo[i];

                int vertexIndex = charInfo.vertexIndex;

                Color32[] vertexColors = textInfo.meshInfo[charInfo.materialReferenceIndex].colors32;

                for (int j = 0; j < 4; j++)
                {
                    vertexColors[vertexIndex + j] = color;
                }
            }
        }
        tmPro.UpdateVertexData(TMP_VertexDataUpdateFlags.All);

    }

}
