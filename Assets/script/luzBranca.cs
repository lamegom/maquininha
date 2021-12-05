using UnityEngine;
using System.Collections;

public class luzBranca : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if(layout.auto || ganhoLinhas.bonus[5] != 0){
			gameObject.GetComponent<Light>().enabled = false;
		}
		else{
			gameObject.GetComponent<Light>().enabled = true;
		}
	}
}
