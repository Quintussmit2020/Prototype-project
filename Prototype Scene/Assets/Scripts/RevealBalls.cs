using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealBalls : MonoBehaviour
{
    public GameObject reticle;
    public GameObject Balls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        RevealBallsNow();
    }

    private void OnTriggerExit(Collider other)
    {
        HideBallsNow();
    }
    private void RevealBallsNow()
    {
        Balls.active = true;
        reticle.active = true;
    }

    private void HideBallsNow()
    {
        
        Balls.active = false;
        reticle.active = false;
    }
}
