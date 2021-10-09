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

    //variaveis para limita��o do movimento
    //Velocidade de movimenta��o, quanto maior, mais r�pido
    public float velocidade = 5.0f;

    [Space(10)]
    //Dist�ncia adicional do player
    public Vector3 offset = Vector3.up;

    public Transform CorpoDoPlayer;

    [Space(15)]
    //Posi��o min e max em X da player
    public float[] xClamp = new float[2];

    //Posi��o min e max em Z do player
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

        // for�a = input * velocidade * dire��o
        MoviEixoX = MoviEixoXInput * Speed * transform.forward;
        MoviEixoY = MoviEixoYInput * Speed * transform.right;


        finalVelocity = MoviEixoX + MoviEixoY;

        controller.Move(finalVelocity * Time.deltaTime);

        //Cria uma nova vari�vel e adiciona a posi��o do player a ela
        Vector3 playerPos =CorpoDoPlayer.position;

        //Obt�m a posi��o em X
        float posX = Mathf.Clamp(playerPos.x, xClamp[0], xClamp[1]);

        //Obt�m a posi��o em z
        float posZ = Mathf.Clamp(playerPos.z, zClamp[0], zClamp[1]);

        //Movimenta o player suavimente at� a posi��o do player
        transform.position = Vector3.Lerp(
                    transform.position, //Posi��o autual
                    new Vector3(posX, 0, posZ) + offset, //Nova posi��o com o espa�amento
                    velocidade * Time.deltaTime //Tempo da transi��o
                );
    }
}
