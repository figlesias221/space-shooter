using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreUI : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject highScoreUIEntryPrefab;
    [SerializeField] Transform elementWrapper;


    List<GameObject> uiElements = new();

    private void OnEnable()
    {
        UpdateUI(HighScoreElements.highScoreElements);
    }

    private void OnDisable()
    {
        UpdateUI(HighScoreElements.highScoreElements);
    }

    private void UpdateUI(List<HighScoreElement> list)
    {
        int i = 0;
        while (i < list.Count)
        {
            HighScoreElement highScoreElement = list[i];
            if (highScoreElement.score > 0)
            {
                if (i >= uiElements.Count)
                {
                    var inst = Instantiate(highScoreUIEntryPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent(elementWrapper);
                    uiElements.Add(inst);
                }

                var texts = uiElements[i].GetComponentsInChildren<TextMeshProUGUI>();
                texts[0].text = highScoreElement.playerName;
                texts[1].text = highScoreElement.score.ToString();
            }
            i++;
        }
    }
}
