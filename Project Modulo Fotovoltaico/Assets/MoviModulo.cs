using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using System.Threading;


public class MoviModulo : MonoBehaviour
{

    //SETAS HORIZONTAIS
    bool setadir;
    bool setaeqd;
    int auxsetadir;
    int auxsetaeqd;

    //metodo para reconhecer o clique no botão 1
    public void pressbutton1(bool soma) {
        setadir = soma ;
    }
    //metodo para reconhecer o clique no botão 2
    public void pressbutton2(bool diminui)
    {
        setaeqd = diminui;
    }

    //SETAS VERTICAIS
    bool setacima;
    bool setabaixo;
    int auxsetacima;
    int auxsetabaixo;

    //metedo para reconhecer o clique no botão 3
    public void pressbutton3(bool soma)
    {
        setacima = soma;
    }

    //metodo para reconhecer o clique no botão 4
    public void pressbutton4(bool diminui)
    {
        setabaixo = diminui;
    }



    // ZENITE
    public static int AnguloZenite = 0; 

    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;

    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;

    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject C5;
    public GameObject C6;

    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject D5;
    public GameObject D6;

    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public GameObject E5;
    public GameObject E6;

    public GameObject F1;
    public GameObject F2;
    public GameObject F3;
    public GameObject F4;
    public GameObject F5;
    public GameObject F6;

    public GameObject G1;
    public GameObject G2;
    public GameObject G3;
    public GameObject G4;
    public GameObject G5;
    public GameObject G6;

    public GameObject H1;
    public GameObject H2;
    public GameObject H3;
    public GameObject H4;
    public GameObject H5;
    public GameObject H6;

    public GameObject I1;
    public GameObject I2;
    public GameObject I3;
    public GameObject I4;
    public GameObject I5;
    public GameObject I6;

    public GameObject J1;
    public GameObject J2;
    public GameObject J3;
    public GameObject J4;
    public GameObject J5;
    public GameObject J6;

    public GameObject Modulo;
    public GameObject SuporteModulo;
    public GameObject TraseiraModulo;


    // AZIMUTE

    public static int AnguloAzimute = 0;
    public GameObject SuporteAzimute;
    public GameObject Estrutura_Azimute;
    public GameObject Cubos;
    public GameObject Cilindro_Rotacao;


    void OnGUI()
    {

        //converte o angulo zenite e azimute atual em uma string para ser mostrada posteriormente
        string anguloY = Convert.ToString(Modulo.transform.eulerAngles.x);
        string anguloX = Convert.ToString(Modulo.transform.eulerAngles.y);

        GUI.Label(new Rect(1197, 0, 100, 30), "ZÊNITE:");
        GUI.Label(new Rect(1290, 0, 100, 30), Convert.ToString(AnguloZenite) + "°");

        //confere se a seta no teclado foi presionado e adiciona o valor 1 em uma variavel, fiz isso pois ao clica nas setas estava reconhecendo o clique duas vezes(precionar e soltar)
        if (Input.GetButtonDown("SetaCima"))
        {
            auxsetacima += 1;

        }
        //confere se a seta ou o botão 1 foi precionado 
        if (setacima == true | auxsetacima == 2)
        { // Para adicionar um grau de rotação 
            //confere se o angulo zenite chegou ao se maximo
            if (AnguloZenite < 90)
            {
                AnguloZenite += 10;
                for (int i = 0; i <= 9; i++)
                {
                    // apos conferir todas as dependencias, efetua o movimento dos gameobejects
                    A1.transform.eulerAngles = new UnityEngine.Vector3(A1.transform.eulerAngles.x + 1, A1.transform.eulerAngles.y, A1.transform.eulerAngles.z);
                    A2.transform.eulerAngles = new UnityEngine.Vector3(A2.transform.eulerAngles.x + 1, A2.transform.eulerAngles.y, A2.transform.eulerAngles.z);
                    A3.transform.eulerAngles = new UnityEngine.Vector3(A3.transform.eulerAngles.x + 1, A3.transform.eulerAngles.y, A3.transform.eulerAngles.z);
                    A4.transform.eulerAngles = new UnityEngine.Vector3(A4.transform.eulerAngles.x + 1, A4.transform.eulerAngles.y, A4.transform.eulerAngles.z);
                    A5.transform.eulerAngles = new UnityEngine.Vector3(A5.transform.eulerAngles.x + 1, A5.transform.eulerAngles.y, A5.transform.eulerAngles.z);
                    A6.transform.eulerAngles = new UnityEngine.Vector3(A6.transform.eulerAngles.x + 1, A6.transform.eulerAngles.y, A6.transform.eulerAngles.z);

                    B1.transform.eulerAngles = new UnityEngine.Vector3(B1.transform.eulerAngles.x + 1, B1.transform.eulerAngles.y, B1.transform.eulerAngles.z);
                    B2.transform.eulerAngles = new UnityEngine.Vector3(B2.transform.eulerAngles.x + 1, B2.transform.eulerAngles.y, B2.transform.eulerAngles.z);
                    B3.transform.eulerAngles = new UnityEngine.Vector3(B3.transform.eulerAngles.x + 1, B3.transform.eulerAngles.y, B3.transform.eulerAngles.z);
                    B4.transform.eulerAngles = new UnityEngine.Vector3(B4.transform.eulerAngles.x + 1, B4.transform.eulerAngles.y, B4.transform.eulerAngles.z);
                    B5.transform.eulerAngles = new UnityEngine.Vector3(B5.transform.eulerAngles.x + 1, B5.transform.eulerAngles.y, B5.transform.eulerAngles.z);
                    B6.transform.eulerAngles = new UnityEngine.Vector3(B6.transform.eulerAngles.x + 1, B6.transform.eulerAngles.y, B6.transform.eulerAngles.z);

                    C1.transform.eulerAngles = new UnityEngine.Vector3(C1.transform.eulerAngles.x + 1, C1.transform.eulerAngles.y, C1.transform.eulerAngles.z);
                    C2.transform.eulerAngles = new UnityEngine.Vector3(C2.transform.eulerAngles.x + 1, C2.transform.eulerAngles.y, C2.transform.eulerAngles.z);
                    C3.transform.eulerAngles = new UnityEngine.Vector3(C3.transform.eulerAngles.x + 1, C3.transform.eulerAngles.y, C3.transform.eulerAngles.z);
                    C4.transform.eulerAngles = new UnityEngine.Vector3(C4.transform.eulerAngles.x + 1, C4.transform.eulerAngles.y, C4.transform.eulerAngles.z);
                    C5.transform.eulerAngles = new UnityEngine.Vector3(C5.transform.eulerAngles.x + 1, C5.transform.eulerAngles.y, C5.transform.eulerAngles.z);
                    C6.transform.eulerAngles = new UnityEngine.Vector3(C6.transform.eulerAngles.x + 1, C6.transform.eulerAngles.y, C6.transform.eulerAngles.z);

                    D1.transform.eulerAngles = new UnityEngine.Vector3(D1.transform.eulerAngles.x + 1, D1.transform.eulerAngles.y, D1.transform.eulerAngles.z);
                    D2.transform.eulerAngles = new UnityEngine.Vector3(D2.transform.eulerAngles.x + 1, D2.transform.eulerAngles.y, D2.transform.eulerAngles.z);
                    D3.transform.eulerAngles = new UnityEngine.Vector3(D3.transform.eulerAngles.x + 1, D3.transform.eulerAngles.y, D3.transform.eulerAngles.z);
                    D4.transform.eulerAngles = new UnityEngine.Vector3(D4.transform.eulerAngles.x + 1, D4.transform.eulerAngles.y, D4.transform.eulerAngles.z);
                    D5.transform.eulerAngles = new UnityEngine.Vector3(D5.transform.eulerAngles.x + 1, D5.transform.eulerAngles.y, D5.transform.eulerAngles.z);
                    D6.transform.eulerAngles = new UnityEngine.Vector3(D6.transform.eulerAngles.x + 1, D6.transform.eulerAngles.y, D6.transform.eulerAngles.z);

                    E1.transform.eulerAngles = new UnityEngine.Vector3(E1.transform.eulerAngles.x + 1, E1.transform.eulerAngles.y, E1.transform.eulerAngles.z);
                    E2.transform.eulerAngles = new UnityEngine.Vector3(E2.transform.eulerAngles.x + 1, E2.transform.eulerAngles.y, E2.transform.eulerAngles.z);
                    E3.transform.eulerAngles = new UnityEngine.Vector3(E3.transform.eulerAngles.x + 1, E3.transform.eulerAngles.y, E3.transform.eulerAngles.z);
                    E4.transform.eulerAngles = new UnityEngine.Vector3(E4.transform.eulerAngles.x + 1, E4.transform.eulerAngles.y, E4.transform.eulerAngles.z);
                    E5.transform.eulerAngles = new UnityEngine.Vector3(E5.transform.eulerAngles.x + 1, E5.transform.eulerAngles.y, E5.transform.eulerAngles.z);
                    E6.transform.eulerAngles = new UnityEngine.Vector3(E6.transform.eulerAngles.x + 1, E6.transform.eulerAngles.y, E6.transform.eulerAngles.z);

                    F1.transform.eulerAngles = new UnityEngine.Vector3(F1.transform.eulerAngles.x + 1, F1.transform.eulerAngles.y, F1.transform.eulerAngles.z);
                    F2.transform.eulerAngles = new UnityEngine.Vector3(F2.transform.eulerAngles.x + 1, F2.transform.eulerAngles.y, F2.transform.eulerAngles.z);
                    F3.transform.eulerAngles = new UnityEngine.Vector3(F3.transform.eulerAngles.x + 1, F3.transform.eulerAngles.y, F3.transform.eulerAngles.z);
                    F4.transform.eulerAngles = new UnityEngine.Vector3(F4.transform.eulerAngles.x + 1, F4.transform.eulerAngles.y, F4.transform.eulerAngles.z);
                    F5.transform.eulerAngles = new UnityEngine.Vector3(F5.transform.eulerAngles.x + 1, F5.transform.eulerAngles.y, F5.transform.eulerAngles.z);
                    F6.transform.eulerAngles = new UnityEngine.Vector3(F6.transform.eulerAngles.x + 1, F6.transform.eulerAngles.y, F6.transform.eulerAngles.z);

                    G1.transform.eulerAngles = new UnityEngine.Vector3(G1.transform.eulerAngles.x + 1, G1.transform.eulerAngles.y, G1.transform.eulerAngles.z);
                    G2.transform.eulerAngles = new UnityEngine.Vector3(G2.transform.eulerAngles.x + 1, G2.transform.eulerAngles.y, G2.transform.eulerAngles.z);
                    G3.transform.eulerAngles = new UnityEngine.Vector3(G3.transform.eulerAngles.x + 1, G3.transform.eulerAngles.y, G3.transform.eulerAngles.z);
                    G4.transform.eulerAngles = new UnityEngine.Vector3(G4.transform.eulerAngles.x + 1, G4.transform.eulerAngles.y, G4.transform.eulerAngles.z);
                    G5.transform.eulerAngles = new UnityEngine.Vector3(G5.transform.eulerAngles.x + 1, G5.transform.eulerAngles.y, G5.transform.eulerAngles.z);
                    G6.transform.eulerAngles = new UnityEngine.Vector3(G6.transform.eulerAngles.x + 1, G6.transform.eulerAngles.y, G6.transform.eulerAngles.z);

                    H1.transform.eulerAngles = new UnityEngine.Vector3(H1.transform.eulerAngles.x + 1, H1.transform.eulerAngles.y, H1.transform.eulerAngles.z);
                    H2.transform.eulerAngles = new UnityEngine.Vector3(H2.transform.eulerAngles.x + 1, H2.transform.eulerAngles.y, H2.transform.eulerAngles.z);
                    H3.transform.eulerAngles = new UnityEngine.Vector3(H3.transform.eulerAngles.x + 1, H3.transform.eulerAngles.y, H3.transform.eulerAngles.z);
                    H4.transform.eulerAngles = new UnityEngine.Vector3(H4.transform.eulerAngles.x + 1, H4.transform.eulerAngles.y, H4.transform.eulerAngles.z);
                    H5.transform.eulerAngles = new UnityEngine.Vector3(H5.transform.eulerAngles.x + 1, H5.transform.eulerAngles.y, H5.transform.eulerAngles.z);
                    H6.transform.eulerAngles = new UnityEngine.Vector3(H6.transform.eulerAngles.x + 1, H6.transform.eulerAngles.y, H6.transform.eulerAngles.z);

                    I1.transform.eulerAngles = new UnityEngine.Vector3(I1.transform.eulerAngles.x + 1, I1.transform.eulerAngles.y, I1.transform.eulerAngles.z);
                    I2.transform.eulerAngles = new UnityEngine.Vector3(I2.transform.eulerAngles.x + 1, I2.transform.eulerAngles.y, I2.transform.eulerAngles.z);
                    I3.transform.eulerAngles = new UnityEngine.Vector3(I3.transform.eulerAngles.x + 1, I3.transform.eulerAngles.y, I3.transform.eulerAngles.z);
                    I4.transform.eulerAngles = new UnityEngine.Vector3(I4.transform.eulerAngles.x + 1, I4.transform.eulerAngles.y, I4.transform.eulerAngles.z);
                    I5.transform.eulerAngles = new UnityEngine.Vector3(I5.transform.eulerAngles.x + 1, I5.transform.eulerAngles.y, I5.transform.eulerAngles.z);
                    I6.transform.eulerAngles = new UnityEngine.Vector3(I6.transform.eulerAngles.x + 1, I6.transform.eulerAngles.y, I6.transform.eulerAngles.z);

                    J1.transform.eulerAngles = new UnityEngine.Vector3(J1.transform.eulerAngles.x + 1, J1.transform.eulerAngles.y, J1.transform.eulerAngles.z);
                    J2.transform.eulerAngles = new UnityEngine.Vector3(J2.transform.eulerAngles.x + 1, J2.transform.eulerAngles.y, J2.transform.eulerAngles.z);
                    J3.transform.eulerAngles = new UnityEngine.Vector3(J3.transform.eulerAngles.x + 1, J3.transform.eulerAngles.y, J3.transform.eulerAngles.z);
                    J4.transform.eulerAngles = new UnityEngine.Vector3(J4.transform.eulerAngles.x + 1, J4.transform.eulerAngles.y, J4.transform.eulerAngles.z);
                    J5.transform.eulerAngles = new UnityEngine.Vector3(J5.transform.eulerAngles.x + 1, J5.transform.eulerAngles.y, J5.transform.eulerAngles.z);
                    J6.transform.eulerAngles = new UnityEngine.Vector3(J6.transform.eulerAngles.x + 1, J6.transform.eulerAngles.y, J6.transform.eulerAngles.z);

                    Modulo.transform.eulerAngles = new UnityEngine.Vector3(Modulo.transform.eulerAngles.x + 1, Modulo.transform.eulerAngles.y, Modulo.transform.eulerAngles.z);
                    TraseiraModulo.transform.eulerAngles = new UnityEngine.Vector3(TraseiraModulo.transform.eulerAngles.x + 1, TraseiraModulo.transform.eulerAngles.y, TraseiraModulo.transform.eulerAngles.z);
                    SuporteModulo.transform.eulerAngles = new UnityEngine.Vector3(SuporteModulo.transform.eulerAngles.x + 1, SuporteModulo.transform.eulerAngles.y, SuporteModulo.transform.eulerAngles.z);

                }
            }
            //apos reconhecer o clique atribuimos novamente o false para que possamos reconhecelo novamente 
            setacima = false;
            auxsetacima = 0;
        }

        if ( Input.GetButtonDown("SetaBaixo"))
        {
            auxsetabaixo += 1 ;

        }

        if (setabaixo == true | auxsetabaixo == 2 )
        {
            if (AnguloZenite > 0)
            {
                AnguloZenite -= 10;
                for (int i = 0; i <= 9; i++)
                {
                    A1.transform.eulerAngles = new UnityEngine.Vector3(A1.transform.eulerAngles.x - 1, A1.transform.eulerAngles.y, A1.transform.eulerAngles.z);
                    A2.transform.eulerAngles = new UnityEngine.Vector3(A2.transform.eulerAngles.x - 1, A2.transform.eulerAngles.y, A2.transform.eulerAngles.z);
                    A3.transform.eulerAngles = new UnityEngine.Vector3(A3.transform.eulerAngles.x - 1, A3.transform.eulerAngles.y, A3.transform.eulerAngles.z);
                    A4.transform.eulerAngles = new UnityEngine.Vector3(A4.transform.eulerAngles.x - 1, A4.transform.eulerAngles.y, A4.transform.eulerAngles.z);
                    A5.transform.eulerAngles = new UnityEngine.Vector3(A5.transform.eulerAngles.x - 1, A5.transform.eulerAngles.y, A5.transform.eulerAngles.z);
                    A6.transform.eulerAngles = new UnityEngine.Vector3(A6.transform.eulerAngles.x - 1, A6.transform.eulerAngles.y, A6.transform.eulerAngles.z);

                    B1.transform.eulerAngles = new UnityEngine.Vector3(B1.transform.eulerAngles.x - 1, B1.transform.eulerAngles.y, B1.transform.eulerAngles.z);
                    B2.transform.eulerAngles = new UnityEngine.Vector3(B2.transform.eulerAngles.x - 1, B2.transform.eulerAngles.y, B2.transform.eulerAngles.z);
                    B3.transform.eulerAngles = new UnityEngine.Vector3(B3.transform.eulerAngles.x - 1, B3.transform.eulerAngles.y, B3.transform.eulerAngles.z);
                    B4.transform.eulerAngles = new UnityEngine.Vector3(B4.transform.eulerAngles.x - 1, B4.transform.eulerAngles.y, B4.transform.eulerAngles.z);
                    B5.transform.eulerAngles = new UnityEngine.Vector3(B5.transform.eulerAngles.x - 1, B5.transform.eulerAngles.y, B5.transform.eulerAngles.z);
                    B6.transform.eulerAngles = new UnityEngine.Vector3(B6.transform.eulerAngles.x - 1, B6.transform.eulerAngles.y, B6.transform.eulerAngles.z);

                    C1.transform.eulerAngles = new UnityEngine.Vector3(C1.transform.eulerAngles.x - 1, C1.transform.eulerAngles.y, C1.transform.eulerAngles.z);
                    C2.transform.eulerAngles = new UnityEngine.Vector3(C2.transform.eulerAngles.x - 1, C2.transform.eulerAngles.y, C2.transform.eulerAngles.z);
                    C3.transform.eulerAngles = new UnityEngine.Vector3(C3.transform.eulerAngles.x - 1, C3.transform.eulerAngles.y, C3.transform.eulerAngles.z);
                    C4.transform.eulerAngles = new UnityEngine.Vector3(C4.transform.eulerAngles.x - 1, C4.transform.eulerAngles.y, C4.transform.eulerAngles.z);
                    C5.transform.eulerAngles = new UnityEngine.Vector3(C5.transform.eulerAngles.x - 1, C5.transform.eulerAngles.y, C5.transform.eulerAngles.z);
                    C6.transform.eulerAngles = new UnityEngine.Vector3(C6.transform.eulerAngles.x - 1, C6.transform.eulerAngles.y, C6.transform.eulerAngles.z);

                    D1.transform.eulerAngles = new UnityEngine.Vector3(D1.transform.eulerAngles.x - 1, D1.transform.eulerAngles.y, D1.transform.eulerAngles.z);
                    D2.transform.eulerAngles = new UnityEngine.Vector3(D2.transform.eulerAngles.x - 1, D2.transform.eulerAngles.y, D2.transform.eulerAngles.z);
                    D3.transform.eulerAngles = new UnityEngine.Vector3(D3.transform.eulerAngles.x - 1, D3.transform.eulerAngles.y, D3.transform.eulerAngles.z);
                    D4.transform.eulerAngles = new UnityEngine.Vector3(D4.transform.eulerAngles.x - 1, D4.transform.eulerAngles.y, D4.transform.eulerAngles.z);
                    D5.transform.eulerAngles = new UnityEngine.Vector3(D5.transform.eulerAngles.x - 1, D5.transform.eulerAngles.y, D5.transform.eulerAngles.z);
                    D6.transform.eulerAngles = new UnityEngine.Vector3(D6.transform.eulerAngles.x - 1, D6.transform.eulerAngles.y, D6.transform.eulerAngles.z);

                    E1.transform.eulerAngles = new UnityEngine.Vector3(E1.transform.eulerAngles.x - 1, E1.transform.eulerAngles.y, E1.transform.eulerAngles.z);
                    E2.transform.eulerAngles = new UnityEngine.Vector3(E2.transform.eulerAngles.x - 1, E2.transform.eulerAngles.y, E2.transform.eulerAngles.z);
                    E3.transform.eulerAngles = new UnityEngine.Vector3(E3.transform.eulerAngles.x - 1, E3.transform.eulerAngles.y, E3.transform.eulerAngles.z);
                    E4.transform.eulerAngles = new UnityEngine.Vector3(E4.transform.eulerAngles.x - 1, E4.transform.eulerAngles.y, E4.transform.eulerAngles.z);
                    E5.transform.eulerAngles = new UnityEngine.Vector3(E5.transform.eulerAngles.x - 1, E5.transform.eulerAngles.y, E5.transform.eulerAngles.z);
                    E6.transform.eulerAngles = new UnityEngine.Vector3(E6.transform.eulerAngles.x - 1, E6.transform.eulerAngles.y, E6.transform.eulerAngles.z);

                    F1.transform.eulerAngles = new UnityEngine.Vector3(F1.transform.eulerAngles.x - 1, F1.transform.eulerAngles.y, F1.transform.eulerAngles.z);
                    F2.transform.eulerAngles = new UnityEngine.Vector3(F2.transform.eulerAngles.x - 1, F2.transform.eulerAngles.y, F2.transform.eulerAngles.z);
                    F3.transform.eulerAngles = new UnityEngine.Vector3(F3.transform.eulerAngles.x - 1, F3.transform.eulerAngles.y, F3.transform.eulerAngles.z);
                    F4.transform.eulerAngles = new UnityEngine.Vector3(F4.transform.eulerAngles.x - 1, F4.transform.eulerAngles.y, F4.transform.eulerAngles.z);
                    F5.transform.eulerAngles = new UnityEngine.Vector3(F5.transform.eulerAngles.x - 1, F5.transform.eulerAngles.y, F5.transform.eulerAngles.z);
                    F6.transform.eulerAngles = new UnityEngine.Vector3(F6.transform.eulerAngles.x - 1, F6.transform.eulerAngles.y, F6.transform.eulerAngles.z);

                    G1.transform.eulerAngles = new UnityEngine.Vector3(G1.transform.eulerAngles.x - 1, G1.transform.eulerAngles.y, G1.transform.eulerAngles.z);
                    G2.transform.eulerAngles = new UnityEngine.Vector3(G2.transform.eulerAngles.x - 1, G2.transform.eulerAngles.y, G2.transform.eulerAngles.z);
                    G3.transform.eulerAngles = new UnityEngine.Vector3(G3.transform.eulerAngles.x - 1, G3.transform.eulerAngles.y, G3.transform.eulerAngles.z);
                    G4.transform.eulerAngles = new UnityEngine.Vector3(G4.transform.eulerAngles.x - 1, G4.transform.eulerAngles.y, G4.transform.eulerAngles.z);
                    G5.transform.eulerAngles = new UnityEngine.Vector3(G5.transform.eulerAngles.x - 1, G5.transform.eulerAngles.y, G5.transform.eulerAngles.z);
                    G6.transform.eulerAngles = new UnityEngine.Vector3(G6.transform.eulerAngles.x - 1, G6.transform.eulerAngles.y, G6.transform.eulerAngles.z);

                    H1.transform.eulerAngles = new UnityEngine.Vector3(H1.transform.eulerAngles.x - 1, H1.transform.eulerAngles.y, H1.transform.eulerAngles.z);
                    H2.transform.eulerAngles = new UnityEngine.Vector3(H2.transform.eulerAngles.x - 1, H2.transform.eulerAngles.y, H2.transform.eulerAngles.z);
                    H3.transform.eulerAngles = new UnityEngine.Vector3(H3.transform.eulerAngles.x - 1, H3.transform.eulerAngles.y, H3.transform.eulerAngles.z);
                    H4.transform.eulerAngles = new UnityEngine.Vector3(H4.transform.eulerAngles.x - 1, H4.transform.eulerAngles.y, H4.transform.eulerAngles.z);
                    H5.transform.eulerAngles = new UnityEngine.Vector3(H5.transform.eulerAngles.x - 1, H5.transform.eulerAngles.y, H5.transform.eulerAngles.z);
                    H6.transform.eulerAngles = new UnityEngine.Vector3(H6.transform.eulerAngles.x - 1, H6.transform.eulerAngles.y, H6.transform.eulerAngles.z);

                    I1.transform.eulerAngles = new UnityEngine.Vector3(I1.transform.eulerAngles.x - 1, I1.transform.eulerAngles.y, I1.transform.eulerAngles.z);
                    I2.transform.eulerAngles = new UnityEngine.Vector3(I2.transform.eulerAngles.x - 1, I2.transform.eulerAngles.y, I2.transform.eulerAngles.z);
                    I3.transform.eulerAngles = new UnityEngine.Vector3(I3.transform.eulerAngles.x - 1, I3.transform.eulerAngles.y, I3.transform.eulerAngles.z);
                    I4.transform.eulerAngles = new UnityEngine.Vector3(I4.transform.eulerAngles.x - 1, I4.transform.eulerAngles.y, I4.transform.eulerAngles.z);
                    I5.transform.eulerAngles = new UnityEngine.Vector3(I5.transform.eulerAngles.x - 1, I5.transform.eulerAngles.y, I5.transform.eulerAngles.z);
                    I6.transform.eulerAngles = new UnityEngine.Vector3(I6.transform.eulerAngles.x - 1, I6.transform.eulerAngles.y, I6.transform.eulerAngles.z);

                    J1.transform.eulerAngles = new UnityEngine.Vector3(J1.transform.eulerAngles.x - 1, J1.transform.eulerAngles.y, J1.transform.eulerAngles.z);
                    J2.transform.eulerAngles = new UnityEngine.Vector3(J2.transform.eulerAngles.x - 1, J2.transform.eulerAngles.y, J2.transform.eulerAngles.z);
                    J3.transform.eulerAngles = new UnityEngine.Vector3(J3.transform.eulerAngles.x - 1, J3.transform.eulerAngles.y, J3.transform.eulerAngles.z);
                    J4.transform.eulerAngles = new UnityEngine.Vector3(J4.transform.eulerAngles.x - 1, J4.transform.eulerAngles.y, J4.transform.eulerAngles.z);
                    J5.transform.eulerAngles = new UnityEngine.Vector3(J5.transform.eulerAngles.x - 1, J5.transform.eulerAngles.y, J5.transform.eulerAngles.z);
                    J6.transform.eulerAngles = new UnityEngine.Vector3(J6.transform.eulerAngles.x - 1, J6.transform.eulerAngles.y, J6.transform.eulerAngles.z);

                    Modulo.transform.eulerAngles = new UnityEngine.Vector3(Modulo.transform.eulerAngles.x - 1, Modulo.transform.eulerAngles.y, Modulo.transform.eulerAngles.z);
                    TraseiraModulo.transform.eulerAngles = new UnityEngine.Vector3(TraseiraModulo.transform.eulerAngles.x - 1, TraseiraModulo.transform.eulerAngles.y, TraseiraModulo.transform.eulerAngles.z);
                    SuporteModulo.transform.eulerAngles = new UnityEngine.Vector3(SuporteModulo.transform.eulerAngles.x - 1, SuporteModulo.transform.eulerAngles.y, SuporteModulo.transform.eulerAngles.z);

                }
            }
            setabaixo = false;
            auxsetabaixo = 0;
        }


        GUI.Label(new Rect(1186, 25, 100, 30), "AZIMUTE:");
        GUI.Label(new Rect(1290, 25, 100, 30), Convert.ToString(AnguloAzimute) + "°");

        if (Input.GetButtonDown("SetaDireita"))
        {
            auxsetadir += 1;

        }

        if (setadir == true | auxsetadir == 2 )
        {
            if (AnguloAzimute < 90)
            {
                AnguloAzimute += 10;
                for (int i = 0; i <= 9; i++)
                {
                    A1.transform.eulerAngles = new UnityEngine.Vector3(A1.transform.eulerAngles.x, A1.transform.eulerAngles.y + 1, A1.transform.eulerAngles.z);
                    A2.transform.eulerAngles = new UnityEngine.Vector3(A2.transform.eulerAngles.x, A2.transform.eulerAngles.y + 1, A2.transform.eulerAngles.z);
                    A3.transform.eulerAngles = new UnityEngine.Vector3(A3.transform.eulerAngles.x, A3.transform.eulerAngles.y + 1, A3.transform.eulerAngles.z);
                    A4.transform.eulerAngles = new UnityEngine.Vector3(A4.transform.eulerAngles.x, A4.transform.eulerAngles.y + 1, A4.transform.eulerAngles.z);
                    A5.transform.eulerAngles = new UnityEngine.Vector3(A5.transform.eulerAngles.x, A5.transform.eulerAngles.y + 1, A5.transform.eulerAngles.z);
                    A6.transform.eulerAngles = new UnityEngine.Vector3(A6.transform.eulerAngles.x, A6.transform.eulerAngles.y + 1, A6.transform.eulerAngles.z);

                    B1.transform.eulerAngles = new UnityEngine.Vector3(B1.transform.eulerAngles.x, B1.transform.eulerAngles.y + 1, B1.transform.eulerAngles.z);
                    B2.transform.eulerAngles = new UnityEngine.Vector3(B2.transform.eulerAngles.x, B2.transform.eulerAngles.y + 1, B2.transform.eulerAngles.z);
                    B3.transform.eulerAngles = new UnityEngine.Vector3(B3.transform.eulerAngles.x, B3.transform.eulerAngles.y + 1, B3.transform.eulerAngles.z);
                    B4.transform.eulerAngles = new UnityEngine.Vector3(B4.transform.eulerAngles.x, B4.transform.eulerAngles.y + 1, B4.transform.eulerAngles.z);
                    B5.transform.eulerAngles = new UnityEngine.Vector3(B5.transform.eulerAngles.x, B5.transform.eulerAngles.y + 1, B5.transform.eulerAngles.z);
                    B6.transform.eulerAngles = new UnityEngine.Vector3(B6.transform.eulerAngles.x, B6.transform.eulerAngles.y + 1, B6.transform.eulerAngles.z);

                    C1.transform.eulerAngles = new UnityEngine.Vector3(C1.transform.eulerAngles.x, C1.transform.eulerAngles.y + 1, C1.transform.eulerAngles.z);
                    C2.transform.eulerAngles = new UnityEngine.Vector3(C2.transform.eulerAngles.x, C2.transform.eulerAngles.y + 1, C2.transform.eulerAngles.z);
                    C3.transform.eulerAngles = new UnityEngine.Vector3(C3.transform.eulerAngles.x, C3.transform.eulerAngles.y + 1, C3.transform.eulerAngles.z);
                    C4.transform.eulerAngles = new UnityEngine.Vector3(C4.transform.eulerAngles.x, C4.transform.eulerAngles.y + 1, C4.transform.eulerAngles.z);
                    C5.transform.eulerAngles = new UnityEngine.Vector3(C5.transform.eulerAngles.x, C5.transform.eulerAngles.y + 1, C5.transform.eulerAngles.z);
                    C6.transform.eulerAngles = new UnityEngine.Vector3(C6.transform.eulerAngles.x, C6.transform.eulerAngles.y + 1, C6.transform.eulerAngles.z);

                    D1.transform.eulerAngles = new UnityEngine.Vector3(D1.transform.eulerAngles.x, D1.transform.eulerAngles.y + 1, D1.transform.eulerAngles.z);
                    D2.transform.eulerAngles = new UnityEngine.Vector3(D2.transform.eulerAngles.x, D2.transform.eulerAngles.y + 1, D2.transform.eulerAngles.z);
                    D3.transform.eulerAngles = new UnityEngine.Vector3(D3.transform.eulerAngles.x, D3.transform.eulerAngles.y + 1, D3.transform.eulerAngles.z);
                    D4.transform.eulerAngles = new UnityEngine.Vector3(D4.transform.eulerAngles.x, D4.transform.eulerAngles.y + 1, D4.transform.eulerAngles.z);
                    D5.transform.eulerAngles = new UnityEngine.Vector3(D5.transform.eulerAngles.x, D5.transform.eulerAngles.y + 1, D5.transform.eulerAngles.z);
                    D6.transform.eulerAngles = new UnityEngine.Vector3(D6.transform.eulerAngles.x, D6.transform.eulerAngles.y + 1, D6.transform.eulerAngles.z);

                    E1.transform.eulerAngles = new UnityEngine.Vector3(E1.transform.eulerAngles.x, E1.transform.eulerAngles.y + 1, E1.transform.eulerAngles.z);
                    E2.transform.eulerAngles = new UnityEngine.Vector3(E2.transform.eulerAngles.x, E2.transform.eulerAngles.y + 1, E2.transform.eulerAngles.z);
                    E3.transform.eulerAngles = new UnityEngine.Vector3(E3.transform.eulerAngles.x, E3.transform.eulerAngles.y + 1, E3.transform.eulerAngles.z);
                    E4.transform.eulerAngles = new UnityEngine.Vector3(E4.transform.eulerAngles.x, E4.transform.eulerAngles.y + 1, E4.transform.eulerAngles.z);
                    E5.transform.eulerAngles = new UnityEngine.Vector3(E5.transform.eulerAngles.x, E5.transform.eulerAngles.y + 1, E5.transform.eulerAngles.z);
                    E6.transform.eulerAngles = new UnityEngine.Vector3(E6.transform.eulerAngles.x, E6.transform.eulerAngles.y + 1, E6.transform.eulerAngles.z);

                    F1.transform.eulerAngles = new UnityEngine.Vector3(F1.transform.eulerAngles.x, F1.transform.eulerAngles.y + 1, F1.transform.eulerAngles.z);
                    F2.transform.eulerAngles = new UnityEngine.Vector3(F2.transform.eulerAngles.x, F2.transform.eulerAngles.y + 1, F2.transform.eulerAngles.z);
                    F3.transform.eulerAngles = new UnityEngine.Vector3(F3.transform.eulerAngles.x, F3.transform.eulerAngles.y + 1, F3.transform.eulerAngles.z);
                    F4.transform.eulerAngles = new UnityEngine.Vector3(F4.transform.eulerAngles.x, F4.transform.eulerAngles.y + 1, F4.transform.eulerAngles.z);
                    F5.transform.eulerAngles = new UnityEngine.Vector3(F5.transform.eulerAngles.x, F5.transform.eulerAngles.y + 1, F5.transform.eulerAngles.z);
                    F6.transform.eulerAngles = new UnityEngine.Vector3(F6.transform.eulerAngles.x, F6.transform.eulerAngles.y + 1, F6.transform.eulerAngles.z);

                    G1.transform.eulerAngles = new UnityEngine.Vector3(G1.transform.eulerAngles.x, G1.transform.eulerAngles.y + 1, G1.transform.eulerAngles.z);
                    G2.transform.eulerAngles = new UnityEngine.Vector3(G2.transform.eulerAngles.x, G2.transform.eulerAngles.y + 1, G2.transform.eulerAngles.z);
                    G3.transform.eulerAngles = new UnityEngine.Vector3(G3.transform.eulerAngles.x, G3.transform.eulerAngles.y + 1, G3.transform.eulerAngles.z);
                    G4.transform.eulerAngles = new UnityEngine.Vector3(G4.transform.eulerAngles.x, G4.transform.eulerAngles.y + 1, G4.transform.eulerAngles.z);
                    G5.transform.eulerAngles = new UnityEngine.Vector3(G5.transform.eulerAngles.x, G5.transform.eulerAngles.y + 1, G5.transform.eulerAngles.z);
                    G6.transform.eulerAngles = new UnityEngine.Vector3(G6.transform.eulerAngles.x, G6.transform.eulerAngles.y + 1, G6.transform.eulerAngles.z);

                    H1.transform.eulerAngles = new UnityEngine.Vector3(H1.transform.eulerAngles.x, H1.transform.eulerAngles.y + 1, H1.transform.eulerAngles.z);
                    H2.transform.eulerAngles = new UnityEngine.Vector3(H2.transform.eulerAngles.x, H2.transform.eulerAngles.y + 1, H2.transform.eulerAngles.z);
                    H3.transform.eulerAngles = new UnityEngine.Vector3(H3.transform.eulerAngles.x, H3.transform.eulerAngles.y + 1, H3.transform.eulerAngles.z);
                    H4.transform.eulerAngles = new UnityEngine.Vector3(H4.transform.eulerAngles.x, H4.transform.eulerAngles.y + 1, H4.transform.eulerAngles.z);
                    H5.transform.eulerAngles = new UnityEngine.Vector3(H5.transform.eulerAngles.x, H5.transform.eulerAngles.y + 1, H5.transform.eulerAngles.z);
                    H6.transform.eulerAngles = new UnityEngine.Vector3(H6.transform.eulerAngles.x, H6.transform.eulerAngles.y + 1, H6.transform.eulerAngles.z);

                    I1.transform.eulerAngles = new UnityEngine.Vector3(I1.transform.eulerAngles.x, I1.transform.eulerAngles.y + 1, I1.transform.eulerAngles.z);
                    I2.transform.eulerAngles = new UnityEngine.Vector3(I2.transform.eulerAngles.x, I2.transform.eulerAngles.y + 1, I2.transform.eulerAngles.z);
                    I3.transform.eulerAngles = new UnityEngine.Vector3(I3.transform.eulerAngles.x, I3.transform.eulerAngles.y + 1, I3.transform.eulerAngles.z);
                    I4.transform.eulerAngles = new UnityEngine.Vector3(I4.transform.eulerAngles.x, I4.transform.eulerAngles.y + 1, I4.transform.eulerAngles.z);
                    I5.transform.eulerAngles = new UnityEngine.Vector3(I5.transform.eulerAngles.x, I5.transform.eulerAngles.y + 1, I5.transform.eulerAngles.z);
                    I6.transform.eulerAngles = new UnityEngine.Vector3(I6.transform.eulerAngles.x, I6.transform.eulerAngles.y + 1, I6.transform.eulerAngles.z);

                    J1.transform.eulerAngles = new UnityEngine.Vector3(J1.transform.eulerAngles.x, J1.transform.eulerAngles.y + 1, J1.transform.eulerAngles.z);
                    J2.transform.eulerAngles = new UnityEngine.Vector3(J2.transform.eulerAngles.x, J2.transform.eulerAngles.y + 1, J2.transform.eulerAngles.z);
                    J3.transform.eulerAngles = new UnityEngine.Vector3(J3.transform.eulerAngles.x, J3.transform.eulerAngles.y + 1, J3.transform.eulerAngles.z);
                    J4.transform.eulerAngles = new UnityEngine.Vector3(J4.transform.eulerAngles.x, J4.transform.eulerAngles.y + 1, J4.transform.eulerAngles.z);
                    J5.transform.eulerAngles = new UnityEngine.Vector3(J5.transform.eulerAngles.x, J5.transform.eulerAngles.y + 1, J5.transform.eulerAngles.z);
                    J6.transform.eulerAngles = new UnityEngine.Vector3(J6.transform.eulerAngles.x, J6.transform.eulerAngles.y + 1, J6.transform.eulerAngles.z);

                    Modulo.transform.eulerAngles = new UnityEngine.Vector3(Modulo.transform.eulerAngles.x, Modulo.transform.eulerAngles.y + 1, Modulo.transform.eulerAngles.z);
                    TraseiraModulo.transform.eulerAngles = new UnityEngine.Vector3(TraseiraModulo.transform.eulerAngles.x, TraseiraModulo.transform.eulerAngles.y + 1, TraseiraModulo.transform.eulerAngles.z);
                    SuporteModulo.transform.eulerAngles = new UnityEngine.Vector3(SuporteModulo.transform.eulerAngles.x, SuporteModulo.transform.eulerAngles.y + 1, SuporteModulo.transform.eulerAngles.z);

                    SuporteAzimute.transform.eulerAngles = new UnityEngine.Vector3(SuporteAzimute.transform.eulerAngles.x, SuporteAzimute.transform.eulerAngles.y + 1, SuporteAzimute.transform.eulerAngles.z);
                    Cubos.transform.eulerAngles = new UnityEngine.Vector3(Cubos.transform.eulerAngles.x, Cubos.transform.eulerAngles.y + 1, Cubos.transform.eulerAngles.z);
                    Estrutura_Azimute.transform.eulerAngles = new UnityEngine.Vector3(Estrutura_Azimute.transform.eulerAngles.x, Estrutura_Azimute.transform.eulerAngles.y + 1, Estrutura_Azimute.transform.eulerAngles.z);
                    Cilindro_Rotacao.transform.eulerAngles = new UnityEngine.Vector3(Cilindro_Rotacao.transform.eulerAngles.x, Cilindro_Rotacao.transform.eulerAngles.y + 1, Cilindro_Rotacao.transform.eulerAngles.z);
                }

                A1.transform.eulerAngles = new UnityEngine.Vector3(A1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(A1.transform.eulerAngles.y, 0)), A1.transform.eulerAngles.z);
                A2.transform.eulerAngles = new UnityEngine.Vector3(A2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(A2.transform.eulerAngles.y, 0)), A2.transform.eulerAngles.z);
                A3.transform.eulerAngles = new UnityEngine.Vector3(A3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(A3.transform.eulerAngles.y, 0)), A3.transform.eulerAngles.z);
                A4.transform.eulerAngles = new UnityEngine.Vector3(A4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(A4.transform.eulerAngles.y, 0)), A4.transform.eulerAngles.z);
                A5.transform.eulerAngles = new UnityEngine.Vector3(A5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(A5.transform.eulerAngles.y, 0)), A5.transform.eulerAngles.z);
                A6.transform.eulerAngles = new UnityEngine.Vector3(A6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(A6.transform.eulerAngles.y, 0)), A6.transform.eulerAngles.z);

                B1.transform.eulerAngles = new UnityEngine.Vector3(B1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(B1.transform.eulerAngles.y, 0)), B1.transform.eulerAngles.z);
                B2.transform.eulerAngles = new UnityEngine.Vector3(B2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(B2.transform.eulerAngles.y, 0)), B2.transform.eulerAngles.z);
                B3.transform.eulerAngles = new UnityEngine.Vector3(B3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(B3.transform.eulerAngles.y, 0)), B3.transform.eulerAngles.z);
                B4.transform.eulerAngles = new UnityEngine.Vector3(B4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(B4.transform.eulerAngles.y, 0)), B4.transform.eulerAngles.z);
                B5.transform.eulerAngles = new UnityEngine.Vector3(B5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(B5.transform.eulerAngles.y, 0)), B5.transform.eulerAngles.z);
                B6.transform.eulerAngles = new UnityEngine.Vector3(B6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(B6.transform.eulerAngles.y, 0)), B6.transform.eulerAngles.z);

                C1.transform.eulerAngles = new UnityEngine.Vector3(C1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(C1.transform.eulerAngles.y, 0)), C1.transform.eulerAngles.z);
                C2.transform.eulerAngles = new UnityEngine.Vector3(C2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(C2.transform.eulerAngles.y, 0)), C2.transform.eulerAngles.z);
                C3.transform.eulerAngles = new UnityEngine.Vector3(C3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(C3.transform.eulerAngles.y, 0)), C3.transform.eulerAngles.z);
                C4.transform.eulerAngles = new UnityEngine.Vector3(C4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(C4.transform.eulerAngles.y, 0)), C4.transform.eulerAngles.z);
                C5.transform.eulerAngles = new UnityEngine.Vector3(C5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(C5.transform.eulerAngles.y, 0)), C5.transform.eulerAngles.z);
                C6.transform.eulerAngles = new UnityEngine.Vector3(C6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(C6.transform.eulerAngles.y, 0)), C6.transform.eulerAngles.z);

                D1.transform.eulerAngles = new UnityEngine.Vector3(D1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(D1.transform.eulerAngles.y, 0)), D1.transform.eulerAngles.z);
                D2.transform.eulerAngles = new UnityEngine.Vector3(D2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(D2.transform.eulerAngles.y, 0)), D2.transform.eulerAngles.z);
                D3.transform.eulerAngles = new UnityEngine.Vector3(D3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(D3.transform.eulerAngles.y, 0)), D3.transform.eulerAngles.z);
                D4.transform.eulerAngles = new UnityEngine.Vector3(D4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(D4.transform.eulerAngles.y, 0)), D4.transform.eulerAngles.z);
                D5.transform.eulerAngles = new UnityEngine.Vector3(D5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(D5.transform.eulerAngles.y, 0)), D5.transform.eulerAngles.z);
                D6.transform.eulerAngles = new UnityEngine.Vector3(D6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(D6.transform.eulerAngles.y, 0)), D6.transform.eulerAngles.z);

                E1.transform.eulerAngles = new UnityEngine.Vector3(E1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(E1.transform.eulerAngles.y, 0)), E1.transform.eulerAngles.z);
                E2.transform.eulerAngles = new UnityEngine.Vector3(E2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(E2.transform.eulerAngles.y, 0)), E2.transform.eulerAngles.z);
                E3.transform.eulerAngles = new UnityEngine.Vector3(E3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(E3.transform.eulerAngles.y, 0)), E3.transform.eulerAngles.z);
                E4.transform.eulerAngles = new UnityEngine.Vector3(E4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(E4.transform.eulerAngles.y, 0)), E4.transform.eulerAngles.z);
                E5.transform.eulerAngles = new UnityEngine.Vector3(E5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(E5.transform.eulerAngles.y, 0)), E5.transform.eulerAngles.z);
                E6.transform.eulerAngles = new UnityEngine.Vector3(E6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(E6.transform.eulerAngles.y, 0)), E6.transform.eulerAngles.z);

                F1.transform.eulerAngles = new UnityEngine.Vector3(F1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(F1.transform.eulerAngles.y, 0)), F1.transform.eulerAngles.z);
                F2.transform.eulerAngles = new UnityEngine.Vector3(F2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(F2.transform.eulerAngles.y, 0)), F2.transform.eulerAngles.z);
                F3.transform.eulerAngles = new UnityEngine.Vector3(F3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(F3.transform.eulerAngles.y, 0)), F3.transform.eulerAngles.z);
                F4.transform.eulerAngles = new UnityEngine.Vector3(F4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(F4.transform.eulerAngles.y, 0)), F4.transform.eulerAngles.z);
                F5.transform.eulerAngles = new UnityEngine.Vector3(F5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(F5.transform.eulerAngles.y, 0)), F5.transform.eulerAngles.z);
                F6.transform.eulerAngles = new UnityEngine.Vector3(F6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(F6.transform.eulerAngles.y, 0)), F6.transform.eulerAngles.z);

                G1.transform.eulerAngles = new UnityEngine.Vector3(G1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(G1.transform.eulerAngles.y, 0)), G1.transform.eulerAngles.z);
                G2.transform.eulerAngles = new UnityEngine.Vector3(G2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(G2.transform.eulerAngles.y, 0)), G2.transform.eulerAngles.z);
                G3.transform.eulerAngles = new UnityEngine.Vector3(G3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(G3.transform.eulerAngles.y, 0)), G3.transform.eulerAngles.z);
                G4.transform.eulerAngles = new UnityEngine.Vector3(G4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(G4.transform.eulerAngles.y, 0)), G4.transform.eulerAngles.z);
                G5.transform.eulerAngles = new UnityEngine.Vector3(G5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(G5.transform.eulerAngles.y, 0)), G5.transform.eulerAngles.z);
                G6.transform.eulerAngles = new UnityEngine.Vector3(G6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(G6.transform.eulerAngles.y, 0)), G6.transform.eulerAngles.z);

                H1.transform.eulerAngles = new UnityEngine.Vector3(H1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(H1.transform.eulerAngles.y, 0)), H1.transform.eulerAngles.z);
                H2.transform.eulerAngles = new UnityEngine.Vector3(H2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(H2.transform.eulerAngles.y, 0)), H2.transform.eulerAngles.z);
                H3.transform.eulerAngles = new UnityEngine.Vector3(H3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(H3.transform.eulerAngles.y, 0)), H3.transform.eulerAngles.z);
                H4.transform.eulerAngles = new UnityEngine.Vector3(H4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(H4.transform.eulerAngles.y, 0)), H4.transform.eulerAngles.z);
                H5.transform.eulerAngles = new UnityEngine.Vector3(H5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(H5.transform.eulerAngles.y, 0)), H5.transform.eulerAngles.z);
                H6.transform.eulerAngles = new UnityEngine.Vector3(H6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(H6.transform.eulerAngles.y, 0)), H6.transform.eulerAngles.z);

                I1.transform.eulerAngles = new UnityEngine.Vector3(I1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(I1.transform.eulerAngles.y, 0)), I1.transform.eulerAngles.z);
                I2.transform.eulerAngles = new UnityEngine.Vector3(I2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(I2.transform.eulerAngles.y, 0)), I2.transform.eulerAngles.z);
                I3.transform.eulerAngles = new UnityEngine.Vector3(I3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(I3.transform.eulerAngles.y, 0)), I3.transform.eulerAngles.z);
                I4.transform.eulerAngles = new UnityEngine.Vector3(I4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(I4.transform.eulerAngles.y, 0)), I4.transform.eulerAngles.z);
                I5.transform.eulerAngles = new UnityEngine.Vector3(I5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(I5.transform.eulerAngles.y, 0)), I5.transform.eulerAngles.z);
                I6.transform.eulerAngles = new UnityEngine.Vector3(I6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(I6.transform.eulerAngles.y, 0)), I6.transform.eulerAngles.z);

                J1.transform.eulerAngles = new UnityEngine.Vector3(J1.transform.eulerAngles.x, Convert.ToSingle(Math.Round(J1.transform.eulerAngles.y, 0)), J1.transform.eulerAngles.z);
                J2.transform.eulerAngles = new UnityEngine.Vector3(J2.transform.eulerAngles.x, Convert.ToSingle(Math.Round(J2.transform.eulerAngles.y, 0)), J2.transform.eulerAngles.z);
                J3.transform.eulerAngles = new UnityEngine.Vector3(J3.transform.eulerAngles.x, Convert.ToSingle(Math.Round(J3.transform.eulerAngles.y, 0)), J3.transform.eulerAngles.z);
                J4.transform.eulerAngles = new UnityEngine.Vector3(J4.transform.eulerAngles.x, Convert.ToSingle(Math.Round(J4.transform.eulerAngles.y, 0)), J4.transform.eulerAngles.z);
                J5.transform.eulerAngles = new UnityEngine.Vector3(J5.transform.eulerAngles.x, Convert.ToSingle(Math.Round(J5.transform.eulerAngles.y, 0)), J5.transform.eulerAngles.z);
                J6.transform.eulerAngles = new UnityEngine.Vector3(J6.transform.eulerAngles.x, Convert.ToSingle(Math.Round(J6.transform.eulerAngles.y, 0)), J6.transform.eulerAngles.z);

                Modulo.transform.eulerAngles = new UnityEngine.Vector3(Modulo.transform.eulerAngles.x, Convert.ToSingle(Math.Round(Modulo.transform.eulerAngles.y, 0)), Modulo.transform.eulerAngles.z);
                TraseiraModulo.transform.eulerAngles = new UnityEngine.Vector3(TraseiraModulo.transform.eulerAngles.x, Convert.ToSingle(Math.Round(TraseiraModulo.transform.eulerAngles.y, 0)), TraseiraModulo.transform.eulerAngles.z);
                SuporteModulo.transform.eulerAngles = new UnityEngine.Vector3(SuporteModulo.transform.eulerAngles.x, Convert.ToSingle(Math.Round(SuporteModulo.transform.eulerAngles.y, 0)), SuporteModulo.transform.eulerAngles.z);

                SuporteAzimute.transform.eulerAngles = new UnityEngine.Vector3(SuporteAzimute.transform.eulerAngles.x, Convert.ToSingle(Math.Round(SuporteAzimute.transform.eulerAngles.y, 0)), SuporteAzimute.transform.eulerAngles.z);
                Cubos.transform.eulerAngles = new UnityEngine.Vector3(Cubos.transform.eulerAngles.x, Convert.ToSingle(Math.Round(Cubos.transform.eulerAngles.y, 0)), Cubos.transform.eulerAngles.z);
                Estrutura_Azimute.transform.eulerAngles = new UnityEngine.Vector3(Estrutura_Azimute.transform.eulerAngles.x, Convert.ToSingle(Math.Round(Estrutura_Azimute.transform.eulerAngles.y, 0)), Estrutura_Azimute.transform.eulerAngles.z);
                Cilindro_Rotacao.transform.eulerAngles = new UnityEngine.Vector3(Cilindro_Rotacao.transform.eulerAngles.x, Convert.ToSingle(Math.Round(Cilindro_Rotacao.transform.eulerAngles.y, 0)), Cilindro_Rotacao.transform.eulerAngles.z);
            }
            setadir = false;
            auxsetadir = 0;
        }
        if (Input.GetButtonDown("SetaEsquerda"))
        {
            auxsetaeqd += 1;

        }
        if (setaeqd == true | auxsetaeqd == 2 )
        {
            if (AnguloAzimute > -90)
            {
                AnguloAzimute -= 10;
                for (int i = 0; i <= 9; i++)
                {
                    A1.transform.eulerAngles = new UnityEngine.Vector3(A1.transform.eulerAngles.x, A1.transform.eulerAngles.y - 1, A1.transform.eulerAngles.z);
                    A2.transform.eulerAngles = new UnityEngine.Vector3(A2.transform.eulerAngles.x, A2.transform.eulerAngles.y - 1, A2.transform.eulerAngles.z);
                    A3.transform.eulerAngles = new UnityEngine.Vector3(A3.transform.eulerAngles.x, A3.transform.eulerAngles.y - 1, A3.transform.eulerAngles.z);
                    A4.transform.eulerAngles = new UnityEngine.Vector3(A4.transform.eulerAngles.x, A4.transform.eulerAngles.y - 1, A4.transform.eulerAngles.z);
                    A5.transform.eulerAngles = new UnityEngine.Vector3(A5.transform.eulerAngles.x, A5.transform.eulerAngles.y - 1, A5.transform.eulerAngles.z);
                    A6.transform.eulerAngles = new UnityEngine.Vector3(A6.transform.eulerAngles.x, A6.transform.eulerAngles.y - 1, A6.transform.eulerAngles.z);

                    B1.transform.eulerAngles = new UnityEngine.Vector3(B1.transform.eulerAngles.x, B1.transform.eulerAngles.y - 1, B1.transform.eulerAngles.z);
                    B2.transform.eulerAngles = new UnityEngine.Vector3(B2.transform.eulerAngles.x, B2.transform.eulerAngles.y - 1, B2.transform.eulerAngles.z);
                    B3.transform.eulerAngles = new UnityEngine.Vector3(B3.transform.eulerAngles.x, B3.transform.eulerAngles.y - 1, B3.transform.eulerAngles.z);
                    B4.transform.eulerAngles = new UnityEngine.Vector3(B4.transform.eulerAngles.x, B4.transform.eulerAngles.y - 1, B4.transform.eulerAngles.z);
                    B5.transform.eulerAngles = new UnityEngine.Vector3(B5.transform.eulerAngles.x, B5.transform.eulerAngles.y - 1, B5.transform.eulerAngles.z);
                    B6.transform.eulerAngles = new UnityEngine.Vector3(B6.transform.eulerAngles.x, B6.transform.eulerAngles.y - 1, B6.transform.eulerAngles.z);

                    C1.transform.eulerAngles = new UnityEngine.Vector3(C1.transform.eulerAngles.x, C1.transform.eulerAngles.y - 1, C1.transform.eulerAngles.z);
                    C2.transform.eulerAngles = new UnityEngine.Vector3(C2.transform.eulerAngles.x, C2.transform.eulerAngles.y - 1, C2.transform.eulerAngles.z);
                    C3.transform.eulerAngles = new UnityEngine.Vector3(C3.transform.eulerAngles.x, C3.transform.eulerAngles.y - 1, C3.transform.eulerAngles.z);
                    C4.transform.eulerAngles = new UnityEngine.Vector3(C4.transform.eulerAngles.x, C4.transform.eulerAngles.y - 1, C4.transform.eulerAngles.z);
                    C5.transform.eulerAngles = new UnityEngine.Vector3(C5.transform.eulerAngles.x, C5.transform.eulerAngles.y - 1, C5.transform.eulerAngles.z);
                    C6.transform.eulerAngles = new UnityEngine.Vector3(C6.transform.eulerAngles.x, C6.transform.eulerAngles.y - 1, C6.transform.eulerAngles.z);

                    D1.transform.eulerAngles = new UnityEngine.Vector3(D1.transform.eulerAngles.x, D1.transform.eulerAngles.y - 1, D1.transform.eulerAngles.z);
                    D2.transform.eulerAngles = new UnityEngine.Vector3(D2.transform.eulerAngles.x, D2.transform.eulerAngles.y - 1, D2.transform.eulerAngles.z);
                    D3.transform.eulerAngles = new UnityEngine.Vector3(D3.transform.eulerAngles.x, D3.transform.eulerAngles.y - 1, D3.transform.eulerAngles.z);
                    D4.transform.eulerAngles = new UnityEngine.Vector3(D4.transform.eulerAngles.x, D4.transform.eulerAngles.y - 1, D4.transform.eulerAngles.z);
                    D5.transform.eulerAngles = new UnityEngine.Vector3(D5.transform.eulerAngles.x, D5.transform.eulerAngles.y - 1, D5.transform.eulerAngles.z);
                    D6.transform.eulerAngles = new UnityEngine.Vector3(D6.transform.eulerAngles.x, D6.transform.eulerAngles.y - 1, D6.transform.eulerAngles.z);

                    E1.transform.eulerAngles = new UnityEngine.Vector3(E1.transform.eulerAngles.x, E1.transform.eulerAngles.y - 1, E1.transform.eulerAngles.z);
                    E2.transform.eulerAngles = new UnityEngine.Vector3(E2.transform.eulerAngles.x, E2.transform.eulerAngles.y - 1, E2.transform.eulerAngles.z);
                    E3.transform.eulerAngles = new UnityEngine.Vector3(E3.transform.eulerAngles.x, E3.transform.eulerAngles.y - 1, E3.transform.eulerAngles.z);
                    E4.transform.eulerAngles = new UnityEngine.Vector3(E4.transform.eulerAngles.x, E4.transform.eulerAngles.y - 1, E4.transform.eulerAngles.z);
                    E5.transform.eulerAngles = new UnityEngine.Vector3(E5.transform.eulerAngles.x, E5.transform.eulerAngles.y - 1, E5.transform.eulerAngles.z);
                    E6.transform.eulerAngles = new UnityEngine.Vector3(E6.transform.eulerAngles.x, E6.transform.eulerAngles.y - 1, E6.transform.eulerAngles.z);

                    F1.transform.eulerAngles = new UnityEngine.Vector3(F1.transform.eulerAngles.x, F1.transform.eulerAngles.y - 1, F1.transform.eulerAngles.z);
                    F2.transform.eulerAngles = new UnityEngine.Vector3(F2.transform.eulerAngles.x, F2.transform.eulerAngles.y - 1, F2.transform.eulerAngles.z);
                    F3.transform.eulerAngles = new UnityEngine.Vector3(F3.transform.eulerAngles.x, F3.transform.eulerAngles.y - 1, F3.transform.eulerAngles.z);
                    F4.transform.eulerAngles = new UnityEngine.Vector3(F4.transform.eulerAngles.x, F4.transform.eulerAngles.y - 1, F4.transform.eulerAngles.z);
                    F5.transform.eulerAngles = new UnityEngine.Vector3(F5.transform.eulerAngles.x, F5.transform.eulerAngles.y - 1, F5.transform.eulerAngles.z);
                    F6.transform.eulerAngles = new UnityEngine.Vector3(F6.transform.eulerAngles.x, F6.transform.eulerAngles.y - 1, F6.transform.eulerAngles.z);

                    G1.transform.eulerAngles = new UnityEngine.Vector3(G1.transform.eulerAngles.x, G1.transform.eulerAngles.y - 1, G1.transform.eulerAngles.z);
                    G2.transform.eulerAngles = new UnityEngine.Vector3(G2.transform.eulerAngles.x, G2.transform.eulerAngles.y - 1, G2.transform.eulerAngles.z);
                    G3.transform.eulerAngles = new UnityEngine.Vector3(G3.transform.eulerAngles.x, G3.transform.eulerAngles.y - 1, G3.transform.eulerAngles.z);
                    G4.transform.eulerAngles = new UnityEngine.Vector3(G4.transform.eulerAngles.x, G4.transform.eulerAngles.y - 1, G4.transform.eulerAngles.z);
                    G5.transform.eulerAngles = new UnityEngine.Vector3(G5.transform.eulerAngles.x, G5.transform.eulerAngles.y - 1, G5.transform.eulerAngles.z);
                    G6.transform.eulerAngles = new UnityEngine.Vector3(G6.transform.eulerAngles.x, G6.transform.eulerAngles.y - 1, G6.transform.eulerAngles.z);

                    H1.transform.eulerAngles = new UnityEngine.Vector3(H1.transform.eulerAngles.x, H1.transform.eulerAngles.y - 1, H1.transform.eulerAngles.z);
                    H2.transform.eulerAngles = new UnityEngine.Vector3(H2.transform.eulerAngles.x, H2.transform.eulerAngles.y - 1, H2.transform.eulerAngles.z);
                    H3.transform.eulerAngles = new UnityEngine.Vector3(H3.transform.eulerAngles.x, H3.transform.eulerAngles.y - 1, H3.transform.eulerAngles.z);
                    H4.transform.eulerAngles = new UnityEngine.Vector3(H4.transform.eulerAngles.x, H4.transform.eulerAngles.y - 1, H4.transform.eulerAngles.z);
                    H5.transform.eulerAngles = new UnityEngine.Vector3(H5.transform.eulerAngles.x, H5.transform.eulerAngles.y - 1, H5.transform.eulerAngles.z);
                    H6.transform.eulerAngles = new UnityEngine.Vector3(H6.transform.eulerAngles.x, H6.transform.eulerAngles.y - 1, H6.transform.eulerAngles.z);

                    I1.transform.eulerAngles = new UnityEngine.Vector3(I1.transform.eulerAngles.x, I1.transform.eulerAngles.y - 1, I1.transform.eulerAngles.z);
                    I2.transform.eulerAngles = new UnityEngine.Vector3(I2.transform.eulerAngles.x, I2.transform.eulerAngles.y - 1, I2.transform.eulerAngles.z);
                    I3.transform.eulerAngles = new UnityEngine.Vector3(I3.transform.eulerAngles.x, I3.transform.eulerAngles.y - 1, I3.transform.eulerAngles.z);
                    I4.transform.eulerAngles = new UnityEngine.Vector3(I4.transform.eulerAngles.x, I4.transform.eulerAngles.y - 1, I4.transform.eulerAngles.z);
                    I5.transform.eulerAngles = new UnityEngine.Vector3(I5.transform.eulerAngles.x, I5.transform.eulerAngles.y - 1, I5.transform.eulerAngles.z);
                    I6.transform.eulerAngles = new UnityEngine.Vector3(I6.transform.eulerAngles.x, I6.transform.eulerAngles.y - 1, I6.transform.eulerAngles.z);

                    J1.transform.eulerAngles = new UnityEngine.Vector3(J1.transform.eulerAngles.x, J1.transform.eulerAngles.y - 1, J1.transform.eulerAngles.z);
                    J2.transform.eulerAngles = new UnityEngine.Vector3(J2.transform.eulerAngles.x, J2.transform.eulerAngles.y - 1, J2.transform.eulerAngles.z);
                    J3.transform.eulerAngles = new UnityEngine.Vector3(J3.transform.eulerAngles.x, J3.transform.eulerAngles.y - 1, J3.transform.eulerAngles.z);
                    J4.transform.eulerAngles = new UnityEngine.Vector3(J4.transform.eulerAngles.x, J4.transform.eulerAngles.y - 1, J4.transform.eulerAngles.z);
                    J5.transform.eulerAngles = new UnityEngine.Vector3(J5.transform.eulerAngles.x, J5.transform.eulerAngles.y - 1, J5.transform.eulerAngles.z);
                    J6.transform.eulerAngles = new UnityEngine.Vector3(J6.transform.eulerAngles.x, J6.transform.eulerAngles.y - 1, J6.transform.eulerAngles.z);

                    Modulo.transform.eulerAngles = new UnityEngine.Vector3(Modulo.transform.eulerAngles.x, Modulo.transform.eulerAngles.y - 1, Modulo.transform.eulerAngles.z);
                    TraseiraModulo.transform.eulerAngles = new UnityEngine.Vector3(TraseiraModulo.transform.eulerAngles.x, TraseiraModulo.transform.eulerAngles.y - 1, TraseiraModulo.transform.eulerAngles.z);
                    SuporteModulo.transform.eulerAngles = new UnityEngine.Vector3(SuporteModulo.transform.eulerAngles.x, SuporteModulo.transform.eulerAngles.y - 1, SuporteModulo.transform.eulerAngles.z);

                    SuporteAzimute.transform.eulerAngles = new UnityEngine.Vector3(SuporteAzimute.transform.eulerAngles.x, SuporteAzimute.transform.eulerAngles.y - 1, SuporteAzimute.transform.eulerAngles.z);
                    Cubos.transform.eulerAngles = new UnityEngine.Vector3(Cubos.transform.eulerAngles.x, Cubos.transform.eulerAngles.y - 1, Cubos.transform.eulerAngles.z);
                    Estrutura_Azimute.transform.eulerAngles = new UnityEngine.Vector3(Estrutura_Azimute.transform.eulerAngles.x, Estrutura_Azimute.transform.eulerAngles.y - 1, Estrutura_Azimute.transform.eulerAngles.z);
                    Cilindro_Rotacao.transform.eulerAngles = new UnityEngine.Vector3(Cilindro_Rotacao.transform.eulerAngles.x, Cilindro_Rotacao.transform.eulerAngles.y - 1, Cilindro_Rotacao.transform.eulerAngles.z);
                }
            }
            setaeqd = false;
            auxsetaeqd = 0;
        }
        
    }
}
