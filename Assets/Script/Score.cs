using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int myScore =0;
    private int unit = 0;
    private int dizaine = 0;

    public Image ScoreUnite;
    public Image ScoreDizaine;
    public List<Sprite> Number;

    public void addScore()
    {
        myScore++;
        unit++;

        if (unit >= 10)
        {
            unit = 0;
            dizaine++;
        }

        changeScore(unit, dizaine);
        //GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }

    public void resetScore()
    {
        myScore = 0;
        unit = 0;
        dizaine = 0;
        changeScore(unit, dizaine);
        //GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }

    private void changeScore(int pointU ,int pointD)
    {
        //Debug.Log(myScore);
        ScoreDizaine.sprite = Number[pointD];
        ScoreUnite.sprite = Number[pointU];
    }
}
