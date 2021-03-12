using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_4_1_20_Sashank : MonoBehaviour
{
    public float colorDuration;
    public Color startColor;
    public Color endColor;
   
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material.color = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ChangeColor(this.GetComponent<Renderer>().material));
        }
    }
    IEnumerator ChangeColor(Material colorChange)
    {
        float t = 0;

        while (t < colorDuration)
        {
            t += Time.deltaTime;
            colorChange.color = Color.Lerp(startColor, endColor, t / colorDuration);
            yield return null;
        }

        if(t == colorDuration)
        {
            this.GetComponent<Renderer>().material.color = startColor;
        }
    }
}
