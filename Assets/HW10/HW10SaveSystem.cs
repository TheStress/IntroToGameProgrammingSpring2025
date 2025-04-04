using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HW10SaveSystem : MonoBehaviour
{
    List<HW10SaveItem> saveItems = new List<HW10SaveItem>();

    void Start() {
        HW10SaveItem[] saveItemsArray = FindObjectsByType<HW10SaveItem>(FindObjectsSortMode.None); // Finding all objects in the scene with this script on it
        saveItems = saveItemsArray.ToList(); // Converting an array to a list
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.S)) {
            foreach(HW10SaveItem item in saveItems) {
                item.Save();
            }
        }
        if (Input.GetKeyDown(KeyCode.L)) {
            foreach (HW10SaveItem item in saveItems) {
                item.Load();
            }
        }
    }
}
