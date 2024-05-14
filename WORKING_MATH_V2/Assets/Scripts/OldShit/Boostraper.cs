using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    public Page page = new Page();
    public List<PageColor> bookColor = new List<PageColor>();
    [SerializeField] public int QuaPages = 1;
    [SerializeField] public Book bookClass;
    [SerializeField] public Result result;

    void Start()
    {

        for (int o = 0; o <= 5; o++)
        {
            for (int p = 0; p <= 7; p++)
            {
                page.page[o].line.Add(0);
            }
        }

        
        bookClass.page = page;
        //bookClass.bookColor = bookColor;
        
        result.page = page;
        /*
        result.bookColor = bookColor;
        result.QuaPages = QuaPages;
        */
    }

    void Update()
    {
        
    }
}
