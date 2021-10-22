using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{

    private int m_Life = 3;
    private bool m_Destroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((m_Life <= 0) && (!m_Destroyed)) {
            m_Destroyed = true;
            Destroy(this.gameObject);
        }
    }

    public void GetDamage(int damage) {
        m_Life -= damage;
    }
}
