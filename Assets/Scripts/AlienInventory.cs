using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienInventory : MonoBehaviour
{
    [SerializeField] private int m_Score = 0;
    [SerializeField] private int m_Keys = 0;
    private CanvasCtl m_Canvas;

    public void Start()
    {
        m_Canvas = (CanvasCtl)FindObjectOfType(typeof(CanvasCtl));
        m_Canvas.SetScore(m_Score);
        m_Canvas.SetKeys(m_Keys);
    }

    public void AddScore(int points)
    {
        m_Score += points;
        m_Canvas.SetScore(m_Score);
    }
    
    public int GetScore()
    {
        return m_Score;
    }

    public void ObtainKey()
    {
        m_Keys++;
        m_Canvas.SetKeys(m_Keys);
    }
    
    public int GetKeys()
    {
        return m_Keys;
    }
}
