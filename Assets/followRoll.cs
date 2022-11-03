using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followRoll : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 rotateChange;
    //public float acc = 0.1f;
    private Vector3 offset = new Vector3(3f,1.8f,0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
    	//acc = acc+acc;
    	//Vector3 offsetAc = new Vector3(0f, acc, 0f);
	transform.position = sphere.transform.position + offset ;//+ offsetAc;   
	transform.Rotate (rotateChange * Time.deltaTime);     
    }
}
