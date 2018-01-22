using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnters : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (StolknovenieFixed.statement == StolknovenieFixed.GameStatement.onPrujinaRun)
            StolknovenieFixed.statement = StolknovenieFixed.GameStatement.RunBodyEnd;
    }
}
