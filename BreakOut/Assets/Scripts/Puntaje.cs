using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
	public Transform transformPuntajeAlto;
	public Transform transformPuntajeActual;
	public TMP_Text textoPuntajeAlto;
	public TMP_Text textoActual;
	
	public PuntajeAlto puntajeAltoSO;
	
    // Start is called before the first frame update
    void Start()
    {
	    transformPuntajeAlto = GameObject.Find("HightScore").transform;
	    transformPuntajeActual = GameObject.Find("Score").transform;
	    textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
	    textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
	    
	    puntajeAltoSO.Cargar();
	    textoPuntajeAlto.text = $"HightScore: {puntajeAltoSO.puntajeAlto}";
	    puntajeAltoSO.puntaje = 0;
	    /*if (PlayerPrefs.HasKey("HightScore"))
	    {
	    	puntajeAlto = PlayerPrefs.GetInt("HightScore");
	    	textoPuntajeAlto.text = $"HightScore: {puntajeAlto}";
	    }*/
    }

    // Update is called once per frame
    void Update()
    {
	    textoActual.text = $"Score: {puntajeAltoSO.puntaje}";
	    if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
	    {
	    	puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
	    	textoPuntajeAlto.text = $"HightScore: {puntajeAltoSO.puntajeAlto}";
	    	puntajeAltoSO.Guardar();
	    	//PlayerPrefs.SetInt("HightScore", puntos);
	    }
    }
	
	public void AumentarPuntaje(int puntos)
	{
		puntajeAltoSO.puntaje += puntos;
	}
}
