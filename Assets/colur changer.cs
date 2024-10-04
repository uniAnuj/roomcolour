using UnityEngine;
using UnityEngine.UI;

public class ChangeWallColor : MonoBehaviour
{
    public GameObject[] walls;  // Assign all the walls in the inspector
    public Button redButton;
    public Button yellowButton;
    public Button greenButton;

    void Start()
    {
        // Add listeners to each button to change the walls' color
        redButton.onClick.AddListener(() => ChangeColor(Color.red));
        yellowButton.onClick.AddListener(() => ChangeColor(Color.yellow));
        greenButton.onClick.AddListener(() => ChangeColor(Color.green));
    }

    void ChangeColor(Color newColor)
    {
        foreach (GameObject wall in walls)
        {
            wall.GetComponent<Renderer>().material.color = newColor;
        }
    }
}
