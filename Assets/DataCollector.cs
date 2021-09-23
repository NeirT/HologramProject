using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManager;

public class DataCollector : MonoBehaviour
{
    public static GameObject reminder, day, month, year, hour, minute, sec;

    void OnClicked() {
        SceneManager.LoadSence("4facehologram");
    }
}
