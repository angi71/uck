using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp : MonoBehaviour
{
    public Text stateText;
    public Text countText;
    public GameObject text;


    private Count count;
    private Collider coll;

    private void Awake()
    {
        //næ í count scriftina
        count = text.GetComponent<Count>();
        coll = GetComponent<Collider>();
    }

    private void OnMouseDown()
    {
        //Næ í spill og breyti stöðuni í að spyrja
        string value = text.name;
        count.AddCount(1);
        countText.text = value + ":" + count.number; ;
        gameObject.SetActive(false);
        stateText.text = "Ask";
    }

    private void Update()
    {
        //slekur á collisun þegar það á ekki veiða
        if (stateText.text != "Fish")
        {
           coll.enabled = false;
        }
    }
}
