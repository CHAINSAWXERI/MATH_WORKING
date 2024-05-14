using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Result : MonoBehaviour
{
    [SerializeField] public TMP_Text ResultText;
    [SerializeField] public List<TextPage> ResultTexts = new List<TextPage>();
    public Page page;

    void Start()
    {
        
    }
    void Update()
    {
        for (int o = 0; o <= 5; o++)
        {
            for (int p = 0; p <= 7; p++)
            {
                page.page[o].line[p].
            }
        }
    }
}
