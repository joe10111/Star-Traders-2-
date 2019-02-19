using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float moveSpeed;

	
	// Update is called once per frame
	void Update ()
    {
        transform.position -= new Vector3( 0f, moveSpeed * Time.deltaTime, 0f);
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
