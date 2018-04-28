using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotation : MonoBehaviour {

    public Slider xSlider;
    public Slider ySlider;
    public Slider zSlider;

    //public Text xDegree;
    //public Text yDegree;
    //public Text zDegree;

    public GameObject theObject;

	// Use this for initialization
	void Start () {

        xSlider.maxValue = 360;
        ySlider.maxValue = 360;
        zSlider.maxValue = 360;

    }
	
	// Update is called once per frame
	void Update () {

        
      
        	
	}
}
