using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhichRoom : MonoBehaviour
{
    public int yellowScore = 5;
    public int redScore = 10;
    public int purpleScore = 15;
    public int blueScore = 20;
    public static int score;

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.name == "Yellow")
            {
            score += yellowScore;
            }
        if (collision.gameObject.name == "Red")
            {
            score += redScore;
            }
        if (collision.gameObject.name == "Purple")
            {
            score += purpleScore;
            }
        if (collision.gameObject.name == "Blue")
            {
            score += blueScore;
            }
        }
    }
