using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{

    public Text scoreText;
    public GameObject Sphere;
    private int score;


    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        score++;
        scoreText.text = "SCORE: " + score;


    }
}
