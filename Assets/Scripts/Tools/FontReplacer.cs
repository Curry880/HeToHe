using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class FontReplacer : EditorWindow
{
    Font newFont;

    [MenuItem("Tools/Replace Fonts (UI Text)")]
    public static void ShowWindow()
    {
        GetWindow<FontReplacer>("Replace Fonts");
    }

    void OnGUI()
    {
        newFont = (Font)EditorGUILayout.ObjectField("New Font", newFont, typeof(Font), false);

        if (GUILayout.Button("Replace All UI Text Fonts"))
        {
            ReplaceFonts();
        }
    }

    void ReplaceFonts()
    {
        Text[] texts = Resources.FindObjectsOfTypeAll<Text>();

        int count = 0;
        foreach (Text t in texts)
        {
            if (t.font != newFont)
            {
                Undo.RecordObject(t, "Replace Font");
                t.font = newFont;
                EditorUtility.SetDirty(t);
                count++;
            }
        }
        Debug.Log($"Replaced fonts in {count} Text components.");
    }
}
