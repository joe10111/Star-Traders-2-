using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
      private void OnCollisionEnter2D(Collision2D other)
    {
        if(gameObject.tag == "Player")
        {
            CameraShake.instance.shakeDuration = .5f;
            Health.instance.DamageToPlayer();
        }
    }
}
