using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public Renderer rend;

    private int counter = 0;
    private int randNumber;

    // Start is called before the first frame update
    void Start()
    {
        randNumber = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.gameObject.name + " : " + counter);

        if (counter == 100 && this.gameObject.CompareTag("Red")) {
            rend.enabled = false;
        }
        
        if (counter == randNumber && this.gameObject.CompareTag("Blue")) {
            rend.enabled = false;
        }

        counter++;
    }
}
