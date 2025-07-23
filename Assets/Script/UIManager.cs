using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    public GameObject TitleScreen;
    public GameObject ReadyScreen;
    public GameObject GameOverScreen;
    public GameObject ScoreUI;

    public void UpdateScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    public void ShowStart()
    {
        TitleScreen.SetActive(true);
        ReadyScreen.SetActive(false);
        GameOverScreen.SetActive(false);
        ScoreUI.SetActive(false);
    }

    public void HideStart()
    {
        TitleScreen.SetActive(false);
    }

    public void ShowReady()
    {
        TitleScreen.SetActive(false);
        ReadyScreen.SetActive(true);
        GameOverScreen.SetActive(false);
    }

    public void HideReady()
    {
        ReadyScreen.SetActive(false);
        ScoreUI.SetActive(true);
    }

    public void ShowGameOver()
    {
        GameOverScreen.SetActive(true);
    }


}
