using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager _GameManager;

    public float _Speed = 10f;
    Rigidbody PlayerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_GameManager._IsGameOver)
            return;

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        float fallSpeed = PlayerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputY);
        velocity = velocity * _Speed;

        velocity.y = fallSpeed;

        PlayerRigidbody.velocity = velocity;
    }
}
