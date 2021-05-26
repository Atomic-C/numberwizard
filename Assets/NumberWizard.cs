using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please pick a number.");
        Debug.Log("The highest numeber you can chose is: " + max);
        Debug.Log("The lowest number you can chose is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So it's Higher? is it...");
            min = guess;
            guess = ((max + min) / 2);
            Debug.Log(guess + " perhaps?");
        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("So it's Lower? is it...");
            max = guess;
            guess = ((max + min) / 2);
            Debug.Log(guess + " perhaps?");
        }
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }
        // Read documentation: https://docs.unity3d.com/ScriptReference/Input.html
        // Fixed intellisense not working on unity through source: https://forum.unity.com/threads/intellisense-not-working-with-visual-studio-fix.836599/
    }
}
