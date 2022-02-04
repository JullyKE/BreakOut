using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDePersistencia : MonoBehaviour
{
	public List<PuntajePersistente> ObjetosAGuardar;
	
	public void OnEnable()
	{
		for (int i = 0; i < ObjetosAGuardar.Count; i++) 
		{
			var SO = ObjetosAGuardar[i];
			SO.Guardar();
		}
	}
	
	public void OnDisable()
	{
		for (int i = 0; i < ObjetosAGuardar.Count; i++) 
		{
			var so = ObjetosAGuardar[i];
			so.Guardar();
		}
	}
}
