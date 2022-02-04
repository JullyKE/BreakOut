using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
	public GameObject MenuOpciones;
	public GameObject MenuInicio;
	
	public void IniciarJuego()
	{
		SceneManager.LoadScene(1);
	}
	
	public void FinalizarJuego()
	{
		Debug.Log("Saliste");
		Application.Quit();
	}
	public void MostrarOpciones()
	{
		MenuInicio.SetActive(false);
		MenuOpciones.SetActive(true);
	}
	public void MostrarMenuInicial()
	{
		MenuInicio.SetActive(true);
		MenuOpciones.SetActive(false);
	}
}
