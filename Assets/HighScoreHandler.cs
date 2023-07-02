using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreHandler : MonoBehaviour
{
    [SerializeField] int maxCount;
    [SerializeField] string fileName;

    public delegate void OnHighScoreChange(List<HighScoreElement> list);
    public static event OnHighScoreChange onHighScoreChange;

    private void Start()
    {
        LoadHighScores();
    }

    private void LoadHighScores()
    {
        HighScoreElements.highScoreElements = FileHandler.ReadListFromJSON<HighScoreElement>(fileName);

        while (HighScoreElements.highScoreElements.Count > maxCount)
        {
            HighScoreElements.highScoreElements.RemoveAt(maxCount);
        }

        if (onHighScoreChange != null)
        {
            onHighScoreChange.Invoke(HighScoreElements.highScoreElements);
        }
        Debug.Log(HighScoreElements.highScoreElements.Count);
    }

    private void SaveHighScores()
    {
        FileHandler.SaveToJSON(HighScoreElements.highScoreElements, fileName);
    }

    public void AddHighScoreIfPossible(HighScoreElement element)
    {
        for (int i = 0; i < maxCount; i++)
        {
            if (i >= HighScoreElements.highScoreElements.Count || element.score > HighScoreElements.highScoreElements[i].score)
            {
                HighScoreElements.highScoreElements.Insert(i, element);

                while (HighScoreElements.highScoreElements.Count > maxCount)
                {
                    HighScoreElements.highScoreElements.RemoveAt(maxCount);
                }

                SaveHighScores();

                if (onHighScoreChange != null)
                {
                    onHighScoreChange.Invoke(HighScoreElements.highScoreElements);
                }

                break;
            }
        }

    }
}
