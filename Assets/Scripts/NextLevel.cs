using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    int _sceneIndex;

    void Awake() 
    {
        _sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(_sceneIndex);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
}
