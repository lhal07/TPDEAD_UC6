using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Trap
{
    // Start is called before the first frame update
    void Start()
    {
        InitPlayerLifeObject();
        m_Damage = 5;
        m_TimeDamage = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
