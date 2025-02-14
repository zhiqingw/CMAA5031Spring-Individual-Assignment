using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public Text text;

    void Start()
    {
        text.text = "Score:\n0"; // Reset text
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score:\n" + score; // Update text
    }

    // Update score
    public static void UpdateScore(int updateValue)
    {
        GameManager.score += updateValue;
    }
}
