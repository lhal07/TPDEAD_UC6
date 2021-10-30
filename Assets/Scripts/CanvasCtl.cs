using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasCtl : MonoBehaviour
{

    private Slider m_SliderLife;
    private Text m_TextScore;
    private Image m_ImageKey1;
    private Image m_ImageKey2;

    // Start is called before the first frame update
    void Start()
    {
        m_TextScore = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        m_SliderLife = this.gameObject.transform.GetChild(2).GetComponent<Slider>();
        m_ImageKey1 = this.gameObject.transform.GetChild(3).GetComponent<Image>();
        m_ImageKey2 = this.gameObject.transform.GetChild(4).GetComponent<Image>();
        SetScore(0);
        SetLife(100);
        SetKeys(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int score) {
        m_TextScore.text = "SCORE: " + score.ToString();
    }

    public void SetLife(int life) {
        m_SliderLife.value = life;
    }

    public void SetKeys(int n_keys) {
        m_ImageKey1.enabled = (n_keys > 0);
        m_ImageKey2.enabled = (n_keys > 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Cenas/Jogo");
    }
}
