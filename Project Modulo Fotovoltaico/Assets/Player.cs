using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;

    Vector3 MoviEixoX;
    Vector3 MoviEixoY;
    Vector3 finalVelocity;

    float Speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        
    }

    // Update is called once per frame
    void Update()
    {
        float MoviEixoXInput = Input.GetAxisRaw("Vertical");
        float MoviEixoYInput = Input.GetAxisRaw("Horizontal");

        // força = input * velocidade * direção
        MoviEixoX = MoviEixoXInput * Speed * transform.forward;
        MoviEixoY = MoviEixoYInput * Speed * transform.right;


        finalVelocity = MoviEixoX + MoviEixoY;

        controller.Move(finalVelocity * Time.deltaTime);
    }
}
