using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponattr : MonoBehaviour
{
    public attributes atm;

    private void OnTriggerEnter(Collider other)
    {
        System.Console.WriteLine("piff");
        if (other.CompareTag("enemy")) 
        {
            other.GetComponent<attributes>().TakeDMG(atm.attack);
            System.Console.WriteLine("puff");
        }
    }
}
