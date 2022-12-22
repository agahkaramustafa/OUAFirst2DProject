using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    Scene _scene;

    void Awake() 
    {
        _scene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.lives--;
            SceneManager.LoadScene(_scene.name);
            Score.totalScore = 0;
        }
    }
}
