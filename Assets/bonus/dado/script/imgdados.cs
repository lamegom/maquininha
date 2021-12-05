using UnityEngine;
using System.Collections;

public class imgdados : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(!lancaDado.jogar){
			gameObject.GetComponent<Renderer>().enabled = false;
		}
		else{
			gameObject.GetComponent<Renderer>().enabled = true;
		}
	}

}
