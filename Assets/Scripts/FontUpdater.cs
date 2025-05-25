using UnityEngine;
using UnityEngine.UI;

public class FontUpdater : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.currentFont != null)
        {
            text = GetComponent<Text>();
            text.font = GameManager.currentFont;
        }
    }

    void OnEnable()
    {
        if (GameManager.currentFont != null)
        {
            text = GetComponent<Text>();
            text.font = GameManager.currentFont;
        }
    }
}
