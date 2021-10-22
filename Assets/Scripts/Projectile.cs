using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Projectile : MonoBehaviour
{
    private Rigidbody m_Rb;
    private BreakableWall m_BW;
    private float m_Timer = 0.0f;
    private float m_LifeSpan = 0.5f;
    private bool m_Destroyed = false;
    private int m_Damage = 1;
    [SerializeField]
    private float m_Speed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        m_Rb = gameObject.GetComponent<Rigidbody>();
        m_Rb.AddForce(this.transform.forward * m_Speed);
    }

    // Update is called once per frame
    void Update()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer > m_LifeSpan) {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        m_BW = col.GetComponent<BreakableWall>();
        print ("Hit " + col.tag + "\n");
        if (col.CompareTag("Wall")) {
            DestroyProjectile();
            return;
        }
        if (col.CompareTag("BreakableWall")) {
            DestroyProjectile();
            m_BW.GetDamage(m_Damage);
            return;
        }
    }

    void DestroyProjectile(float delay=0.0f) {
        if (!m_Destroyed) {
            m_Destroyed = true;
            Destroy(this.gameObject,delay);
        }
    }

}
