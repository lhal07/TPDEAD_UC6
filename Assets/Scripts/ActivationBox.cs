using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationBox : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            this.transform.parent.gameObject.GetComponent<Crush>().ActivateAnimation();
        }
    }
}
