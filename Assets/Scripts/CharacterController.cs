using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 1.0f;
    Animator _animator;
    Rigidbody2D r2d;
    Vector3 charPos;
    SpriteRenderer _spriteRenderer;

    [SerializeField] GameObject _camera;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        r2d = GetComponent<Rigidbody2D>();
        charPos = transform.position;
    }

    void FixedUpdate() // (Timescale / fixed timestep) All physics applications must be in the fixedupdate method.
    {
        //r2d.velocity = new Vector2(speed, 0f);
    }

    void Update() 
    {
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;

        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat(nameof(speed), 0.0f);
        }
        else
        {
            _animator.SetFloat(nameof(speed), speed);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        } else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
    }

    void LateUpdate() 
    {
        _camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);
    }

}
