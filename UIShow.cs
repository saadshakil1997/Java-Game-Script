using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIShow : MonoBehaviour
{
    public GameObject health,bombdiffused;
    public Slider slider;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        health.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void healthbar()
    {
        slider.value += 5;
    }
    private void OnTriggerEnter(Collider other)
    {
        health.SetActive(true);
        StartCoroutine(wait());
        InvokeRepeating("healthbar", 0f, 1f);
        count =count+ 1;
        PlayerPrefs.SetInt("CountBombs", count);
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(20);
        this.gameObject.SetActive(false);
        health.SetActive(false);
        slider.value = 0;
      /*  bombdiffused.SetActive(true);
        yield return new WaitForSeconds(5);
        bombdiffused.SetActive(false);*/

    }
    void bomb()
    {
       
    }
}
