using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramplines : MonoBehaviour
{
    public float jumpFactor = 2.5f;
    
    void OnTriggerEnter(Collider other)
    {
        // Увеличение силы прыжкагрока

        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }
    void OnTriggerExit(Collider other)
    {
        //Понижение силы прыжка

        other.GetComponent<Jump>().jumpStrength /= jumpFactor;

    }
}
    