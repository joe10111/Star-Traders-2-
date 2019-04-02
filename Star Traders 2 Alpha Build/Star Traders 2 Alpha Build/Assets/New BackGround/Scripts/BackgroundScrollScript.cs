
// BACKGROUND SCROLL SCRIPT CS 20151402_0647 //

// Scroll the background at "scrollSpeed" and reset is horizontal position when it reaches "resetXPos"

using UnityEngine;
using System;


public class BackgroundScrollScript: MonoBehaviour
{
	
	public float scrollSpeed = -0.48f;
	public float resetXPos = -0.64f; // X position to reach
	
	// reference to objects's transform
	Transform myTr;
	
	 
	public void Start()
	{
	
		myTr = transform; // Cache object's transform
	
	}
	
	public void Update()
	{
		
		// Move transform at "scrollSpeed"
		myTr.localPosition = new Vector3 (myTr.localPosition.x, myTr.localPosition.y + scrollSpeed * Time.deltaTime, myTr.localPosition.z);

	}
	
	public void LateUpdate()
	{
		
		// Reset position when it reaches "resetXPos"
		if ( myTr.localPosition.y <= resetXPos ) myTr.localPosition = new Vector3 ( myTr.localPosition.y, 0, myTr.localPosition.z);
		
	}

}