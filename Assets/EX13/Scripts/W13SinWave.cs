using UnityEngine;

public class W13SinWave : MonoBehaviour
{
    public float timer = 0; // The timer to track teh sin and cos values
    public float waveSize = 2f; // How far away from the original position the object is going to ocilate from
    public Vector3 originalPos; // storing the original position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = transform.position; // Storing the original position
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // Adding to the timer 
        
        float sinVal = Mathf.Sin(timer); // getting the sin value
        float cosVal = Mathf.Cos(timer); // Getting the cos value

        Vector3 offsetPos = new Vector3(sinVal * waveSize, cosVal * waveSize); // creating the offset vector with the seperate sin and cos avlues
        transform.position = originalPos + offsetPos; // Setting the transform offsetting from the original position stored
    }
}
