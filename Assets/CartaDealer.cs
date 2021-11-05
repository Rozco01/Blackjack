using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartaDealer : MonoBehaviour
{

    public static int puntajeTotalDealer;

    private int puntajeDealerVista;
    private int puntajeDealerOculta;
    public Image Vista;
    public Image Oculta;
    public string[] Opciones;
    public Sprite As,dos,tres,cuatro,cinco,seis,siete,ocho,nueve,diez,once,doce,trece;

    // Start is called before the first frame update
    void Start()
    {
        ValorCartaVista();
        ValorCartaOculta();
    }

    // Update is called once per frame
    void Update()
    {
        puntajeTotalDealer = puntajeDealerOculta + puntajeDealerVista;

        if (GameManager.mostrar == true)
        {
            mostrarFinal();
        }
    }

    private void ValorCartaVista(){
        string randomCarta = Opciones[Random.Range(0,Opciones.Length)];
            switch(randomCarta)
            {
                case "as":
                    Vista.sprite = As;
                    puntajeDealerVista = 1;
                break;

                case "dos":
                Vista.sprite = dos;
                puntajeDealerVista = 2;
            
                break;

                case "tres":
                Vista.sprite = tres;
                puntajeDealerVista = 3;
                
                break;

                case "cuatro":
                    Vista.sprite = cuatro;
                    puntajeDealerVista = 4;
               
                break;

                case "cinco":
                    Vista.sprite = cinco;
                    puntajeDealerVista = 5;
                    
                break;

                case "seis":
                    Vista.sprite = seis;
                    puntajeDealerVista = 6;
                break;

                case "siete":
                    Vista.sprite = siete;
                    puntajeDealerVista = 7;
                break;

                case "ocho":
                    Vista.sprite = ocho;
                    puntajeDealerVista = 8;
                break;

                case "nueve":
                    Vista.sprite = nueve;
                    puntajeDealerVista = 9;
                break;

                case "diez":
                    Vista.sprite = diez;
                    puntajeDealerVista = 10;
                break;

                case "once":
                    Vista.sprite = once;
                    puntajeDealerVista = 11;
                break;

                case "doce":
                    Vista.sprite = doce;
                    puntajeDealerVista = 12;
                break;

                case "trece":
                    Vista.sprite = trece;
                    puntajeDealerVista = 13;
                break;
        }
        
    }

    private void ValorCartaOculta(){
        string randomCarta = Opciones[Random.Range(0,Opciones.Length)];
            switch(randomCarta)
            {
                case "as":
                puntajeDealerOculta = 1;
                break;

                case "dos":
                puntajeDealerOculta = 2;
                break;

                case "tres":
                puntajeDealerOculta = 3;
                break;

                case "cuatro":
                puntajeDealerOculta = 4;
                break;

                case "cinco":
                puntajeDealerOculta = 5;
                break;

                case "seis":
                puntajeDealerOculta = 6;
                break;

                case "siete":
                puntajeDealerOculta = 7;
                break;

                case "ocho":
                puntajeDealerOculta = 8;
                break;

                case "nueve":
                puntajeDealerOculta = 9;
                break;

                case "diez":
                puntajeDealerOculta = 10;
                break;

                case "once":
                puntajeDealerOculta = 11;
                break;

                case "doce":
                puntajeDealerOculta = 12;
                break;

                case "trece":
                puntajeDealerOculta = 13;
                break;
        }
    }

    private void mostrarFinal(){
        if (puntajeDealerOculta == 1)
        {
            Oculta.sprite = As;
        }else if (puntajeDealerOculta == 2)
        {
            Oculta.sprite = dos;    
        }else if (puntajeDealerOculta == 3)
        {
           Oculta.sprite = tres; 
        }else if (puntajeDealerOculta == 4)
        {
            Oculta.sprite = cuatro;
        }else if (puntajeDealerOculta == 5)
        {
            Oculta.sprite = cinco;
        }else if (puntajeDealerOculta == 6)
        {
            Oculta.sprite = seis;
        }else if (puntajeDealerOculta == 7)
        {
            Oculta.sprite = siete;
        }else if (puntajeDealerOculta == 8)
        {
            Oculta.sprite = ocho;
        }else if (puntajeDealerOculta == 9)
        {
            Oculta.sprite = nueve;
        }else if (puntajeDealerOculta == 10)
        {
            Oculta.sprite = diez;
        }else if (puntajeDealerOculta == 11)
        {
            Oculta.sprite = once;
        }else if (puntajeDealerOculta == 12)
        {
            Oculta.sprite = doce;
        }else if (puntajeDealerOculta == 13)
        {
            Oculta.sprite = trece;
        }
        
    }
}
