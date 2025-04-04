using System.Collections.Generic;
using UnityEngine;

public class W10SquareSpawner : MonoBehaviour
{
    public int numOfShapes;
    public Vector2 squareSize;
    public GameObject circlePrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            int factor = numOfShapes / 4;
            for (int i = 0; i < numOfShapes; i++) {
                Vector2 position = Vector2.zero;

                if (i < factor) {

                }
                else if(i < factor*2) {

                }
                else if(i < factor*3) {

                }
                else {

                }

                Instantiate(circlePrefab, position, Quaternion.identity);
            }
        }
    }
}
