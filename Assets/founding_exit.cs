using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class founding_exit : MonoBehaviour {

    public Transform exit;
    public Transform _player;

	// Use this for initialization
	void Start () {
        exit = GameObject.FindGameObjectWithTag("Finish").transform;
    }
	
	// Update is called once per frame
	void Update () {
        float distt = Vector3.Distance(exit.position, transform.position);
        if (distt <= 2)
        {
            
            SceneManager.LoadScene(3);

        }
    }
}
