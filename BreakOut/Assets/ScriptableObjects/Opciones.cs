using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Opciones", menuName = "Tools/Opciones", order = 1)]
public class Opciones : PuntajePersistente
{
	public enum dificultad
	{
		facil,
		normal,
		dificil
	}
	
	public float velocidadBola= 30;
	public dificultad NivelDificultad = dificultad.facil;
    
	public void CambiarVelocidad(float nuevaVelocidad)
	{
		velocidadBola = nuevaVelocidad;
	}
	
	public void CambiarDificultad(int nuevaDificuldad)
	{
		NivelDificultad = (dificultad)nuevaDificuldad;
	}
}
