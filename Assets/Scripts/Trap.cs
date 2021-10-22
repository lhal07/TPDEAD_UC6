using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trap : MonoBehaviour
{
    protected int m_Damage = 1;
    protected AlienEnergy m_Alien;
    protected float m_Timer = 0f;
    protected float m_TimeDamage = 1.0f;

    public void DamagePlayer() {
        Debug.Log("Damage Player: " + m_Damage.ToString());
        m_Alien.GetDamage(m_Damage);
    }

    protected void InitPlayerLifeObject() {
        m_Alien = (AlienEnergy)FindObjectOfType(typeof(AlienEnergy));
    }

    protected void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter\n");
        if (collider.gameObject.tag == "Player") {
            DamagePlayer();
            m_Timer = 0;
        }
    }

    protected virtual void OnTriggerStay(Collider collider)
    {
        Debug.Log("OnTriggerStay\n");
        if (collider.gameObject.tag == "Player") {
            m_Timer += Time.deltaTime;
            if (m_Timer >= m_TimeDamage) {
                DamagePlayer();
                m_Timer = 0;
            }
        }
    }

}
