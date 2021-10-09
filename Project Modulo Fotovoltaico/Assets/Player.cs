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

    //variaveis para limitação do movimento
    //Velocidade de movimentação, quanto maior, mais rápido
    public float velocidade = 5.0f;

    [Space(10)]
    //Distância adicional do player
    public Vector3 offset = Vector3.up;

    public Transform CorpoDoPlayer;

    [Space(15)]
    //Posição min e max em X da player
    public float[] xClamp = new float[2];

    //Posição min e max em Z do player
    public float[] zClamp = new float[2];

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

        //Cria uma nova variável e adiciona a posição do player a ela
        Vector3 playerPos =CorpoDoPlayer.position;

        //Obtém a posição em X
        float posX = Mathf.Clamp(playerPos.x, xClamp[0], xClamp[1]);

        //Obtém a posição em z
        float posZ = Mathf.Clamp(playerPos.z, zClamp[0], zClamp[1]);

        //Movimenta o player suavimente até a posição do player
        transform.position = Vector3.Lerp(
                    transform.position, //Posição autual
                    new Vector3(posX, 0, posZ) + offset, //Nova posição com o espaçamento
                    velocidade * Time.deltaTime //Tempo da transição
                );
    }
}
