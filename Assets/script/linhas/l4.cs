﻿using UnityEngine;
using System.Collections;

public class l4 : MonoBehaviour {

	public static bool teste = true, teste2 = true, teste3 = true;
	public Color c1 = new Color(0,1,0);

	public  Material linha; // recebe material da linha
	int lengthOfLineRenderer = 5;

	// Use this for initialization
	void Start () {
		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		lineRenderer.SetWidth(0.1f, 0.1f);
		lineRenderer.SetVertexCount(lengthOfLineRenderer);
		lineRenderer.material = new Material(linha);
		lineRenderer.SetColors(c1, c1);
	}
	
	// Update is called once per frame
	void Update () {

		//mostra linha quando aperta linhas
		if(layout.mostratecla && layout.tecla >= 4){
			chamaLine();
		}

		if(!parada5.teste && !ponto5.teste && !ponto10.teste && !ponto15.teste && layout.tecla >= 4){
			if(teste){
				string[] pontuacao =  new string[5];
				pontuacao[0] = ponto11.ponto;
				pontuacao[1] = ponto7.ponto;
				pontuacao[2] = ponto3.ponto;
				pontuacao[3] = ponto9.ponto;
				pontuacao[4] = ponto15.ponto;
				teste = false;
				int figurasPorLinhas = 0;
				

				//linha 4
				if(ponto11.ponto == ponto7.ponto && ponto11.ponto == ponto3.ponto && ponto11.ponto == ponto9.ponto && ponto11.ponto == ponto15.ponto ){
					chamaLine();
					ponto11.liberaSelecao = ponto7.liberaSelecao = ponto3.liberaSelecao = ponto9.liberaSelecao = ponto15.liberaSelecao = true;
					ganhoLinhas.figura = pontuacao[0];
					ganhoLinhas.linhapremiacao = 100;
					ganhoLinhas.premio();
				}
				//pagamento de linha 4 e 3 figuras, "direita, esquerda, meio e any"
				else{
					for(int j = 0; j <= 1; j++){
						for(int i = 0; i <= 1;i++){
							for(int k = i+1;k <= 2;k++){
								for(int m = k + 1; m <= 3;m++){
									for(int n = m + 1; n <= 4; n++){
										if(j == 0){
											
											// 4 pontos
											if(pontuacao[i] == pontuacao[k] && pontuacao[i]== pontuacao[m] && pontuacao[i]== pontuacao[n] && figurasPorLinhas == 0){
												
												//esquerda
												if(i == 0 && k == 1 && m == 2 && n == 3 ){
													ganhoLinhas.figura = pontuacao[i];
													ganhoLinhas.linhapremiacao = 10;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(i == 0) 			{ ponto11.liberaSelecao = true;}										
													if(i == 1 || k == 1){ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(m == 3 || n == 3){ ponto9.liberaSelecao = true;}
													if(n == 4)			{ ponto15.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
													figurasPorLinhas = 4;
													
												}
												//direita
												else if(i == 1 && k == 2 && m == 3 && n == 4 ){
													ganhoLinhas.figura = pontuacao[i];
													ganhoLinhas.linhapremiacao = 10;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(i == 0) 			{ ponto11.liberaSelecao = true;}										
													if(i == 1 || k == 1){ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(m == 3 || n == 3){ ponto9.liberaSelecao = true;}
													if(n == 4)			{ ponto15.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
													figurasPorLinhas = 4;
													
												}
												//any
												else{
													ganhoLinhas.figura = pontuacao[i];
													ganhoLinhas.linhapremiacao = 20;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(i == 0) 			{ ponto11.liberaSelecao = true;}										
													if(i == 1 || k == 1){ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(m == 3 || n == 3){ ponto9.liberaSelecao = true;}
													if(n == 4)			{ ponto15.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
													figurasPorLinhas = 4;
													
												}
											}
										}
										// aqui entra a variavel && figurasPorLinha < 4
										if(j == 1 && figurasPorLinhas != 4){
											//esquerda e meio
											if(pontuacao[i] == pontuacao[k] && pontuacao[i] == pontuacao[m] && pontuacao[i] != "slot04c (UnityEngine.Texture2D)" && figurasPorLinhas == 0 ){
												figurasPorLinhas = 4;
												
												//esquerda
												if(i == 0 && k == 1 && m == 2){
													ganhoLinhas.figura = pontuacao[i];
													ganhoLinhas.linhapremiacao = 1;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(i == 0) 			{ ponto11.liberaSelecao = true;}										
													if(i == 1 || k == 1){ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(m == 3){ ponto9.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
													
												}
												else if(pontuacao[i] != "slot03c (UnityEngine.Texture2D)" && pontuacao[i] != "slot06c (UnityEngine.Texture2D)" ){
													ganhoLinhas.figura = pontuacao[i];
													ganhoLinhas.linhapremiacao = 2;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(i == 0) 			{ ponto11.liberaSelecao = true;}										
													if(i == 1 || k == 1){ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(m == 3){ ponto9.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
												}
											}
											//direita
											else if(pontuacao[k] == pontuacao[m] && pontuacao[k] == pontuacao[n] && pontuacao[k] != "slot04c (UnityEngine.Texture2D)" && figurasPorLinhas == 0 ){
												figurasPorLinhas = 4;
												
												//direita
												if(k == 2 && m == 3 && n == 4 || k == 1 && m == 2 && n == 3){
													ganhoLinhas.figura = pontuacao[k];
													ganhoLinhas.linhapremiacao = 1;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(k == 1 )			{ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(n == 3 || m == 3){ ponto9.liberaSelecao = true;}
													if(n == 4)			{ ponto15.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
													
												}
												else if(pontuacao[k] != "slot03c (UnityEngine.Texture2D)" && pontuacao[k] != "slot06c (UnityEngine.Texture2D)" ){
													ganhoLinhas.figura = pontuacao[k];
													ganhoLinhas.linhapremiacao = 2;
													ganhoLinhas.premio();
													// ativa as figuras da linha
													if(k == 1 )			{ ponto7.liberaSelecao = true;}						
													if(k == 2 || m == 2){ ponto3.liberaSelecao = true;}
													if(n == 3 || m == 3){ ponto9.liberaSelecao = true;}
													if(n == 4)			{ ponto15.liberaSelecao = true;}
													chamaLine(); // chama a linha na tela
												}
												
											}
											//034
											else if(pontuacao[i] == pontuacao[m] && pontuacao[i] == pontuacao[n] && pontuacao[i] != "slot04c (UnityEngine.Texture2D)" && figurasPorLinhas == 0 && pontuacao[i] != "slot03c (UnityEngine.Texture2D)" && pontuacao[i] != "slot06c (UnityEngine.Texture2D)"){
												figurasPorLinhas = 4;
												
												ganhoLinhas.figura = pontuacao[i];
												ganhoLinhas.linhapremiacao = 2;
												ganhoLinhas.premio();
												
												// ativa as figuras da linha
												if(i == 0) 			{ ponto11.liberaSelecao = true;}		
												if(i == 1 ){ ponto7.liberaSelecao = true;}						
												if(m == 2){ ponto3.liberaSelecao = true;}
												if(m == 3 || n == 3){ ponto9.liberaSelecao = true;}
												if(n == 4)			{ ponto15.liberaSelecao = true;}
												chamaLine(); // chama a linha na tela
												
											}
											//014
											else if(pontuacao[i] == pontuacao[k] && pontuacao[i] == pontuacao[n] && pontuacao[i] != "slot04c (UnityEngine.Texture2D)" && figurasPorLinhas == 0 && pontuacao[i] != "slot03c (UnityEngine.Texture2D)" && pontuacao[i] != "slot06c (UnityEngine.Texture2D)"){
												figurasPorLinhas = 4;
												
												ganhoLinhas.figura = pontuacao[i];
												ganhoLinhas.linhapremiacao = 2;
												ganhoLinhas.premio();
												
												
												// ativa as figuras da linha
												if(i == 0) 			{ ponto11.liberaSelecao = true;}
												if(i == 1 || k == 1 ){ ponto7.liberaSelecao = true;}						
												if(k == 2)			{ ponto3.liberaSelecao = true;}
												if(n == 3)			{ ponto9.liberaSelecao = true;}
												if(n == 4)			{ ponto15.liberaSelecao = true;}
												chamaLine(); // chama a linha na tela
												
											}
										}
										
										
									}
								}
							}
						}
					}
				}
			}
		}
		else{
			teste = true;
			LineRenderer lineRenderer = GetComponent<LineRenderer>();
			lineRenderer.GetComponent<Renderer>().enabled = false;
			TeclaLinha =false;
		}


	}

	void chamaLine(){
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.GetComponent<Renderer>().enabled = true;
		lineRenderer.SetPosition(0, new Vector3(-4,0.1f,-5) );
		lineRenderer.SetPosition(1,new Vector3 (-3,0.1f,-5));
		lineRenderer.SetPosition(2,new Vector3 (0,2.5f,-5) );
		lineRenderer.SetPosition(3,new Vector3 (3,0,-5) );
		lineRenderer.SetPosition(4, new Vector3(4,0,-5) );
		TeclaLinha = true;
	}
	bool TeclaLinha;
	void OnGUI(){
		if(TeclaLinha){
			GUI.Label(new Rect(2.0F,Screen.height/1.6f,20,20),"4");
		}
		
	}



}
