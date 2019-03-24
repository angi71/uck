using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public int number = 0;
    
    //Byrja með textan óvirkan
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void AddCount(int newCount)
    {
        number += newCount;
           //Geri textan virkan þegar að er búið að taka spill
        if (number ==1)
        {
            gameObject.SetActive(true);
        }
        else if (number == 4)
        {

        }
    }

}
