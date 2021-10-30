using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienEnergy : MonoBehaviour
{
    [SerializeField] private int m_Energy = 100;
    private CanvasCtl m_Canvas;
    private Animator m_Anim;
    private bool m_Dead = false;

    // Start is called before the first frame update
    void Start()
    {
        m_Canvas = (CanvasCtl)FindObjectOfType(typeof(CanvasCtl));
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetDamage(int damage)
    {
        m_Energy -= damage;
        m_Canvas.SetLife(m_Energy);
        if (m_Energy < 1) {
            m_Dead = true;
            m_Anim.SetTrigger("dead");
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        m_Canvas.RestartGame();
    }

    public bool isGameOver()
    {
        return m_Dead;
    }
}
