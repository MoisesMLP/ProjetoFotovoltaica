using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera1 : MonoBehaviour
{
    public float sensibilidade = 100f;

    // declarando corpo que a camera ira seguir
    public Transform CorpoDoPlayer;

    float xRotacao = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //inicia como o cursor do mouse no meio
        Cursor.lockState = CursorLockMode.Locked;
    }
   
    // Update is called once per frame
    void Update()
    {
        //pegando valores do de acordo com os eixos do mouse
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        //pegando o valor obtido nos eixos y do mouse e usando na rotação da camera
        xRotacao -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotacao, 0f, 0f);

        //bloqueando a rotação acima de 180 graus no eixo y
        xRotacao = Mathf.Clamp(xRotacao, -90f, 90f);

        //pegando o valor obtido nos eixos x do mouse e usando na rotação da camera a partir do corpo do player
        CorpoDoPlayer.Rotate(Vector3.up * mouseX);
    }
}
