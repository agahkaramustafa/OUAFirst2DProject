using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 0.0f;
    Animator _animator;
    Rigidbody2D r2d;

    void Start()
    {
        _animator = GetComponent<Animator>();
        r2d = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1.0f;
            Debug.Log("hız 1");
        }
        else
        {
            speed = 0.0f;
            Debug.Log("Hız 0");
        }

        _animator.SetFloat(nameof(speed), speed);
        r2d.velocity = new Vector2(speed, 0f);
    }

}
