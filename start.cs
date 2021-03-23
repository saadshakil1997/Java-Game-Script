using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject uishow;
   
    // Start is called before the first frame update
    void Start()
    {
        uishow.SetActive(true);
       
        StartCoroutine(wait());
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
    IEnumerator wait()
    {
        yield return new WaitForSeconds(10);
        uishow.SetActive(false);
       
    }
}
