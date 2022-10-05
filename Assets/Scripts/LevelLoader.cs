using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LukaDimopoulos
{
    public class LevelLoader : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                LoadLevel("Week2Activities");
            }
        }
        /// <summary>
        /// This will load a different scene.
        /// </summary>

        private void LoadLevel(string SceneToLoad)
       {
            SceneManager.LoadScene(SceneToLoad);
       }

    }
    
}
