using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienInventory : MonoBehaviour
{
    [SerializeField] private int m_Score = 0;
    [SerializeField] private int m_Keys = 0;

    public void AddScore(int points) {
        m_Score += points;
    }
    
    public int GetScore() {
        return m_Score;
    }

    public void ObtainedKey() {
        m_Keys++;
    }
    
    public int GetKeys() {
        return m_Keys;
    }
}
