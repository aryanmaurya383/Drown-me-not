using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayATGameOver : MonoBehaviour
{
    public TextMeshProUGUI score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score " + ((int)DiverRepulsion.finalScore).ToString();
    }
}
