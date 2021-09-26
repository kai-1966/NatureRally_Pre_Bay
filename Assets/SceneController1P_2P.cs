using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneController1P_2P : MonoBehaviour
{
    public void ButtonClicked()
    {
        print("before load");
        SceneManager.LoadScene("Scene2_Post");
        print("after load");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}