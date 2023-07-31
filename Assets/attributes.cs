using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attributes : MonoBehaviour
{
    public int health;
    public int attack;

    public void TakeDMG(int dmg)
    {
        health -= dmg;
    }
    public void DealDMG(GameObject target)
    {
        var atm = target.GetComponent<attributes>();
        if (atm != null)
        {
            atm.TakeDMG(attack);
        }
    }
}
