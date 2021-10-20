using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : Trap
{
    // Start is called before the first frame update
    void Start()
    {
        InitPlayerLifeObject();
        m_Damage = 1;
        m_TimeDamage = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
