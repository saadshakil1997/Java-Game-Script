using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public UIShow uIShow;
    // Start is called before the first frame update
    void Start()
    {
        uIShow.GetComponent<UIShow>();
        /*Debug.Log(PlayerPrefs.GetInt("CountBombs"));*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetInt("CountBombs")==2)
        {
            Debug.Log("Win");
        }
    }
}
