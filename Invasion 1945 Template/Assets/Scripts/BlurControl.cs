using UnityEngine;
using System.Collections;

public class BlurControl : MonoBehaviour {
	
	float value = 40f; 
	
	// Use this for initialization
	void Start () {
		value = 40.0f;
		this.transform.GetComponent<Renderer>().material.SetFloat("_blurSizeXY",value);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Vertical") == 1)
		{
			//value = value + Time.deltaTime;
			if (value>20f) value = 40f;
			this.transform.GetComponent<Renderer>().material.SetFloat("_blurSizeXY",value);
		}
		else if(Input.GetAxisRaw("Horizontal") == 1)
		{
			//value = (value - Time.deltaTime) % 20.0f;
			if (value<0f) value = 0f;
			this.transform.GetComponent<Renderer>().material.SetFloat("_blurSizeXY",value);
		}		
	}
	
	void OnGUI () {
		GUI.TextArea(new Rect(10f,10f,200f,50f), "Press the 'Up' and 'Down' arrows \nto interact with the blur plane\nCurrent value: "+value);
		}
}
