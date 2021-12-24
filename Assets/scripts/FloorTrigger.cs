using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FloorTrigger : MonoBehaviour
{
    public GameObject exit;
public GameObject Sphere;
    public Text LifeText;
    public int life = 3;
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        life--;
        LifeText.text = "Life: " + life;
      if (life == 0)
       {
            exit.gameObject.SetActive(true);
       }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }

}
