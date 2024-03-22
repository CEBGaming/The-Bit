using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOff : MonoBehaviour
{
  

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
