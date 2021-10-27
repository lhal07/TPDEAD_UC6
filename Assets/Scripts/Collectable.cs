using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    protected AlienInventory m_Alien;

    // Start is called before the first frame update
    void Start()
    {
        m_Alien = (AlienInventory)FindObjectOfType(typeof(AlienInventory));
    }

    protected void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            DetectedPlayer();
            Destroy(this.gameObject);
        }
    }

    public abstract void DetectedPlayer();
}
