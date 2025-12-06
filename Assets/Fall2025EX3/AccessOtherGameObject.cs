using UnityEngine;

public class AccessOtherGameObject : MonoBehaviour
{
    public GameObject otherObject;

    //void Start()
    //{
    //    otherObject.transform.position = new Vector3 (0, 0, 0); // Setting other object position to (0,0,0)
    //}



    void Start() {
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
