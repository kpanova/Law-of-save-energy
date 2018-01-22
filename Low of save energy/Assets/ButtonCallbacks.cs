using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCallbacks : MonoBehaviour {
    
    public void ButtonAction()
    {
        SceneManager.LoadScene("scene");
        StolknovenieFixed.statement = StolknovenieFixed.GameStatement.onRunBody;
    }

}
