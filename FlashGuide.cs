using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashGuide : MonoBehaviour
{
    float number;
    
    // Start is called before the first frame update
    void Start()
    {
        number=1;
    }

    // Update is called once per frame
    void Update()
    {
        number=number+0.5f;
        if (number%2==0)
        GetComponent<SpriteRenderer>().enabled=false;
        else
        GetComponent<SpriteRenderer>().enabled=true;
    }
}
