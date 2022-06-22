using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    public float time=0;
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        score.text = "Score " + ((int)time).ToString();
    }
}
