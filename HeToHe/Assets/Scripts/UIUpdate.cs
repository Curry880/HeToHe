using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdate : MonoBehaviour
{
    [SerializeField] GameObject quizText;
    [SerializeField] TextMeshProUGUI currentNumText;
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] GameManager gameManager;
    private void Update()
    {
        if (gameManager.currentquiz > gameManager.ansQuiz.Length) return;
        currentNumText.text = gameManager.currentquiz.ToString();
        TimerText.text = gameManager.timer.ToString();
    }
    public void QuizUpdate(GameManager.Level level)
    {
        Debug.Log(level);
        if (gameManager.currentquiz > gameManager.ansQuiz.Length) return;
        if (level != GameManager.Level.esey)
        {
            quizText.GetComponent<TextMeshProUGUI>().fontSize = Random.Range(72, 156);
        }
        if(level == GameManager.Level.hard)
        {
            quizText.transform.Rotate(0, 0, Random.Range(-90, 90));
            Debug.Log("Hard");
        }
        if (gameManager.ansQuiz[gameManager.currentquiz - 1] == 0)
        {
            quizText.GetComponent<TextMeshProUGUI>().text = "‚Ö";
        }
        else
        {
            quizText.GetComponent<TextMeshProUGUI>().text = "ƒw";
        }
    }
}
