using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    //Setting the transform for my Backgrounds
    public Transform BG1, BG2;
    //Var for Scrolling Speed
    public float scrollSpeed;
    //Var for Background Width
    private float bgWidth;

	// Use this for initialization
	void Start ()
    {
       //Setting The background width to the backgorunds x width
       bgWidth = BG1.GetComponent<SpriteRenderer>().sprite.bounds.size.x;

	}
	
	// Update is called once per frame
	void Update ()
    {
       //Moving the back ground
       //Accesing its vector(The backgrounds x position, minusing the scrollSpeed set above, multipling by the games frames per second) 
       //Than setting the y, and z position
       BG1.position = new Vector3(BG1.position.x - (scrollSpeed * Time.deltaTime), BG1.position.y, BG2.position.z);
        
       //Setting background 2 to do the same but simplfied
       BG2.position -= new Vector3(scrollSpeed * Time.deltaTime, 0f, 0f);

       //Jumping the background to its orginal position so that it looks like its looping
       if (BG1.position.x < -bgWidth - 1)
        {
            BG1.position += new Vector3(bgWidth * 2f, 0f, 0f);
        }
       //Jumping the background 2 to its orginal position so that it looks like its looping
       if (BG2.position.x < -bgWidth - 1)
       {
           BG2.position += new Vector3(bgWidth * 2f, 0f, 0f);
       }
    }
}
