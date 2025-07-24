using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] private GameObject TitleScreen;
    [SerializeField] private GameObject ReadyScreen;
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject ScoreUI;

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
