using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoff_on : MonoBehaviour {

    public Light lamp;
    private float countdown = 1f;

	// Use this for initialization
	void Start () {
        lamp.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime * 2f;
        if(countdown <= 0)
        {
            countdown = Random.Range(0, 2);
            lamp.enabled = !lamp.enabled;
        }
        
	}
}
