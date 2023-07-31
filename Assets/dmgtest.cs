using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgtest : MonoBehaviour
{
    public attributes PlayerAtr;
    public attributes EnemyAtr;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            PlayerAtr.DealDMG(EnemyAtr.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            EnemyAtr.DealDMG(PlayerAtr.gameObject);
        }
    }
}
