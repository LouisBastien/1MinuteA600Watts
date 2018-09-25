using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setup_script : MonoBehaviour {

    void Start()
    {
        StartCoroutine(Wait7Sec());
    }

    IEnumerator Wait7Sec()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("Game");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
