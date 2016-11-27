using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour 
{
    public Canvas quitMenu;

    public Canvas difficultyMenu;

    public Button startText;

    public Button exitText;

    public Button difficultyText;

	// Use this for initialization
	void Start () 
    {
        quitMenu = quitMenu.GetComponent<Canvas>();

        difficultyMenu = difficultyMenu.GetComponent<Canvas>();

        startText = startText.GetComponent<Button>();

        exitText = exitText.GetComponent<Button>();

        difficultyText = difficultyText.GetComponent<Button>();


        quitMenu.enabled = false;

        difficultyMenu.enabled = false;
	}

    public void ExitPress()
    {

        quitMenu.enabled = true;

        startText.enabled = false;

        exitText.enabled = false;

        difficultyText.enabled = false;

        difficultyMenu.enabled = false;

    }

    public void NoPress()
    {

        difficultyMenu.enabled = false;

        quitMenu.enabled = false;

        startText.enabled = true;

        exitText.enabled = true;

        difficultyText.enabled = true;

    }
    public void difficultyPress()
    {

        difficultyMenu.enabled = true;

        startText.enabled = false;

        exitText.enabled = false;

        difficultyText.enabled = false;

        quitMenu.enabled = false;

    }
    public void StartLevel()
    {

        Application.LoadLevel(1);

    }
    public void ExitGame()
    {

        Application.Quit();

    }

}
