﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
	    resistencia = 5;
	    res = resistencia;
    }
    
	public override void RebotarBola(Collision col)
	{
		base.RebotarBola(col);
	}
}
