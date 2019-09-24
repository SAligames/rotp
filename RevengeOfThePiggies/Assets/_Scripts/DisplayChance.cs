using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayChance : Observer
{
    public override void OnNotify(object o, NotificationType n)
    {
        if(n==NotificationType.ChanceUpdated)
        {
            GetComponent<TextMeshProUGUI>().text = "Number of shots: " + o;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
