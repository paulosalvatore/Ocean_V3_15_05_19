using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterarEstadoBotao : MonoBehaviour {
	
	public void AlterarEstado()
	{
		gameObject.SetActive(!gameObject.activeSelf);
	}
}
