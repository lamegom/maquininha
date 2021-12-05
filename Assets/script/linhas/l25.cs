using UnityEngine;
using System.Collections;

public class l25 : MonoBehaviour {
	
	public static bool teste = true, teste2 = true, teste3 = true;
	public Color c1 = new Color(0.25f,1,1);
	
	public  Material linha; // recebe material da linha
	int lengthOfLineRenderer = 2;
	
	// Use this for initialization
	void Start () {
		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		lineRenderer.SetWidth(0.1f, 0.1f);
		lineRenderer.SetVertexCount(lengthOfLineRenderer);
		lineRenderer.material = new Material(linha);
		lineRenderer.SetColors(c1, c1);
	}
	
	void Update () {
		
		
		//mostra linha quando aperta linhas
		if(layout.mostratecla && layout.tecla >= 25){
			chamaLine();
		}
		
		if(!parada5.teste && !ponto5.teste && !ponto10.teste && !ponto15.teste && layout.tecla >= 25 ){
			if(teste){
				string[] pontuacao =  new string[5];
				pontuacao[0] = ponto5.ponto;
				pontuacao[1] = ponto10.ponto;
				pontuacao[2] = ponto15.ponto;
				
				teste = false;
				
				//linha 3
				if(pontuacao[0] == pontuacao[1] && pontuacao[0] == pontuacao[2]){
					chamaLine();
					ganhoLinhas.figura = pontuacao[0];
					ganhoLinhas.linhapremiacao = 3;
					ganhoLinhas.premio();
					ponto5.liberaSelecao = ponto10.liberaSelecao = ponto15.liberaSelecao = true;
					
				}
				
			}
		}
		else{
			teste = true;
			LineRenderer lineRenderer = GetComponent<LineRenderer>();
			lineRenderer.GetComponent<Renderer>().enabled = false;
		}
		
		
	}
		

	
	void chamaLine(){
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.GetComponent<Renderer>().enabled = true;
		lineRenderer.SetPosition(0, new Vector3(3, -0.5f,-5) );
		lineRenderer.SetPosition(1,new Vector3 (3, 3,-5));
		
	}
	
	
}
