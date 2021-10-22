using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crush : Trap
{
    private Animator m_Anim;
    private HitBox[] m_HitBoxes;
    private ActivationBox m_ActivationBox;
    private bool m_HasHitPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        InitPlayerLifeObject();
        m_Damage = 10;
        m_Anim = GetComponent<Animator>();
        m_HitBoxes = (HitBox[])FindObjectsOfType(typeof(HitBox));
        m_ActivationBox = (ActivationBox)FindObjectOfType(typeof(ActivationBox));
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Anim.GetBool("Activated")) {
            bool hitPlayer = !m_HasHitPlayer;
            foreach(HitBox hb in m_HitBoxes) {
                hitPlayer &= hb.DetectPlayer();
            }
            bool enteredBothHitBoxes = true;
            foreach(HitBox hb in m_HitBoxes) {
                enteredBothHitBoxes &= hb.PlayerEnteredHitBox();
            }
            Debug.Log("HitBoxes:" + 
                    m_HitBoxes[0].DetectPlayer().ToString() +
                    " " + 
                    m_HitBoxes[1].DetectPlayer().ToString());
            //Debug.Log("enteredBothHitBoxes: " + enteredBothHitBoxes.ToString());
            // If both HItBoxes detect player, the player gets damage
            if (hitPlayer && !m_HasHitPlayer) {
                m_HasHitPlayer = true;
                DamagePlayer();
            }
        }
    }

    public void ActivateAnimation()
    {
        m_Anim.SetTrigger("Crush");
    }

    public void ActivateTrap() {
        Debug.Log("ActivatedTrap");
        m_Anim.SetBool("Activated", true);
    }

    public void StopTrap() {
        Debug.Log("StopTrap");
        m_Anim.SetBool("Activated", false);
        m_HasHitPlayer = false;
    }

}
