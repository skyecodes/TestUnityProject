using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public BoardHandler BoardHandler;
    public RecipeRegistry RecipeRegistry;

    private void Start()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        BoardHandler = GetComponent<BoardHandler>();
        RecipeRegistry = GetComponent<RecipeRegistry>();
    }
}
