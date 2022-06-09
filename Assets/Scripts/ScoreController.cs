using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    public Text rightScore;
    public Text leftScore;
    public ScoreManager manager;

    // Update is called once per frame
    void Update()
    {
        rightScore.text = manager.rightScore.ToString();
        leftScore.text = manager.leftScore.ToString();
    }
}
