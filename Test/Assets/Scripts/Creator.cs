using System.Collections;
using System;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject obj;
    public float seconds = 1;

    public float Seconds
    {
        get {return seconds;}
        set 
        {
                if(value < 0 || value == 0)
                {
                    Debug.LogError("value can't be < 0 or == 0");
                }
                else
                {
                    seconds = value;
                }
        }
    }

    // Update is called once per frame
    void Start()
    {
        seconds = 2f;
        StartCoroutine(createCubes());
    }

    private IEnumerator createCubes()
    {
        while(true)
        {
            GameObject newObj = Instantiate(obj, transform.position, transform.rotation);
            yield return new WaitForSeconds(seconds);
        }
        
    }
}
