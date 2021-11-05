using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValorCartasJugador : MonoBehaviour
{

    public static int puntajeTotalJugador;

    private int puntajeCarta1,puntajeCarta2,puntajeCarta3=0,puntajeCarta4=0,puntajeCarta5=0;

    public Image ImgCarta1,ImgCarta2,ImgCarta3,ImgCarta4,ImgCarta5;
    public Text PuntajeJugador;
    public Text mensaje;

    private int cont=0;
    public Button NuevaCarta;

    public string[] OpcionesJugador;
    public Sprite As,dos,tres,cuatro,cinco,seis,siete,ocho,nueve,diez,once,doce,trece;



    // Start is called before the first frame update
    void Start()
    {
        Button btnNueva = NuevaCarta.GetComponent<Button>();
        btnNueva.onClick.AddListener(DoClickNueva);

        PrimeraCartas();
        SegundaCartas();
    }

    // Update is called once per frame
    void Update()
    {
        puntajeTotalJugador = puntajeCarta1+puntajeCarta2+puntajeCarta3+puntajeCarta4+puntajeCarta5;
        PuntajeJugador.text = puntajeTotalJugador.ToString();
    }


    private void PrimeraCartas(){
        string randomCarta = OpcionesJugador[Random.Range(0,OpcionesJugador.Length)];
            switch(randomCarta)
            {
                case "as":
                    ImgCarta1.sprite = As;
                    puntajeCarta1 = 1;
                break;

                case "dos":
                  ImgCarta1.sprite = dos;
                    puntajeCarta1 = 2;
                break;

                case "tres":
                    ImgCarta1.sprite = tres;
                    puntajeCarta1 = 3;
                break;

                case "cuatro":
                ImgCarta1.sprite = cuatro;
                puntajeCarta1 = 4;
                break;

                case "cinco":
                ImgCarta1.sprite = cinco;
                puntajeCarta1 = 5;
                break;

                case "seis":
                ImgCarta1.sprite = seis;
                puntajeCarta1 = 6;
                break;

                case "siete":
                ImgCarta1.sprite = siete;
                puntajeCarta1 = 7;
                break;

                case "ocho":
                ImgCarta1.sprite = ocho;
                puntajeCarta1 = 8;
                break;

                case "nueve":
                ImgCarta1.sprite = nueve;
                puntajeCarta1 = 9;
                break;

                case "diez":
                ImgCarta1.sprite = diez;
                puntajeCarta1 = 10;
                break;

                case "once":
                ImgCarta1.sprite = once;
                puntajeCarta1 = 11;
                break;

                case "doce":
                ImgCarta1.sprite = doce;
                puntajeCarta1 = 12;
                break;

                case "trece":
                ImgCarta1.sprite = trece;
                puntajeCarta1 = 13;
                break;
            }
    }   
    private void SegundaCartas(){
        string randomCarta = OpcionesJugador[Random.Range(0,OpcionesJugador.Length)];
            switch(randomCarta)
            {
                case "as":
                    ImgCarta2.sprite = As;
                    puntajeCarta2 = 1;
                break;

                case "dos":
                  ImgCarta2.sprite = dos;
                    puntajeCarta2 = 2;
                break;

                case "tres":
                    ImgCarta2.sprite = tres;
                    puntajeCarta2 = 3;
                break;

                case "cuatro":
                ImgCarta2.sprite = cuatro;
                puntajeCarta2 = 4;
                break;

                case "cinco":
                ImgCarta2.sprite = cinco;
                puntajeCarta2 = 5;
                break;

                case "seis":
                ImgCarta2.sprite = seis;
                puntajeCarta2 = 6;
                break;

                case "siete":
                ImgCarta2.sprite = siete;
                puntajeCarta2 = 7;
                break;

                case "ocho":
                ImgCarta2.sprite = ocho;
                puntajeCarta2 = 8;
                break;

                case "nueve":
                ImgCarta2.sprite = nueve;
                puntajeCarta2 = 9;
                break;

                case "diez":
                ImgCarta2.sprite = diez;
                puntajeCarta2 = 10;
                break;

                case "once":
                ImgCarta2.sprite = once;
                puntajeCarta2 = 11;
                break;

                case "doce":
                ImgCarta2.sprite = doce;
                puntajeCarta2 = 12;
                break;

                case "trece":
                ImgCarta2.sprite = trece;
                puntajeCarta2 = 13;
                break;
            }
    } 

    public void DoClickNueva(){
        cont = cont + 1;
        if (cont == 1)
        {
            ImgCarta3.enabled = true;
            string randomCarta = OpcionesJugador[Random.Range(0,OpcionesJugador.Length)];
            switch(randomCarta)
            {
                case "as":
                    ImgCarta3.sprite = As;
                    puntajeCarta3 = 1;
                break;

                case "dos":
                  ImgCarta3.sprite = dos;
                    puntajeCarta3 = 2;
                break;

                case "tres":
                    ImgCarta3.sprite = tres;
                    puntajeCarta3 = 3;
                break;

                case "cuatro":
                ImgCarta3.sprite = cuatro;
                puntajeCarta3 = 4;
                break;

                case "cinco":
                ImgCarta3.sprite = cinco;
                puntajeCarta3 = 5;
                break;

                case "seis":
                ImgCarta3.sprite = seis;
                puntajeCarta3 = 6;
                break;

                case "siete":
                ImgCarta3.sprite = siete;
                puntajeCarta3 = 7;
                break;

                case "ocho":
                ImgCarta3.sprite = ocho;
                puntajeCarta3 = 8;
                break;

                case "nueve":
                ImgCarta3.sprite = nueve;
                puntajeCarta3 = 9;
                break;

                case "diez":
                ImgCarta3.sprite = diez;
                puntajeCarta3 = 10;
                break;

                case "once":
                ImgCarta3.sprite = once;
                puntajeCarta3 = 11;
                break;

                case "doce":
                ImgCarta3.sprite = doce;
                puntajeCarta3 = 12;
                break;

                case "trece":
                ImgCarta3.sprite = trece;
                puntajeCarta3 = 13;
                break;
            }
        }

        if (cont == 2)
        {
            ImgCarta4.enabled = true;
            string randomCarta = OpcionesJugador[Random.Range(0,OpcionesJugador.Length)];
            switch(randomCarta)
            {
                case "as":
                    ImgCarta4.sprite = As;
                    puntajeCarta4 = 1;
                break;

                case "dos":
                  ImgCarta4.sprite = dos;
                    puntajeCarta4 = 2;
                break;

                case "tres":
                    ImgCarta4.sprite = tres;
                    puntajeCarta4 = 3;
                break;

                case "cuatro":
                ImgCarta4.sprite = cuatro;
                puntajeCarta4 = 4;
                break;

                case "cinco":
                ImgCarta4.sprite = cinco;
                puntajeCarta4 = 5;
                break;

                case "seis":
                ImgCarta4.sprite = seis;
                puntajeCarta4 = 6;
                break;

                case "siete":
                ImgCarta4.sprite = siete;
                puntajeCarta4 = 7;
                break;

                case "ocho":
                ImgCarta4.sprite = ocho;
                puntajeCarta4 = 8;
                break;

                case "nueve":
                ImgCarta4.sprite = nueve;
                puntajeCarta4 = 9;
                break;

                case "diez":
                ImgCarta4.sprite = diez;
                puntajeCarta4 = 10;
                break;

                case "once":
                ImgCarta4.sprite = once;
                puntajeCarta4 = 11;
                break;

                case "doce":
                ImgCarta4.sprite = doce;
                puntajeCarta4 = 12;
                break;

                case "trece":
                ImgCarta4.sprite = trece;
                puntajeCarta4 = 13;
                break;
            }
        }
        if (cont == 3)
        {
            mensaje.text = "no puede tener mas cartas";
        }
    }  
}
