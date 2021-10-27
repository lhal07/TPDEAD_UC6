using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : Collectable
{
    public override void DetectedPlayer()
    {
        m_Alien.ObtainKey();
    }
}
