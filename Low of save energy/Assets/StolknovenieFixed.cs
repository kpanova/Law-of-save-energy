using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
using System.Linq;

public class StolknovenieFixed : MonoBehaviour {

    public GameObject Prujina;
    public GameObject forceBody;
    public GameObject shaiba;
    public float rotationSpeed = 1;
    public float minRotation = -0.3f;
    
    // Use this for initialization
    void Start () {
        var collider = shaiba.GetComponent<Collider>();
        collider.isTrigger = true;
    }
    // Update is called once per frame
    void Update()
    {
        switch (statement)
        {
            case GameStatement.onRunBody:
                forceBody.transform.Rotate(0, 0, -1*rotationSpeed, Space.World);
                IsRotationEnd();
                break;
            case GameStatement.onPrujinaRun:
                forceBody.MoveByZ(-0.1f);
                Prujina.MoveByZ(-0.1f);
                break;
            case GameStatement.RunBodyEnd:
                GameObject.Find("Cylinder002").GetComponents<Rigidbody>().First().isKinematic = true;
                statement = GameStatement.ShaibaRun;
                var collider = shaiba.GetComponent<Collider>();
                collider.isTrigger = false;
                var rigidbody = shaiba.GetComponents<Rigidbody>().First();
                rigidbody.isKinematic = false;
                rigidbody.AddRelativeForce(new Vector3(0, 0, -1), ForceMode.Impulse);
                break;
        }
    }
    public enum GameStatement
    {
        onRunBody,
        onPrujinaRun,
        RunBodyEnd,
        ShaibaRun,
        onEnd
    }
    public static GameStatement statement = GameStatement.onRunBody;
    void IsRotationEnd()
    {
        if (forceBody.transform.rotation.z < minRotation)
            statement = GameStatement.onPrujinaRun;
    }
}
