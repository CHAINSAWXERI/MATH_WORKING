using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public Page page;

    public void AddNum(int x, int y)
    {
        page.page[x].line[y]++;
        //bookColor[numPage].pageColor[x].lineColor[y] = Color.red;
    }
}
