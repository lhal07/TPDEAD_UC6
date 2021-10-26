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

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter\n");
        if (collider.gameObject.tag == "Player") {
            DetectedPlayer();
            Destroy(this.gameObject);
        }
    }

    public abstract void DetectedPlayer();
}
