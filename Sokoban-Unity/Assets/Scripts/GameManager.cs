using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ItemBox[] _ItemBoxes;
    public bool _IsGameOver;

    public GameObject _WinUi;

    // Start is called before the first frame update
    void Start()
    {
        _IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene(0);

        if (_IsGameOver == true)
            return;

        int count = 0;
        for(int nIndex = 0; nIndex < 3; nIndex++)
        {
            if (_ItemBoxes[nIndex].isOveraped)
                count++;
        }

        if(count >= 3)
        {
            Debug.Log("You Win!");
            _IsGameOver = true;
            _WinUi.SetActive(true);
        }
    }
}
