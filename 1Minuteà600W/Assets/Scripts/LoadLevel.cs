using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public void my_LoadLevel(string _level)
    {
        SceneManager.LoadScene(_level);
    }
}
