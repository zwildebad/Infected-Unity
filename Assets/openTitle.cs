﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openTitle : MonoBehaviour
{
    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
