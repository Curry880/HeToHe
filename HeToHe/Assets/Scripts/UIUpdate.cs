using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdate : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI quizText;
    [SerializeField] TextMeshProUGUI currentNumText;
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] GameManager gameManager;
    private void Update()
    {
        if (gameManager.currentquiz > gameManager.ansQuiz.Length) return;
        currentNumText.text = gameManager.currentquiz.ToString();
        TimerText.text = gameManager.timer.ToString();
        if(gameManager.ansQuiz[gameManager.currentquiz-1] == 0)
        {
            quizText.text = "‚Ö";
        }
        else
        {
            quizText.text = "ƒw";
        }
    }
}
