using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    private bool m_PlayerEnterHitBox = false;
    private bool m_PlayerExitHitBox = false;
    private bool m_PlayerOnHitBox = false;

    protected void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            m_PlayerEnterHitBox = true;
            m_PlayerExitHitBox = false;
        }
    }

    protected void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            m_PlayerEnterHitBox = false;
            m_PlayerOnHitBox = true;
        }
    }

    protected void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            m_PlayerEnterHitBox = false;
            m_PlayerExitHitBox = true;
            m_PlayerOnHitBox = false;
        }
    }

    public bool PlayerEnteredHitBox() {
        return m_PlayerEnterHitBox;
    }

    public bool PlayerOnHitBox() {
        return m_PlayerOnHitBox;
    }

    public bool PlayerExitedHitBox() {
        return m_PlayerExitHitBox;
    }

    public bool DetectPlayer() {
        return ( m_PlayerEnterHitBox || m_PlayerOnHitBox ) && !m_PlayerExitHitBox;
    }
}
