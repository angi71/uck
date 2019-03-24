using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomPlace : MonoBehaviour
{
    //Dreifi spilonum um borið
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(-6.7f, 6.7f), Random.Range(6.5f, 6.6f), Random.Range(-3f,3f));
        transform.position = position;
        Quaternion rotation = Quaternion.Euler(90f, Random.Range(0f, 179f), Random.Range(0f, 179f));
        transform.rotation = rotation;
    }
}
