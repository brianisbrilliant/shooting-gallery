// The Almighty Button God
// Creator of all buttons, good and bad

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    public GameObject[] buttonPrefabs;      // this array holds multiple button prefabs
    public bool debug = true;               // turn this off when you launch the game.
    public Transform canvas;                // assign the canvas to this.

    // TODO - Get bounds of canvas for this.
    public float xDistance = 80;
    public float yDistance = 40;

    void Update() {
        if(debug && Input.GetKeyDown(KeyCode.B)) {
            SpawnButton();
        }
    }

    void SpawnButton() {
        GameObject newButton = Instantiate(buttonPrefabs[Random.Range(0, buttonPrefabs.Length)]);
        newButton.transform.SetParent(canvas);      // make the new button a child of the canvas.
        newButton.transform.localPosition = Vector3.zero;    // put the button in front of the camera.
        newButton.transform.localScale = Vector3.one;
        // randomly move the button
        newButton.transform.Translate(  Random.Range(-xDistance, xDistance), 
                                        Random.Range(-yDistance, yDistance), 
                                        0);
    }
}
