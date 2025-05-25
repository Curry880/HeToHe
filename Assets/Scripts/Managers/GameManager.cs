using UnityEngine;

public enum Level
{
    Esey,
    Normal,
    Hard
};

public static class GameManager
{
    public static int numOfQuestions = 10;
    public static int numOfCorrects = 0;
    public static float Timer = 0;
    public static Level currentLevel = Level.Esey;
    public static Font currentFont = null;
}
