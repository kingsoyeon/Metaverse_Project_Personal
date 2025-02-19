using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum UIState
{
    Home,
    Game,
    Explain,
    GameOver
}
public class UIManager : MonoBehaviour
{
    // ΩÃ±€≈Ê
    static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            return instance;
        }
    }

   


}
