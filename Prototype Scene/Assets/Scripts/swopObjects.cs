using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swopObjects : MonoBehaviour
{

    public GameObject Thing01;
    public GameObject Thing02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            print("v key was pressed");
            swopFurniture();
        }
    }

    public void swopFurniture()
    {
        if (Thing01.active == true)
        {
            Thing01.active = false;
            Thing02.active = true;

        }
        else
        {
            Thing01.active = true;
            Thing02.active = false;
        }
    }
}
