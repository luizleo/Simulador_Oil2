using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Barra_Vertical : MonoBehaviour {




	public GameObject barra, config, clima, model,ext1,ext2,ext3,ext4,ext5,ext6,model_op,config_op,clima_op;
	public GameObject view_config,view_modelo,view_clima;


	Vector3 posicao;
	Vector3 incremento;
	Vector3 inicio,config_ini,clima_ini,model_ini;
	Vector3 decremento;
	int var = 0;

	// Use this for initialization
	void Start () {
		inicio = barra.transform.position;
		posicao = barra.transform.position;
		config_ini = config.transform.position;
		clima_ini = clima.transform.position;
		model_ini = model.transform.position;
		incremento = new Vector3 (0, -40, 0);
		decremento = new Vector3 (0, 60, 0);

	}
	
	// Update is called once per frame
	void Update () {
		if (var == 1) {

			if (posicao.y > 250)
		     posicao = posicao + incremento;
			
			clima.transform.position = clima_ini;
			config.transform.position = config_ini;
			model.transform.position = model_ini;
		    config.gameObject.SetActive (false);
		    clima.gameObject.SetActive (false);
			model.gameObject.SetActive (false);
			ext1.gameObject.SetActive (false);
			ext2.gameObject.SetActive (false);
			ext3.gameObject.SetActive (false);

		
		}
		if (var == 0) {
			if (posicao.y < 1000)
				posicao = posicao + decremento;
			if (posicao.y > 1000) 
				posicao = inicio;
		}
	
		barra.transform.position = posicao;
		barra.gameObject.SetActive (true);

	}

		public void ligar_botao(string botao)
		{
		if (botao == "config") {
			config_op.gameObject.SetActive (true);
			view_config.gameObject.SetActive (true);
			ext4.gameObject.SetActive (true);
			var = 1;
		}
		if (botao == "clima") {
			ext5.gameObject.SetActive (true);
			view_clima.gameObject.SetActive (true);
			clima_op.gameObject.SetActive (true);
			var = 1;
		}
		
		if (botao == "model") {
			
			model_op.gameObject.SetActive (true);
			view_modelo.gameObject.SetActive (true);
			ext6.gameObject.SetActive (true);
			var = 1;
		}
		if (botao == "voltar")  {
			
			config.gameObject.SetActive (true);
			clima.gameObject.SetActive (true);
			model.gameObject.SetActive (true);
			ext1.gameObject.SetActive (true);
			ext2.gameObject.SetActive (true);
			ext3.gameObject.SetActive (true);
			ext4.gameObject.SetActive (false);
			ext5.gameObject.SetActive (false);
			ext6.gameObject.SetActive (false);
			config_op.gameObject.SetActive (false);
			clima_op.gameObject.SetActive (false);
			model_op.gameObject.SetActive (false);
			view_modelo.gameObject.SetActive (false);
			view_config.gameObject.SetActive (false);
			view_clima.gameObject.SetActive (false);
		
			var = 0;

		}
	
	}
}

