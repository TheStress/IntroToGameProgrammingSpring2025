using UnityEngine;

public class DemonstrationW6 : MonoBehaviour
{
    Vector2 position2D = new Vector2(1f, 2f);
    Vector3 position3D = new Vector3(1f, 2f, 3f);

    // Both constructor functions work
    Color colorUsingColor = new Color(0f, 1f, 0f, 1f);
    Color colorUsingVector = new Vector4(1f, 0f, 0f, 1f);

    Collider2D test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Vector2 v1 = new Vector2(4, 5);
        Vector2 v2 = new Vector2(3, 0);
        //Vector2 vOut = v1 * v2;

        Vector2 v = new Vector2(2, 2);
        Vector2 vOut = v * 3;

        //Vector2 direction = v.normalized;
        //float lengthOfVector = v.magnitude;
        //Debug.Log(lengthOfVector);

        //Vector2 vOut = v1 + v2;

        float val1 = 2;
        float val2 = 1;
        float valOut = val1 + val2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space)) {
            for(int i = 0; i < 10000000; i++) {
                float test = Mathf.Pow(2, 5);
            }
        }
    }
}
