using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationDoor : MonoBehaviour
{
    private Animator m_Anim;
    protected AlienInventory m_Alien;

    // Start is called before the first frame update
    void Start()
    {
        m_Anim = this.transform.parent.GetComponent<Animator>();
        m_Alien = (AlienInventory)FindObjectOfType(typeof(AlienInventory));
    }

    void OnTriggerEnter(Collider collider)
    {
        if ((collider.gameObject.tag == "Player") && (m_Alien.GetKeys() >= 2) ) {
            m_Anim.SetTrigger("OpenDoor");
        }
    }
}
