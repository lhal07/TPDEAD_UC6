using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : Collectable
{
    private int m_Points = 5;

    public override void DetectedPlayer()
    {
        m_Alien.AddScore(m_Points);
    }
}
