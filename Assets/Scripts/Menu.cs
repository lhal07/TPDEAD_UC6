using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private Image m_CreditsImage;

    // Start is called before the first frame update
    void Start()
    {
        m_CreditsImage = this.transform.GetChild(3).GetComponent<Image>();
        m_CreditsImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Cenas/Jogo");
    }

    public void ShowCredits()
    {
        m_CreditsImage.gameObject.SetActive(true);
    }

    public void CloseCredits()
    {
        m_CreditsImage.gameObject.SetActive(false);
    }
}
