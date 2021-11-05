using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static bool mostrar = false;
    public Text mensaje;
    public Button parar;
    // Start is called before the first frame update
    void Start()
    {
        Button btnParar = parar.GetComponent<Button>();
        btnParar.onClick.AddListener(Estado);
    }

    // Update is called once per frame
    void Update()
    {
        if (ValorCartasJugador.puntajeTotalJugador > 21)
        {
            mensaje.text = "has Perdido";
        }
    }

    private void Estado(){
        mostrar = true;
        if (ValorCartasJugador.puntajeTotalJugador == 21 || ValorCartasJugador.puntajeTotalJugador > CartaDealer.puntajeTotalDealer)
        {
            mostrar = true;
            mensaje.text = "Has ganado";
        }else if (ValorCartasJugador.puntajeTotalJugador < CartaDealer.puntajeTotalDealer)
        {
            mostrar = true;
            mensaje.text = "has Perdido";
        }
    }
}
