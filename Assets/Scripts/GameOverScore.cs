using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;


    void Update()
    {

        score.text = "Score " + ((int)DiverRepulsion.finalScore).ToString();
    }
}
