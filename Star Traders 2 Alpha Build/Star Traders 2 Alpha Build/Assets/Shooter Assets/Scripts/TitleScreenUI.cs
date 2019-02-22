using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenUI : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, moveSpeed * Time.deltaTime, 0f);
    }
}
