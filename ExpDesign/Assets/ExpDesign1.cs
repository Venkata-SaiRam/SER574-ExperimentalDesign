using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ExperimentalDesign;

public class ExpDesign1 : MonoBehaviour
{
	public InputField nameField;
    // Start is called before the first frame update
    void Start()
    {

        ExpDesign ed = new ExpDesign();
		String finalresult = ed.result();
		nameField.text = finalresult;
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
