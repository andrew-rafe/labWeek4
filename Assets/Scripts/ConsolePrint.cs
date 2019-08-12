using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{

    private int counter = 0;
    private string name;

    // Start is called before the first frame update
    void Start()
    {
        name = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(name + " : " + counter++);
    }
}
