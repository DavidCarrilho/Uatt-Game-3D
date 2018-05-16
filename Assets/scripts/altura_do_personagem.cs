using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class altura_do_personagem : MonoBehaviour {

    public Transform personagem;
    Text texto_da_interface;

	// Use this for initialization
	void Start () {
        texto_da_interface = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log (personagem.position.y);
        texto_da_interface.text = Mathf.RoundToInt (personagem.position.y).ToString();

    }
}
