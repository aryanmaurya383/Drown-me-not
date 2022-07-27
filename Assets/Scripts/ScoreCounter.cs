using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    
    public TextMeshProUGUI score;
    public static float scoreValue;

    private void Start()
    {
        scoreValue = 0;
        
    }
    // Update is called once per frame
    void Update()
    {
        scoreValue += Time.deltaTime;
        
        score.text = "Score " + ((int)scoreValue).ToString();
    }
}
