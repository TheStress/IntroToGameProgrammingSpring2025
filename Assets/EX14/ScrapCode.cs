using UnityEngine;

public class ScrapCode : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int n = 0;
        while(n < 3) {
            Debug.Log("LOOP # " + n);
            n++;
        }


        for(int i = 0; i < 3; i++) {
            Debug.Log("LOOP # " + n);
        }
    }
}
