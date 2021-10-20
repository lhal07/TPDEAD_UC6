using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienEnergy : MonoBehaviour
{
    [SerializeField] private int m_Energy = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage(int damage) {
        m_Energy -= damage;
    }
}
