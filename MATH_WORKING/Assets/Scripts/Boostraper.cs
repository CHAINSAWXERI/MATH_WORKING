using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    public List<Page> book = new List<Page>();
    public List<PageColor> bookColor = new List<PageColor>();
    [SerializeField] public int QuaPages;

    void Start()
    {
        for (int i = 0; i <= QuaPages; i++)
        {
            for (int o = 0; o <= 5; o++)
            {
                for (int p = 0; p <= 7; p++)
                {
                    book[i].page[o].line.Add(0);
                }
            }
        }

        for (int i = 0; i <= QuaPages; i++)
        {
            for (int o = 0; o <= 5; o++)
            {
                for (int p = 0; p <= 7; p++)
                {
                    bookColor[i].pageColor[o].colorLine.Add(Color.white);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
