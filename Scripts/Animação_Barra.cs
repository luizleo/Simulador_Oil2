using UnityEngine;
using System.Collections;

public class Animação_Barra : MonoBehaviour {

	public GameObject botao;

	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - botao.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = botao.transform.position + offset;
	}
}
