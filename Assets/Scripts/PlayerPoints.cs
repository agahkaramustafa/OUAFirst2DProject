using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    AudioSource audioSource;

    void Awake() 
    {
        audioSource = GetComponent<AudioSource>();
        _text.text = Score.totalScore.ToString();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Diamond"))
        {
            Score.totalScore++;
            audioSource.Play();
            _text.text = Score.totalScore.ToString();
            Destroy(other.gameObject);
        }
    }
}
