using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject m_Projectile;
    private float m_ShotInterval = 0.5f;
    private float m_Timer = 0.0f;
    [SerializeField]
    private float m_Offset = 2.0f;

    // Update is called once per frame
    void Update()
    {
       m_Timer += Time.deltaTime;
       if (Input.GetKey(KeyCode.Return)) {
          Shoot();
       }
    }

    void Shoot()
    {
        if (m_Timer > m_ShotInterval) {
            m_Timer = 0.0f;
            Transform gunPoint = this.transform.GetChild(0);
            Vector3 position = gunPoint.position + gunPoint.forward * m_Offset;
            Instantiate(m_Projectile, position, gunPoint.rotation);
        }
    }

}
