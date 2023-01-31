using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D r2b;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        r2b = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1.0f;
            Debug.Log(message: "Hiz 1.0");

        }
        else
        {
            speed = 0.0f;
            Debug.Log(message: "Hiz 0.1");
        }

        _animator.SetFloat(name: "speed", speed);
        r2b.velocity = new Vector2(x: speed, y: 0f);
    } 
}
