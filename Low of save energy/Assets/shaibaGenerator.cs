using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class shaibaGenerator : MonoBehaviour {

    public List<GameObject> shaibs;
	// Use this for initialization
	void Start () {
        //для примера 0,01627954
        shaibs.First().transform.position = new Vector3(-0.86372046f, -0.1338437f, 1f);
        shaibs.Last().transform.position = new Vector3(0.89627954f, -0.1338437f, 1f);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
